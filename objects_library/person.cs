using System;

class Person : IComparable
{
    private int age;
    private string name;

    public Person(string name)
    {
        this.name = name;
        age = 18;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int CompareTo(object? obj)
    {
        Person other = (Person)obj!;
        return Name.CompareTo(other.Name);
    }
}