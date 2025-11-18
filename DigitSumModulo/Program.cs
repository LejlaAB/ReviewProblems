using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer");
        var text = Console.ReadLine();
        int number = int.Parse(text);

        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum = sum + digit;
            number = number / 10;
        }

        Console.WriteLine("Sum: " + sum);
    }
}