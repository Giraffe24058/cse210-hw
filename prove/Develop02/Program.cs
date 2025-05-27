using System;


// For this assignment, I added creativity by adding a trivia or personality
// question, of sorts, to make it fun and more enjoyable. This way I can be 
// thoughtful and serious in a journal entry as well as having a fun way to 
// enjoy the journal and show my preferences/personality.
class Program
{

    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Prompt promptGetter = new Prompt();


        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("\nPlease select a choice from the following: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file"); Console.WriteLine("5. Quit");
            Console.Write("What's your choice? (1-5) ");


            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                case "1.":
                    string prompt = promptGetter.Get_Prompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string reply = Console.ReadLine();

                    Entry entry = new Entry(prompt, reply);
                    myJournal.AddNewEntry(entry);
                    break;

                case "2":
                case "2.":
                    myJournal.ShowAllEntries();
                    break;

                case "3":
                case "3.":
                    Console.Write("Enter a filename to save to: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveJournal(saveFile);
                    break;

                case "4":
                case "4.":
                    Console.Write("Enter a filename to load from: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadJournal(loadFile);
                    break;

                case "5":
                case "5.":
                    keepGoing = false;
                    Console.WriteLine("Thanks for journaling. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Sorry, I didn't understand that. Pick 1–5.");
                    break;
            }
        }
    }
}


