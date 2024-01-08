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

namespace LibraryManagementSystemm.UserPageUserControls
{
    public partial class UserMainPage : UserControl
    {
        private readonly User _currentUser;
        private List<Book> _currentBooksList;
        private readonly LibraryDBContext _dbContext;
        private BorrowHistory _borrowHistory;
        private readonly UserPageService _userPageService;
        public UserMainPage(User currentUser, LibraryDBContext dbContext)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _dbContext = dbContext;
            _userPageService = new UserPageService(_dbContext);
            _currentBooksList = new List<Book>();
            _borrowHistory = new BorrowHistory(_currentUser, _userPageService); 
        }

        public void InitializeUI()
        {
            _currentBooksList = _userPageService.GetAllBooks();
            BindBooksToDataGridView(_currentBooksList);
        }
        private void BindBooksToDataGridView(List<Book> books)
        {
            dgvBooks.DataSource = books;
        }

        private void RefreshBookList()
        {
            _currentBooksList = _userPageService.GetAllBooks();
            BindBooksToDataGridView(_currentBooksList);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchCriteria = txtSearch.Text;

            if (!string.IsNullOrEmpty(searchCriteria))
            {
                List<Book> searchResults = _userPageService.SearchBooks(searchCriteria);
                BindBooksToDataGridView(searchResults);
            }
            else
            {
                BindBooksToDataGridView(_currentBooksList);
            }
        }

        private void btnBorrowBook_Click_1(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];

                if (selectedRow != null && selectedRow.DataBoundItem is Book selectedBook)
                {
                    if (selectedBook.Availability)
                    {
                        _userPageService.BorrowBook(_currentUser, selectedBook);

                        RefreshBookList();
                        _borrowHistory.LoadBorrowingHistory(_currentUser);
                    }
                    else
                    {
                        MessageBox.Show("This book is not available for borrowing.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a valid book.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.");
            }

        }

        private void BtnAvailable_Click_1(object sender, EventArgs e)
        {
            _currentBooksList = _userPageService.GetAvailableBooks();
            BindBooksToDataGridView(_currentBooksList);
        }

        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            _currentBooksList = _userPageService.GetAllBooks();
            BindBooksToDataGridView(_currentBooksList);
        }
    }
}
