public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Optional: Getter for student name (used later in WritingAssignment)
    public string GetStudentName()
    {
        return _studentName;
    }
}
