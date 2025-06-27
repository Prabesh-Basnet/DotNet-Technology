using System;

class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal speaks");
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Dog barks");
}

class Qno5
{
    //static void Main()
    //{
    //    Animal a = new Dog();
    //    a.Speak();
    //}
}
