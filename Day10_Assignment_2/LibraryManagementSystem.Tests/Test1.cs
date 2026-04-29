using LibraryManagementSystem;
using Microsoft.Extensions.DependencyModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagementSystem.Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var library = new Library();
            var book = new Book { Title = "C#", Author = "MS", ISBN = "123" };

            library.AddBook(book);

            Assert.AreEqual(1, library.Books.Count);
        }

        [TestMethod]
        public void RegisterBorrower_ShouldAddBorrower()
        {
            var library = new Library();
            var borrower = new Borrower { Name = "Sneha", LibraryCardNumber = "001" };

            library.RegisterBorrower(borrower);

            Assert.AreEqual(1, library.Borrowers.Count);
        }

        [TestMethod]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var library = new Library();
            var book = new Book { Title = "C#", Author = "MS", ISBN = "123" };
            var borrower = new Borrower { Name = "Sneha", LibraryCardNumber = "001" };

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123", "001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            var library = new Library();
            var book = new Book { Title = "C#", Author = "MS", ISBN = "123" };
            var borrower = new Borrower { Name = "Sneha", LibraryCardNumber = "001" };

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("123", "001");

            library.ReturnBook("123", "001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void ViewBooks_ShouldReturnAllBooks()
        {
            var library = new Library();
            library.AddBook(new Book { Title = "C#", Author = "MS", ISBN = "123" });

            var books = library.ViewBooks();

            Assert.AreEqual(1, books.Count);
        }

        [TestMethod]
        public void ViewBorrowers_ShouldReturnAllBorrowers()
        {
            var library = new Library();
            library.RegisterBorrower(new Borrower { Name = "Sneha", LibraryCardNumber = "001" });

            var borrowers = library.ViewBorrowers();

            Assert.AreEqual(1, borrowers.Count);
        }
    }
}