public class Program
{
    public static void Main(String [] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        while (true)
        {
            Scripture scripture = scriptureLibrary.GetRandomScripture();

            Console.Clear();
            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetVisibleText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }

            while (scripture.HideRandomWord())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetReference());
                Console.WriteLine(scripture.GetVisibleText());

                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
                input = Console.ReadLine().ToLower();
                if (input == "quit")
                {
                    return;
                }
            }
        }
    }
}
