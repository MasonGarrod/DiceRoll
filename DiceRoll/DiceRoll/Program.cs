using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            int diceRoll = 0;
            int attempts = 0;

            Console.WriteLine("Press any key to roll the dice");

            while (diceRoll != 6)
            {
                Console.ReadKey();
                diceRoll = rng.Next(1, 7);
                Console.WriteLine("You rolled a " + diceRoll);
                attempts++;
            }

            Console.WriteLine("You have attempted " + attempts + " attempts to roll a 6");

            Console.ReadKey();
        }
    }
}
