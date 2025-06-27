using System;
using System.Collections.Generic;
using System.IO;

class SaveGoals
{
    private List<Goal> _goals;

    public SaveGoals()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

        public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Save());
            }
        }
    }

    public void SaveAllGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Save());
            }
        }
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>();

        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    bool complete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, desc, points);
                    if (complete) goal.RecordEvent();  // Mark as complete
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);

                    _goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "ChecklistGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    int current = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);
                    for (int i = 0; i < current; i++) goal.RecordEvent();  // Simulate progress
                    _goals.Add(goal);
                }
            }
        }
    }


    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayStatus();
        }
    }

        public List<Goal> GetGoals()
    {
        return _goals;
    }

}
