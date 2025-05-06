using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = int.MaxValue;
        
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber !=0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } 

        // Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum, or largest, number in the list.
        int max = numbers[0];
        int smallestPositive = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            // Find the smallest positive number
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}