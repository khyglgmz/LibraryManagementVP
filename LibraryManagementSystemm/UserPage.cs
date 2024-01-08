using LibraryManagementSystemm.Data_Acces_Layer;
using LibraryManagementSystemm.Entities;
using LibraryManagementSystemm.Services;
using LibraryManagementSystemm.UserPageUserControls;
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

namespace LibraryManagementSystemm
{
    public partial class UserPage : Form
    {
        private readonly User _currentUser;
        private List<Book> _currentBooksList;
        private readonly LibraryDBContext _dbContext;
        private BorrowHistory _borrowHistory;
        private readonly UserPageService _userPageService;
        private readonly UserMainPage _userMainPage;
        public UserPage(User currentUser, LibraryDBContext dbContext)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _dbContext = dbContext;

            _userPageService = new UserPageService(_dbContext);
            _borrowHistory = new BorrowHistory(_currentUser, _userPageService); 
            _userMainPage = new UserMainPage(_currentUser, _dbContext);
        }


        private void UserPage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_currentUser.Username}!";
            ShowUserMainPage();
        }

        private void ShowUserMainPage()
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(_userMainPage);

            _userMainPage.InitializeUI();
        }

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            ShowBorrowHistory();
        }
        public void ShowBorrowHistory()
        {
            if (_borrowHistory == null)
            {
                _borrowHistory = new BorrowHistory(_currentUser, _userPageService);
            }

            _borrowHistory.LoadBorrowingHistory(_currentUser);
            panel1.Controls.Clear();
            panel1.Controls.Add(_borrowHistory);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { }



        private void btnMainPage_Click(object sender, EventArgs e)
        {
            ShowUserMainPage();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
