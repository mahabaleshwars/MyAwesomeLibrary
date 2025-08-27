namespace MyAwesomeLibrary;

/// <summary>
/// Provides utility methods for mathematical operations.
/// </summary>
public static class MathUtilities
{
    /// <summary>
    /// Determines whether a number is prime.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True if the number is prime; otherwise, false.</returns>
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number == 2)
            return true;

        if (number % 2 == 0)
            return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    /// <summary>
    /// Calculates the factorial of a number.
    /// </summary>
    /// <param name="number">The number to calculate factorial for.</param>
    /// <returns>The factorial of the number.</returns>
    /// <exception cref="ArgumentException">Thrown when number is negative.</exception>
    public static long Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers.", nameof(number));

        if (number == 0 || number == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    /// <summary>
    /// Generates a Fibonacci sequence up to the specified count.
    /// </summary>
    /// <param name="count">The number of Fibonacci numbers to generate.</param>
    /// <returns>An enumerable of Fibonacci numbers.</returns>
    /// <exception cref="ArgumentException">Thrown when count is negative.</exception>
    public static IEnumerable<long> Fibonacci(int count)
    {
        if (count < 0)
            throw new ArgumentException("Count cannot be negative.", nameof(count));

        if (count == 0)
            yield break;

        yield return 0;

        if (count == 1)
            yield break;

        yield return 1;

        long prev = 0;
        long curr = 1;

        for (int i = 2; i < count; i++)
        {
            long next = prev + curr;
            yield return next;
            prev = curr;
            curr = next;
        }
    }

    /// <summary>
    /// Calculates the greatest common divisor of two numbers.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The greatest common divisor.</returns>
    public static int GreatestCommonDivisor(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}