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
            game1.rollDice();
            game1.SumOfDice();


            //Create a Testing object to verify the output and operation of the other classes.
            Testing testing = new Testing();
            testing.TestDie();
            testing.TestGame();

            Console.ReadKey();
        }
    }
}

// Have the requirements been met?
// I beleive that the main requirements has been met because it creates the game and testikng objects and calls the correct methods.
// The additional requirments hasn't been met like like using XML doucmentation and making the dice continues. To do that I would put the game methods in a while loop and ask ther user ifr they want to play again
// Is the code formatted using the Style Guidelines correctly?
// Yes since the objects are in the main they should be in cammel case
// Is the code easy to read?
// Yes you have used suitable naming for his objects
// Are different errors handled correctly?
// There are no possible errors that can happen in this class