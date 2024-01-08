using LibraryManagementSystemm.Data_Acces_Layer;
using LibraryManagementSystemm.Entities;
using LibraryManagementSystemm.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystemm
{
    public partial class LoginPage : Form
    {
        private readonly LibraryDBContext _dbContext;

        public User AuthenticatedUser { get; internal set; }

        public LoginPage()
        {
            InitializeComponent();
            _dbContext = new LibraryDBContext();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var authenticatedUser = AuthenticateUser(username, password);

                if (authenticatedUser != null)
                {
                    if (authenticatedUser.Role == "Admin")
                    {
                        OpenAdminPage();
                    }
                    else if (authenticatedUser.Role == "User")
                    {
                        OpenUserPage(authenticatedUser);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            return _dbContext.User.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
        private void OpenAdminPage()
        {
            var authenticatedUser = AuthenticateUser(txtUsername.Text, txtPassword.Text);

            if (authenticatedUser != null)
            {
                if (authenticatedUser.Role == "Admin")
                {
                    var adminBookService = new AdminBookService(_dbContext);
                    var adminPage = new AdminPage(adminBookService, authenticatedUser);
                    adminPage.ShowDialog();
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
        private void OpenUserPage(User authenticatedUser)
        {
            var userPage = new UserPage(authenticatedUser, _dbContext);

            userPage.ShowDialog();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
