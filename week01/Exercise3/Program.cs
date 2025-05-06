using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "y";
        while (again == "y")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            int guessNum = -1;
            int tries = 0;
    
            while (magicNum != guessNum)
            { 
                Console.Write("What is your guess? ");
                guessNum = int.Parse(Console.ReadLine());
                tries = tries + 1;
    
                if (magicNum < guessNum)
                {
                    Console.WriteLine("Lower");
                }
                else if ( magicNum > guessNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You quessed it!");
                }
            }
            Console.WriteLine($"It took you {tries} guesses.");

            Console.Write("Do you want to play again? (y/n) ");
            again = Console.ReadLine();
        }
        Console.Write("Goodbye");
    }
}