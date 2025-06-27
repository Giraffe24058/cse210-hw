using System;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completion;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completion = false;
    }

    public string Name => _name;


    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string Save();
    public abstract void DisplayStatus();
}
