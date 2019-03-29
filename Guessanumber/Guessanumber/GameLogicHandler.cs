/* Author: Farrah Marie Chavez
 * Date Created: 03 March 2019
 * Last Date Modified:
 * Last Person who Modified:
 * 
 * File description:
 * This file handles the logic of the Guess A Number game. It contains the following functions:
 * 
 * void NewGame(int) - initializes the attempt counter, assigns a random number to guess based on the given maximum number and initializes the prize value according to game type.
 * bool IsCorrectGuess(int) - takes the number guessed by player and compares it to the number generated in NewGame() function. If the numbers are the same, return true. Else, false.
 * bool IsNumberToGuessLower(int) - take the number guess by player and checks if the guess is higher. If it is, then the number to guess is lower and function returns true. Else, the number to guess is higher and function returns false.
 * int CalculatePrize() - when this function is called, it simply returns the prize value (assigned in the NewGame() function) according to the number of attempts.
 * 
 * Log:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Guessanumber
{
    class GameLogicHandler
    {
        public int AttemptsCounter { get; set; }
        public int MaximumNumber { get; set; }
        private int numberToGuess;
        private int[] prizes;

        /*
         
            Quick Guide to the Prizes:
            For games with 1 - 10 range:
            1st attempt = $20, 2nd attempt = $10, 3rd attempt = $5

            For games with 1 - 20 range:
            1st attempt = $50, 2nd attempt = $25, 3rd attempt = $10

            For games with 1 - 50 range:
            1st attempt = $100, 2nd attempt = $50, 3rd attempt = $25
             
        */


        public void NewGame(int max)
        {
            Random randomizer = new Random();
            AttemptsCounter = 0;
            numberToGuess = randomizer.Next(1, max);
            MaximumNumber = max;
            prizes = new int[4];

            switch (max){
                case 10:
                    // No need to initialize index 0;
                    prizes[1] = 20;     // accessed as prizes[attemt_counter] where the player guessed the number the first time so attempt_counter is 1.
                    prizes[2] = 10;
                    prizes[3] = 5;
                    break;
                case 20:
                    prizes[1] = 50;    
                    prizes[2] = 25;
                    prizes[3] = 10;
                    break;
                case 50:
                    prizes[1] = 100;
                    prizes[2] = 50;
                    prizes[3] = 25;
                    break;
                default: break;
            }
                
        }

        public bool IsCorrectGuess(int guess)
        {
            bool is_correct = false;

            if(guess == numberToGuess)
            {
                is_correct = true;
            }

            return is_correct;
        }

        public bool IsNumberToGuessLower(int guess)
        {
            bool is_lower = false;

            if(guess > numberToGuess)
            {
                is_lower = true;
            }

            return is_lower;
        }

        public int CalculatePrize()
        { 
            return prizes[AttemptsCounter];
        }

    }
}
