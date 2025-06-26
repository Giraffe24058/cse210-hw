using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Recorded: {_name} (+{_points} points)");
        if (IsComplete())
        {
            Console.WriteLine($"Bonus: {_name} (+{_bonusPoints} points)");
        }
    }

    public override string Save()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{_name} ({_description}) Points: {_points} - Completed: {_currentCount}/{_targetCount}");
    }
}
