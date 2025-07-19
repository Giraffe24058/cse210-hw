public class Planner
{
    private Schedule _schedule;

    public Planner(Schedule schedule)
    {
        _schedule = schedule;
    }

    public void AddCourse(Course course, string status)
    {
        _schedule.AddCourse(course, status);
    }

    public void RemoveCourse(string name)
    {
        _schedule.RemoveCourse(name);
    }

    public void PrintPlanner()
    {
        _schedule.PrintAllCourses();
    }
}
