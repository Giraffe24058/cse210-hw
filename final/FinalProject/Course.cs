public class Course
{
    public string name;
    public string code;
    public CourseStatus status;
    public List<Topic> topics;
    public Professor professor;

    public Course(string name, string code, CourseStatus status, Professor professor)
    {
        this.name = name;
        this.code = code;
        this.status = status;
        this.professor = professor;
        topics = new List<Topic>();
    }

    public void AddTopic(Topic topic)
    {
        topics.Add(topic);
    }
}
