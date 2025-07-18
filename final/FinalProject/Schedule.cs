using System;
using System.Collections.Generic;

public class Schedule
{
    public List<Course> takenCourses = new List<Course>();
    public List<Course> currentCourses = new List<Course>();
    public List<Course> plannedCourses = new List<Course>();

    public void AddCourse(Course course, string status)
    {
        string lowerStatus = status.ToLower();

        if (lowerStatus == "taken")
            takenCourses.Add(course);
        else if (lowerStatus == "taking")
            currentCourses.Add(course);
        else if (lowerStatus == "planned")
            plannedCourses.Add(course);
        else
            Console.WriteLine("Unknown course status. Course not added.");
    }

    public void PrintAllCourses()
    {
        Console.WriteLine("Taken Courses:");
        foreach (Course c in takenCourses)
            c.PrintInfo();

        Console.WriteLine("\nCurrent Courses:");
        foreach (Course c in currentCourses)
            c.PrintInfo();

        Console.WriteLine("\nPlanned Courses:");
        foreach (Course c in plannedCourses)
            c.PrintInfo();
    }
}
