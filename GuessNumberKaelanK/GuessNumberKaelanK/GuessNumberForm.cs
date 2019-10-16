/*
 * Created by: Kaelan K
 * Created on: 15-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Guess Number
 * This program generates a number and then displays a checkmark or x if the user gets it right or wrong
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

namespace GuessNumberKaelanK
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();
            //hiding label
            lblAnswer.Hide();
            picAns.Hide();
        }

        private void LblGuessNumber_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // settings constant max number
            const int MAX_NUMBER = 10;
            int numNumbers;
            // parsing the users input
            numNumbers = int.Parse(txtGuess.Text);

            // if guess too high display x and say too high
            if (numNumbers > MAX_NUMBER)
            {
                lblAnswer.Text = "Your Guess Is Too High";
                lblAnswer.Show();
                picAns.Show();
                this.picAns.Image = Properties.Resources.red_x;
            }

            // if guess too low display x and say too low
            else if (numNumbers < MAX_NUMBER)
            {
                lblAnswer.Text = "Your Guess Is Too Low";
                lblAnswer.Show();
                picAns.Show();
                this.picAns.Image = Properties.Resources.red_x;
            }

            // if guess too high display checkmark and say too high
            else
            {
                lblAnswer.Text = "You Guessed Right!";
                lblAnswer.Show();
                picAns.Show();
                this.picAns.Image = Properties.Resources.checkmark;  
            }
            
        }
    }
}
