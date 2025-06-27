using System;

class Program
{
    static void Main(string[] args)
    {
        SaveGoals saveGoals = new SaveGoals();
        saveGoals.LoadGoals();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest Menu ---");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record progress on a goal");
            Console.WriteLine("3. View goals");
            Console.WriteLine("4. Save and exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(saveGoals);
                    break;
                case "2":
                    RecordGoalProgress(saveGoals);
                    break;
                case "3":
                    saveGoals.DisplayGoals();
                    break;
                case "4":
                    saveGoals.SaveToFile();
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(SaveGoals saveGoals)
    {
        Console.WriteLine("\nWhat type of goal?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choose a type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("How difficult is it?");
        Console.WriteLine("1. Easy (50 points)");
        Console.WriteLine("2. Medium (100 points)");
        Console.WriteLine("3. Hard (200 points)");
        Console.Write("Choose difficulty: ");
        string difficulty = Console.ReadLine();

        int points = difficulty switch
        {
            "1" => 50,
            "2" => 100,
            "3" => 200,
            _ => 50
        };

        Goal newGoal = null;

        if (type == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (type == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (type == "3")
        {
            Console.Write("How many times to complete this goal? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points when completed: ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (newGoal != null)
        {
            saveGoals.AddGoal(newGoal);
            Console.WriteLine("Goal added!");
        }
    }

    static void RecordGoalProgress(SaveGoals saveGoals)
    {
        Console.WriteLine("\nWhich goal did you complete?");
        List<Goal> goals = saveGoals.GetGoals();

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]._name}");
        }

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goals.Count)
        {
            goals[index - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}
