using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percent = int.Parse(gradePercentage);

        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if(percent >= 80)
        {
            letter = "B";
        }
        else if(percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"Your letter grade is {letter}");

        if(percent >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class! ");
        }
        else
        {
            Console.WriteLine("You didn't pass this class. Good luck taking it next time! ");
        }
    }
}