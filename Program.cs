using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoll.Game;

namespace DiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            DiceGame.StartGame(dice);
        }
    }
}
