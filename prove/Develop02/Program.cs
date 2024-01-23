using System;


class Program
{
    static void Main(String [] args)
    {
        Journal myJournal = new Journal();

        // Provide a menu for the user to choose options
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Show the user a random prompt and save their response, the prompt, and the date as an Entry
                    string[] prompts = { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
                    Random rnd = new Random();
                    int index = rnd.Next(prompts.Length);
                    string prompt = prompts[index];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response, DateTime.Now);
                    break;
                case "2":
                    // Iterate through all entries in the journal and display them to the screen
                    myJournal.DisplayJournal();
                    break;
                case "3":
                    // Prompt the user for a filename and then save the current journal to that file location
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;
                case "4":
                    // Prompt the user for a filename and then load the journal from that file
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}