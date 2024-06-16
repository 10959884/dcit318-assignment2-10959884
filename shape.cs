using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + circle.GetArea());
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
    }
}
