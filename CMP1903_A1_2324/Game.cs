using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
       
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //create three die objects
        public Die Die1 = new Die();
        public Die Die2 = new Die();
        public Die Die3 = new Die();
        // <black-eye-inc> Review:
        // One of the underlying principles of Object-Oriented Programming is
        // "encapsulation" -- this is basically making all the parameters of a class private and
        // relying on public methods to access them.
        // So you could change the above variables to private variables to help show
        // off/demonstrate this principle.
        // C# Style Guide Naming Rules:
        // - Parameters and local variables: camelCase
        // - Private Parameters: _camelCase
        // </black-eye-inc>
        public Game()
        {
            Console.WriteLine("creating a game");
         
        }
        // <black-eye-inc> Review:
        // Excluding for the use of testing purposes, I'd recommend against the use of adding
        // "Console.Writeline" code everywhere to say every small activity the program is commiting
        // Sinse it's not what the target user brought this game to see.
        // </black-eye-inc>
  
        //roll the three die
        public void rollDice()
        {
            
            Die1.Roll();
            Die2.Roll();
            Die3.Roll();
        }
        // <black-eye-inc> Review:
        // for "rollDice()", the C# Coding Style Guidelines recommend using PascalCase for method
        // names.
        // Also, I recommend keeping a consistent naming scheme -- "rollDice()" is camelCase, while
        // "SumOfDice()" is PascalCase.
        // </black-eye-inc>
        
        //sum and report the total
        public int SumOfDice()
        {
            int sumOfDice = Die1.DiceValue + Die2.DiceValue + Die3.DiceValue;
            Console.WriteLine($"sum of rolled Dice is {sumOfDice}");
            return sumOfDice;
        }
        // <black-eye-inc> Review:
        // I personally would have put "rollDice()" and "SumOfDice()" in the same funtion to
        // minimise faff, so while there's nothing wrong with doing this, I am very intrigued as to
        // why you taken this aproach.

        // I couldn't find the EXTRA Functionality feature "Continuous Dice rolls".
        // this would be a function that endlessly rolls dice and asks the user if they want to
        // roll again, ending the loop if "no".
        // </black-eye-inc>
    }
}