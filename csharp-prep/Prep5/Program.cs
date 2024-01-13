using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favoriteNumber = int.Parse(userInput);
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! The square of your number is: {squaredNumber}");
    }

    static void Main()
    {
        DisplayWelcome();

        string name = PromptUserName();

        int inputNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(inputNumber);
        DisplayResult(name, squaredNumber);
    }
}
