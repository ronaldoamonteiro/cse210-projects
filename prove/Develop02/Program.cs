using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool _running = true;

        Console.WriteLine("\nWelcome to the Journal Program!\n");

        while (_running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write"); // I have included 4 more questions in addition to the suggested ones.
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit\n");
            Console.Write("What would you like to do? ");

            string _input = Console.ReadLine();
            Console.Write("\n");


            switch (_input)
            {
                case "1":
                    string _prompt = journal.GetRandomPrompt();
                    Console.WriteLine(_prompt);
                    string _response = Console.ReadLine();
                    journal.AddEntry(new Entry(_prompt, _response));
                    Console.WriteLine("***Entry added successfully***\n");
                    break;

                case "2":
                    journal.DisplayEntries();
                    Console.Write("\n");
                    break;

		        case "3": //I put Save first instead of Load because it makes more sense in my view
                    Console.WriteLine("Please enter a file name:");
                    string _fileName = Console.ReadLine();
                    journal.SaveToFile(_fileName);
                    Console.WriteLine("***Journal saved to file successfully***\n");
                    break;

                case "4":
                    Console.WriteLine("Please enter a file name:");
                    _fileName = Console.ReadLine();
                    journal.LoadFromFile(_fileName);
                    Console.WriteLine("***Journal loaded from file successfully***\n");
                    break;

                case "5":
                    _running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
        }
    }
}