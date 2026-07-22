using System;
using System.Collections.Generic;

public class Counter
{
    /// <summary>
    /// Generates a list of numbers from 1 to 100
    /// </summary>
    /// <returns>A list containing integers from 1 to 100</returns>
    public static List<int> CountToHundred()
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }

    /// <summary>
    /// Generates fizz-only output from 1 to 100.
    /// Multiples of 3 are replaced with "Fizz".
    /// </summary>
    public static List<string> CountWithFizz()
    {
        List<string> output = new List<string>();
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                output.Add("Fizz");
            }
            else
            {
                output.Add(i.ToString());
            }
        }

        return output;
    }

    /// <summary>
    /// Generates FizzBuzz output from 1 to 100.
    /// Multiples of 15 are replaced with "FizzBuzz", multiples of 3 with "Fizz", multiples of 5 with "Buzz".
    /// </summary>
    public static List<string> CountWithFizzBuzz()
    {
        List<string> items = new List<string>();

        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0)
            {
                items.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                items.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                items.Add("Buzz");
            }
            else
            {
                items.Add(i.ToString());
            }
        }

        return items;
    }

    /// <summary>
    /// Prints the fizz-only counting list to the console
    /// </summary>
    public static void PrintCount()
    {
        List<string> output = CountWithFizz();
        Console.WriteLine("Counting from 1 to 100 (Fizz-only):");
        Console.WriteLine(string.Join(", ", output));
    }
}
