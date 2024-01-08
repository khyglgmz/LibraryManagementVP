namespace LibraryManagementSystemm
{
    partial class UserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnMainPage = new Button();
            lblWelcome = new Label();
            btnBorrowHistory = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            btnShowAll = new Button();
            txtSearch = new TextBox();
            BtnAvailable = new Button();
            dgvBooks = new DataGridView();
            btnBorrowBook = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(225, 207, 183);
            splitContainer1.Panel1.Controls.Add(btnMainPage);
            splitContainer1.Panel1.Controls.Add(lblWelcome);
            splitContainer1.Panel1.Controls.Add(btnBorrowHistory);
            splitContainer1.Panel1.Controls.Add(btnLogOut);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1247, 654);
            splitContainer1.SplitterDistance = 263;
            splitContainer1.TabIndex = 0;
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = Color.FromArgb(209, 183, 146);
            btnMainPage.ForeColor = Color.FromArgb(88, 60, 33);
            btnMainPage.Location = new Point(-1, 143);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(261, 59);
            btnMainPage.TabIndex = 5;
            btnMainPage.Text = "All Books";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = Color.FromArgb(88, 60, 33);
            lblWelcome.Location = new Point(76, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "label1";
            // 
            // btnBorrowHistory
            // 
            btnBorrowHistory.BackColor = Color.FromArgb(209, 183, 146);
            btnBorrowHistory.ForeColor = Color.FromArgb(88, 60, 33);
            btnBorrowHistory.Location = new Point(-1, 220);
            btnBorrowHistory.Name = "btnBorrowHistory";
            btnBorrowHistory.Size = new Size(261, 59);
            btnBorrowHistory.TabIndex = 2;
            btnBorrowHistory.Text = "Borrowing History";
            btnBorrowHistory.UseVisualStyleBackColor = false;
            btnBorrowHistory.Click += btnBorrowHistory_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(209, 183, 146);
            btnLogOut.ForeColor = Color.FromArgb(88, 60, 33);
            btnLogOut.Location = new Point(8, 592);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(261, 59);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 207, 183);
            panel1.Controls.Add(btnShowAll);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(BtnAvailable);
            panel1.Controls.Add(dgvBooks);
            panel1.Controls.Add(btnBorrowBook);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 654);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(209, 183, 146);
            btnShowAll.ForeColor = Color.FromArgb(88, 60, 33);
            btnShowAll.Location = new Point(77, 448);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(261, 60);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All Books";
            btnShowAll.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(209, 183, 146);
            txtSearch.Location = new Point(207, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(248, 23);
            txtSearch.TabIndex = 4;
            // 
            // BtnAvailable
            // 
            BtnAvailable.BackColor = Color.FromArgb(209, 183, 146);
            BtnAvailable.ForeColor = Color.FromArgb(88, 60, 33);
            BtnAvailable.Location = new Point(77, 383);
            BtnAvailable.Name = "BtnAvailable";
            BtnAvailable.Size = new Size(261, 59);
            BtnAvailable.TabIndex = 3;
            BtnAvailable.Text = "Only Avaliable Books";
            BtnAvailable.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            dgvBooks.BackgroundColor = Color.FromArgb(225, 207, 183);
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.GridColor = Color.DarkSalmon;
            dgvBooks.Location = new Point(77, 169);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(713, 169);
            dgvBooks.TabIndex = 2;
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.BackColor = Color.FromArgb(209, 183, 146);
            btnBorrowBook.ForeColor = Color.FromArgb(88, 60, 33);
            btnBorrowBook.Location = new Point(522, 383);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(268, 76);
            btnBorrowBook.TabIndex = 1;
            btnBorrowBook.Text = "Borrow Book";
            btnBorrowBook.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(209, 183, 146);
            btnSearch.ForeColor = Color.FromArgb(88, 60, 33);
            btnSearch.Location = new Point(522, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(261, 59);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search Books";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 654);
            Controls.Add(splitContainer1);
            Name = "UserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPage";
            Load += UserPage_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnBorrowBook;
        private Button btnSearch;
        private Panel panel1;
        private DataGridView dgvBooks;
        private Button btnBorrowHistory;
        private Button btnLogOut;
        private Button BtnAvailable;
        private Label lblWelcome;
        private TextBox txtSearch;
        private Button btnShowAll;
        private Button btnMainPage;
    }
}