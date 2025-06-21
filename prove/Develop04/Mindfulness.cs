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
