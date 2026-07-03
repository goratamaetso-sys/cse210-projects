using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayMessage()
    {
    Console.WriteLine("Hello world!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name? ");
        string name = Console.ReadLine();
        return name;
       
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is: {squaredNumber}");
    }
}