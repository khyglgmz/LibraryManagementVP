namespace LibraryManagementSystemm.AdminPageUserControls
{
    partial class AddNewBookPage
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
            panel1 = new Panel();
            btnAddNewBook = new Button();
            checkBoxAvailability = new CheckBox();
            txtNewBookPage = new TextBox();
            txtNewGenre = new TextBox();
            txtNewAuthor = new TextBox();
            txtNewTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 207, 183);
            panel1.Controls.Add(btnAddNewBook);
            panel1.Controls.Add(checkBoxAvailability);
            panel1.Controls.Add(txtNewBookPage);
            panel1.Controls.Add(txtNewGenre);
            panel1.Controls.Add(txtNewAuthor);
            panel1.Controls.Add(txtNewTitle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 737);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddNewBook
            // 
            btnAddNewBook.BackColor = Color.FromArgb(209, 183, 146);
            btnAddNewBook.ForeColor = Color.FromArgb(88, 60, 33);
            btnAddNewBook.Location = new Point(405, 243);
            btnAddNewBook.Name = "btnAddNewBook";
            btnAddNewBook.Size = new Size(184, 48);
            btnAddNewBook.TabIndex = 10;
            btnAddNewBook.Text = "Add New Book";
            btnAddNewBook.UseVisualStyleBackColor = false;
            btnAddNewBook.Click += btnAddNewBook_Click;
            // 
            // checkBoxAvailability
            // 
            checkBoxAvailability.AutoSize = true;
            checkBoxAvailability.ForeColor = Color.FromArgb(88, 60, 33);
            checkBoxAvailability.Location = new Point(787, 174);
            checkBoxAvailability.Name = "checkBoxAvailability";
            checkBoxAvailability.Size = new Size(74, 19);
            checkBoxAvailability.TabIndex = 9;
            checkBoxAvailability.Text = "Available";
            checkBoxAvailability.UseVisualStyleBackColor = true;
            // 
            // txtNewBookPage
            // 
            txtNewBookPage.BackColor = Color.FromArgb(209, 183, 146);
            txtNewBookPage.ForeColor = Color.FromArgb(88, 60, 33);
            txtNewBookPage.Location = new Point(593, 174);
            txtNewBookPage.Name = "txtNewBookPage";
            txtNewBookPage.Size = new Size(100, 23);
            txtNewBookPage.TabIndex = 8;
            // 
            // txtNewGenre
            // 
            txtNewGenre.BackColor = Color.FromArgb(209, 183, 146);
            txtNewGenre.ForeColor = Color.FromArgb(88, 60, 33);
            txtNewGenre.Location = new Point(438, 174);
            txtNewGenre.Name = "txtNewGenre";
            txtNewGenre.Size = new Size(100, 23);
            txtNewGenre.TabIndex = 7;
            // 
            // txtNewAuthor
            // 
            txtNewAuthor.BackColor = Color.FromArgb(209, 183, 146);
            txtNewAuthor.ForeColor = Color.FromArgb(88, 60, 33);
            txtNewAuthor.Location = new Point(276, 174);
            txtNewAuthor.Name = "txtNewAuthor";
            txtNewAuthor.Size = new Size(100, 23);
            txtNewAuthor.TabIndex = 6;
            // 
            // txtNewTitle
            // 
            txtNewTitle.BackColor = Color.FromArgb(209, 183, 146);
            txtNewTitle.ForeColor = Color.FromArgb(88, 60, 33);
            txtNewTitle.Location = new Point(111, 174);
            txtNewTitle.Name = "txtNewTitle";
            txtNewTitle.Size = new Size(100, 23);
            txtNewTitle.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(88, 60, 33);
            label5.Location = new Point(303, 130);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(88, 60, 33);
            label4.Location = new Point(787, 130);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Availability";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(88, 60, 33);
            label3.Location = new Point(608, 130);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Book Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(88, 60, 33);
            label2.Location = new Point(470, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Genre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(88, 60, 33);
            label1.Location = new Point(148, 130);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // AddNewBookPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddNewBookPage";
            Size = new Size(1049, 737);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddNewBook;
        private CheckBox checkBoxAvailability;
        private TextBox txtNewBookPage;
        private TextBox txtNewGenre;
        private TextBox txtNewAuthor;
        private TextBox txtNewTitle;
    }
}
