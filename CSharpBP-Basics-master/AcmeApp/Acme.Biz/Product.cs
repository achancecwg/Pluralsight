using Acme.Common;
using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in Inventory.
    /// </summary>
    public class Product
    {

        public const double InchesPerMeter = 39.37;

        public readonly decimal MinimumPrice;

        #region Constructors
        public Product()
        {
            //this.ProductVendor = new Vendor();
            this.MinimumPrice = .96m;
            this.Category = "Tools";
            Console.WriteLine("Product was created");
        }

        public Product(int productId, string productName, string description) : this()
        {
           this.ProductId = productId;
           this.ProductName = productName;
           this.Description = description;
           if (ProductName.StartsWith("Bulk"))
            {
                this.MinimumPrice = 9.99m;
            }


            Console.WriteLine("Properties were set for product name : " + ProductName);
        }
        #endregion


        #region Properties
        private string productName;

        public string ProductName
        {
            get {
                var formattedValue = productName?.Trim();
                return formattedValue;
            }
            set {

                if (value.Length < 3)
                {
                    ValidationMessage = "Product name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product cannot be more than 20 characters";
                }
                else
                {
                    productName = value;
                }

            }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }

        public string Category { get; set; }
        public int SequenceNumber { get; set; } = 1;

        private DateTime? availabilityDate;

        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        public string ValidationMessage { get; private set; }



        #endregion

        public string SayHello()
        {
            // var vendor = new Vendor();
            //vendor.SendWelcomeEmail("Hello from the Product class");

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Product", this.ProductName, "sales@abc.com");

            //an example of the "using static" feature of C# 6
            var result = LogAction("say hello");

            return "Hello " + ProductName +
                " (" + ProductId + "): " +
                Description + " Available on: " + AvailabilityDate?.ToShortDateString();

            //testing github repo
        }

      
    }
}
