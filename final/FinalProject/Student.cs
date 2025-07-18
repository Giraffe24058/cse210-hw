public class Student
{
    public string name;
    public string schoolStage;
    public List<Semester> semesters;

    public Student(string name, string schoolStage)
    {
        this.name = name;
        this.schoolStage = schoolStage;
        semesters = new List<Semester>();
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student: " + name);
        Console.WriteLine("Stage: " + schoolStage);
    }
}
