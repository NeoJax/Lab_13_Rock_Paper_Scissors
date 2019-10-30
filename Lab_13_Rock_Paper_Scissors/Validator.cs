using System;
namespace Lab_13_Rock_Paper_Scissors
{
    public class Validator
    {

        public Validator() { }

        public static Roshambo ValidateChoice()
        {
            Console.WriteLine("Pick your weapon. (Rock, Paper, Scissors)");
            string input = Console.ReadLine().ToLower();
            if (ValidateString(input))
            {
                if (input == "rock")
                {
                    return Roshambo.rock;
                }
                else if (input == "paper")
                {
                    return Roshambo.paper;
                }
                else if (input == "scissors")
                {
                    return Roshambo.scissors;
                }
            }
            Console.WriteLine("Please enter a valid option");
            return ValidateChoice();
        }

        public static bool ValidateString(string choice)
        {
            if (choice == "rock")
            {
                return true;
            }
            else if (choice == "scissors")
            {
                return true;
            }
            else if (choice == "paper")
            {
                return true;
            }
            return false;
        }
    }
}
