using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ACM.BL;

namespace AcmeCustomerForms
{
    /// <summary>
    /// Interaction logic for PedometerWindow.xaml
    /// </summary>
    public partial class PedometerWindow : Window
    {
        public PedometerWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculateGoalPercentage(this.GoalTextBox.Text,
                                                           this.StepsTextBox.Text);

            this.ResultLabel.Content = "You reached "
                 + result
                 + "% of your goal!";
        }
    }
}
