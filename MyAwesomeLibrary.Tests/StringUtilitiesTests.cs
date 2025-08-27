using Xunit;

namespace MyAwesomeLibrary.Tests;

public class StringUtilitiesTests
{
    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("world", "dlrow")]
    [InlineData("", "")]
    [InlineData("a", "a")]
    [InlineData("12345", "54321")]
    public void ReverseString_ShouldReturnReversedString(string input, string expected)
    {
        // Act
        string result = StringUtilities.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseString_WithNullInput_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => StringUtilities.ReverseString(null!));
    }

    [Theory]
    [InlineData("racecar", true)]
    [InlineData("hello", false)]
    [InlineData("", true)]
    [InlineData("a", true)]
    [InlineData("A man a plan a canal Panama", true)]
    [InlineData("race a car", false)]
    public void IsPalindrome_ShouldReturnCorrectResult(string input, bool expected)
    {
        // Act
        bool result = StringUtilities.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsPalindrome_WithNullInput_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => StringUtilities.IsPalindrome(null!));
    }

    [Theory]
    [InlineData("hello world", "Hello World")]
    [InlineData("HELLO WORLD", "Hello World")]
    [InlineData("hello", "Hello")]
    [InlineData("", "")]
    [InlineData("a", "A")]
    public void ToTitleCase_ShouldReturnTitleCasedString(string input, string expected)
    {
        // Act
        string result = StringUtilities.ToTitleCase(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ToTitleCase_WithNullInput_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => StringUtilities.ToTitleCase(null!));
    }

    [Theory]
    [InlineData("hello world", 2)]
    [InlineData("one", 1)]
    [InlineData("", 0)]
    [InlineData("   ", 0)]
    [InlineData("hello world test", 3)]
    [InlineData("word1\tword2\nword3", 3)]
    public void WordCount_ShouldReturnCorrectWordCount(string input, int expected)
    {
        // Act
        int result = StringUtilities.WordCount(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordCount_WithNullInput_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => StringUtilities.WordCount(null!));
    }
}