using System;

class Book : IComparable
{
    private string title;
    private Person author;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public Person Author
    {
        get { return author; }
        set { author = value; }
    }

    public Book(string title)
    {
        this.title = title;
        author = new Person("Unknown");
    }

    public Book(Person author, string title)
    {
        this.author = author;
        this.title = title;
    }

    public int CompareTo(object? obj)
    {
        Book other = (Book)obj!;
        return Title.CompareTo(other.Title);
    }
}