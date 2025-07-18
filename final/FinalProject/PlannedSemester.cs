using System;
using System.Collections.Generic;

public class PlannedSemester
{
    public List<Course> plannedCourses = new List<Course>();

    public void AddCourse(Course course)
    {
        plannedCourses.Add(course);
        Console.WriteLine("Added " + course.GetName() + " to planned semester.");
    }

    public void RemoveCourse(string courseName)
    {
        Course courseToRemove = null;
        foreach (Course c in plannedCourses)
        {
            if (c.GetName() == courseName)
            {
                courseToRemove = c;
                break;
            }
        }

        if (courseToRemove != null)
        {
            plannedCourses.Remove(courseToRemove);
            Console.WriteLine("Removed " + courseName + " from planned semester.");
        }
        else
        {
            Console.WriteLine("Course " + courseName + " not found in planned semester.");
        }
    }

    public void PrintPlannedCourses()
    {
        if (plannedCourses.Count == 0)
        {
            Console.WriteLine("No courses planned yet.");
        }
        else
        {
            Console.WriteLine("Courses planned for next semester:");
            foreach (Course c in plannedCourses)
            {
                c.PrintInfo();
            }
        }
    }
}
