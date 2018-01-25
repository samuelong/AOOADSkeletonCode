using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class Policy
    {
        //Contains the full list of Policy Objects
        private static List<Policy> list = new List<Policy>();
        //List of riders that can be applied
        //Link to Customer
        private Customer customer;
        public string name;
        public string desc;
        public DateTime payDate;
        public DateTime endDate;
        public decimal premium;

        //Constructor
        public Policy(string name, string desc, decimal premium, DateTime payDate, DateTime endDate, Customer customer)
        {
            this.name = name;
            this.desc = desc;
            this.premium = premium;
            this.payDate = payDate;
            this.endDate = endDate;
            this.customer = customer;
        }

        //Returns the list of Policies that the Customer has
        public static List<Policy> getPolicies(Customer cust)
        {
            List<Policy> myList = new List<Policy>();
            foreach (Policy policy in list)
            {
                if (policy.customer == cust)
                {
                    myList.Add(policy);
                }
            }
            return myList;
        }

        //
        public static void addPolicy(Policy p)
        {
            list.Add(p);
        }
    }
}
