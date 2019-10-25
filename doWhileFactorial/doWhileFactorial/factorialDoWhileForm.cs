/*
 * Created by: Kaelan K
 * Created on: 25-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates the factorial of a number from a user
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

namespace doWhileFactorial
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declaring local vars
            double factorialAnswer;
            double factorialUserValue;
            double factorialCounter;

            this.lstFactorialNumbers.Items.Clear();

            // initialize final answer to 1
            factorialAnswer = 1;

            // get the input from user
            factorialUserValue = Convert.ToDouble(this.txtUserValue.Text);

            // set counter to 0
            factorialCounter = 0;

            do
            {
                // increment by one
                factorialCounter++;

                // list factorial counter in listbox
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                // multiply counter by answer
                factorialCounter = factorialAnswer * factorialCounter; 

            } while (factorialCounter <= factorialUserValue);

            // convert answer to string and display
            this.lblUserValue.Text = this.txtUserValue.Text + " ! = " + Convert.ToString(factorialAnswer);
        }
    }
}
