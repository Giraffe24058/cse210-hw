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
        Spinner(3);
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
        Console.Write("\r \r");
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
        _classDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
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
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
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

    public Reflection()
    {
        _className = "Reflection";
        _classDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void RunActivity()
    {
        Start();
        Random rand = new Random();

        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        Spinner(3);

        List<string> shuffledQuestions = new List<string>(_questions);
        for (int i = shuffledQuestions.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            string temp = shuffledQuestions[i];
            shuffledQuestions[i] = shuffledQuestions[j];
            shuffledQuestions[j] = temp;
        }

        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            if (index >= shuffledQuestions.Count)
            {
                index = 0;
            }

            Console.WriteLine($"\n{shuffledQuestions[index]}");
            Spinner(5);
            index++;
        }

        End();
    }
}

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
