using System;
using System.Collections.Generic;

public class Program
{
    static Schedule schedule = new Schedule();
    static Planner planner = new Planner(schedule);

    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            ShowMenu();
            Console.Write("Enter the number of your choice (or 0 to quit): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddCourse();
                    break;
                case "2":
                    RemoveCourse();
                    break;
                case "3":
                    ViewPlanner();
                    break;
                case "4":
                    ShowCourseOptions();
                    break;
                case "5":
                    PlanCourseForNextSemester();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("Good luck with school!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    public static void ShowMenu()
    {
        Console.WriteLine("Welcome to the student planner program. Here are your options:");
        Console.WriteLine("1. Add a new class to my schedule");
        Console.WriteLine("2. Remove a class from my schedule");
        Console.WriteLine("3. List your classes / show your schedule");
        Console.WriteLine("4. Look at class options");
        Console.WriteLine("5. Plan a class for next semester");
    }

        public static void AddCourse()
    {
        Console.Write("Course name: ");
        string name = Console.ReadLine();

        Console.Write("Course code: ");
        string code = Console.ReadLine();

        Console.Write("Professor name: ");
        string professorName = Console.ReadLine();

        Console.Write("Progress status (Taken / Taking / Planned): ");
        string status = Console.ReadLine();

        Console.Write("Credits: ");
        string creditsInput = Console.ReadLine();
        int credits;

        if (!int.TryParse(creditsInput, out credits))
        {
            Console.WriteLine("Invalid input for credits. Setting credits to 0.");
            credits = 0;
        }

        Course course = new Course(name, code, status, professorName, credits);
        planner.AddCourse(course, status);

        Console.WriteLine("Added Course.");
    }


    public static void RemoveCourse()
    {
        Console.Write("Enter the name of the class to remove: ");
        string courseName = Console.ReadLine();

        planner.RemoveCourse(courseName);
    }

    public static void ViewPlanner()
    {
        planner.PrintPlanner();
    }

    public static void ShowCourseOptions()
    {
        Console.WriteLine("Class options:");
        List<CourseOption> options = new List<CourseOption>()
        {
            new CourseOption("Math 101", "M101", 3, "Professor Lowski"),
            new CourseOption("Science 101", "S101", 4, "Professor Smith"),
            new CourseOption("History 201", "H201", 3, "Professor Jones"),
            new CourseOption("English 101", "E101", 3, "Professor Brown"),
            new CourseOption("Computer Science 101", "CS101", 4, "Professor Davis")
        };

        foreach (var option in options)
        {
            option.PrintInfo();
            Console.WriteLine();
        }
    }

    public static void PlanCourseForNextSemester()
    {
        Console.WriteLine("Planning a class for next semester.");
        ShowCourseOptions();
        Console.Write("Enter course name to plan: ");
        string courseName = Console.ReadLine();

        // In a real program, you’d search course catalog here; for now, a simple check:
        List<CourseOption> options = new List<CourseOption>()
        {
            new CourseOption("Math 101", "M101", 3, "Professor Lowski"),
            new CourseOption("Science 101", "S101", 4, "Professor Smith"),
            new CourseOption("History 201", "H201", 3, "Professor Jones")
        };

        CourseOption selectedOption = options.Find(o => o.ToCourse("Planned").GetName().Equals(courseName, StringComparison.OrdinalIgnoreCase));

        if (selectedOption != null)
        {
            Course plannedCourse = selectedOption.ToCourse("Planned");
            planner.AddCourse(plannedCourse, "Planned");
            Console.WriteLine("Course planned for next semester.");
        }
        else
        {
            Console.WriteLine("Course not found in catalog.");
        }
    }
}
