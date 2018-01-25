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
        private string id;
        public Customer(string id)
        {
            this.id = id;
        }
        public static void addCustomer(string id)
        {
            if (list.Find(x => x.id == id) == null)
            {
                list.Add(new Customer(id));
            }
        }
        public static Customer getCustomer(string id)
        {
            return list.Find(x => x.id == id);
        }
        public void addPolicy(string name, string desc, decimal premium, DateTime date)
        {
            Policy.addPolicy(new Policy(name, desc, premium, date, this));
        }
    }
}
