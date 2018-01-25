using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class PolicyInsurance
    {
        //Contains the full list of Policy Objects
        private static List<PolicyInsurance> list = new List<PolicyInsurance>();
        //List of riders that can be applied
        //Link to Customer
        private int no;
        private Customer customer;
        public string name;
        public string desc;
        public DateTime payDate;
        public DateTime endDate;
        public decimal premium;
        public PolicyState pState;

        //Constructor
        public PolicyInsurance(string name, string desc, decimal premium, DateTime payDate, DateTime endDate, Customer customer)
        {
            this.name = name;
            this.desc = desc;
            this.premium = premium;
            this.payDate = payDate;
            this.endDate = endDate;
            this.customer = customer;
            pState = new Active();
        }

        public void setPolicyState(PolicyState state)
        {
            pState = state;
        }

        //Returns the list of Policies that the Customer has
        public static List<PolicyInsurance> getPolicies(Customer cust)
        {
            List<PolicyInsurance> myList = new List<PolicyInsurance>();
            foreach (PolicyInsurance policy in list)
            {
                if (policy.customer == cust)
                {
                    myList.Add(policy);
                }
            }
            return myList;
        }

        //
        public static void addPolicy(PolicyInsurance p)
        {
            list.Add(p);
        }
    }
}
