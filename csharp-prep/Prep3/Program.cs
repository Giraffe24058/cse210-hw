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

    while (guess != magicNumber)
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

    }
        
    if (guessCount == 1) // This means that they guessed it on the first try!
    {
        Console.WriteLine($"Amazing!!! You guessed it on your first try! ");
    }
    else if (guessCount < 15) // This means that it took less than 20 guesses
    {
        Console.WriteLine($"It only took you {guessCount} guesses! Way to go! ");
        }
    else if (guessCount < 21) // This means that it took less than 20 guesses
    {
        Console.WriteLine($"Good job! It only took you {guessCount} guesses! ");
        }
    else if (guessCount < 51) // This means that it took less than 50 guesses
    {
    Console.WriteLine($"It took you {guessCount} guesses! ");
        }
    else // This should mean that it took over 50 guesses
    {
        Console.WriteLine($"It took you {guessCount} guesses! Can you get it in less than that next time? ");
    }



    }
}