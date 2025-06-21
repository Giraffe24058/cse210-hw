
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
