using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace DinerMaxWCFWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DinerMaxService : IDinerMaxService
    {
      DinerMaxDataClassesDataContext data = new DinerMaxDataClassesDataContext();

        public bool addNewCustomer(Customer newCustomer)
        {
            try
            {
                data.Customers.InsertOnSubmit(newCustomer);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCustomer(int customerID)
        {
            try
            {
                Customer customerToDelete = (from customer in data.Customers
                                             where customer.Id == customerID
                                             select customer).Single();
                data.Customers.DeleteOnSubmit(customerToDelete);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modifyCustomer (Customer newCustomer)
        {
            try
            {
                Customer customerToModify = (from customer in data.Customers
                                             where customer.Id == newCustomer.Id
                                             select customer).Single();
                customerToModify.Age = newCustomer.Age;
                customerToModify.City = newCustomer.City;
                customerToModify.IsRegularCustomer = newCustomer.IsRegularCustomer;
                customerToModify.Name = newCustomer.Name;
                customerToModify.Surname = newCustomer.Surname;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> getCustomers()
        {
            try
            {
                return (from customer in data.Customers
                        select customer).ToList();
            }
            catch
            {
                return null; ;
            }
        }
    }
}
