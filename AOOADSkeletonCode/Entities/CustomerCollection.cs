using System.Collections.Generic;

namespace AOOADSkeletonCode.Entities
{
    class CustomerCollection
    {
        private List<Customer> list = new List<Customer>();

        // Add Customer if it does not exist

        public void addCustomer(Customer cust)
        {
            if (list.Find(x => x.AccNum == cust.AccNum) == null)
            {
                list.Add(cust);
            }
        }

        // Return Customer object if it exist
        public Customer getCustomer(string accNum)
        {
            return list.Find(x => x.AccNum == accNum);
        }
    }
}
