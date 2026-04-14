using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    private bool isBorrowed;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void BorrowBook()
    {
        if (!isBorrowed)
        {
            isBorrowed = true;
            Console.WriteLine($"Borrowed: {Title}");
        }
        else
        {
            Console.WriteLine($"Already borrowed: {Title}");
        }
    }

    public void ReturnBook()
    {
        if (isBorrowed)
        {
            isBorrowed = false;
            Console.WriteLine($"Returned: {Title}");
        }
        else
        {
            Console.WriteLine("Book was not borrowed");
        }
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book("Book A", "Author A");

        b1.BorrowBook(); // success
        b1.BorrowBook(); // fail
        b1.ReturnBook(); // success
        b1.ReturnBook(); // fail
    }
}