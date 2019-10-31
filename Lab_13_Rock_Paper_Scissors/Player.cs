using System;
namespace Lab_13_Rock_Paper_Scissors
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Result { get; set; }
        public Player(string name, Roshambo result)
        {
            Name = name;
            Result = result;
        }
        abstract public Roshambo GenerateRoshambo();
    }
}
