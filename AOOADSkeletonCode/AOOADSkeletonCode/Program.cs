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
            CustomerCollection customerCollection = new CustomerCollection();
            //Filling
            customerCollection.addCustomer("001");
            customerCollection.addCustomer("002");
            customerCollection.getCustomer("001").AddPolicy(new InsurancePolicy("1", "Policy 1", "My Policy 1", 300, DateTime.Today.AddDays(1), DateTime.Today.AddDays(100)));
            customerCollection.getCustomer("002").AddPolicy(new InsurancePolicy("2", "Policy 2", "My Policy 2", 15, DateTime.Today.AddDays(5), DateTime.Today.AddDays(100)));
            customerCollection.getCustomer("001").AddPolicy(new InsurancePolicy("3", "Policy 3", "My Policy 3", 1000, DateTime.Today.AddDays(-2), DateTime.Today.AddDays(100)));
            //Running

            // 0 - Agent 1 - Customer 2 - Administrator
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
            string id;
            Console.Write("User ID :");
            id = Console.ReadLine();
            Console.WriteLine();
            Customer cust = customerCollection.getCustomer(id);
            //List<InsurancePolicy> policyList = InsurancePolicy.getPolicies(cust);
            string policyNum = "";
            while (policyNum != "-1")
            {
                Console.WriteLine("Type -1 to leave");
                foreach (InsurancePolicy policy in cust.GetPoliciesByLapsed())
                {
                    Console.WriteLine("No.: {0}\nPolicy: {1}\nDesc: {2}\nPremium: {5}\nOverdue: {3}\nDue Date: {4}\n==============", policy.Number, policy.Name, policy.Desc, policy.IsLapsed(), policy.EndDate, policy.Premium);
                }
                Console.WriteLine("Select a Policy:");
                policyNum = Console.ReadLine();
                if (cust.GetPolicies().Find(x => x.Number == policyNum) != null)
                {
                    payPremiumByCreditCard();
                    break;
                }
                else if (policyNum != "-1") { Console.WriteLine("Policy not found. Please try again"); }
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        public static void payPremiumByCreditCard()
        {
            Console.WriteLine("Use Case Changes to \"Pay Premium By Credit Card\"");

        }
    }
}
