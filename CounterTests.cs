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
}