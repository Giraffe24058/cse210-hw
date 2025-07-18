public class Schedule
{
    public List<Course> takenCourses = new List<Course>();
    public List<Course> currentCourses = new List<Course>();
    public List<Course> plannedCourses = new List<Course>();

    public void AddCourse(Course course, string status)
    {
         
    }

    public void PrintAllCourses()
    {
         
    }
}

public class CourseOption
{
    public string name;
    public string code;
    public int credits;
    public string professorName;

    public CourseOption(string name, string code, int credits, string professorName)
    {
        name = name;
        code = code;
        credits = credits;
        professorName = professorName;
    }

    public Course ToCourse(string status)
    {
         
    }

    public void PrintInfo()
    {
         
    }
}
