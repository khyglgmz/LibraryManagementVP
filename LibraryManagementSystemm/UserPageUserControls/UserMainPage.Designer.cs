namespace LibraryManagementSystemm.UserPageUserControls
{
    partial class UserMainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnShowAll = new Button();
            txtSearch = new TextBox();
            BtnAvailable = new Button();
            dgvBooks = new DataGridView();
            btnBorrowBook = new Button();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1189, 650);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(209, 183, 146);
            btnShowAll.ForeColor = Color.FromArgb(88, 60, 33);
            btnShowAll.Location = new Point(179, 454);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(211, 48);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All Books";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.BurlyWood;
            txtSearch.ForeColor = Color.FromArgb(88, 60, 33);
            txtSearch.Location = new Point(247, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 23);
            txtSearch.TabIndex = 4;
            // 
            // BtnAvailable
            // 
            BtnAvailable.BackColor = Color.FromArgb(209, 183, 146);
            BtnAvailable.ForeColor = Color.FromArgb(88, 60, 33);
            BtnAvailable.Location = new Point(179, 362);
            BtnAvailable.Name = "BtnAvailable";
            BtnAvailable.Size = new Size(211, 51);
            BtnAvailable.TabIndex = 3;
            BtnAvailable.Text = "Only Avaliable Books";
            BtnAvailable.UseVisualStyleBackColor = false;
            BtnAvailable.Click += BtnAvailable_Click_1;
            // 
            // dgvBooks
            // 
            dgvBooks.BackgroundColor = Color.FromArgb(209, 183, 146);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(209, 183, 146);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(88, 60, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.GridColor = Color.DarkSalmon;
            dgvBooks.Location = new Point(179, 170);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(832, 186);
            dgvBooks.TabIndex = 2;
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.BackColor = Color.FromArgb(209, 183, 146);
            btnBorrowBook.ForeColor = Color.FromArgb(88, 60, 33);
            btnBorrowBook.Location = new Point(691, 365);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(215, 48);
            btnBorrowBook.TabIndex = 1;
            btnBorrowBook.Text = "Borrow Book";
            btnBorrowBook.UseVisualStyleBackColor = false;
            btnBorrowBook.Click += btnBorrowBook_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(209, 183, 146);
            btnSearch.ForeColor = Color.FromArgb(88, 60, 33);
            btnSearch.Location = new Point(630, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(207, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search Books";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserMainPage";
            Size = new Size(1189, 650);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnShowAll;
        private TextBox txtSearch;
        private Button BtnAvailable;
        private DataGridView dgvBooks;
        private Button btnBorrowBook;
        private Button btnSearch;
    }
}
