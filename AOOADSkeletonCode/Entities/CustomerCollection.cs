using System.Collections.Generic;

namespace AOOADSkeletonCode.Entities
{
    class CustomerCollection
    {
        private List<Customer> list = new List<Customer>();

        // Add Customer if it does not exist
        public void addCustomer(string accNum)
        {
            if (list.Find(x => x.AccNum == accNum) == null)
            {
                list.Add(new Customer(accNum));
            }
        }
        // Return Customer object if it exist
        public Customer getCustomer(string accNum)
        {
            return list.Find(x => x.AccNum == accNum);
        }
    }
}
