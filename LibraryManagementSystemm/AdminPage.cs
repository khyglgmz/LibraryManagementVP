using LibraryManagementSystemm.AdminPageUserControls;
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

namespace LibraryManagementSystemm
{
    public partial class AdminPage : Form
    {
        private readonly AdminBookService _adminBookService;
        private readonly User _authenticatedUser;
        private readonly LibraryDBContext _dbContext;
        public AdminPage(AdminBookService adminBookService, User authenticatedUser)
        {
            InitializeComponent();
            _dbContext = new LibraryDBContext();
            _adminBookService = new AdminBookService(_dbContext);
            _authenticatedUser = authenticatedUser;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayUserControl(new AddNewBookPage(_adminBookService));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DisplayUserControl(new DeleteBookPage(_dbContext));
        }
        private void DisplayUserControl(UserControl userControl)
        {
            panel2.Controls.Clear();

            panel2.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
