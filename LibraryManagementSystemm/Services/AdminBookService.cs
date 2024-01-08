using LibraryManagementSystemm.Data_Acces_Layer;
using LibraryManagementSystemm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemm.Services
{
    public class AdminBookService
    {

        private readonly LibraryDBContext _dbContext;

        public AdminBookService(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddNewBook(string title, string author, string genre, string bookPage, bool availability)
        {

            var newBook = new Book
            {
                Title = title,
                Author = author,
                Genre = genre,
                bookPage = bookPage,
                Availability = availability 
            };

            _dbContext.Book.Add(newBook);
            _dbContext.SaveChanges();
        }
        public void DeleteBook(int bookId)
        {
            var bookToDelete = _dbContext.Book.Find(bookId);

            if (bookToDelete != null)
            {
                _dbContext.Book.Remove(bookToDelete);
                _dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("The book doesnt exist!");
            }
        }

    }
}
