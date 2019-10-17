/*
 * Created by: Kaelan K
 * Created on: 17-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares with While Loop
 * This program calculates and displays perfect squares
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

namespace PerfectSquareWhileLoop
{
    public partial class frmPerfectSquareLoop : Form
    {
        public frmPerfectSquareLoop()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local vars
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInterger;

            // set initail values
            value = 1;

            // reset list box
            this.lstPerfectSquare.ResetText();

            // get the users value 
            endingValue = Convert.ToInt32(this.nudUserInput.Value);

            // continue stating any perfect sqaures between the min and max
            while (value <= endingValue)
            {
                // take the sqaure root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an interger
                squareRootAsInterger = Convert.ToInt32(squareRootAsDouble);

                // the only way for the two numbers to be the same is if they are a perfect square
                if  (squareRootAsInterger == squareRootAsDouble)
                {
                    this.lstPerfectSquare.Items.Add(value + " is a perfect square");
                    
                    // refresh the form
                    this.Refresh();
                }

                // increases value by 1
                value++;
            }

        }
    }
}
