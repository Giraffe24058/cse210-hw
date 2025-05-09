using System;
using System.ComponentModel;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: {_jobs}");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}