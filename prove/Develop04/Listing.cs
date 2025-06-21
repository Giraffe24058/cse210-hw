
class Listing : Mindfulness
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing()
    {
        _className = "Listing";
        _classDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void RunActivity()
    {
        Start();
        Random rand = new Random();

        List<string> shuffledPrompts = new List<string>(_prompts);
        for (int i = shuffledPrompts.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            string temp = shuffledPrompts[i];
            shuffledPrompts[i] = shuffledPrompts[j];
            shuffledPrompts[j] = temp;
        }

        string prompt = shuffledPrompts[0];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You may begin listing in:");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        End();
    }
}
