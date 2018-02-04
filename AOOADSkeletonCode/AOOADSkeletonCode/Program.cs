using AOOADSkeletonCode.Entities;
using AOOADSkeletonCode.Entities.Policies;
using System;
using System.Collections.Generic;
using AOOADSkeletonCode.Interfaces.IPolicyDuration;

namespace AOOADSkeletonCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing
            List<Agent> agentList = new List<Agent>();
            agentList.Add(new Agent("001", "FIRST AGENT ALIVE"));
            CustomerCollection customerCollection = new CustomerCollection();
            //Filling
            agentList[0].myCustomers.addCustomer(new Customer("001"));
            customerCollection.addCustomer(agentList[0].myCustomers.getCustomer("001"));
            agentList[0].myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("1", "Policy 1", "My Policy 1", 300, DateTime.Today.AddDays(1), new Duration_Monthly(), DateTime.Today.AddDays(100), agentList[0].myCustomers.getCustomer("001")));
            agentList[0].myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("2", "Policy 2", "My Policy 2", 15, DateTime.Today.AddDays(5), new Duration_Monthly(),DateTime.Today.AddDays(100), agentList[0].myCustomers.getCustomer("001")));
            agentList[0].myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("3", "Policy 3", "My Policy 3", 1000, DateTime.Today.AddDays(-2), new Duration_Monthly(), DateTime.Today.AddDays(100), agentList[0].myCustomers.getCustomer("001")));
            //Running

            // 0 - Agent, 1 - Customer, 2 - Administrator
            int who = 1;
            //Customer View Policies
            if (who == 1)
            {
                displayCustomerPolicies(customerCollection);

            }
        }
        public static void displayCustomerPolicies(CustomerCollection customerCollection)
        {
            Console.WriteLine("Customer View Policies\n");
            string accNum;
            Customer cust = null;
            while (cust == null)
            {
                Console.Write("User ID:");
                accNum = Console.ReadLine();
                Console.WriteLine();
                cust = customerCollection.getCustomer(accNum);
            }
            //List<InsurancePolicy> policyList = InsurancePolicy.getPolicies(cust);
            string policyNum = "";
            while (policyNum != "-1")
            {
                Console.WriteLine("Type -1 to leave");

                List<InsurancePolicy> lapsedPolicyList = cust.GetPoliciesByLapsed();
                foreach (InsurancePolicy policy in lapsedPolicyList)
                {
                    Console.WriteLine("No.: {0}\nPolicy: {1}\nDesc: {2}\nPremium: {5}\nOverdue: {3}\nDue Date: {4}\n==============", policy.Number, policy.Name, policy.Desc, policy.IsLapsed(), policy.PayDate, policy.Premium);
                }
                Console.WriteLine("Select a Policy:");
                policyNum = Console.ReadLine();
                InsurancePolicy myPolicy = lapsedPolicyList.Find(x=>x.Number == policyNum);
                if (myPolicy != null)
                {
                    payPremiumByCreditCard(ref myPolicy);
                }
                else if (policyNum != "-1") { Console.WriteLine("Policy not found. Please try again"); }
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        public static void payPremiumByCreditCard(ref InsurancePolicy p)
        {
            Console.WriteLine("Use Case Changes to \"Pay Premium By Credit Card\"");
            p.Duration.AddPayDate(p);
            p.AutoState();
        }
    }
}