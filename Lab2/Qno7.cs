using System;

class Number
{
    public int value;
    public Number(int x) => value = x;

    public static Number operator -(Number n) => new Number(-n.value);

    public void Display() => Console.WriteLine(value);
}

class Qno7
{
    //static void Main()
    //{
    //    Number n = new Number(10);
    //    Number neg = -n;
    //    neg.Display(); // Output: -10
    //}
}
