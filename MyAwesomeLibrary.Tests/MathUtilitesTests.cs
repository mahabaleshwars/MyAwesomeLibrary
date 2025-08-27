using Xunit;

namespace MyAwesomeLibrary.Tests;

public class MathUtilitiesTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(25, false)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-5, false)]
    public void IsPrime_ShouldReturnCorrectResult(int number, bool expected)
    {
        // Act
        bool result = MathUtilities.IsPrime(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(3, 6)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void Factorial_ShouldReturnCorrectResult(int number, long expected)
    {
        // Act
        long result = MathUtilities.Factorial(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Factorial_WithNegativeNumber_ShouldThrowArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => MathUtilities.Factorial(-1));
    }

    [Theory]
    [InlineData(0, new long[] { })]
    [InlineData(1, new long[] { 0 })]
    [InlineData(2, new long[] { 0, 1 })]
    [InlineData(5, new long[] { 0, 1, 1, 2, 3 })]
    [InlineData(8, new long[] { 0, 1, 1, 2, 3, 5, 8, 13 })]
    public void Fibonacci_ShouldReturnCorrectSequence(int count, long[] expected)
    {
        // Act
        var result = MathUtilities.Fibonacci(count).ToArray();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fibonacci_WithNegativeCount_ShouldThrowArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => MathUtilities.Fibonacci(-1).ToList());
    }

    [Theory]
    [InlineData(12, 18, 6)]
    [InlineData(48, 18, 6)]
    [InlineData(7, 5, 1)]
    [InlineData(0, 5, 5)]
    [InlineData(-12, 18, 6)]
    public void GreatestCommonDivisor_ShouldReturnCorrectResult(int a, int b, int expected)
    {
        // Act
        int result = MathUtilities.GreatestCommonDivisor(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}