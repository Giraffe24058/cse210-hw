using System;

class Program
{
    static void Main(string[] args)
    {

    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 1001);

    int guess = -1;
    int guessCount = 0;

    Console.Write("Do you want to play the numbers game? (Y/N)  ");
    string response = Console.ReadLine();


    while (response.ToUpper() == "Y")
        do
        {
            Console.Write("Guess a number from 1 to 1001: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("It's higher than that!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("It's lower than that!");
                }
            else
            {
                Console.WriteLine($"You guessed it! It was {magicNumber}! ");
            }
            ++ guessCount;
        } while (guess != magicNumber);
        
    Console.WriteLine($"It took you {guessCount} guesses! ");
        


    }
}