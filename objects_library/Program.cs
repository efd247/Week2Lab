using System;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Alice");
        Person person2 = new Person("Bob");

        person1.Age = 21;

        Console.WriteLine(person1.Name + " - Age: " + person1.Age);
        Console.WriteLine(person2.Name + " - Age: " + person2.Age);

        Console.WriteLine(person1.CompareTo(person2));
        Console.WriteLine();

// A2 - Test Book class
Book book1 = new Book("The Hobbit");
Book book2 = new Book(new Person("George Orwell"), "1984");

Console.WriteLine(book1.Title + " - " + book1.Author.Name);
Console.WriteLine(book2.Title + " - " + book2.Author.Name);

Console.WriteLine(book1.CompareTo(book2));
    }
}