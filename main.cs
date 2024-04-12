using System;

class PasswordGenerator
{
    private const string LowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
    private const string UppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string Numbers = "0123456789";
    private const string Symbols = "!@#$%^&*()-_=+";

    private readonly Random _random;

    public PasswordGenerator()
    {
        _random = new Random();
    }

    public string GeneratePassword(int length, bool includeCaps, bool includeNumbers, bool includeSymbols)
    {
        string characters = LowercaseCharacters;
        if (includeCaps)
            characters += UppercaseCharacters;
        if (includeNumbers)
            characters += Numbers;
        if (includeSymbols)
            characters += Symbols;

        char[] password = new char[length];
        for (int i = 0; i < length; i++)
        {
            password[i] = characters[_random.Next(characters.Length)];
        }

        return new string(password);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Random password generator");

        PasswordGenerator passwordGenerator = new PasswordGenerator();

        Console.Write("Enter the password length: ");
        int length;
        while (!int.TryParse(Console.ReadLine(), out length) || length < 1)
        {
            Console.WriteLine("Please enter a valid password length: ");
        }

        Console.Write("Include capital letters? (y/n): ");
        bool includeCaps = Console.ReadLine().ToLower() == "y";

        Console.Write("Include Numbers? (y/n): ");
        bool includeNumbers = Console.ReadLine().ToLower() == "y";

        Console.Write("Include Symbols? (y/n): ");
        bool includeSymbols = Console.ReadLine().ToLower() == "y";

        string password = passwordGenerator.GeneratePassword(length, includeCaps, includeNumbers, includeSymbols);
        Console.WriteLine($"The generated password is: {password}");
    }
}