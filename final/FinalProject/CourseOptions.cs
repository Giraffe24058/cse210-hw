public class CourseOption
{
    private string _name;
    private string _code;
    private int _credits;
    private string _professorName;

    public CourseOption(string name, string code, int credits, string professorName)
    {
        _name = name;
        _code = code;
        _credits = credits;
        _professorName = professorName;
    }

    public Course ToCourse(string status)
    {
        return new Course(_name, _code, status, _professorName);
    }

    public void PrintInfo()
    {
        // TODO: implement this method to print info about this course option
    }
}

    

