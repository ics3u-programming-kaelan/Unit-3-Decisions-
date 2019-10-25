/*
 * Created by: Kaelan K
 * Created on: 25-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Running Average
 * This program calculates the running average
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

namespace runningAverageKaelanK
{
    public partial class runningAverageForm : Form
    {

        // setting global variables
        int sum = 0;
        int numberOfNumbers = 0;

        public runningAverageForm()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // setting local vars
            int nextNumber;
            int average;

            // converting input to a number
            nextNumber = int.Parse(txtInput.Text);

            // incrementing number of numbers by 1
            numberOfNumbers++;

            // sum is equal to sum plus next input
            sum = sum + nextNumber;

            // average is sum divided by amount of numbers
            average = sum / numberOfNumbers;

            // converting average to string and displaying it
            this.lblAverage.Text = Convert.ToString(average);
            
            if (nextNumber > 100)
            {

            }

            else if (nextNumber == -1)
            {
                this.btnCalculate.Enabled = false;
                this.txtInput.Visible = false;
            }
        }
    }
}
