# Password Generator

This is a simple password generator program written in C#.

## Usage

1. Clone the repository to your local machine.
2. Compile the program using a C# compiler.
3. Run the compiled executable.
4. Follow the prompts to generate a password.

## Features

- Generates random passwords of variable length.
- Option to include uppercase letters, numbers, and symbols in the password.

## How it works

The program uses a `PasswordGenerator` class to generate passwords based on specified criteria. You can customize the length and character sets used in the generated password.

## Example

```csharp
PasswordGenerator passwordGenerator = new PasswordGenerator();

// Generate a password with length 12, including uppercase letters, numbers, and symbols
string password = passwordGenerator.GeneratePassword(12, includeCaps: true, includeNumbers: true, includeSymbols: true);

Console.WriteLine($"Generated password: {password}");
