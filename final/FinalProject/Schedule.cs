using System;
using System.Collections.Generic;

public class Schedule
{
    public List<Course> takenCourses = new List<Course>();
    public List<Course> currentCourses = new List<Course>();
    public List<Course> plannedCourses = new List<Course>();

    public void AddCourse(Course course, string status)
    {
        if (status == "Taken") takenCourses.Add(course);
        else if (status == "Taking") currentCourses.Add(course);
        else if (status == "Planned") plannedCourses.Add(course);
    }

    public void RemoveCourse(string name)
    {
        takenCourses.RemoveAll(c => c.GetName() == name);
        currentCourses.RemoveAll(c => c.GetName() == name);
        plannedCourses.RemoveAll(c => c.GetName() == name);
    }

    public void PrintAllCourses()
    {
        Console.WriteLine("Taken Courses:");
        foreach (var c in takenCourses) c.PrintInfo();

        Console.WriteLine("\nCurrent Courses:");
        foreach (var c in currentCourses) c.PrintInfo();

        Console.WriteLine("\nPlanned Courses:");
        foreach (var c in plannedCourses) c.PrintInfo();
    }
}
