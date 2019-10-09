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
            Double factorialAnswer = 1;
            Double factorialUserValue;
            int factorialCounter = 1;

            this.lstFactorialNumbers.Items.Clear();


            factorialUserValue = Convert.ToDouble(this.txtUserValue.Text);

            do
            {
                factorialCounter = factorialCounter + 1;
            } while ();

        }
    }
}
