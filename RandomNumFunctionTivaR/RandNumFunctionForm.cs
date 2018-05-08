using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 08-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Percentage Program (Random Number Function)
 * This program allows the user to set a parameter of the maximum number they...
 * ...would like to receive and then the program gives the user a number in ...
 * ... between 1 and the maximum value that the user selected.
*/

namespace RandomNumFunctionTivaR
{
    public partial class frmRandNumFunction : Form
    {
        public frmRandNumFunction()
        {
            InitializeComponent();
            lblRandomNumber.Hide();
        }

        // Function: GenerateRandomNumber
        // Input: int minimum, int maximum
        // Output: int
        // Description: This function returns a random number between the given minimum and maximum values.
        private int GenerateRandomNumber(int minimum, int maximum)
        {
            Random randomNumberGenerator = new Random();
            int aRandomNumber;

            aRandomNumber = randomNumberGenerator.Next(minimum, maximum + 1);

            return aRandomNumber;
        }

        private void btnGenerateRandNum_Click(object sender, EventArgs e)
        {
            // Declare local variables
            int userRandomNumber;
            int userMaxValue;

            // Get the max value from the user 
            userMaxValue = Convert.ToInt16(this.nudMaxValue.Value);

            // Call the function to return a random number
            userRandomNumber = GenerateRandomNumber(1, userMaxValue);

            // Show the label
            lblRandomNumber.Show();

            // Display the random number on the label
            this.lblRandomNumber.Text = "The random number is: " + userRandomNumber;
        }
    }
}
