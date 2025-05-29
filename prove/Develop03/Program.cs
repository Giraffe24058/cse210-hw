using System;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 1, 2, 3), "..."),
            new Scripture(new Reference("Proverbs", 1, 2, 3), "..."),
            new Scripture(new Reference("Proverbs", 1, 2, 3), "..."),
            new Scripture(new Reference("Proverbs", 1, 2, 3), "..."),
            new Scripture(new Reference("Proverbs", 1, 2, 3), "..."),
        };


        Random rand = new Random();
        Scripture scripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide more words, type 'new' for a new scripture, or 'quit' to exit.");

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
                break;


            else if (input.ToLower() == "new")
            {
                scripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];
            }
            else if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
            }

        }
    }
}
