/*
 * Created by: Kaelan K
 * Created on: 31-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Control Objects
 * This program loops through objects in the form and changes their colour acordingly
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

namespace ForEachKaelanK
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void BtnColour_Click(object sender, EventArgs e)
        {
            // loop through all of the objects and make it green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;
            }
        }

        private void LblColour_Click(object sender, EventArgs e)
        {
            // loop through all fo the objects in the form and change it to red
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;

                // if object is a label then change colour to purple
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }
        }
    }
}
