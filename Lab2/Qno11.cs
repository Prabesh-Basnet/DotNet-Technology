using System;

class GenericClass<T>
{
    public T value;
    public GenericClass(T val) => value = val;

    public void Display() => Console.WriteLine($"Value: {value}");
}

class Qno11
{
    //static void Main()
    //{
    //    GenericClass<int> g1 = new GenericClass<int>(10);
    //    GenericClass<string> g2 = new GenericClass<string>("Hello");

    //    g1.Display();
    //    g2.Display();
    //}
}
