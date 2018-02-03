using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class Customer
    {
        private static List<Customer> list = new List<Customer>();
        private List<InsurancePolicy> policies = new List<InsurancePolicy>();
        private string id;
        public Customer(string id)
        {
            this.id = id;
        }
        // Add Customer if it does not exist
        public static void addCustomer(string id)
        {
            if (list.Find(x => x.id == id) == null)
            {
                list.Add(new Customer(id));
            }
        }
        // Return Customer object if it exist
        public static Customer getCustomer(string id)
        {
            return list.Find(x => x.id == id);
        }
        public void addPolicy(string name, string desc, decimal premium, DateTime payDate, DateTime date)
        {
            policies.Add(new InsurancePolicy(name, desc, premium, payDate, date, this));
        }
    }
}
