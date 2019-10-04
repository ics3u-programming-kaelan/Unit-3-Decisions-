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
            lblAnswer.Hide();
        }

        private void LblGuessNumber_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            const int MAX_NUMBER = 10;
            int numNumbers;

            numNumbers = int.Parse(txtGuess.Text);

            if (numNumbers > MAX_NUMBER)
            {
                lblAnswer.Text = "Your Guess Is Too High";
                lblAnswer.Show();
            }

            if (numNumbers < MAX_NUMBER)
            {
                lblAnswer.Text = "Your Guess Is Too Low";
                lblAnswer.Show();
            }

            else
            {
                lblAnswer.Text = "You Guessed Right!";
                lblAnswer.Show();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"n:\Classes\Sem1-Fall2019\ICS3U Programming\KKaelan (s254351)\Unit 3 (Decisions)\GuessNumberKaelanK\Sounds\Correct Answer Sound Effect.mp3");
                player.Play();
            }
        }
    }
}
