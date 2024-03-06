using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object and call its methods.
            Game game1 = new Game();
            game1.RollDice();
            game1.SumOfDice();


            //Create a Testing object to verify the output and operation of the other classes.
            Testing testing = new Testing();
            testing.TestDie();
            testing.TestGame();

            Console.ReadKey();
        }
    }
}

