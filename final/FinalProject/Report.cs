public class ReportGenerator
{
    public void PrintPlanner(Student student)
    {
        if (student == null)
        {
            Console.WriteLine("No student data available.");
            return;
        }

        student.PrintInfo();

        if (student.semesters.Count == 0)
        {
            Console.WriteLine("No semesters added.");
            return;
        }

        foreach (Semester semester in student.semesters)
        {
            Console.WriteLine();
            semester.PrintInfo();

            if (semester.courses.Count == 0)
            {
                Console.WriteLine("  No courses in this semester.");
                continue;
            }

            foreach (Course course in semester.courses)
            {
                Console.WriteLine();
                course.PrintInfo();
                course.professor.PrintInfo();
            }
        }
    }
}
