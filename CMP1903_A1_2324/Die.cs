using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //creating a static instance of random so that random number generation is possible.
        private static readonly Random randomNumber = new Random();
        //Property
        private int _diceValue;
        public Die()
        {
            Console.WriteLine("Creating a new Dice");
            

        }
        // getter and setter for diceValue
        public int DiceValue
        {
            get
            {
                {
                
                    return _diceValue;
                }
            }
            set
            {
                

                    if (value >= 1 && value <= 6)
                    {
                        _diceValue = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid value: out of range");
                    }
                
            }
        }
        // <black-eye-inc> Review:
        // Great implementation of using encapsulation (a key Object-Oriented Principle) to protect
        // internal values -- mentioning this in your video will gain you a mark!
        // </black-eye-inc>

        //Method
        public int Roll()
        {
            Console.WriteLine("Rolling a new value");
            int _diceValue = randomNumber.Next(1,7);
            Console.WriteLine($"rolled a {_diceValue}");
            DiceValue = _diceValue;
            return _diceValue;
        }

    }
}

// <black-eye-inc>
// A brilliant, consistant and accurate/correct use of the C# style Guide's naming sceme has been
// used throughout "Die.cs" -- Great Job!

// Commentation, especially on the "Roll()" method is quite sparce.
// </black-eye-inc>
