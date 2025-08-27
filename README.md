# MyAwesomeLibrary

A comprehensive .NET library providing utility functions for string manipulation and mathematical operations.

## Features

### String Utilities
- **ReverseString**: Reverse the characters in a string
- **IsPalindrome**: Check if a string is a palindrome
- **ToTitleCase**: Convert strings to title case
- **WordCount**: Count the number of words in a string

### Math Utilities
- **IsPrime**: Check if a number is prime
- **Factorial**: Calculate factorial of a number
- **Fibonacci**: Generate Fibonacci sequence
- **GreatestCommonDivisor**: Find GCD of two numbers

## Installation

Install the package via NuGet Package Manager:

```bash
dotnet add package MyAwesomeLibrary
```

Or via Package Manager Console:

```powershell
Install-Package MyAwesomeLibrary
```

## Usage

### String Utilities Example

```csharp
using MyAwesomeLibrary;

// Reverse a string
string reversed = StringUtilities.ReverseString("hello");
// Output: "olleh"

// Check if palindrome
bool isPalindrome = StringUtilities.IsPalindrome("racecar");
// Output: true

// Convert to title case
string titleCase = StringUtilities.ToTitleCase("hello world");
// Output: "Hello World"

// Count words
int wordCount = StringUtilities.WordCount("Hello beautiful world");
// Output: 3
```

### Math Utilities Example

```csharp
using MyAwesomeLibrary;

// Check if prime
bool isPrime = MathUtilities.IsPrime(17);
// Output: true

// Calculate factorial
long factorial = MathUtilities.Factorial(5);
// Output: 120

// Generate Fibonacci sequence
var fibonacci = MathUtilities.Fibonacci(8).ToArray();
// Output: [0, 1, 1, 2, 3, 5, 8, 13]

// Find GCD
int gcd = MathUtilities.GreatestCommonDivisor(48, 18);
// Output: 6
```

## Building the Project

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run tests
dotnet test

# Create NuGet package
dotnet pack --configuration Release
```

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests for new functionality
5. Ensure all tests pass
6. Create a pull request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Changelog

### Version 1.0.0
- Initial release
- String utilities: ReverseString, IsPalindrome, ToTitleCase, WordCount
- Math utilities: IsPrime, Factorial, Fibonacci, GreatestCommonDivisor
- Comprehensive unit tests
- Full XML documentation