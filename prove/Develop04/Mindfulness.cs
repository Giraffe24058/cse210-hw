using System;

abstract class Mindfulness
{
    protected string _className;
    protected string _classDescription;
    protected int _time;

    public void Start()
    {
        // dsplay welcome message and set duration
    }

    public void End()
    {
        // dsplay completion message
    }

    protected void Spinner(int seconds)
    {
        // show spinner
    }

    protected void Countdown(int seconds)
    {
        // countdown
    }

    public abstract void RunActivity();
}

class Breathing : Mindfulness
{
    public Breathing()
    {
        // Set _className and _classDescription
    }

    public override void RunActivity()
    {
        Start();
        // Alternate "Breathe in..." and "Breathe out..." with countdowns
        End();
    }
}

class Reflection : Mindfulness
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection()
    {
        // Initialize _className, _classDescription, _prompts, and _questions
    }

    public override void RunActivity()
    {
        Start();
        // Show a random prompt
        End();
    }
}

class Listing : Mindfulness
{
    private List<string> _prompts;

    public Listing()
    {
        // Initialize _className, _classDescription, and _prompts
    }

    public override void RunActivity()
    {
        Start();
        // Show a random prompt, countdown to start, collect user input until time runs out
        // display number of items listed
        End();
    }
}

// Main program
class Program
{
    static void Main()
    {
        while (true)
        {
            // display menu, get user choice, create appropriate activity object
            // call RunActivity() , return to menu or exit
        }
    }
}
