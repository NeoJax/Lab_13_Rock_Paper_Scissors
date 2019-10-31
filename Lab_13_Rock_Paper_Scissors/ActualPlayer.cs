using System;
namespace Lab_13_Rock_Paper_Scissors
{
    class ActualPlayer : Player
    {
        public ActualPlayer(string name, Roshambo result) : base(name, result) { }

        public override Roshambo GenerateRoshambo()
        {
            return Validator.ValidateChoice();
        }
    }
}
