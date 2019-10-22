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

        }


        foreach (Control aControlObject in this.Controls)
        {
            aControlObject.BackColor = Color.Green;
        }

        if (aControlObject.GetType() == typeof(Label))
        {
            aControlObject.BackColor = Color.Purple;
        }
    }
}
