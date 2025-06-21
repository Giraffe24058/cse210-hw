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
