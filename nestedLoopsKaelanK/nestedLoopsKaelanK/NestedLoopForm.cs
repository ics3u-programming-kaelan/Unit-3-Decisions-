/*
 * Created by: Kaelan K
 * Created on: 24-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program loops through letters A - Z and then in a - z
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

namespace nestedLoopsKaelanK
{
    public partial class frmNestedLoop : Form
    {
        public frmNestedLoop()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local vars
            int alphaVal;
            int lowAlphaVal;
            string letter;
            string lowLetter;

            // clear listbox
            this.lstAlphaNest.Items.Clear();

            // loop through upper case alpha
            for (alphaVal = 65; alphaVal <= 90; alphaVal++)
            {
                letter = Char.ConvertFromUtf32(alphaVal);

                // loop through lower case
                for (lowAlphaVal = 97; lowAlphaVal <= 122; lowAlphaVal++)
                {
                    lowLetter = Char.ConvertFromUtf32(lowAlphaVal);
                    this.lstAlphaNest.Items.Add(letter + " -> " + lowLetter);
                    
                }
                this.lstAlphaNest.Items.Add(alphaVal + " -> " + letter);
            }

        }

        private void FrmNestedLoop_Load(object sender, EventArgs e)
        {

        }
    }
}
