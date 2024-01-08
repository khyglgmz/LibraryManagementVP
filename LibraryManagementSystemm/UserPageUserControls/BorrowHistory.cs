using LibraryManagementSystemm.Entities;
using LibraryManagementSystemm.Services;
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
    public partial class BorrowHistory : UserControl
    {
        private readonly UserPageService _userPageService;
        private List<BookBorrowing> _borrowingHistory;
        private readonly User _currentUser;


        public BorrowHistory(User currentUser, UserPageService userPageService)
        {
            InitializeComponent();
            _userPageService = userPageService;
            _borrowingHistory = new List<BookBorrowing>();
            _currentUser = currentUser; 
            dgvBorrowingHistory.AutoGenerateColumns = false;
            InitializeDataGridView();
            LoadBorrowingHistory(_currentUser);
        }

        private void InitializeDataGridView()
        {

            DataGridViewTextBoxColumn borrowDateColumn = new DataGridViewTextBoxColumn();
            borrowDateColumn.DataPropertyName = "BorrowDate";
            borrowDateColumn.HeaderText = "Borrow Date";

            DataGridViewTextBoxColumn returnDateColumn = new DataGridViewTextBoxColumn();
            returnDateColumn.DataPropertyName = "ReturnDate";
            returnDateColumn.HeaderText = "Return Date";

            DataGridViewTextBoxColumn bookTitleColumn = new DataGridViewTextBoxColumn();
            bookTitleColumn.DataPropertyName = "BookTitle";
            bookTitleColumn.HeaderText = "Book Title";

            DataGridViewTextBoxColumn userNameColumn = new DataGridViewTextBoxColumn();
            userNameColumn.DataPropertyName = "Username";
            userNameColumn.HeaderText = "Username";

            

            dgvBorrowingHistory.Columns.Add(borrowDateColumn);
            dgvBorrowingHistory.Columns.Add(returnDateColumn);
            dgvBorrowingHistory.Columns.Add(bookTitleColumn);
            dgvBorrowingHistory.Columns.Add(userNameColumn);
        }
        public void LoadBorrowingHistory(User currentUser)
        {
            List<BorrowHistoryItem> borrowingHistory = _userPageService.GetBorrowingHistory(currentUser);

            dgvBorrowingHistory.DataSource = borrowingHistory;

            dgvBorrowingHistory.Refresh();
        }






       
        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            if (dgvBorrowingHistory.SelectedRows.Count > 0)
            {
                BorrowHistoryItem selectedBorrowing = dgvBorrowingHistory.SelectedRows[0].DataBoundItem as BorrowHistoryItem;

                if (selectedBorrowing.ReturnDate.HasValue)
                {
                    MessageBox.Show("This book has already been returned.");
                }
                else
                {
                    _userPageService.ReturnBook(selectedBorrowing.BorrowingId);

                    LoadBorrowingHistory(_currentUser);

                    MessageBox.Show("Book returned successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }

        private void BorrowHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
