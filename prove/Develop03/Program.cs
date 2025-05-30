using System;

// I exceeded the core requirements of this project by making a list of scriptures.
// Instead of just having one scriptuer, I decided dto put a few scriptures that I 
// liked, and I also put in the doctrinal mastery scripture passages from seminary.
// This allows for more scripture memorization. It selects scriptures at random.
class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 11, 12), "My son, despise not the chastening of the Lord; neither be weary of his correction: For whom the Lord loveth he correcteth; even as a father the son in whom he delighteth."),
            new Scripture(new Reference("Proverbs", 3, 13), "Happy is the man that findeth wisdom, and the man that getteth understanding."),
            new Scripture(new Reference("Proverbs", 28, 13), "He that covereth his sins shall not prosper: but whoso confesseth and forsaketh them shall have mercy."),
            new Scripture(new Reference("Alma", 7, 11, 13), "And he shall go forth, suffering pains and afflictions and temptations of every kind."),
            new Scripture(new Reference("Alma", 34, 9, 10), "There must be an atonement made, ... an infinite and eternal sacrifice."),
            new Scripture(new Reference("Alma", 39, 9), "Go no more after the lusts of your eyes."),
            new Scripture(new Reference("Alma", 41, 10), "Wickedness never was happiness."),
            new Scripture(new Reference("Helaman", 5, 12), "It is upon the rock of our Redeemer … that ye must build your foundation."),
            new Scripture(new Reference("3 Nephi", 11, 10, 11), "I have suffered the will of the Father in all things from the beginning."),
            new Scripture(new Reference("3 Nephi", 12, 48), "Be perfect even as I, or your Father who is in heaven is perfect."),
            new Scripture(new Reference("3 Nephi", 27, 20), "Come unto me and be baptized ... that ye may be sanctified by the reception of the Holy Ghost."),
            new Scripture(new Reference("Ether", 12, 6), "Ye receive no witness until after the trial of your faith."),
            new Scripture(new Reference("Ether", 12, 27), "If men come unto me ... then will I make weak things become strong unto them."),
            new Scripture(new Reference("Moroni", 7, 45, 48), "Charity is the pure love of Christ."),
            new Scripture(new Reference("Moroni", 10, 4, 5), "Ask with a sincere heart, with real intent, having faith in Christ ... [and] by the power of the Holy Ghost ye may know the truth of all things.")

        };


        Random rand = new Random();
        Scripture scripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! Type 'new' for a new scripture or 'quit' to exit.");
            }
            else
            {
                Console.WriteLine("\nPress Enter to hide more words, type 'new' for a new scripture or 'quit' to exit.");
            }
            ;

            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            else if (input == "new")
            {
                scripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];
            }
            else if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(2);
            }

        }
    }
}
