using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class TheRock : Player
    {
        public TheRock(string name, Roshambo result) : base (name, result) { }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
