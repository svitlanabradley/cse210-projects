using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

// run Journal application
class Program
{
    static void Main(string[] args)
    {
        // create a new Journal object to store entries
        Journal journal = new Journal();

        // create a new PromptGenerator object to get random prompts
        PromptGenerator promptGenerator = new PromptGenerator();

        // get the current date and time
        DateTime theCurrentTime = DateTime.Now;


        bool running = true;
        Console.WriteLine("Welcome to the Journal Program!");

        // menu loop
        while (running)
        {
            // display menu options
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // read user's choice
            string choice = Console.ReadLine();

            // Option 1: write a new journal entry
            if (choice == "1")
            {
                //create a new Entry object
                Entry entry = new Entry();

                // ask user for title
                Console.Write("Title for this entry: ");
                entry._title = Console.ReadLine();

                // ask user for location
                Console.Write("Location: ");
                entry._location = Console.ReadLine();

                // get a random prompt from the PromptGenerator
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{entry._promptText}");

                // ask user to respond to the prompt
                Console.Write("> ");
                entry._entryText = Console.ReadLine();

                // set the current date and time
                entry._date = theCurrentTime.ToString("dd.MM.yyyy HH:mm");

                // add the new entry to the journal
                journal.AddEntry(entry);
            }

            // option 2: display all journal entries
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            // option 3: load entries from a fole
            else if (choice == "3")
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            // option 4: save entries to a file
            else if (choice == "4")
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            // option 5: exit the program
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye! Have a good day!");
            }
        }
    }
}