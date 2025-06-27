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
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Logic to parse and load goals from file
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
