using System;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public Book(string Title)
    {
        this.Title = Title;
        Author = "Unknown";
        YearPublished = 0;
    }

    public Book(string Title, string Author)
    {
        this.Title = Title;
        this.Author = Author;
        YearPublished = 0;
    }
    public Book(string Title, string Author, int YearPublished)
    {
        this.Title = Title;
        this.Author = Author;
        this.YearPublished = YearPublished;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}");
    }

}
public class program
{
    public static void Main()
    {
        Book book1 = new Book("The Great Gatsby");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("1984", "George Orwell", 1949);
        book1.DisplayDetails();
        book2.DisplayDetails();
        book3.DisplayDetails();
    }
}