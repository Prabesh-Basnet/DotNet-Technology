using System;

class Employee
{
    public string Name;
    public string Email;
    public double Salary;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}, Salary: {Salary}");
    }
}

class Program
{
    //static void Main()
    //{
    //    Employee emp = new Employee();
    //    emp.Name = "Prabesh";
    //    emp.Email = "prabesh123@gmail.com";
    //    emp.Salary = 25000;
    //    emp.Display();
    //}
}
