using System;

class Program
{
    static void Main(string[] args)
    {

    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);

    int guess = -1;


    do
    {
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
    } while (guess != magicNumber);

    {
        Console.WriteLine("Guess a number: ");
        guess = int.Parse(Console.ReadLine());
    while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }


    }








    }
}