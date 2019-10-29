using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class ThatOneGuy : Player
    {
        public ThatOneGuy(string name, Roshambo result) : base(name, result) { }

        public override Roshambo generateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(1, 2);

            if (random == 1)
            {
                return Roshambo.Paper;
            }
            else if (random == 2)
            {
                return Roshambo.Rock;
            }
            return Roshambo.Scissors;
        }
    }
}
