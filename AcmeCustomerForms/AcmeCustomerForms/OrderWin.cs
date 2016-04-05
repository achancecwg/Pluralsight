using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeCustomerForms
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            PlaceOrder();

        }
        private void PlaceOrder()
        {
         

            // ------ Populate customer instance and other data from UI here ---

            var customer = new Customer();

            var order = new Order();

            var payment = new Payment();

            // ------ End of data needed from UI -------

            var orderController = new OrderController();

            orderController.ProcessOrder(customer, order, payment, 
                                           allowSplitOrders: false, 
                                           emailReceipt: true);
        }
    }
}

