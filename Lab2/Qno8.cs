using System;

class Point
{
    public int x;
    public Point(int val) => x = val;

    public static Point operator +(Point a, Point b) => new Point(a.x + b.x);

    public void Display() => Console.WriteLine(x);
}

class Qno8
{
    //static void Main()
    //{
    //    Point p1 = new Point(8);
    //    Point p2 = new Point(10);
    //    Point p3 = p1 + p2;
    //    p3.Display(); // Output: 18
    //}
}
