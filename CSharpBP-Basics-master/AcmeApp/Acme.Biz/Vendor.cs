using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages the vendors from whom we purchase our inventory.
    /// </summary>
    public class Vendor 
    {

        public enum IncludeAddress { Yes, No};
        public enum SendCopy { Yes, No};
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }


   


        /// <summary>
        /// 
        /// </summary>
        /// <param name="product">Product to order.</param>
        /// <param name="quantity">Quantity to order.</param>
        /// <param name="deliverByDate">Date product needed by.</param>
        /// <param name="instructions">Delivery instructions</param>
        /// <returns></returns>
        public OperationResult PlaceOrder(Product product, int quantity, DateTimeOffset? deliverByDate =null, string instructions="Standard Delivery")
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity));

            if (deliverByDate <= DateTimeOffset.Now)
                throw new ArgumentOutOfRangeException(nameof(deliverByDate));

            var success = false;

            var orderText = "Order from Acme, Inc" + System.Environment.NewLine + "Product: " + product.ProductCode +
                            System.Environment.NewLine + "Quantity: " + quantity;

            if (deliverByDate.HasValue)
            {
                orderText += System.Environment.NewLine + "Deliver By: " + deliverByDate.Value.ToString("d");
            }

            if (instructions != null)
            {
                orderText += System.Environment.NewLine + "Delivery Instructions: " + instructions;
            }


            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Order", orderText, this.Email);

            if (confirmation.StartsWith("Message sent:"))
            {
                success = true;
            }

            var operationResult = new OperationResult(success, orderText);
            return operationResult;
        }
        /// <summary>
        /// Sends a product to vendor
        /// </summary>
        /// <param name="product">Product to order.</param>
        /// <param name="quantity">Quantity to order.</param>
        /// <param name="includeAddress">Address included?</param>
        /// <param name="sendCopy">Send a copy?</param>
        /// <returns>Success flag and order text</returns>
        public OperationResult PlaceOrder(Product product, int quantity,IncludeAddress includeAddress, SendCopy sendCopy)
        {
            var orderText = "Test";

            if (includeAddress == IncludeAddress.Yes) orderText += " With Address";
            if (sendCopy == SendCopy.Yes) orderText += " With Copy";

            var operationalResult = new OperationResult(true, orderText);
            return operationalResult;
        }

        /// <summary>
        /// Sends an email to welcome a new vendor.
        /// </summary>
        /// <returns></returns>
        public string SendWelcomeEmail(string message)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.CompanyName).Trim();
            var confirmation = emailService.SendMessage(subject,
                                                        message, 
                                                        this.Email);
            return confirmation;
        }
    }

    
}
