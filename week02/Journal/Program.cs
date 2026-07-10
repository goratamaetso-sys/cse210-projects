using System;
// added option to save as csv
class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
       

        string choice = "";
        while (choice != "6")
        {
            
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save as text");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save as csv");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine();

            choice = Console.ReadLine();

        switch (choice)
        {
            case  "1":
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
            string entryText = Console.ReadLine();
            journal.AddEntry(prompt,entryText);
            break;

            case "2":
            journal.DisplayEntries();
            break;

             case "3":
            Console.Write("Enter filename:");
            string saveFile = Console.ReadLine();
            journal.SaveToFile(saveFile);
            break;

            case "4":
            Console.Write("Enter filename: ");
            string loadFile = Console.ReadLine();
            journal.LoadFromFile(loadFile);
            break;

            case "5":
            Console.Write("Enter CSV filename: ");
            string csvFile = Console.ReadLine();
            journal.SaveToCsv(csvFile);
            break;
            
            case "6":
            Console.WriteLine("Goodbye!");
            break;

            default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }

        }
    }
}