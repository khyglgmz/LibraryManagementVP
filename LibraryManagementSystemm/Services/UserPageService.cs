using LibraryManagementSystemm.Data_Acces_Layer;
using LibraryManagementSystemm.Entities;
using LibraryManagementSystemm.UserPageUserControls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemm.Services
{
    public class UserPageService
    {
        private readonly LibraryDBContext _dbContext;

        public UserPageService(LibraryDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext), "dbContext cannot be null.");
        }
        public List<Book> GetAvailableBooks()
        {
            return _dbContext.Book.Where(b => b.Availability).ToList();
        }
        public List<Book> GetAllBooks()
        {
            // Return all books, regardless of availability
            return _dbContext.Book.ToList();
        }

        public List<Book> SearchBooks(string searchCriteria)
        {
            return _dbContext.Book.Where(b => b.Title.Contains(searchCriteria) ||
                                              b.Author.Contains(searchCriteria) ||
                                              b.Genre.Contains(searchCriteria)).ToList();
        }

        // Inside UserPageService class
        public List<BorrowHistoryItem> GetBorrowingHistory(User currentUser)
        {
            return _dbContext.BookBorrowings
                .Where(b => b.UserId == currentUser.UserID)
                .Include(b => b.Book)
                .Include(b => b.User)
                .Select(b => new BorrowHistoryItem
                {
                    BorrowingId = b.BorrowingId,
                    UserId = b.UserId,
                    Username = b.User.Username,
                    BookId = b.BookId,
                    BookTitle = b.Book.Title,
                    BorrowDate = b.BorrowDate,
                    ReturnDate = b.ReturnDate 
                })
                .ToList();
        }

        public void ReturnBook(int borrowingId)
        {
           
                var borrowedBook = _dbContext.BookBorrowings
                    .Include(b => b.Book)
                    .SingleOrDefault(b => b.BorrowingId == borrowingId);

                if (borrowedBook != null && borrowedBook.ReturnDate == null)
                {
                    borrowedBook.Book.Availability = true;

                    borrowedBook.ReturnDate = DateTime.Now;

                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("This book is already returned or not borrowed.");
                }
            

        }


        public List<BorrowHistoryItem> GetLatestBorrowingHistory(User currentUser)
        {
            return _dbContext.BookBorrowings
                .Where(b => b.UserId == currentUser.UserID && b.ReturnDate != null)
                .Include(b => b.Book)
                .Include(b => b.User)
                .Select(b => new BorrowHistoryItem
                {
                    BorrowingId = b.BorrowingId,
                    UserId = b.UserId,
                    Username = b.User.Username,
                    BookId = b.BookId,
                    BookTitle = b.Book.Title,
                    BorrowDate = b.BorrowDate,
                    ReturnDate = b.ReturnDate
                })
                .ToList();
        }


        public List<BorrowHistoryItem> BorrowBook(User currentUser, Book book)
        {
            if (book.Availability)
            {
                book.Availability = false;

                var borrowingRecord = new BookBorrowing
                {
                    UserId = currentUser.UserID,
                    BookId = book.BookId,
                    BorrowDate = DateTime.Now,
                    ReturnDate = null  
                };

                _dbContext.BookBorrowings.Add(borrowingRecord);

                _dbContext.SaveChanges();

                List<BorrowHistoryItem> latestBorrowingHistory = GetLatestBorrowingHistory(currentUser);

                MessageBox.Show($"You have successfully borrowed '{book.Title}'. ");

                return latestBorrowingHistory;
            }
            else
            {
                MessageBox.Show("This book is not available for borrowing.");
                return null;
            }
        }



    }

} 


