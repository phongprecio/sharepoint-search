using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Search.Query;
using Microsoft.SharePoint.Client.Taxonomy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharePointSearchApp
{
    class UserInfo
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public UserInfo(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }
    }

    public partial class Form1 : System.Windows.Forms.Form
    {
        private ClientContext _context { get; set; }
        public Form1(ClientContext context)
        {
            _context = context;

            InitializeComponent();

            // Bind data book category list box
            GetTermsInTermSet(_context, bookCategoryLbx);

            InitDataLeader(leaderLbx); // TODO
        }

        private static void GetTermsInTermSet(ClientContext context, ListBox bookCategoryLbx)
        {
            // Get the TaxonomySession
            TaxonomySession taxonomySession = TaxonomySession.GetTaxonomySession(context);
            // Get the term store default
            TermStore termStore = taxonomySession.GetDefaultSiteCollectionTermStore();
            // Get Term Group
            TermGroup termGroup = termStore.Groups.GetByName("Search");
            // Get the term set by Name
            TermSet termSet = termGroup.TermSets.GetByName("Book Genres");
            var terms = termSet.GetAllTerms();
            context.Load(terms);
            context.ExecuteQuery();

            bookCategoryLbx.DataSource = terms.ToList();
            bookCategoryLbx.DisplayMember = "Name";
            bookCategoryLbx.ValueMember = "Id";
            bookCategoryLbx.SelectionMode = SelectionMode.MultiExtended;

        }

        private static void InitDataLeader(ListBox leaderLbx)
        {
            var leaders = new List<UserInfo>();
            leaders.Add(new UserInfo("Phong Tran", "phong@adminvn.onmicrosoft.com"));
            leaders.Add(new UserInfo("Tom", "tom@adminvn.onmicrosoft.com"));
            leaders.Add(new UserInfo("user1", "user1@adminvn.onmicrosoft.com"));
            leaders.Add(new UserInfo("user2", "user2@adminvn.onmicrosoft.com"));
            leaders.Add(new UserInfo("user3", "user3@adminvn.onmicrosoft.com"));

            leaderLbx.DataSource = leaders;
            leaderLbx.DisplayMember = "UserName";
            leaderLbx.ValueMember = "Email";
            leaderLbx.SelectionMode = SelectionMode.MultiExtended;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string searchCondition = String.Empty;
            
            if (!string.IsNullOrEmpty(searchTxt.Text.Trim()))
            {
                searchCondition = searchTxt.Text.Trim();
            }

            if (dateTimePicker1.MinDate != dateTimePicker1.Value)
            {
                if (!string.IsNullOrEmpty(searchCondition))
                    searchCondition = searchCondition + " AND ";

                var dateCondition = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                searchCondition = searchCondition + $"RefinableDate00>={dateCondition}";
            }

            if (dateTimePicker2.MinDate != dateTimePicker2.Value)
            {
                if (!string.IsNullOrEmpty(searchCondition))
                    searchCondition = searchCondition + " AND ";

                var dateCondition = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                searchCondition = searchCondition + $"RefinableDate00<={dateCondition}";
            }

            if (isMemberCbx.SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(searchCondition))
                    searchCondition = searchCondition + " AND ";
                int isMember = isMemberCbx.SelectedItem.ToString() == "True" ? 1 : 0;
                searchCondition = searchCondition + $"RefinableString02:{isMember}";
            }

            if (!string.IsNullOrEmpty(firstNameTxt.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(searchCondition))
                    searchCondition = searchCondition + " AND ";
                searchCondition = searchCondition + $"RefinableString00:{firstNameTxt.Text.Trim()}";
            }

            if (bookCategoryLbx.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrEmpty(searchCondition))
                    searchCondition = searchCondition + " AND ";
                var selectedIdString = " RefinableString01:";
                var i = 0;
                foreach (Term item in bookCategoryLbx.SelectedItems)
                {
                    if (i > 0)
                        selectedIdString = selectedIdString + " OR RefinableString01:";
                    selectedIdString = selectedIdString + item.Id;
                    i++;
                }
                searchCondition = searchCondition + selectedIdString;
            }

            if (leaderLbx.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrEmpty(searchCondition))
                    searchCondition = searchCondition + " AND ";
                var selectedLeaderString = " RefinableString03:";
                var i = 0;
                foreach (UserInfo item in leaderLbx.SelectedItems)
                {
                    if (i > 0)
                        selectedLeaderString = selectedLeaderString + " OR RefinableString03:";
                    selectedLeaderString = selectedLeaderString + item.Email;
                    i++;
                }
                searchCondition = searchCondition + selectedLeaderString;
            }

            string strQueryText = searchCondition+ " AND Path:\"https://adminvn.sharepoint.com/\" AND filetype<>html AND filetype<>php AND FileExtension<>aspx AND FileExtension<>js AND FileExtension<>php XRANK(nb=5000) (body:" + searchCondition + ")";

            KeywordQuery keywordQuery = new KeywordQuery(_context);
            SearchExecutor searchExecutor = new SearchExecutor(_context);
            keywordQuery.QueryText = strQueryText;
            keywordQuery.EnableSorting = true;
            keywordQuery.RowsPerPage = 100;
            keywordQuery.RowLimit = 100;
            keywordQuery.StartRow = 0;

            var results = searchExecutor.ExecuteQuery(keywordQuery);
            _context.ExecuteQuery();

            int trows = results.Value[0].TotalRows;
            if (trows == 0)
            {
                MessageBox.Show("No record found for the given search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var resultRow in results.Value[0].ResultRows)
            {
                string editorName = string.Empty;
                if (Convert.ToString(resultRow["EditorOWSUSER"]) != "")
                    editorName = resultRow["EditorOWSUSER"].ToString().Split('|')[1];
                if (resultRow["ServerRedirectedURL"] == null)
                {
                    dataGridView1.Rows.Add(resultRow["Title"], resultRow["Culture"], "", resultRow["DocId"], resultRow["LinkingUrl"], resultRow["Path"], editorName, resultRow["LastModifiedTime"]);
                }
                else
                {
                    dataGridView1.Rows.Add(resultRow["Title"], resultRow["Culture"], resultRow["ServerRedirectedURL"], resultRow["DocId"], resultRow["LinkingUrl"], resultRow["Path"], editorName, resultRow["LastModifiedTime"]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
