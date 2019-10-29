using System;
namespace Lab_13_Rock_Paper_Scissors
{
    public class RoshamboApp
    {
        public int Wins { get; set; }
        public int Losses { get; set; }

        public RoshamboApp() { }

        public bool Continue()
        {
            Console.WriteLine("Do you want to continue?(y/n)");
            string userInput = Console.ReadLine();
            if (userInput == "y")
            {
                return true;
            }
            return false;

        }

        public string Choose()
        {
            Console.WriteLine("Choose a player.");
            return Console.ReadLine();
        }


    }
}
