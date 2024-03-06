using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */


        //testing game object
        public void TestGame()
        {
            Console.WriteLine("Testing Game");
            Game testGame = new Game();
            //running the test a thousand times
            for (int i = 0; i < 1000; i++)
            {
                //rolling all the dice
                testGame.RollDice();

                //taking the individual die values and checking they are in the correct range
                
                int die1Value = testGame.die1Result;
                Debug.Assert(die1Value >= 1 && die1Value <= 6, "Die roll out of intended range");

                int die2Value = testGame.die2Result;
                Debug.Assert(die2Value >= 1 && die2Value <= 6, "Die roll out of intended range");

                int die3Value = testGame.die3Result;
                Debug.Assert(die3Value >= 1 && die3Value <= 6, "Die roll out of intended range");

                //getting the sum of the dice
                int sum = die1Value + die2Value + die3Value;
                //checking sum is in the expected range
                Debug.Assert(sum >= 3 && sum <= 18, "Total out of intended range");
                //checking that the summing function is giving the correct value
                Debug.Assert(sum == testGame.SumOfDice(),"sum function not returning the correct value");
            }
        }
        public void TestDie()
        {
            Console.WriteLine("testing die");
            Die testDie = new Die();
            for (int i = 0;i < 1000;i++)
            {
                testDie.Roll();
                Debug.Assert((testDie.DiceValue>=1 && testDie.DiceValue <= 6),$"Die roll out of intended range:{testDie.DiceValue}");
            }
        }
       
           
    }

}

