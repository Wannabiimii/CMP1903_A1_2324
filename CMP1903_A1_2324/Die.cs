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
        

        //Method
        public int Roll()
        {
            Console.WriteLine("Rolling a new value");

            //sets dice value to a random number
            int _diceValue = randomNumber.Next(1,7);

            Console.WriteLine($"rolled a {_diceValue}");

            //updating the public dice value
            DiceValue = _diceValue;
            return _diceValue;
        }

    }
}

