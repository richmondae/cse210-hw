using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        int userId = -1;
        while (userId != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userFeedback = Console.ReadLine();
            userId = int.Parse(userFeedback);
            if (userId != 0)
            {
                numbers.Add(userId);
            }
        }
        // Find smallest positive number
        int minPositive = int.MaxValue;
        foreach (int number in numbers)
        {
           if (number > 0 && number < minPositive)
           {
               minPositive = number;
           }
        }

        Console.WriteLine($"The smallest positive number is: {minPositive}");

        // Sort the numbers in the list
        numbers.Sort();

        Console.Write("Sorted numbers: ");
        foreach (int number in numbers)
        {
           Console.WriteLine($"{number} ");
        }
        Console.WriteLine();
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}