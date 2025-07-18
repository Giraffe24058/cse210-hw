public class Course
{
    public string name;
    public string code;
    public string progress;
    public Professor professor;

    public Course(string name, string code, string progress, Professor professor)
    {
        this.name = name;
        this.code = code;
        this.progress = progress;
        this.professor = professor;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Course: " + name + " (" + code + ")");
        Console.WriteLine("Progress: " + progress);
        Console.WriteLine("Professor: " + professor.name);
    }
}
