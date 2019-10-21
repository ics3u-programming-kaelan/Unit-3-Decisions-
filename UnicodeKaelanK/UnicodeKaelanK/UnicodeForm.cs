/*
 * Created by: Kaelan K
 * Created on: 21-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program displays the decimal value of letters
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

namespace UnicodeKaelanK
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare the local vars
            int counter;
            string alphaValue;

            // clear the items in the list box
            this.lstValues.Items.Clear();
            
            // set counter to 65, loop until less or equal to 90, add one to counter
            for (counter = 65; counter <= 90; counter++)
            {
                // convert counter to letter
                alphaValue = Char.ConvertFromUtf32(counter);

                // display the letter and the counter value
                this.lstValues.Items.Add(alphaValue + " -> " + counter);
            }

        }
    }
}
