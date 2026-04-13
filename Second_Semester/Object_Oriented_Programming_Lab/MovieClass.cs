using System;
public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int ReleaseYear { get; set; }

    public Movie()
    {
        Title = "Unknown";
        Director = "Unknown";
        ReleaseYear = 0;

    }
    public Movie(string title)
    {
        Title = title;
        Director = "Unknown";
        ReleaseYear = 0;
    }
    public Movie(string title, string director)
    {
        Title = title;
        Director = director;
        ReleaseYear = 0;
    }
    public Movie(string title, string director, int releaseYear)
    {
        Title = title;
        Director = director;
        ReleaseYear = releaseYear;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Director: {Director}, Release Year: {ReleaseYear}");

    }
}

//public class program
//{
//    public static void Main()
//    {
//        Movie M1 = new Movie();
//        M1.Display();
//        Movie M2 = new Movie("Love");
//        M2.Display();
//        Movie M3 = new Movie("Love", "John");
//        M3.Display();
//        Movie M4 = new Movie("Love", "John", 2020);
//        M4.Display();



    }
}

