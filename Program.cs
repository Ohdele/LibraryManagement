using System;
using System.Collections.Generic;

class LibraryManager
{
    static List<string> books = new List<string>();
    static List<string> borrowedBooks = new List<string>();
    static int maxBooksToBorrow = 3;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Would you like to add, remove, search, borrow, return, or exit?");
            string action = Console.ReadLine()?.ToLower() ?? string.Empty;  // Default to empty string if null

            if (action == "add")
            {
                AddBook();
            }
            else if (action == "remove")
            {
                RemoveBook();
            }
            else if (action == "search")
            {
                SearchBook();
            }
            else if (action == "borrow")
            {
                BorrowBook();
            }
            else if (action == "return")
            {
                ReturnBook();
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'borrow', 'return', or 'exit'.");
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("Enter the title of the book to add:");
        string book = Console.ReadLine()?.Trim() ?? string.Empty;  // Default to empty string if null

        if (string.IsNullOrEmpty(book))
        {
            Console.WriteLine("Book title cannot be empty.");
        }
        else
        {
            books.Add(book);
            Console.WriteLine($"Book '{book}' added successfully.");
        }
    }

    static void RemoveBook()
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string book = Console.ReadLine()?.Trim() ?? string.Empty;  // Default to empty string if null

        if (string.IsNullOrEmpty(book) || !books.Contains(book))
        {
            Console.WriteLine("Book not found.");
        }
        else
        {
            books.Remove(book);
            Console.WriteLine($"Book '{book}' removed successfully.");
        }
    }

    static void SearchBook()
    {
        Console.WriteLine("Enter the title of the book to search for:");
        string book = Console.ReadLine()?.Trim() ?? string.Empty;  // Default to empty string if null

        if (string.IsNullOrEmpty(book) || !books.Contains(book))
        {
            Console.WriteLine("The book is not available.");
        }
        else
        {
            Console.WriteLine($"The book '{book}' is available.");
        }
    }

    static void BorrowBook()
    {
        if (borrowedBooks.Count >= maxBooksToBorrow)
        {
            Console.WriteLine("You can only borrow up to 3 books at a time.");
            return;
        }

        Console.WriteLine("Enter the title of the book to borrow:");
        string book = Console.ReadLine()?.Trim() ?? string.Empty;  // Default to empty string if null

        if (string.IsNullOrEmpty(book) || !books.Contains(book))
        {
            Console.WriteLine("The book is not available.");
        }
        else
        {
            borrowedBooks.Add(book);
            books.Remove(book);
            Console.WriteLine($"You have borrowed '{book}'.");
        }
    }

    static void ReturnBook()
    {
        Console.WriteLine("Enter the title of the book to return:");
        string book = Console.ReadLine()?.Trim() ?? string.Empty;  // Default to empty string if null

        if (string.IsNullOrEmpty(book) || !borrowedBooks.Contains(book))
        {
            Console.WriteLine("You haven't borrowed that book.");
        }
        else
        {
            borrowedBooks.Remove(book);
            books.Add(book);
            Console.WriteLine($"You have returned '{book}'.");
        }
    }
}
