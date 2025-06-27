using System;

class test
{
    // Auto property
    public int ID { get; set; }

    // Read-only property
    private string name = "Prabesh";
    public string Name => name;

    // Write-only property
    private string secret;
    public string Secret { set { secret = value; } }
}

class Qno9
{
    //static void Main()
    //{
    //    test d = new test();
    //    d.ID = 10;
    //    d.Secret = "top";
    //    Console.WriteLine($"ID: {d.ID}, Name: {d.Name}");
    //}
}
