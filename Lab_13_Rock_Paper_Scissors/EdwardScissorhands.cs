using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class EdwardScissorhands : Player
    {
        public EdwardScissorhands(string name, Roshambo result) : base(name, result) { }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.scissors;
        }

    }
}
