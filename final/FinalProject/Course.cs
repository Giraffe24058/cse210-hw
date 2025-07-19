public class Course : CourseBase
{
    private string _progress;

    public Course(string name, string code, string progress, string professorName, int credits)
        : base(name, code, credits, professorName)
    {
        _progress = progress;
    }

    public string GetProgress()
    {
        return _progress;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[Course] {_name} ({_code}) - {_credits} credits - Professor {_professorName}");
        Console.WriteLine($"Progress: {_progress}");
    }
}
