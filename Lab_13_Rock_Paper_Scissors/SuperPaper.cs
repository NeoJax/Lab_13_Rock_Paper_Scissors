using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class SuperPaper : Player
    {
        public SuperPaper(string name, Roshambo result) : base(name, result) { }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.paper;
        }

    }
}
