using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing
            Customer.addCustomer("001");
            Customer.getCustomer("001").addPolicy("TestPolicy", "Main Policy!", 300, DateTime.Today.AddDays(1), DateTime.Today.AddDays(100));
            Customer.getCustomer("001").addPolicy("DummyPolicy", "Dummy Policy", 15, DateTime.Today.AddDays(5), DateTime.Today.AddDays(100));
            Customer.getCustomer("001").addPolicy("OverDuePolicy", "Overdue 1, 2, 3!", 1000, DateTime.Today.AddDays(-2), DateTime.Today.AddDays(100));
            //Running

            // 0 - Agent 1 - Customer 2 - Administrator
            int who = 1;
            //Customer View Policies
            if (who == 1)
            {
                Console.WriteLine("Customer View Policies\n");
                string id;
                Console.Write("User ID :");
                id = Console.ReadLine();
                Console.WriteLine();
                displayCustomerPolicies(id);
                Console.WriteLine("Customer chooses to select TestPolicy");
                Console.WriteLine("Customer decides to pay the Premiums");
                Console.WriteLine("Use Case Changes to \"Pay Premium By Credit Card\"");
                Console.ReadKey();
            }
        }
        public static void displayCustomerPolicies(string id)
        {
            Customer cust = Customer.getCustomer(id);
            //List<InsurancePolicy> policyList = InsurancePolicy.getPolicies(cust);
            foreach (InsurancePolicy policy in policyList)
            {
                Console.WriteLine("Policy: {0}\nDesc: {1}\nPremium: {4}\nOverdue: {2}\nDue Date: {3}\n==============", policy.name, policy.desc, (policy.endDate.Date < DateTime.Today ? true : false), policy.endDate, policy.premium);
            }
        }
    }
}
