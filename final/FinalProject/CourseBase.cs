public abstract class CourseBase
{
    protected string _name;
    protected string _code;
    protected int _credits;
    protected string _professorName;

    public CourseBase(string name, string code, int credits, string professorName)
    {
        _name = name;
        _code = code;
        _credits = credits;
        _professorName = professorName;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{_name} ({_code}) - {_credits} credits - Professor {_professorName}");
    }
}
