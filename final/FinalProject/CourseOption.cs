public class CourseOption : CourseBase
{
    public CourseOption(string name, string code, int credits, string professorName)
        : base(name, code, credits, professorName)
    {
    }

    public Course ToCourse(string status)
    {
        return new Course(_name, _code, status, _professorName, _credits);
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[Option] {_name} ({_code}) - {_credits} credits - Professor {_professorName}");
    }
}
