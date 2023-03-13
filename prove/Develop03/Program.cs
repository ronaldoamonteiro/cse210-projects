using System;

class Program
{
    static void Main(string[] args)
    {
        // create a list of scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life"),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose"),
        };

        // select a random scripture
        var generator = new ScriptureGenerator(scriptures);
        var scripture = generator.SelectRandomScripture();

        // display the complete scripture
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());

        // prompt the user to press enter or quit
        string input;
        do
        {
            Console.Write("Press enter to continue or type 'quit' to exit: ");
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            // hide a few random words and display the scripture again
            scripture.HideWords();
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());

        } while (!scripture.IsCompletelyHidden());
    }
}    