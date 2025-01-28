"# Library Management System"


# Library Management System Documentation

## Overview
The Library Management System (LMS) is a C# console application that allows users to manage a library of books. Users can add, remove, search, borrow, and return books. This system is designed to be simple and intuitive, leveraging Microsoft Copilot to help optimize code and add new features across four parts.

---

## Part 1: Basic Library Management System

### Objective:
The goal of Part 1 was to create a basic library management system where users can:
- Add a book to the library.
- Remove a book from the library.
- Search for a book.
- Borrow a book.
- Return a borrowed book.

### Key Features:
- **Add Book**: Users can input the title of a book, and the system adds it to the library collection.
- **Remove Book**: Users can input the title of a book, and if it exists in the library, it gets removed.
- **Search Book**: Users can search for a book by title, and the system will confirm its availability.
- **Borrow Book**: Users can borrow a book, which is marked as checked out.
- **Return Book**: Users can return a borrowed book, marking it as available again.

---

## Part 2: Enhanced Features (Search & Borrow Limit)

### Objective:
In Part 2, the system was enhanced by adding the ability to:
- Search for a book by its title.
- Limit the number of books a user can borrow at once (maximum of 3 books).

### Key Features:
- **Search Book**: Users can search for a book, and if it is available in the library, it is confirmed; if not, the system informs the user.
- **Limit Borrowing**: The system ensures that users cannot borrow more than 3 books at a time. The system tracks borrowed books and prevents users from borrowing more if they exceed the limit.

---

## Part 3: Borrowing and Returning Books (Check-in / Check-out)

### Objective:
Part 3 focused on implementing the borrowing and returning features, with the following:
- Track the number of books borrowed by each user.
- Implement a system to check-in a borrowed book.

### Key Features:
- **Borrow Book**: Users can borrow books, and the system checks if the user exceeds the borrowing limit. If within limit, the book is marked as checked out.
- **Return Book**: When returning a book, the system verifies whether the book is checked out. If it is, the system allows it to be returned and marks it as available.

---

## Part 4: Documentation and Code Refinement

### Objective:
In Part 4, the focus was to refine the code and add detailed documentation to ensure the system works smoothly and is easy to use and maintain.

### Key Features:
- **Error Handling**: Fixed issues with null reference warnings, ensuring safe handling of data and operations.
- **Documentation**: Added documentation and clear comments to each section of the code to inform future developers or reviewers on how to operate and extend the system.
- **Improved Flow**: Users can now easily perform actions such as adding, searching, borrowing, and returning books. If a book is not found during a search, users are prompted to add the book before proceeding.

---

## Usage Instructions

1. **Start the Program**:
   - Run the application with `dotnet run`.
   - The system will prompt the user with options: add, remove, search, borrow, return, or exit.

2. **Add a Book**:
   - Select `add` and input the title of the book.
   - The book will be added to the library.

3. **Search for a Book**:
   - Select `search` and input the title of the book.
   - The system will either confirm the book's availability or inform you that it's not in the collection.
   - If not found, you can add the book directly through the system.

4. **Borrow a Book**:
   - Select `borrow` and input the title of the book.
   - The system will check if the user has exceeded the borrowing limit (max 3 books).
   - If the book is available, it will be borrowed and marked as checked out.

5. **Return a Book**:
   - Select `return` and input the title of the book.
   - If the book is checked out, it will be returned and marked as available.

6. **Exit**:
   - Select `exit` to quit the program.

---

## Future Improvements
- Add a user authentication system to track individual users' borrowing history.
- Implement a database to store books and borrowing records.
- Introduce book categories and filters to improve search functionality.

---

## Conclusion
This Library Management System offers a practical and straightforward way to manage a collection of books. With enhanced search capabilities, borrowing limits, and check-in/check-out functionality, it provides a solid foundation for further development. The code is written to be extensible, making it easy to add new features in the future. The use of Microsoft Copilot helped speed up development and ensure the functionality was robust and efficient.

