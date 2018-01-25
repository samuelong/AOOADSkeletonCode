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
            Customer.getCustomer("001").addPolicy("TestPolicy", "Main Policy!", 300, DateTime.Today.AddDays(1));
            Customer.getCustomer("001").addPolicy("DummyPolicy", "Dummy Policy", 15, DateTime.Today.AddDays(5));
            Customer.getCustomer("001").addPolicy("OverDuePolicy", "Overdue 1, 2, 3!", 1000, DateTime.Today.AddDays(-2));
            //Running
            // 0 - Agent 1 - Customer 2 - Administrator
            int who = 1;
            //Customer View Policies
            if (who == 1)
            {
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
            List<Policy> policyList = Policy.getPolicies(cust);
            foreach (Policy policy in policyList)
            {
                Console.WriteLine("Policy: {0}\nDesc: {1}\nPremium: {4}\nOverdue: {2}\nDue Date: {3}\n==============", policy.Name, policy.Desc, (policy.endDate.Date < DateTime.Today ? true : false), policy.endDate, policy.Premium);
            }
        }
    }

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

    class Policy
    {
        private static List<Policy> list = new List<Policy>();
        private Customer customer;
        public string Name;
        public string Desc;
        public DateTime endDate;
        public decimal Premium;
       
        public Policy(string name, string desc, decimal premium, DateTime date, Customer cust)
        {
            Name = name;
            Desc = desc;
            Premium = premium;
            endDate = date;
            customer = cust;
        }
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
        public static void addPolicy(Policy p)
        {
            list.Add(p);
        }
    }
}
