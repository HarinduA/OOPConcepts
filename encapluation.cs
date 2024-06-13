// Encapsulation example
public class Person
{
    private string name;
    private int age;

    // Properties to access encapsulated fields
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

    // Method to display information
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
