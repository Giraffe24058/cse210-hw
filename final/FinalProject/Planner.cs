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

        foreach (Course course in _schedule.currentCourses)
        {
            if (course.GetName() == courseName)
            {
                courseToRemove = course;
                break;
            }
        }

        if (courseToRemove != null)
        {
            _schedule.currentCourses.Remove(courseToRemove);
            Console.WriteLine("Course removed: " + courseName);
        }
        else
        {
            Console.WriteLine("Course not found: " + courseName);
        }
    }
}
