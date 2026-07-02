using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
       
       //first part
        //Console.Write("What is the magic number? ");   
        //int magicNumber = int.Parse(Console.ReadLine());
        //Console.Write("What is your guess? ");
        //int guess = int.Parse(Console.ReadLine());

        //use random number generator to generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        int guessCount = 0;
        
        //loop until the user guesses the magic number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
            }
        }
    }
}