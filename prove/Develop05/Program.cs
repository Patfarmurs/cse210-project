using System;

class Program
{
    static void Main(string [] args)
    {
    List<Goal> goals = new List<Goal>();

    while (true)
    {
        Console.WriteLine("Select a goal:");
        Console.WriteLine("1. Run a marathon");
        Console.WriteLine("2. Read scriptures");
        Console.WriteLine("3. Attend the temple");
        Console.WriteLine("4. Quit");

        string input = Console.ReadLine();

        if (input == "1")
        {
            Goal marathonGoal = new SimpleGoal("Run a marathon", 1000);
            goals.Add(marathonGoal);
        }
        else if (input == "2")
        {
            Goal readScripturesGoal = new EternalGoal("Read scriptures", 100);
            goals.Add(readScripturesGoal);
        }
        else if (input == "3")
        {
            Goal templeVisitsGoal = new ChecklistGoal("Attend the temple", 50, 10);
            goals.Add(templeVisitsGoal);
        }
        else if (input == "4")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }

    // Record events for goals
    foreach (var goal in goals)
    {
        goal.RecordEvent();
    }

    // Display the user's score and goals
    int totalScore = 0;
    foreach (var goal in goals)
    {
        totalScore += goal.Value;
        Console.WriteLine($"Goal: {goal._Name}, Value: {goal.Value}, Completed: {goal.IsCompleted}");
    }

    Console.WriteLine($"Total Score: {totalScore}");
    }
}
