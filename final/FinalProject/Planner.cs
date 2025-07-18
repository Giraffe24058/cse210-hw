using System;

public class Planner
{
    private Schedule _schedule;
    private Report _report;

    public Planner(Schedule schedule)
    {
        _schedule = schedule;
        _report = new Report();
    }

    public void PrintPlanner()
    {
        _report.PrintPlanner(_schedule);
    }

    public void AddCourse(Course course, string status)
    {
        if (_schedule == null)
        {
            Console.WriteLine("No schedule found.");
            return;
        }

        _schedule.AddCourse(course, status);
        Console.WriteLine("Added " + course.GetName() + " to planner");
    }

    public void RemoveCourse(string courseName)
    {
        if (_schedule == null)
        {
            Console.WriteLine("No schedule found.");
            return;
        }

        Course courseToRemove = null;

        // Look for the course in all course lists (taken, current, planned) so remove works no matter where
        foreach (var courseList in new[] { _schedule.currentCourses, _schedule.takenCourses, _schedule.plannedCourses })
        {
            courseToRemove = courseList.Find(c => c.GetName().Equals(courseName, StringComparison.OrdinalIgnoreCase));
            if (courseToRemove != null)
            {
                courseList.Remove(courseToRemove);
                Console.WriteLine("Course removed: " + courseName);
                return;
            }
        }

        Console.WriteLine("Course not found: " + courseName);
    }
}
