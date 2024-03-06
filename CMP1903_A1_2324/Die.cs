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
            int _diceValue = randomNumber.Next(1,7);
            Console.WriteLine($"rolled a {_diceValue}");
            DiceValue = _diceValue;
            return _diceValue;
        }

    }
}

// Have the requirements been met?
// Yes you have he used a property to store the value and created a method to store a value
// The additional requirment he hasn't met is the use of XML doucmentation
// Is the code formatted using the Style Guidelines correctly?
// _dicevalue in the method shouldn't have an underscore unless he has trying to use the field then he doesn't need the int
// Is the code easy to read?
// Mostly buy I think he can write the get methode like this get { return _num; } and set method like this set { _num = value; } and put the set method in a try and catch instead of using an if 
// Are different errors handled correctly?
// Yes you have the setter method is inside an if to prevent the values from being outside 1 and 6