using System;
using System.Collections.Generic;
namespace Lab_13_Rock_Paper_Scissors
{
    public class RoshamboApp
    {
        public int Wins { get; set; }
        public int Losses { get; set; }

        public RoshamboApp() { }

        public void Start()
        {
            StartTourneyCheck();
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

            return Winner(playerChoice, opponentChoice);
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

        public void StartTourneyCheck()
        {
            Console.WriteLine("Would you like to participate in a tournament? (y or n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                StartTourney();
            }
            else if (input == "n")
            {
                Console.WriteLine("Enjoy the normal game.");
            }
            else
            {
                Console.WriteLine("Please answer with a valid input");
                StartTourneyCheck();
            }
        }

        public void StartTourney()
        {
            TheRock theRock = new TheRock("Dwayne Johnson", Roshambo.rock);
            EdwardScissorhands edward = new EdwardScissorhands("Edward Scissorhands", Roshambo.scissors);
            SuperPaper paperDood = new SuperPaper("That one guy who like paper a lot", Roshambo.paper);
            ThatOneGuy bob = new ThatOneGuy("Bob", Roshambo.rock);
            ThatOtherDude mark = new ThatOtherDude("Mark", Roshambo.paper);
            OldMan oldGuy = new OldMan("Old Guy", Roshambo.scissors);
            Gon gon = new Gon("Gon", Roshambo.rock);
            ActualPlayer player = new ActualPlayer("You", Roshambo.paper);
            Random random = new Random();
            int player1Number;
            int player2Number;
            Player player1;
            Player player2;
            string check;

            List<Player> players = new List<Player>()
            {
                theRock,
                edward,
                paperDood,
                bob,
                mark,
                oldGuy,
                gon,
                player
            };

            while (players.Count > 1)
            {
                player1Number = random.Next(0, players.Count);
                player2Number = random.Next(0, players.Count);
                while (player1Number == player2Number)
                {
                    player2Number = random.Next(0, players.Count);
                }
                player1 = players[player1Number];
                player2 = players[player2Number];
                check = Winner(player1.generateRoshambo(), player2.generateRoshambo());
                while (check == "Tie")
                {
                    check = Winner(player1.generateRoshambo(), player2.generateRoshambo());
                }
                if (check == "Win")
                {
                    Console.WriteLine($"{player1.Name} is the winner!");
                    players.Remove(player2);
                }
                else
                {
                    Console.WriteLine($"{player2.Name} is the winner!");
                    players.Remove(player1);
                }
            }
            Console.WriteLine($"{players[0].Name} is the winner of the Tournament!");

            StartTourneyCheck();
        }

        public string Winner(Roshambo player1, Roshambo player2)
        {
            switch (player1)
            {
                case Roshambo.paper:
                    switch (player2)
                    {
                        case Roshambo.paper:
                            return "Tie";
                        case Roshambo.rock:
                            return "Win";
                        case Roshambo.scissors:
                            return "Lose";
                    }
                    break;
                case Roshambo.rock:
                    switch (player2)
                    {
                        case Roshambo.paper:
                            return "Lose";
                        case Roshambo.rock:
                            return "Tie";
                        case Roshambo.scissors:
                            return "Win";
                    }
                    break;
                case Roshambo.scissors:
                    switch (player2)
                    {
                        case Roshambo.paper:
                            return "Win";
                        case Roshambo.rock:
                            return "Lose";
                        case Roshambo.scissors:
                            return "Tie";
                    }
                    break;
            }

            return "Blah";
        }
    }
}
