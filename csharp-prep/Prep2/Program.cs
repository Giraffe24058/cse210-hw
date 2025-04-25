using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int g = int.Parse(percent);

        if (90 < g && g < 100)
        {
            Console.WriteLine("Your letter grade is A. ");
        }
        else if(80 < g && g < 90)
        {
            Console.WriteLine("Your letter grade is B. ");
        }
        else if(70 < g && g < 80)
        {
            Console.WriteLine("Your letter grade is C. ");
        }
        else if (60 < g && g < 70)
        {
            Console.WriteLine("Your letter grade is D. ");
        }
        else
        {
            Console.WriteLine("Your letter grade is F. ");
        }


        if(g >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class! ");
        }
        else
        {
            Console.WriteLine("You didn't pass this class. Good luck taking it next time! ");
        }
    }
}