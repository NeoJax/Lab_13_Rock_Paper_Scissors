using System;

namespace Lab_13_Rock_Paper_Scissors
{
    public enum Roshambo { rock, paper, scissors };

    class Program
    {
        static void Main(string[] args)
        {
            RoshamboApp game = new RoshamboApp();
            game.Start();
        }
    }
}
