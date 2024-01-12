using System;

class Program
{
    static void Main()
    {
        // Generate a random number from 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int userGuess = 0;

        // Add a loop that keeps looping as long as the guess does not match the magic number
        while (userGuess != magicNumber)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            // Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
