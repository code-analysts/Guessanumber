/*Author:Gagandeep Kaur
//Date created:27/03/2019
//Date last modified:29/03/2019
//Last person who modified file: Farrah Marie Chavez
//File Description:This file describes the logic behind the guess number game.There are three methods for three buttons to check the result for three different attempts made by user.
Log:
29/03/2019 - Deleted commented codes as per Gagan's permision (Farrah)
29/03/2019 - Refactored the GenerateGame() to be re-used for creating new game (Farrah)
29/03/2019 - Integrated the InputValidations code file (by Heena)  
29/03/2019 - Re-created UI to have levels (1-10, 1-20, 
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
        GameLogicHandler GuessANumberGame;
        InputValidations validator;

        FirstForm form_1; //RC: form_1 is not appropriate
        int maximum_number;
        bool success = false; //Shuaib: Why are you using success?

        public SecondForm(FirstForm f, int max)
        {
            InitializeComponent();
            form_1 = f;
            maximum_number = max;
            GuessANumberGame = new GameLogicHandler();
            validator = new InputValidations();
            GenerateGame();
        }

        public void AssignLabel(string level)
        {
            Label1to10.Text = "Enter a number from " + level;
        }

        //Code for level 1-10
        private void Buttonresult1to10_Click(object sender, EventArgs e)
        {
            
            EvaluateGame();
        }

        private void GenerateGame()
        {
            GuessANumberGame.NewGame(maximum_number);
            GuessANumberGame.AttemptsCounter = 0;
            
        }

        private void EvaluateGame()
        {

            GuessANumberGame.AttemptsCounter++;

            if (GuessANumberGame.AttemptsCounter < 3) // Player has 3 attempts to guess the number
            {
                // Validate input here. Maximum number is also passed to check range.
                string message_validation = validator.checkInputValidity(TxtGuessNumber.Text, form_1.MaximumNumber);
                if (message_validation == "VALID")
                {
                    
                    int guess;
                    if(int.TryParse(TxtGuessNumber.Text, out guess))
                    {
                        // Parse is successful. Do nothing.
                    } else
                    {
                        MessageBox.Show("There was an error in string parsing.");
                    }

                    //If the inputted value is valid, check if guess is correct.
                    if (GuessANumberGame.IsCorrectGuess(guess))
                    {
                        MessageBox.Show("You won! Your prize is: $" + GuessANumberGame.CalculatePrize());
                        success = true;
                    }
                    else if (GuessANumberGame.IsNumberToGuessLower(guess))
                    {
                        MessageBox.Show("The number to guess is lower than " + guess + ".");
                    }
                    else
                    {
                        MessageBox.Show("The number to guess is higher than " + guess + ".");
                    }

                    if(GuessANumberGame.AttemptsCounter == 2)
                    {
                        MessageBox.Show("You have 1 attempt left.");
                    }

                    if(GuessANumberGame.AttemptsCounter == 3)
                    {
                        MessageBox.Show("You lost.");
                    }
                }
                else
                {
                    MessageBox.Show(message_validation);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (success == true)
            {
                // Renew the game
                var confirm_message = MessageBox.Show("Do you want to play a new game?", "New Game Generated", MessageBoxButtons.YesNo);
                if(confirm_message == DialogResult.Yes)
                {
                    GenerateGame();
                    form_1.Show();
                  
                }
                this.Hide();

            } else
            {
                form_1.Show();
                this.Hide();
            }

            TxtGuessNumber.Text = "";

        }
    }
}
