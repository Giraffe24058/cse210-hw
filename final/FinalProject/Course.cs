public class Course
{
    private string _name;
    private string _code;
    private string _progress;
    private string _professorName;
    private int _credits;

    public Course(string name, string code, string progress, string professorName, int credits)
    {
        _name = name;
        _code = code;
        _progress = progress;
        _professorName = professorName;
        _credits = credits;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetCredits()
    {
        return _credits;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Course: " + _name + " (" + _code + ")");
        Console.WriteLine("Progress: " + _progress);
        Console.WriteLine("Professor: " + _professorName);
        Console.WriteLine("Credits: " + _credits);
    }
}
