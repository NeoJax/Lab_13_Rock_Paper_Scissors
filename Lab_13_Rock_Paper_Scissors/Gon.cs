using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class Gon : Player
    {
        public Gon(string name, Roshambo result) : base(name, result) { }

        public override Roshambo generateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(1,3);

            if (random == 1)
            {
                return Roshambo.Paper;
            }
            else if (random == 2)
            {
                return Roshambo.Rock;
            }
            else if (random == 3)
            {
                return Roshambo.Scissors;
            }
            return Roshambo.Paper;
        }
    }
}
