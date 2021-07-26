
namespace SharePointSearchApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerRedirectedURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkingUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastModifiedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateToLbl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.isMemberCbx = new System.Windows.Forms.ComboBox();
            this.isMemberLbl = new System.Windows.Forms.Label();
            this.leadersLbl = new System.Windows.Forms.Label();
            this.bookCategoryLbl = new System.Windows.Forms.Label();
            this.bookQuantityLbl = new System.Windows.Forms.Label();
            this.bookQuantityTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.bookCategoryLbx = new System.Windows.Forms.ListBox();
            this.leaderLbx = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(12, 31);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(1112, 27);
            this.searchTxt.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(905, 262);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(219, 49);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Culture,
            this.ServerRedirectedURL,
            this.DocId,
            this.LinkingUrl,
            this.Path,
            this.Owner,
            this.LastModifiedTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 368);
            this.dataGridView1.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Culture
            // 
            this.Culture.HeaderText = "Culture";
            this.Culture.MinimumWidth = 6;
            this.Culture.Name = "Culture";
            this.Culture.Width = 125;
            // 
            // ServerRedirectedURL
            // 
            this.ServerRedirectedURL.HeaderText = "ServerRedirectedURL";
            this.ServerRedirectedURL.MinimumWidth = 6;
            this.ServerRedirectedURL.Name = "ServerRedirectedURL";
            this.ServerRedirectedURL.Width = 125;
            // 
            // DocId
            // 
            this.DocId.HeaderText = "DocId";
            this.DocId.MinimumWidth = 6;
            this.DocId.Name = "DocId";
            this.DocId.Width = 125;
            // 
            // LinkingUrl
            // 
            this.LinkingUrl.HeaderText = "LinkingUrl";
            this.LinkingUrl.MinimumWidth = 6;
            this.LinkingUrl.Name = "LinkingUrl";
            this.LinkingUrl.Width = 125;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 6;
            this.Path.Name = "Path";
            this.Path.Width = 125;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.MinimumWidth = 6;
            this.Owner.Name = "Owner";
            this.Owner.Width = 125;
            // 
            // LastModifiedTime
            // 
            this.LastModifiedTime.HeaderText = "LastModifiedTime";
            this.LastModifiedTime.MinimumWidth = 6;
            this.LastModifiedTime.Name = "LastModifiedTime";
            this.LastModifiedTime.Width = 125;
            // 
            // dateFromLbl
            // 
            this.dateFromLbl.AutoSize = true;
            this.dateFromLbl.Location = new System.Drawing.Point(9, 89);
            this.dateFromLbl.Name = "dateFromLbl";
            this.dateFromLbl.Size = new System.Drawing.Size(79, 20);
            this.dateFromLbl.TabIndex = 4;
            this.dateFromLbl.Text = "Date From";
            this.dateFromLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 80);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateToLbl
            // 
            this.dateToLbl.AutoSize = true;
            this.dateToLbl.Location = new System.Drawing.Point(437, 86);
            this.dateToLbl.Name = "dateToLbl";
            this.dateToLbl.Size = new System.Drawing.Size(61, 20);
            this.dateToLbl.TabIndex = 6;
            this.dateToLbl.Text = "Date To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(514, 82);
            this.dateTimePicker2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // isMemberCbx
            // 
            this.isMemberCbx.FormattingEnabled = true;
            this.isMemberCbx.Items.AddRange(new object[] {
            "",
            "True",
            "False"});
            this.isMemberCbx.Location = new System.Drawing.Point(970, 87);
            this.isMemberCbx.Name = "isMemberCbx";
            this.isMemberCbx.Size = new System.Drawing.Size(151, 28);
            this.isMemberCbx.TabIndex = 8;
            // 
            // isMemberLbl
            // 
            this.isMemberLbl.AutoSize = true;
            this.isMemberLbl.Location = new System.Drawing.Point(869, 87);
            this.isMemberLbl.Name = "isMemberLbl";
            this.isMemberLbl.Size = new System.Drawing.Size(75, 20);
            this.isMemberLbl.TabIndex = 9;
            this.isMemberLbl.Text = "IsMember";
            // 
            // leadersLbl
            // 
            this.leadersLbl.AutoSize = true;
            this.leadersLbl.Location = new System.Drawing.Point(439, 161);
            this.leadersLbl.Name = "leadersLbl";
            this.leadersLbl.Size = new System.Drawing.Size(60, 20);
            this.leadersLbl.TabIndex = 10;
            this.leadersLbl.Text = "Leaders";
            // 
            // bookCategoryLbl
            // 
            this.bookCategoryLbl.AutoSize = true;
            this.bookCategoryLbl.Location = new System.Drawing.Point(9, 156);
            this.bookCategoryLbl.Name = "bookCategoryLbl";
            this.bookCategoryLbl.Size = new System.Drawing.Size(103, 20);
            this.bookCategoryLbl.TabIndex = 11;
            this.bookCategoryLbl.Text = "BookCategory";
            // 
            // bookQuantityLbl
            // 
            this.bookQuantityLbl.AutoSize = true;
            this.bookQuantityLbl.Location = new System.Drawing.Point(866, 156);
            this.bookQuantityLbl.Name = "bookQuantityLbl";
            this.bookQuantityLbl.Size = new System.Drawing.Size(99, 20);
            this.bookQuantityLbl.TabIndex = 14;
            this.bookQuantityLbl.Text = "BookQuantity";
            // 
            // bookQuantityTxt
            // 
            this.bookQuantityTxt.Location = new System.Drawing.Point(972, 153);
            this.bookQuantityTxt.Name = "bookQuantityTxt";
            this.bookQuantityTxt.Size = new System.Drawing.Size(149, 27);
            this.bookQuantityTxt.TabIndex = 15;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(869, 208);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(76, 20);
            this.firstNameLbl.TabIndex = 16;
            this.firstNameLbl.Text = "FirstName";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(972, 205);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(152, 27);
            this.firstNameTxt.TabIndex = 17;
            // 
            // bookCategoryLbx
            // 
            this.bookCategoryLbx.FormattingEnabled = true;
            this.bookCategoryLbx.ItemHeight = 20;
            this.bookCategoryLbx.Items.AddRange(new object[] {
            ""});
            this.bookCategoryLbx.Location = new System.Drawing.Point(121, 159);
            this.bookCategoryLbx.Name = "bookCategoryLbx";
            this.bookCategoryLbx.Size = new System.Drawing.Size(251, 64);
            this.bookCategoryLbx.TabIndex = 18;
            // 
            // leaderLbx
            // 
            this.leaderLbx.FormattingEnabled = true;
            this.leaderLbx.ItemHeight = 20;
            this.leaderLbx.Items.AddRange(new object[] {
            ""});
            this.leaderLbx.Location = new System.Drawing.Point(514, 159);
            this.leaderLbx.Name = "leaderLbx";
            this.leaderLbx.Size = new System.Drawing.Size(250, 64);
            this.leaderLbx.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.leaderLbx);
            this.Controls.Add(this.bookCategoryLbx);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.bookQuantityTxt);
            this.Controls.Add(this.bookQuantityLbl);
            this.Controls.Add(this.bookCategoryLbl);
            this.Controls.Add(this.leadersLbl);
            this.Controls.Add(this.isMemberLbl);
            this.Controls.Add(this.isMemberCbx);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateToLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateFromLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerRedirectedURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkingUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastModifiedTime;
        private System.Windows.Forms.Label dateFromLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateToLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox isMemberCbx;
        private System.Windows.Forms.Label isMemberLbl;
        private System.Windows.Forms.Label leadersLbl;
        private System.Windows.Forms.Label bookCategoryLbl;
        private System.Windows.Forms.Label bookQuantityLbl;
        private System.Windows.Forms.TextBox bookQuantityTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.ListBox bookCategoryLbx;
        private System.Windows.Forms.ListBox leaderLbx;
    }
}

