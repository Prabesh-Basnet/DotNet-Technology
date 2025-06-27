using System;

class Shape
{
    public int Length, Breadth;

    public Shape()
    {
        Length = 0;
        Breadth = 0;
    }

    public Shape(int l, int b)
    {
        Length = l;
        Breadth = b;
    }
}

class Rectangle : Shape
{
    public Rectangle(int l, int b) : base(l, b) { }

    public int Area() => Length * Breadth;
}

class Qno10
{
    //static void Main()
    //{
    //    Rectangle rect = new Rectangle(10, 5);
    //    Console.WriteLine("Area: " + rect.Area());
    //}
}
