using System;

namespace DiceRoll.Game
{
    public class Dice
    {
        public int DiceMinNum { get; private set; }
        public int DiceMaxNum { get; private set; }
        public int Try { get; set; }
        public int DiceSide { get; private set; }
        public Dice() : this(1, 6) { }
        public Dice(int diceMinNum, int diceMaxNum)
        {
            DiceMinNum = diceMinNum;
            DiceMaxNum = diceMaxNum;
            Random random = new Random();
            Try = 0;
            DiceSide = random.Next(DiceMinNum, DiceMaxNum + 1);
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        }
    }
}
