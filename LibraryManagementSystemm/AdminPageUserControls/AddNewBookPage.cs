using LibraryManagementSystemm.Data_Acces_Layer;
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

namespace LibraryManagementSystemm.AdminPageUserControls
{
    public partial class AddNewBookPage : UserControl
    {
        private readonly AdminBookService _adminBookService;

        public AddNewBookPage(AdminBookService adminBookService)
        {
            InitializeComponent();
            _adminBookService = adminBookService;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            string Title = txtNewTitle.Text;
            string Author = txtNewAuthor.Text;
            string Genre = txtNewGenre.Text;
            string bookPage = txtNewBookPage.Text;
            bool availability = checkBoxAvailability.Checked;

            _adminBookService.AddNewBook(Title, Author, Genre, bookPage, availability);
        }
    }
}
