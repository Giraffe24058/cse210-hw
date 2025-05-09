using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Amazon";
        job1._startYear = 2018;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._jobTitle = "Cashier";
        job2._company = "Walmart";
        job2._startYear = 2010;
        job2._endYear = 2017;
    


        Resume resume = new Resume();
        resume._name = "Marisabelle";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails();


    }
}





