/*Author:Gagandeep Kaur
//Date created:27/03/2019
//Date last modified:28/03/2019
//Last person who modified file: Farrah Marie Chavez
//File Description:This file describes the logic behind the guess number game.There are three methods for three buttons to check the result for three different attempts made by user.
Log:
28/03/2019 - Added the GameLogicHandler, Commented code block in Buttonresult1to10_Click() function to make use of the GameLogicHandler functions. (Farrah)
28/03/2019-Added coding for each level on every button with number of attempts and prize(Gagan)
28/03/2019-Added FirstForm and code to accept numbers only for textboxes(Gagan)
27/03/2019-created user interface and intialize variables(Gagan)

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessanumber
{
    public partial class SecondForm : Form
    {
        //Initializing varaiables
        static Random r = new Random();
        int RandomValue1 = r.Next(1,10);
        int RandomValue2 = r.Next(20,40);
        int RandomValue3 = r.Next(50,100);
        int GuessNumber;
        int NumberofAttempts = 3;
        int Numberofguess = 1;
        int PrizeValue1 = 100;
        int PrizeValue2 = 50;
        int PrizeValue3 = 20;
        GameLogicHandler GuessANumberGame;

        public SecondForm()
        {
            InitializeComponent();
            GuessANumberGame = new GameLogicHandler();
            GuessANumberGame.NewGame(10);
        }

        //Code for level 1-10
        private void Buttonresult1to10_Click(object sender, EventArgs e)
        {
            
            GuessANumberGame.attempts_counter++;

            if(GuessANumberGame.attempts_counter <= 3) // Player has 3 attempts to guess the number
            {
                // Validate input here. If the inputted value is valid, check if guess is correct.
                int guess = Convert.ToInt32(Txtnumber1To10.Text);
                if(GuessANumberGame.IsCorrectGuess(guess))
                {
                    MessageBox.Show("You won! Your prize is: $" + GuessANumberGame.CalculatePrize());
                } else if(GuessANumberGame.IsNumberToGuessLower(guess))
                {
                    MessageBox.Show("The number to guess is lower than " + guess + ".");
                } else
                {
                    MessageBox.Show("The number to guess is higher than " + guess + ".");
                }
            }

          /*  
            GuessNumber = Convert.ToInt16(Txtnumber1To10.Text);
            //Check number from 1 to 10 first
            if (GuessNumber >= 1 && GuessNumber <= 10)
            {
                while (NumberofAttempts > 0)
                {
                    if (GuessNumber == RandomValue1)
                    {
                        if (Numberofguess == 1)
                        {
                            MessageBox.Show("You Guessed a correct number in" + Numberofguess + " attempt and you win $" + PrizeValue3);
                        }
                        else
                        {
                            MessageBox.Show("You Guessed a correct number in" + Numberofguess + " attempt");
                            break;
                        }
                    }
                    else if (GuessNumber < RandomValue1)
                    {
                        MessageBox.Show("Guess number is Too Low.Try a high number" + "\n" + "Attempts left" + (3 - Numberofguess));
                    }
                    else if (GuessNumber > RandomValue1)
                    {
                        MessageBox.Show("Guess number is Too High.Try a low number" + "\n" + "Attempts left" + (3 - Numberofguess));
                    }
                    Numberofguess++;
                    NumberofAttempts--;
                    break;
                }
                if (Numberofguess == 4)
                {
                    MessageBox.Show("You loose,correct guess is:" + RandomValue1);
                }
            }
            else
            {
                MessageBox.Show("Please enter number from 1 to 10");
            }
            */
        }
        //Code for level 20-40
        private void Buttonresult20to40_Click(object sender, EventArgs e)
        {
            GuessNumber = Convert.ToInt16(Txtnumber20To40.Text);
            //Check number from 20 to 40 first
            if (GuessNumber >= 20 && GuessNumber <= 40)
            {
                while (NumberofAttempts > 0)
                {
                    if (GuessNumber == RandomValue1)
                    {
                        if (Numberofguess == 1)
                        {
                            MessageBox.Show("You Guessed a correct number in" + Numberofguess + " attempt and you win $" + PrizeValue2);
                        }
                        else
                        {
                            MessageBox.Show("You Guessed a correct number in" + Numberofguess + " attempt");
                            break;
                        }
                    }
                    else if (GuessNumber < RandomValue1)
                    {
                        MessageBox.Show("Guess number is Too Low.Try a high number" + "\n" + "Attempts left" + (3 - Numberofguess));
                    }
                    else if (GuessNumber > RandomValue1)
                    {
                        MessageBox.Show("Guess number is Too High.Try a low number" + "\n" + "Attempts left" + (3 - Numberofguess));
                    }
                    Numberofguess++;
                    NumberofAttempts--;
                    break;
                }
                if (Numberofguess == 4)
                {
                    MessageBox.Show("You loose,correct guess is:" + RandomValue1);
                }
            }
            else
            {
                MessageBox.Show("Please enter number from 20 to 40");
            }

        }
        //Code for level 50-100
        private void Buttonresult50to100_Click(object sender, EventArgs e)
        {
            
            GuessNumber = Convert.ToInt16(Txtnumber50To100.Text);
            GuessNumber = Convert.ToInt16(Txtnumber1To10.Text);
            //Check number from 50 to 100 first
            if (GuessNumber >= 50 && GuessNumber <= 100)
            {
                while (NumberofAttempts > 0)
                {
                    if (GuessNumber == RandomValue1)
                    {
                        if (Numberofguess == 1)
                        {
                            MessageBox.Show("You Guessed a correct number in" + Numberofguess + " attempt and you win $" + PrizeValue1);
                        }
                        else
                        {
                            MessageBox.Show("You Guessed a correct number in" + Numberofguess + " attempt");
                            break;
                        }
                    }
                    else if (GuessNumber < RandomValue1)
                    {
                        MessageBox.Show("Guess number is Too Low.Try a high number" + "\n" + "Attempts left" + (3 - Numberofguess));
                    }
                    else if (GuessNumber > RandomValue1)
                    {
                        MessageBox.Show("Guess number is Too High.Try a low number" + "\n" + "Attempts left" + (3 - Numberofguess));
                    }
                    Numberofguess++;
                    NumberofAttempts--;
                    break;
                }
                if (Numberofguess == 4)
                {
                    MessageBox.Show("You loose,correct guess is:" + RandomValue1);
                }
            }
            else
            {
                MessageBox.Show("Please enter number from 50 to 100");
            }

        }

        //Txtnumber1To10 only accepts numbers
        private void Txtnumber1To10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if(!Char.IsDigit(ch)&& ch!=8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        // Txtnumber20To40 only accepts numbers
        private void Txtnumber20To40_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        //Txtnumber50To100 only accepts numbers
        private void Txtnumber50To100_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
