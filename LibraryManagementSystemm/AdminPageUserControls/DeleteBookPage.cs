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

namespace LibraryManagementSystemm.AdminPageUserControls
{
    public partial class DeleteBookPage : UserControl
    {
        private readonly LibraryDBContext _dbContext;
        private readonly AdminBookService _adminBookService;
        public DeleteBookPage(LibraryDBContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _adminBookService = new AdminBookService(_dbContext);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvSearchResults.SelectedRows.Count > 0)
            {
                Book selectedBook = dgvSearchResults.SelectedRows[0].DataBoundItem as Book;

              
                _adminBookService.DeleteBook(selectedBook.BookId);  

                btnSearch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }

        }
        private List<Book> SearchBooks(string searchCriteria)
        {
            
            var query = _dbContext.Book.Where(b => b.Title.Contains(searchCriteria) || b.Author.Contains(searchCriteria)).ToList();

            return query;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = txtSearch.Text;

            List<Book> searchResults = SearchBooks(searchCriteria);

            dgvSearchResults.DataSource = searchResults;
        }

        private void dgvSearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBookPage_Load(object sender, EventArgs e)
        {

        }
    }
}
