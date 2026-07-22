using System.Collections.Generic;

public static class Counter
{
    public static List<int> CountToHundred()
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            numbers.Add(i);
        }

        return numbers;
    }

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
}
