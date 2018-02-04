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
            Agent Agent1 = new Agent();
            //Filling
            Agent1.addCustomer("001");
            Agent1.addCustomer("002");
            Agent1.myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("1", "Policy 1", "My Policy 1", 300, DateTime.Today.AddDays(1), new Duration_Monthly(), DateTime.Today.AddDays(100)));
            Agent1.myCustomers.getCustomer("002").AddPolicy(new InsurancePolicy("2", "Policy 2", "My Policy 2", 15, DateTime.Today.AddDays(5), new Duration_Monthly(),DateTime.Today.AddDays(100)));
            Agent1.myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("3", "Policy 3", "My Policy 3", 1000, DateTime.Today.AddDays(-2), new Duration_Monthly(), DateTime.Today.AddDays(100)));
           
            //Running
            /*
            // 0 - Agent 1 - Customer 2 - Administrator
            int who = 1;
            //Customer View Policies
            if (who == 1)
            {
                displayCustomerPolicies(Agent1.myCustomers);
            }
            
            */
                       int option = 1;
            int specificOption = 1;

            //Option 0 exits the program
            while (option != 0)
            {
                MainMenu();
                option = Convert.ToInt32(Console.ReadLine());

                //All Options
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nOption 1: Agent\n");
                        AgentMainMenu();
                        while (specificOption != 0)
                        {
                            specificOption = Convert.ToInt32(Console.ReadLine());

                            switch (specificOption)
                            {
                                case 1:
                                    Console.WriteLine("Edit Agent Info");
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AgentMainMenu();
                                    break;

                                case 2:
                                    Console.WriteLine("Register Customer");
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AgentMainMenu();
                                    break;

                                case 3:
                                    Console.WriteLine("Create New Policy");
                                    createPolicy();
                                    break;

                                case 4:
                                    Console.WriteLine("View Customer Policies");
                                    AgentMainMenu();                                    
                                    break;                                    
                            }
                        }
                        break;

                    case 2:                        
                        Console.WriteLine("\nOption 2: Administrator");
                        AdminstratorMainMenu();
                        while (specificOption != 0)
                        {
                            specificOption = Convert.ToInt32(Console.ReadLine());

                            switch (specificOption)
                            {
                                case 1:
                                    Console.WriteLine("Edit Policy Types");                                    
                                    AdminstratorMainMenu();
                                    Console.WriteLine("\nNot yet implemented\n");
                                    break;

                                case 2:
                                    Console.WriteLine("Register Agent");
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AdminstratorMainMenu();
                                    break;

                                case 3:
                                    Console.WriteLine("Edit Agent Info");
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AdminstratorMainMenu();
                                    break;

                                case 4:
                                    Console.WriteLine("Register Customer");
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AdminstratorMainMenu();
                                    break;

                                case 5:
                                    Console.WriteLine("Create New Policy");
                                    createPolicy();
                                    break;

                                case 6:
                                    Console.WriteLine("View Customer Policies (All)");
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AdminstratorMainMenu();
                                    break;
                            }
                        }                        
                        break;

                    case 3:
                        Console.WriteLine("Option 3: Customer");
                        CustomerMainMenu();
                        while (specificOption != 0)
                        {
                            specificOption = Convert.ToInt32(Console.ReadLine());

                            switch (specificOption)
                            {
                                case 1:
                                    Console.WriteLine("View Policies");
                                    displayCustomerPolicies(Agent1.myCustomers);
                                    CustomerMainMenu();
                                    break;
                            }
                        }
                        break;
                }
                Environment.Exit(1);
            }
            Environment.Exit(1);
        }
                
        static void MainMenu()
        /*Displays the main menu*/
        {
            Console.Clear();
            Console.WriteLine("     Provident Life System        ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Agent");
            Console.WriteLine("2. Administrator");
            Console.WriteLine("3. Customer");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your role: ");
        }


        static void AgentMainMenu()
        /*Displays the agent main menu*/
        {
            Console.Clear();
            Console.WriteLine("     Provident Life System (Agent)       ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Edit Agent Info");
            Console.WriteLine("2. Register Customer");
            Console.WriteLine("3. Create New Policy");
            Console.WriteLine("4. View Customer Policies");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
        }

        static void AdminstratorMainMenu()
        /*Displays the adminstrator main menu*/
        {
            Console.Clear();
            Console.WriteLine("     Provident Life System (Administrator)       ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Edit Policy Types");
            Console.WriteLine("2. Register Agent");
            Console.WriteLine("3. Edit Agent Info");
            Console.WriteLine("4. Register Customer");
            Console.WriteLine("5. Create New Policy");
            Console.WriteLine("6. View Customer Policies (All)");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
        }


        static void CustomerMainMenu()
        /*Displays the customer main menu*/
        {
            Console.WriteLine("     Provident Life System (Customer)       ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. View Policies");
            Console.WriteLine("0. Exit");            
            Console.Write("Select an option: ");
        }


        public static void createPolicy()
        {

        }

        public static void editPolicy()
        {
            Console.WriteLine("Please select the index of the customer's policy you wish to edit :  ");
            int customerIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please select what needs to be edited :  ");
            Console.WriteLine("1 : Add Rider ");
            Console.WriteLine("2 : Pay Premium by Cheque ");
            Console.WriteLine("3 : Select another customer's policy ");
            Console.WriteLine("0 : Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        addRider();
                        break;

                    case 2:
                        //payPremiumByCheque();
                        break;

                    case 3:
                        editPolicy();
                        break;
                }
            }

            Environment.Exit(1);

        }

        public static void displayCustomerPolicies(CustomerCollection customerCollection)
        {
            Console.WriteLine("Customer View Policies\n");
            string accNum;
            Customer cust = null;
            while (cust == null)
            {
                Console.Write("User ID :");
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

        
        public static void addRider()
        {
            
            //p.AddRider(newRider);
        }                            

        public static void payPremiumByCheque(ref InsurancePolicy p)
        {
            Console.WriteLine("Use Case Changes to \"Pay Premium By Cheque\"");
            while (true)
            {
                Console.WriteLine("Type in \"Confirm\" to confirm that Customer has Paid Premium by Cheque OR \"Cancel\" to return back to editing policy:   ");
                string confirmation = Console.ReadLine();
                confirmation.ToUpper();
                if (confirmation == "CONFIRM")
                {
                    p.Duration.AddPayDate(p);
                    p.AutoState();
                    break;
                }
                else if (confirmation == "CANCEL")
                {
                    editPolicy();
                    break;
                }
                else
                {
                    Console.WriteLine("Please key in a valid option");
                    continue;
                }
            }
        }
    }

}


