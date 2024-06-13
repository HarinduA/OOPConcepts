// Polymorphism example (method overriding)
public class Teacher : Person
{
    public string Subject { get; set; }

    // Overriding the Display method from the base class
    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
