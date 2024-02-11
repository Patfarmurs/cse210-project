using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 5.0);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green", 4.0, 6.0);
        shapes.Add(rectangle);

        Circle circle = new Circle("Blue", 3.0);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }

        // Testing a single Square instance
        Square singleSquare = new Square("Yellow", 4.0);
        Console.WriteLine($"Color: {singleSquare.Color}");
        Console.WriteLine($"Area: {singleSquare.GetArea()}");
    }
}
