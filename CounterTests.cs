using Xunit;
using System.Collections.Generic;
using System.Linq;

public class CounterTests
{
    [Fact]
    public void CountToHundred_ReturnsListOf100Numbers()
    {
        // Arrange & Act
        List<int> result = Counter.CountToHundred();

        // Assert
        Assert.Equal(100, result.Count);
    }

    [Fact]
    public void CountToHundred_StartsAtOne()
    {
        // Arrange & Act
        List<int> result = Counter.CountToHundred();

        // Assert
        Assert.Equal(1, result.First());
    }

    [Fact]
    public void CountToHundred_EndsAtHundred()
    {
        // Arrange & Act
        List<int> result = Counter.CountToHundred();

        // Assert
        Assert.Equal(100, result.Last());
    }

    [Fact]
    public void CountToHundred_ContainsSequentialNumbers()
    {
        // Arrange & Act
        List<int> result = Counter.CountToHundred();

        // Assert
        for (int i = 0; i < result.Count; i++)
        {
            Assert.Equal(i + 1, result[i]);
        }
    }

    [Fact]
    public void CountWithFizzBuzz_ReturnsListOf100Items()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizzBuzz();

        // Assert
        Assert.Equal(100, result.Count);
    }

    [Fact]
    public void CountWithFizzBuzz_ReplacesMultiplesOfThreeWithFizz()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizzBuzz();

        // Assert
        Assert.Equal("Fizz", result[2]);   // 3
        Assert.Equal("Fizz", result[5]);   // 6
        Assert.Equal("Fizz", result[8]);   // 9
        Assert.Equal("Fizz", result[98]);  // 99
    }

    [Fact]
    public void CountWithFizzBuzz_ReplacesMultiplesOfFiveWithBuzz()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizzBuzz();

        // Assert
        Assert.Equal("Buzz", result[4]);   // 5
        Assert.Equal("Buzz", result[9]);   // 10
        Assert.Equal("Buzz", result[19]);  // 20
        Assert.Equal("Buzz", result[94]);  // 95
        Assert.Equal("Buzz", result[99]);  // 100
    }

    [Fact]
    public void CountWithFizzBuzz_ReplacesMultiplesOfBothThreeAndFiveWithFizzBuzz()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizzBuzz();

        // Assert
        Assert.Equal("FizzBuzz", result[14]); // 15
        Assert.Equal("FizzBuzz", result[29]); // 30
        Assert.Equal("FizzBuzz", result[44]); // 45
        Assert.Equal("FizzBuzz", result[89]); // 90
    }

    [Fact]
    public void CountWithFizzBuzz_LeavesNonMultiplesAsNumbers()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizzBuzz();

        // Assert
        Assert.Equal("1", result[0]);
        Assert.Equal("2", result[1]);
        Assert.Equal("4", result[3]);
        Assert.Equal("7", result[6]);
        Assert.Equal("98", result[97]);
    }
}
