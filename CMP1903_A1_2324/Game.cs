﻿using System;
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
        private Die Die1 = new Die();
        private Die Die2 = new Die();
        private Die Die3 = new Die();
        public int die1Result;
        public int die2Result;
        public int die3Result;
       
        public Game()
        {
            Console.WriteLine("creating a game");
         
        }
       
  
        //roll the three die
        public void RollDice()
        {
            
            die1Result = Die1.Roll();
            die2Result = Die2.Roll();
            die3Result = Die3.Roll();
        }
       
        
        //sum and report the total
        public int SumOfDice()
        {
            int sumOfDice = Die1.DiceValue + Die2.DiceValue + Die3.DiceValue;
            Console.WriteLine($"sum of rolled Dice is {sumOfDice}");
            return sumOfDice;
        }
       
    }
}