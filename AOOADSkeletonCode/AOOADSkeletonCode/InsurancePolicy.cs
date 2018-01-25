using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class InsurancePolicy
    {
        //Contains the full list of Policy Objects
        private static List<InsurancePolicy> list = new List<InsurancePolicy>();
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
        public InsurancePolicy(string name, string desc, decimal premium, DateTime payDate, DateTime endDate, Customer customer)
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
        public static List<InsurancePolicy> getPolicies(Customer cust)
        {
            List<InsurancePolicy> myList = new List<InsurancePolicy>();
            foreach (InsurancePolicy policy in list)
            {
                if (policy.customer == cust)
                {
                    myList.Add(policy);
                }
            }
            return myList;
        }

        //
        public static void addPolicy(InsurancePolicy p)
        {
            list.Add(p);
        }
    }
}
