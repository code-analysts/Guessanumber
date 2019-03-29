using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessanumber
{
    class InputValidations
    {
        string ERRORNOINPUT = "Please input something.";
        string ERRORNOTNUMBER = "Please input a number.";
        string ERRORNOTINRANGER = "Please enter value within range.";

        public string checkInputValidity(string guess, int max)
        {
            int num;
            string error_message;

            if (guess.Length > 0)
            {
                if (int.TryParse(guess, out num))
                { 
                    if (num > 0 && num <= max)
                    {
                        error_message = "VALID";
                    }
                    else
                    {
                        error_message = ERRORNOTINRANGER;
                    }
                }
                else
                {
                    error_message = ERRORNOTNUMBER;
                }
            }
            else
            {
                error_message = ERRORNOINPUT;
            }

            return error_message;
        }
    
    }
}
