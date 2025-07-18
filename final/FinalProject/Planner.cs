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

    public void AddCourseToSemester(int semesterIndex, Course course)
    {
        if (student == null || semesterIndex < 0 || semesterIndex >= student.semesters.Count)
        {
            Console.WriteLine("Invalid semester index.");
            return;
        }

        student.semesters[semesterIndex].AddCourse(course);
        Console.WriteLine("Course added to semester: " + student.semesters[semesterIndex].name);
    }

    public void RemoveCourseFromSemester(int semesterIndex, string courseName)
    {
        if (student == null || semesterIndex < 0 || semesterIndex >= student.semesters.Count)
        {
            Console.WriteLine("Invalid semester index.");
            return;
        }

        Semester semester = student.semesters[semesterIndex];
        Course courseToRemove = null;

        foreach (Course course in semester.courses)
        {
            if (course.name == courseName)
            {
                courseToRemove = course;
                break;
            }
        }

        if (courseToRemove != null)
        {
            semester.courses.Remove(courseToRemove);
            Console.WriteLine("Course removed: " + courseName);
        }
        else
        {
            Console.WriteLine("Course not found: " + courseName);
        }
    }


}
