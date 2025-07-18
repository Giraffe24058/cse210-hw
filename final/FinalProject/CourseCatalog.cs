using System;
using System.Collections.Generic;

public class CourseCatalog
{
    public List<CourseOption> courseOptions = new List<CourseOption>();

    public CourseCatalog()
    {
        // Add some courses with credits and professor name
        courseOptions.Add(new CourseOption("Math 101", "M101", 3, "Professor Lowski"));
        courseOptions.Add(new CourseOption("Science 101", "S101", 4, "Professor Smith"));
        courseOptions.Add(new CourseOption("History 201", "H201", 3, "Professor Jones"));
        courseOptions.Add(new CourseOption("English 101", "E101", 3, "Professor Brown"));
        courseOptions.Add(new CourseOption("Computer Science 101", "CS101", 4, "Professor Davis"));
    }

    public void PrintAllCourses()
    {
        foreach (CourseOption option in courseOptions)
        {
            Console.WriteLine(option._name + " (" + option._code + ") - " + option._credits + " credits - " + option._professorName);
        }
    }
}
