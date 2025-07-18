public class Planner
{
    public Student student;
    public ReportGenerator report;

    public Planner(Student student)
    {
        this.student = student;
        report = new ReportGenerator();
    }

    public void PrintPlanner()
    {
        report.PrintPlanner(student);
    }
}
