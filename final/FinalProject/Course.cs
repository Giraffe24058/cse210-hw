public class Course
{
    private string _name;
    private string _code;
    private string _progress;
    private string _professorName;

    public Course(string name, string code, string progress, string professorName)
    {
        _name = name;
        _code = code;
        _progress = progress;
        _professorName = professorName;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Course: " + _name + " (" + _code + ")");
        Console.WriteLine("Progress: " + _progress);
        Console.WriteLine("Professor: " + _professorName);
    }
}
