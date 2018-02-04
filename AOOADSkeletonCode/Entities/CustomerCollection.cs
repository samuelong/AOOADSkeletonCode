using System.Collections.Generic;

namespace AOOADSkeletonCode.Entities
{
    class CustomerCollection
    {
        private List<Customer> _list = new List<Customer>();
        public List<Customer> List
        {
            get { return _list; }
        }

        // Add Customer if it does not exist

        public void addCustomer(Customer cust)
        {
            if (_list.Find(x => x.AccNum == cust.AccNum) == null)
            {
                _list.Add(cust);
            }
        }

        // Return Customer object if it exist
        public Customer getCustomer(string accNum)
        {
            return _list.Find(x => x.AccNum == accNum);
        }
    }
}
