//Author:Gagandeep Kaur
//Date created:27/03/2019
//Date last modified:27/03/2019
//Last person who modified file:Gagandeep Kaur
//File Description:This file describes the logic behind the guess number game.There are three methods for three buttons to check the result for three different attempts made by user.
//Log:27/03/2019-created user interface and intialize variables(Gagan)
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
    public partial class Form1 : Form
    {
        //Initializing varaiables
        static Random r = new Random();
        int RandomValue1 = r.Next(1,10);
        int RandomValue2 = r.Next(20,40);
        int RandomValue3 = r.Next(50,100);
        int GuessNumber;
        int NumberofAttempts = 3;
        int PrizeValue1 = 20;
        int PrizeValue2 = 50;
        int PrizeValue3 = 100;
        public Form1()
        {
            InitializeComponent();
        }
        //Check number between 1-10
        private void Buttonresult1to10_Click(object sender, EventArgs e)
        {
            //game coding
            GuessNumber = Convert.ToInt32(Txtnumber1To10);
            while(NumberofAttempts>0)
            {
                if(GuessNumber>10)
                {
                    MessageBox.Show("Guess number is Too High");
                }
                else if(GuessNumber<1)
                {
                    MessageBox.Show("Guess number is Too Low ");
                }
                else
                {
                    MessageBox.Show("You Guessed correct number and you win $"+PrizeValue1);
                }
            }
            NumberofAttempts--;
            
        }
        //Check number between 20-40
        private void Buttonresult20to40_Click(object sender, EventArgs e)
        {//game coding
            GuessNumber = Convert.ToInt32(Txtnumber20To40);
            while (NumberofAttempts > 0)
            {
                if (GuessNumber > 40)
                {
                    MessageBox.Show("Guess number is Too High");
                }
                else if (GuessNumber < 20)
                {
                    MessageBox.Show("Guess number is Too Low ");
                }
                else
                {
                    MessageBox.Show("You Guessed correct number and you win $"+PrizeValue2);
                }
            }
            NumberofAttempts--;

        }
        //Check number between 50-100
        private void Buttonresult50to100_Click(object sender, EventArgs e)
        {
            //game coding
            GuessNumber = Convert.ToInt32(Txtnumber50To100);
            while (NumberofAttempts > 0)
            {
                if (GuessNumber > 100)
                {
                    MessageBox.Show("Guess number is Too High");
                }
                else if (GuessNumber < 50)
                {
                    MessageBox.Show("Guess number is Too Low ");
                }
                else
                {
                    MessageBox.Show("You Guessed correct number and you win $" + PrizeValue3);
                }
            }
            NumberofAttempts--;

        }

        private void Txtnumber1To10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtnumber20To40_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtnumber50To100_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
