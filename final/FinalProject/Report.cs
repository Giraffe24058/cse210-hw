public class Report
{
    public void PrintPlanner(Schedule schedule)
    {
        if (schedule == null)
        {
            Console.WriteLine("No schedule data available.");
            return;
        }

        Console.WriteLine("=== Taken Courses ===");
        if (schedule.takenCourses.Count == 0)
        {
            Console.WriteLine("  None");
        }
        else
        {
            foreach (Course course in schedule.takenCourses)
            {
                course.PrintInfo();
                Console.WriteLine();
            }
        }

        Console.WriteLine("=== Current Courses ===");
        if (schedule.currentCourses.Count == 0)
        {
            Console.WriteLine("  None");
        }
        else
        {
            foreach (Course course in schedule.currentCourses)
            {
                course.PrintInfo();
                Console.WriteLine();
            }
        }

        Console.WriteLine("=== Planned Courses ===");
        if (schedule.plannedCourses.Count == 0)
        {
            Console.WriteLine("  None");
        }
        else
        {
            foreach (Course course in schedule.plannedCourses)
            {
                course.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
