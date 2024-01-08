namespace LibraryManagementSystemm.AdminPageUserControls
{
    partial class DeleteBookPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvSearchResults = new DataGridView();
            btnDeleteBook = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(209, 183, 146);
            txtSearch.Location = new Point(104, 165);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(396, 23);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(88, 60, 33);
            label1.Location = new Point(104, 122);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Books";
            // 
            // dgvSearchResults
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(225, 207, 183);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(88, 60, 33);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(225, 207, 183);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 128, 0);
            dgvSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvSearchResults.BackgroundColor = Color.FromArgb(225, 207, 183);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 207, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSearchResults.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSearchResults.GridColor = SystemColors.InfoText;
            dgvSearchResults.Location = new Point(104, 227);
            dgvSearchResults.Name = "dgvSearchResults";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSearchResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(88, 60, 33);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvSearchResults.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSearchResults.Size = new Size(683, 178);
            dgvSearchResults.TabIndex = 2;
            dgvSearchResults.CellContentClick += dgvSearchResults_CellContentClick;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.FromArgb(209, 183, 146);
            btnDeleteBook.ForeColor = Color.FromArgb(88, 60, 33);
            btnDeleteBook.Location = new Point(586, 423);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(201, 36);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(209, 183, 146);
            btnSearch.ForeColor = Color.FromArgb(88, 60, 33);
            btnSearch.Location = new Point(593, 155);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 33);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // DeleteBookPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 207, 183);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteBook);
            Controls.Add(dgvSearchResults);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Name = "DeleteBookPage";
            Size = new Size(1037, 704);
            Load += DeleteBookPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvSearchResults;
        private Button btnDeleteBook;
        private Button btnSearch;
    }
}
