using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;

namespace AcmeCustomerForms
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculateGoalPercentage(this.GoalTextBox.Text, 
                                                           this.StepsTextBox.Text);

            ResultLabel.Text = "You reached "
                 + result
                 + "% of your goal!";

        }

        private void PedometerWin_Load(object sender, EventArgs e)
        {

        }
    }
}
