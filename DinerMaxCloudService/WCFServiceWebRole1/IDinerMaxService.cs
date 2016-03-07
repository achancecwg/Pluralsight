using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DinerMaxWCFWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDinerMaxService
    {
        [OperationContract]
        bool addNewCustomer(Customer newCustomer);

        [OperationContract]
        bool deleteCustomer(int customerID);

        [OperationContract]
        bool modifyCustomer(Customer newCustomer);

        [OperationContract]
        List<Customer> getCustomers();
        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
