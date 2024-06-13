// Inheritance example
public class Student : Person
{
    public int StudentId { get; set; }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}
