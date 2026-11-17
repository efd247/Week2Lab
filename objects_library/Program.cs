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
    }
}