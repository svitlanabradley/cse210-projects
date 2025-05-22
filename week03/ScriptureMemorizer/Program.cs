using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        ScriptureLoader loader = new ScriptureLoader();
        List<Scripture> scripture = loader.LoadFromFile("scriptures.txt");

        Random random = new Random();
        Scripture selectedScripture = scripture[random.Next(scripture.Count)];

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.Write("\nPress Enter to hide words or type 'q' to exit ");
            string input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}