// Abstraction example (using interface)
public interface IShape
{
    double Area(); // Abstract method
}

public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double Area()
    {
        return Length * Width;
    }
}
