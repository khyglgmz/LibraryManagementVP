using LibraryManagementSystemm.Data_Acces_Layer;
using LibraryManagementSystemm.Entities;
using LibraryManagementSystemm.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystemm
{
    public partial class Form1 : Form
    {
        private LibraryDBContext _dbContext;
        private User? _loggedInUser;

        public Form1()
        {
            InitializeComponent();
            _dbContext = new LibraryDBContext();
      
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
          ShowLoginForm();
        }
        private void ShowLoginForm()
        {
            using (var loginPage = new LoginPage())
            {
                var result = loginPage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _loggedInUser = loginPage.AuthenticatedUser;

                    if (_loggedInUser != null)
                    {
                        MessageBox.Show("Login successful!");

                        if (_loggedInUser.Role == "Admin")
                        {
                            MessageBox.Show("adminnn");
                            OpenAdminPage();
                         
                        }
                        else if (_loggedInUser.Role == "User")
                        {
                            UserManager.Login(_loggedInUser);

                       
                            var adminBookService = new AdminBookService(_dbContext);
                            var userPageService = new UserPageService(_dbContext);

                            OpenUserPage(_loggedInUser, loginPage);
                            
                        }

                        loginPage.Close();
                    }
                }
                else
                {
                  
                    if (Application.OpenForms.Count == 1)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void OpenAdminPage()
        {
            var adminBookService = new AdminBookService(_dbContext);
            var adminPage = new AdminPage(adminBookService, _loggedInUser);
            adminPage.ShowDialog();
        }

        private void OpenUserPage(User authenticatedUser, Form loginPage)
        {
            var userPage = new UserPage(authenticatedUser, _dbContext);
            userPage.FormClosed += (s, args) => loginPage.Close(); 
            userPage.Show();
        }

    }
}
