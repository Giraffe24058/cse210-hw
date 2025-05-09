using System;
using System.ComponentModel;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResumeDetails()
    {
        Console.Write($"Name: {_name}");
        Console.Write($"Name: {_name}");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}