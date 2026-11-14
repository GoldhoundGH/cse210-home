using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list1 = new List<Shape>();

        Square shape1 = new Square("red",4);
        list1.Add(shape1);

        Rectangle shape2 = new Rectangle("blue",4.5,2);
        list1.Add(shape2);

        Circle shape3 = new Circle("green",3);
        list1.Add(shape3);

        foreach (Shape shape in list1)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}