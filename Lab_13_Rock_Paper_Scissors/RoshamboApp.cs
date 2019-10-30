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
            Console.WriteLine(verdict);
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
            Roshambo playerChoice = Validator.ValidateChoice();
            Roshambo opponentChoice = opponent.generateRoshambo();
            
            if (playerChoice == Roshambo.rock)
            {
                if (opponentChoice == Roshambo.paper)
                {
                    return "Lose";
                }
                else if (opponentChoice == Roshambo.rock)
                {
                    return "Tie";
                }
                else if (opponentChoice == Roshambo.scissors)
                {
                    return "Win";
                }
            }
            else if (playerChoice == Roshambo.paper)
            {
                if (opponentChoice == Roshambo.paper)
                {
                    return "Tie";
                }
                else if (opponentChoice == Roshambo.rock)
                {
                    return "Win";
                }
                else if (opponentChoice == Roshambo.scissors)
                {
                    return "Lose";
                }
            }
            else if (playerChoice == Roshambo.scissors)
            {
                if (opponentChoice == Roshambo.paper)
                {
                    return "Win";
                }
                else if (opponentChoice == Roshambo.rock)
                {
                    return "Lose";
                }
                else if (opponentChoice == Roshambo.scissors)
                {
                    return "Tie";
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
            Console.WriteLine("Choose a player. (TheRock, Gon, ThatOneGuy)");
            string input = Console.ReadLine().ToLower();
            if (input == "therock")
            {
                return new TheRock("duder", Roshambo.rock);
            }
            else if (input == "gon")
            {
                return new Gon("duderino", Roshambo.paper);
            }
            else if (input == "thatoneguy")
            {
                return new ThatOneGuy("dude", Roshambo.scissors);
            }
            else
            {
                Console.WriteLine("Please enter a valid player.");
                return Choose();
            }
        }


    }
}
