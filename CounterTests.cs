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
    public void CountWithFizz_ReturnsListOf100Items()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizz();

        // Assert
        Assert.Equal(100, result.Count);
    }

    [Fact]
    public void CountWithFizz_ReplacesMultiplesOfThreeWithFizz()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizz();

        // Assert
        Assert.Equal("Fizz", result[2]);   // 3
        Assert.Equal("Fizz", result[5]);   // 6
        Assert.Equal("Fizz", result[98]);  // 99
    }

    [Fact]
    public void CountWithFizz_LeavesNonMultiplesAsNumbers()
    {
        // Arrange & Act
        List<string> result = Counter.CountWithFizz();

        // Assert
        Assert.Equal("1", result[0]);
        Assert.Equal("2", result[1]);
        Assert.Equal("4", result[3]);
        Assert.Equal("100", result[99]);
    }
}
