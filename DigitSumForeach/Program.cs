using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer");
        var input = Console.ReadLine();

        int sum = 0;

        foreach (var ch in input)
        {
            int digit = int.Parse(ch.ToString());
            sum = sum + digit;
        }

        Console.WriteLine("Sum: " + sum);
    }
}