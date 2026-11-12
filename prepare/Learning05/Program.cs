using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new(2,4,"Red");
        Square square = new(1.2,"Blue");
        Circle circle = new(5.1, "Black");

        List<Shape> shapes = [rectangle, square, circle];

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }



    }
}