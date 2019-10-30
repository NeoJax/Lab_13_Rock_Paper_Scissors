using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class ThatOtherDude : Player
    {
        public ThatOtherDude(string name, Roshambo result) : base(name, result) { }

        public override Roshambo generateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(1, 200);

            if (random <= 100)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }
        }

    }
}
