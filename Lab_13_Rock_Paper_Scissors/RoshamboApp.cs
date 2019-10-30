using System;
namespace Lab_13_Rock_Paper_Scissors
{
    public class RoshamboApp
    {
        public int Wins { get; set; }
        public int Losses { get; set; }

        public RoshamboApp() { }

        public void Start()
        {
            string verdict = Throw();
            if (verdict == "Win")
            {
                Wins++;
            }
            else if (verdict == "Lose")
            {
                Losses++;
            }
            Console.WriteLine($"Wins: {Wins}, Losses: {Losses}");
            Continue();
        }

        public string Throw()
        {
            Player opponent = Choose();
            Console.WriteLine("Pick your weapon. (Rock, Paper, Scissors)");
            string input = Console.ReadLine();

            if (input == "Rock")
            {
                if (opponent.generateRoshambo() == Roshambo.Paper)
                {
                    return "Lose";
                }
                else if (opponent.generateRoshambo() == Roshambo.Rock)
                {
                    return "Tie";
                }
                else if (opponent.generateRoshambo() == Roshambo.Scissors)
                {
                    return "Win";
                }
            }
            else if (input == "Paper")
            {
                if (opponent.generateRoshambo() == Roshambo.Paper)
                {
                    return "Lose";
                }
                else if (opponent.generateRoshambo() == Roshambo.Rock)
                {
                    return "Tie";
                }
                else if (opponent.generateRoshambo() == Roshambo.Scissors)
                {
                    return "Win";
                }
            }
            else if (input == "Scissors")
            {
                if (opponent.generateRoshambo() == Roshambo.Paper)
                {
                    return "Lose";
                }
                else if (opponent.generateRoshambo() == Roshambo.Rock)
                {
                    return "Tie";
                }
                else if (opponent.generateRoshambo() == Roshambo.Scissors)
                {
                    return "Win";
                }
            }
            return "Blah";
        }

        public void Continue()
        {
            Console.WriteLine("Do you want to continue?(y/n)");
            string userInput = Console.ReadLine();
            if (userInput == "y")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Thank you!");
            }

        }

        Player Choose()
        {
            Console.WriteLine("Choose a player.");
            string input = Console.ReadLine();
            if (input == "TheRock")
            {
                return new TheRock("duder", Roshambo.Rock);
            }
            else if (input == "Gon")
            {
                return new Gon("duderino", Roshambo.Paper);
            }
            return new ThatOneGuy("dude", Roshambo.Scissors);
        }


    }
}
