public class CourseOption
{
    public string _name;
    public string _code;
    public int _credits;
    public string _professorName;

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
        Console.WriteLine($"{_name} ({_code}) - {_credits} credits - Professor {_professorName}");
    }
}
