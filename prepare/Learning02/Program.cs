using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Pharmaceutical Sales Rep";
        Job1._company = "Eurofarma";
        Job1._startYear = 2014;
        Job1._endYear = 2016;

        Job Job2 = new Job();
        Job2._jobTitle = "CEO & Co-founder";
        Job2._company = "Smart Conversation";
        Job2._startYear = 2017;
        Job2._endYear = 2023;

        Job1.Display();

        Resume myResume = new Resume();
        myResume._name = "Ronaldo";

        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        myResume.Display();

    }
}