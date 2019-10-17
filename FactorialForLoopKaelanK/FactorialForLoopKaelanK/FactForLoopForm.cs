/*
 * Created by: Kaelan K
 * Created on: 17-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial with For Loop
 * This program uses the for loop to calculate the factorial of a number that a user gives
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

namespace FactorialForLoopKaelanK
{
    public partial class frmFactForLoop : Form
    {
        public frmFactForLoop()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //declare local vars
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorial.Items.Clear();

            // initialize the final value to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtInput.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // list the counter number in the list box for the user to see
                this.lstFactorial.Items.Add(factorialCounter);

                // multiply the counter by answer
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            // convert the answer to a string and display to user
            this.lblOutput.Text = this.txtInput.Text + "! = " + Convert.ToString(factorialAnswer);

        }
    }
}
