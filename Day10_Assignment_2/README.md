## Library Management System

### Description
A simple .NET class library that implements a basic library management system with functionality to manage books and borrowers.

### Features
- Add new books  
- Register borrowers  
- Borrow a book  
- Return a book  
- View all books  
- View all borrowers  

### Technologies Used
- C#  
- .NET  
- MSTest  

### Project Structure
- LibraryManagementSystem → Core classes (Book, Borrower, Library)  
- LibraryManagementSystem.Tests → Unit tests  

### Test Cases
- AddBook_ShouldAddBookToLibrary  
- RegisterBorrower_ShouldAddBorrower  
- BorrowBook_ShouldMarkBookAsBorrowed  
- ReturnBook_ShouldMarkBookAsAvailable  
- ViewBooks_ShouldReturnAllBooks  
- ViewBorrowers_ShouldReturnAllBorrowers  

### Output
All unit tests executed successfully with no failures.