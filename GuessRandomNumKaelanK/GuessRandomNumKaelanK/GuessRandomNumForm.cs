/*
 * Created by: Kaelan K
 * Created on: 16-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program generates a random number for you to guess
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

namespace GuessRandomNumKaelanK
{
    public partial class frmGuessRandomNum : Form
    {
        // declare global and local vars and consts
        int correctGuess;
        Random randomNumberGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;

        public frmGuessRandomNum()
        {
            InitializeComponent();

            // hide the label initially
            lblOutput.Hide();

            // setting correct guess
            correctGuess = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // declare the constants and vars
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            int userValue;
            Random randomNumberGenerator = new Random();

            userValue = int.Parse(txtInput.Text);

            // get the random number
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // let the user know if the guessed right or not
            if (userValue == aRandomNumber)
            {
                lblOutput.Text = "You guessed right";
                lblOutput.Show();
            }
            else
            {
                lblOutput.Text = Convert.ToString("You guessed wrong, the answer was " + aRandomNumber);
                lblOutput.Show();
            }

        }
    }
}
