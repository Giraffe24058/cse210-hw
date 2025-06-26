using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded: {_name} (+{_points} points)");
    }

    public override string Save()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{_name} ({_description}) Points: {_points} - Completed: {_completion}");
    }
}
