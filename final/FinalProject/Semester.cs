public class Semester
{
    public string name;
    public string startDate;
    public string endDate;
    public List<Course> courses;

    public Semester(string name, string startDate, string endDate)
    {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
}
