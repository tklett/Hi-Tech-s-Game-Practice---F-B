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
    /// Prints the counting list to the console
    /// </summary>
    public static void PrintCount()
    {
        List<int> numbers = CountToHundred();
        Console.WriteLine("Counting from 1 to 100:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
