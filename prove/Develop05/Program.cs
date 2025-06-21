using System;

class Program
{
    static void Main(string[] args)
    {
        SaveGoals saveGoals = new SaveGoals();
        saveGoals.LoadGoals();

        // Example usage
        Goal simpleGoal = new SimpleGoal("Run a marathon", "Complete a marathon race", 1000);
        Goal eternalGoal = new EternalGoal("Read scriptures", "Read scriptures daily", 100);
        Goal checklistGoal = new ChecklistGoal("Attend temple", "Attend temple 10 times", 50, 10, 500);

        saveGoals.AddGoal(simpleGoal);
        saveGoals.AddGoal(eternalGoal);
        saveGoals.AddGoal(checklistGoal);

        simpleGoal.RecordEvent();
        eternalGoal.RecordEvent();
        checklistGoal.RecordEvent();

        saveGoals.SaveAllGoals();
        saveGoals.DisplayGoals();
    }
}
