using System.Globalization;
using System.Text;

namespace MyAwesomeLibrary;

/// <summary>
/// Provides utility methods for string manipulation and analysis.
/// </summary>
public static class StringUtilities
{
    /// <summary>
    /// Reverses the characters in a string.
    /// </summary>
    /// <param name="input">The string to reverse.</param>
    /// <returns>A new string with characters in reverse order.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static string ReverseString(string input)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        if (string.IsNullOrEmpty(input))
            return input;

        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    /// <summary>
    /// Determines whether a string is a palindrome (reads the same forwards and backwards).
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the string is a palindrome; otherwise, false.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static bool IsPalindrome(string input)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        if (string.IsNullOrEmpty(input))
            return true;

        string normalized = input.ToLowerInvariant().Replace(" ", "");
        return normalized == ReverseString(normalized);
    }

    /// <summary>
    /// Converts a string to title case (first letter of each word capitalized).
    /// </summary>
    /// <param name="input">The string to convert.</param>
    /// <returns>A new string in title case.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static string ToTitleCase(string input)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        if (string.IsNullOrEmpty(input))
            return input;

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.ToLowerInvariant());
    }

    /// <summary>
    /// Counts the number of words in a string.
    /// </summary>
    /// <param name="input">The string to analyze.</param>
    /// <returns>The number of words in the string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static int WordCount(string input)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        if (string.IsNullOrWhiteSpace(input))
            return 0;

        return input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}