using System;

class Qno12
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of subjects: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] marks = new int[n];
        int sum = 0, min, max;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter mark for subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
            sum += marks[i];
        }

        min = max = marks[0];

        foreach (int mark in marks)
        {
            if (mark < min)
                min = mark;
            if (mark > max)
                max = mark;
        }

        double average = (double)sum / n;

        Console.WriteLine($"Minimum Marks: {min}");
        Console.WriteLine($"Maximum Marks: {max}");
        Console.WriteLine($"Average Marks: {average:F2}");
    }
}