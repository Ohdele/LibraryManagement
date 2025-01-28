"# Library Management System - Part 4 Documentation"
## Library Management System - Setup and Testing

### Setup

The system should behave as follows:

1. **Add a Book**
   - Use the `add` command to add a book.
   - Input the title of the book when prompted.

2. **Search for a Book**
   - Use the `search` command to search for a book.
   - If the book is **found**, the system will confirm that it is available.
   - If the book is **not found**, the system will prompt to add the book and then allow you to add it before proceeding.

3. **Borrow a Book**
   - Use the `borrow` command to borrow a book.
   - Input the title of the book to borrow.

4. **Return a Book**
   - Use the `return` command to return a borrowed book.
   - Input the title of the book to return.

5. **Exit the Program**
   - Use the `exit` command to exit the program.

### Example Walkthrough

The system will guide you through a series of prompts to test its functionality. Here’s how the flow will work:

```bash
> dotnet run
Would you like to add, remove, search, borrow, return, or exit?
add
Enter the title of the book to add:
The Catcher in the Rye
The Catcher in the Rye has been added to the library.

Would you like to add, remove, search, borrow, return, or exit?
search
Enter the title of the book to search for:
1984
1984 is available in the library.

Would you like to add, remove, search, borrow, return, or exit?
borrow
Enter the title of the book to borrow:
To Kill a Mockingbird
You have borrowed "To Kill a Mockingbird."

Would you like to add, remove, search, borrow, return, or exit?
return
Enter the title of the book to return:
To Kill a Mockingbird
You have returned "To Kill a Mockingbird."

Would you like to add, remove, search, borrow, return, or exit?
exit
