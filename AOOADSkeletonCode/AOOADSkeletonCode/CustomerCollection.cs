using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class CustomerCollection
    {
        private List<Customer> list = new List<Customer>();

        // Add Customer if it does not exist
        public void addCustomer(string id)
        {
            if (list.Find(x => x.GetId() == id) == null)
            {
                list.Add(new Customer(id));
            }
        }
        // Return Customer object if it exist
        public Customer getCustomer(string id)
        {
            return list.Find(x => x.GetId() == id);
        }
    }
}
