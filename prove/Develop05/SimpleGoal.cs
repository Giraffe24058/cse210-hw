using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override bool IsComplete()
    {
        return _completion;
    }

    public override void RecordEvent()
    {
        _completion = true;
        Console.WriteLine($"Completed: {_name} (+{_points} points)");
    }

    public override string Save()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_completion}";
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{_name} - {_description} - Points: {_points} - Completed: {_completion}");
    }
}
