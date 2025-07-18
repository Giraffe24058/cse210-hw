public class CourseOption
{
    public string name;
    public string code;
    public int credits;
    public string professorName;

    public CourseOption(string name, string code, int credits, string professorName)
    {
        this.name = name;
        this.code = code;
        this.credits = credits;
        this.professorName = professorName;
    }

    public Course ToCourse(string status)
    {
         
    }

    public void PrintInfo()
    {
         
    }
}
