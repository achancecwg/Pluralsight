using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;
using ACM.BL;

namespace ACM.BL
{
    public class OrderController
    {

        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }

        public void ProcessOrder(Customer customer, Order order, Payment payment,
                                bool allowSplitOrders, bool emailReceipt)
        {
 
            
            customerRepository?.Add(customer);
            
            orderRepository?.Add(order);
           
            inventoryRepository?.OrderItems(order, allowSplitOrders);


            payment?.ProcessPayment();

            //check if they want a receipt
            if (emailReceipt)
            {
                var result = customer.ValidateEmail();
                if(result.Success)
                {

                    customerRepository?.Update();

                    //get ready to send email  
                    emailLibrary?.SendEmail(customer.EmailAddress,
                                            "Here is your receipt");
                }
           
            }

    
        }
    }
}
