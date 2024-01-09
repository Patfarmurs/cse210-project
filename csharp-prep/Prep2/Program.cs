using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter student's score: ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);

        char grade;

        if (score>= 90)
        {
            grade = 'A';
        }

        else if (score >= 80)
        {
            grade = 'B';
        }

         else if (score >= 70)
        {
            grade = 'C';
        }

         else if (score >= 60)
        {
            grade = 'D';
        }

        else
        {
            grade = 'F';
        }

        Console.WriteLine($"The student's grade is: {grade}");

        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Good luck next time!");
        } 
    }
}