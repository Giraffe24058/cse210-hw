// Enhancements to exceed requirements:
// - In the Reflection and Listing activities, all prompts/questions are now used once before repeating.
// - This improves the user experience by avoiding repetition and making each session feel more thoughtful.

using System;
abstract class Mindfulness
{
    protected string _className;
    protected string _classDescription;
    protected int _time;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_className} Activity.");
        Console.WriteLine(_classDescription);
        Console.Write("\nEnter duration in seconds: ");
        _time = int.TryParse(Console.ReadLine(), out int t) ? t : 30;

        Console.WriteLine("\nGet ready...");
        Spinner(5);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        Spinner(2);
        Console.WriteLine($"You have completed the {_className} Activity for {_time} seconds.");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{symbols[i % 4]}");
            Thread.Sleep(175);
        }
        Console.Write("\r \r\n");
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
    }

    public abstract void RunActivity();
}

class Breathing : Mindfulness
{
    public Breathing()
    {
        _className = "Breathing";
        _classDescription = "This activity will help you relax by walking you through breathing in and out slowly.Clear your mind and focus on your breathing.";
    }

    public override void RunActivity()
    {
        Start();
        int cycleTime = 6;
        int cycles = _time / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);
        }

        End();
    }
}

class Reflection : Mindfulness
{
    private static List<string> _allPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> _usedPrompts = new List<string>();

    private static List<string> _allQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private static List<string> _usedQuestions = new List<string>();

    public Reflection()
    {
        _className = "Reflection";
        _classDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience...";
    }

    private string GetNextPrompt()
    {
        if (_usedPrompts.Count == _allPrompts.Count)
            _usedPrompts.Clear();

        var unused = _allPrompts.Except(_usedPrompts).ToList();
        var prompt = unused[new Random().Next(unused.Count)];
        _usedPrompts.Add(prompt);
        return prompt;
    }

    private List<string> GetShuffledQuestions()
    {
        if (_usedQuestions.Count == _allQuestions.Count)
            _usedQuestions.Clear();

        var unused = _allQuestions.Except(_usedQuestions).ToList();
        var shuffled = unused.OrderBy(q => Guid.NewGuid()).ToList();
        _usedQuestions.AddRange(shuffled);
        return shuffled;
    }

    public override void RunActivity()
    {
        Start();
        Console.WriteLine($"\n{GetNextPrompt()}");
        Spinner(3);

        var questions = GetShuffledQuestions();
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            if (index >= questions.Count)
            {
                questions = GetShuffledQuestions();
                index = 0;
            }

            Console.WriteLine($"\n{questions[index]}");
            Spinner(5);
            index++;
        }

        End();
    }
}


class Listing : Mindfulness
{
    private static List<string> _allPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static List<string> _usedPrompts = new List<string>();

    public Listing()
    {
        _className = "Listing";
        _classDescription = "This activity will help you reflect on the good things in your life...";
    }

    private string GetNextPrompt()
    {
        if (_usedPrompts.Count == _allPrompts.Count)
            _usedPrompts.Clear();

        var unused = _allPrompts.Except(_usedPrompts).ToList();
        var prompt = unused[new Random().Next(unused.Count)];
        _usedPrompts.Add(prompt);
        return prompt;
    }

    public override void RunActivity()
    {
        Start();
        string prompt = GetNextPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You may begin listing in:");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        End();
    }
}


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Mindfulness activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing();
                    break;
                case "2":
                    activity = new Reflection();
                    break;
                case "3":
                    activity = new Listing();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
            }

            activity.RunActivity();
            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
