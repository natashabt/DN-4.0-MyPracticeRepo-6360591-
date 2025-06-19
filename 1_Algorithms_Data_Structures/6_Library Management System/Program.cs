using System;
using System.Linq;

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int id, string title, string author)
    {
        BookId = id;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"BookId: {BookId}, Title: {Title}, Author: {Author}";
    }
}

class Program
{
    // Linear Search by Title
    static Book LinearSearch(Book[] books, string title)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                return book;
        }
        return null;
    }

    // Binary Search by Title (list must be sorted)
    static Book BinarySearch(Book[] books, string title)
    {
        int low = 0;
        int high = books.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int cmp = string.Compare(books[mid].Title, title, true);

            if (cmp == 0)
                return books[mid];
            else if (cmp < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    // Display all books
    static void DisplayBooks(Book[] books)
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    static void Main(string[] args)
    {
        Book[] books = {
            new Book(101, "C Programming", "Dennis Ritchie"),
            new Book(102, "Java Fundamentals", "James Gosling"),
            new Book(103, "Python Basics", "Guido van Rossum"),
            new Book(104, "Data Structures", "Robert Lafore"),
            new Book(105, "Computer Networks", "Andrew Tanenbaum")
        };

        Console.WriteLine("Books in Library:");
        DisplayBooks(books);

        Console.WriteLine("\nLinear Search for 'Python Basics':");
        var result1 = LinearSearch(books, "Python Basics");
        Console.WriteLine(result1 != null ? result1.ToString() : "Book not found");

        // Sort books by title for binary search
        var sortedBooks = books.OrderBy(b => b.Title.ToLower()).ToArray();

        Console.WriteLine("\nBinary Search for 'Python Basics':");
        var result2 = BinarySearch(sortedBooks, "Python Basics");
        Console.WriteLine(result2 != null ? result2.ToString() : "Book not found");
    }
}
