using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class Gon : Player
    {
        public Gon(string name, Roshambo result) : base(name, result) { }

        public override Roshambo generateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(1, 300);
            Console.WriteLine(random);
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
