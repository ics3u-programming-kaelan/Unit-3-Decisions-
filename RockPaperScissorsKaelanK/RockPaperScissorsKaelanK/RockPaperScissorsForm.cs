using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsKaelanK
{
    public partial class frmRockPaperScissors : Form
    {
        // set variables
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            // create random number generator
            randomNumberGenerator = new Random();
        }
        // Put this inside button clicked
        
         int playerChoice, computerChoice;
         const int ROCK = 1;
         const int PAPER = 2;
         const int SCISSORS = 3;
         
         if (radUserRock.Checked == true)
         {
           playerChoice = 1;
         }
          
         else if (radUserPaper.Checked == true)
         {
           playerChoice = 2;
         }
         
         else if (radUserScissors.Checked == true)
         {
           playerChoice = 3;
         }
         
         else
         {
           radUserRock.Checked = ROCK;
           playerChoice = ROCK;
           
         }

        computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

        if (computerChoice == 1)
        {
            radComputerRock.Checked = true;
        }

        if (computerChoice == 2)
        {
            radComputerPaper.Checked = true;
        }

        if (computerChoice == 3)
        {
            radComputerScissors.Checked = true;

            if(playerChoice == computerChoice)
            {
                lblOutput.Text = "It's a tie!";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
