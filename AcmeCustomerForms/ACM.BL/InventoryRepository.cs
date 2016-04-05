using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class InventoryRepository
    {


        public void OrderItems(Order order, bool allowSplitOrders)
        {
            // -- Order the items from inventory
            // For each item ordered
            // Locate the item in inventory
            // If no longer available, notify user
            // If any items are on backorder and 
            // customer does not want to split orders,
            // notify the user
            // If the item is available,
            // Decrement the quantity remaining
            // Open connection
            // Set stored procedure with inventory data
            // Call save stored procedure


        }
    }
}
