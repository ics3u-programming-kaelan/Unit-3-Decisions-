/*
 * Created by: Kaelan K
 * Created on: 07-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program takes the amount of chocoalte boxes that the user sold and gives them a prize to their coresponding amount
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

namespace ChocoBoxKaelanK
{
    public partial class frmChocoBoxes : Form
    {
        public frmChocoBoxes()
        {
            InitializeComponent();
            // hiding labels on build
            this.lblPrize.Hide();
            this.lblPrizeOutput.Hide();
        }

        private void TxtBoxes_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // setting var
            double boxesSold;

            // converting textbox to a number
            boxesSold = double.Parse(txtBoxes.Text);

            // if boxes sold < 10 then display the user gets an honourable mention and show the labels again
            if (boxesSold > 20)
            {
                this.lblPrizeOutput.Text = "You Win a Prize!";
                this.lblPrizeOutput.Show();
                this.lblPrize.Show();
            }
            // if boxes sold < 10 then display the user gets an honourable mention and show the labels again
            else if (boxesSold < 10)
            {
                this.lblPrizeOutput.Text = "You Got an Honourable Mention!";
                this.lblPrizeOutput.Show();
                this.lblPrize.Show();
            }
            // if anything else then display you win a small prize and show the labels again
            else
            {
                this.lblPrizeOutput.Text = "You Win a Small Prize!";
                this.lblPrizeOutput.Show();
                this.lblPrize.Show();
            }
        }
    }
}
