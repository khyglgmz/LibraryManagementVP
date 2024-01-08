namespace LibraryManagementSystemm.UserPageUserControls
{
    partial class BorrowHistory
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnReturnBooks = new Button();
            dgvBorrowingHistory = new DataGridView();
            bookBindingSource = new BindingSource(components);
            bookBorrowingBindingSource = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            bookBindingSource2 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowingHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBorrowingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnReturnBooks
            // 
            btnReturnBooks.BackColor = Color.FromArgb(209, 183, 146);
            btnReturnBooks.Cursor = Cursors.Hand;
            btnReturnBooks.ForeColor = Color.FromArgb(88, 60, 33);
            btnReturnBooks.Location = new Point(835, 379);
            btnReturnBooks.Name = "btnReturnBooks";
            btnReturnBooks.Size = new Size(136, 37);
            btnReturnBooks.TabIndex = 0;
            btnReturnBooks.Text = "Return Book";
            btnReturnBooks.UseVisualStyleBackColor = false;
            btnReturnBooks.Click += btnReturnBooks_Click;
            // 
            // dgvBorrowingHistory
            // 
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(88, 60, 33);
            dgvBorrowingHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBorrowingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowingHistory.Location = new Point(110, 105);
            dgvBorrowingHistory.Name = "dgvBorrowingHistory";
            dgvBorrowingHistory.Size = new Size(861, 257);
            dgvBorrowingHistory.TabIndex = 1;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Entities.Book);
            // 
            // bookBorrowingBindingSource
            // 
            bookBorrowingBindingSource.DataSource = typeof(Entities.BookBorrowing);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Entities.Book);
            // 
            // bookBindingSource2
            // 
            bookBindingSource2.DataSource = typeof(Entities.Book);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Entities.User);
            // 
            // BorrowHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 207, 183);
            Controls.Add(dgvBorrowingHistory);
            Controls.Add(btnReturnBooks);
            Name = "BorrowHistory";
            Size = new Size(1097, 590);
            Load += BorrowHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowingHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBorrowingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturnBooks;
        private DataGridView dgvBorrowingHistory;
        private BindingSource bookBindingSource;
        private BindingSource bookBorrowingBindingSource;
        private BindingSource bookBindingSource1;
        private BindingSource bookBindingSource2;
        private BindingSource userBindingSource;
    }
}
