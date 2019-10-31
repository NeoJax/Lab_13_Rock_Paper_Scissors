using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class Gon : Player
    {
        public Gon(string name, Roshambo result) : base(name, result) { }

        public override Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(1, 300);
            if (random <= 100)
            {
                return Roshambo.paper;
            }
            else if (random > 100 && random <= 200)
            {
                return Roshambo.rock;
            }
            else
            {
                return Roshambo.scissors;
            }
        }
    }
}
