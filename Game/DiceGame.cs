using System;

namespace DiceRoll.Game
{
    public static class DiceGame
    {
        public static bool StartGame(Dice dice)
        {
            int userGuess;
            bool userLose = true;

            while (dice.Try < 3)
            {
                Console.WriteLine("Enter a number:");

                while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess > dice.DiceMaxNum || userGuess < dice.DiceMinNum)
                {
                    Console.WriteLine("Incorrect input.");
                    Console.WriteLine("Enter a number:");
                }

                if (userGuess == dice.DiceSide)
                {
                    Console.WriteLine("You win!");
                    userLose = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong number.");
                }

                dice.Try++;
            }

            Console.WriteLine("You lose! :(");
            Console.WriteLine("The number was " + dice.DiceSide);
            return false;
        }
    }
}
