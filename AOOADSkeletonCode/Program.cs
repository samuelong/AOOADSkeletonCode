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
            Rider Rider1 = new Rider("Rider 1", 100, 1000);
            Rider Rider2 = new Rider("Rider 2", 200, 3000);
            Rider Rider3 = new Rider("Rider 3", 300, 6000);

            List<Rider> availableRiders1 = new List<Rider>();
            availableRiders1.Add(Rider1);
            availableRiders1.Add(Rider2);
            availableRiders1.Add(Rider3);

            List<Rider> availableRiders2 = new List<Rider>();
            availableRiders1.Add(Rider2);

            List<Rider> availableRiders3 = new List<Rider>();
            availableRiders1.Add(Rider1);

            List<Agent> agentList = new List<Agent>();
            List<Receipt> receiptList = new List<Receipt>();
            agentList.Add(new Agent("001", "FIRST AGENT ALIVE"));
            CustomerCollection customerCollection = new CustomerCollection();

            //Filling
            agentList[0].myCustomers.addCustomer(new Customer("001"));
            customerCollection.addCustomer(agentList[0].myCustomers.getCustomer("001"));
            agentList[0].myCustomers.addCustomer(new Customer("002"));
            customerCollection.addCustomer(agentList[0].myCustomers.getCustomer("002"));
            agentList[0].myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("1", "Policy 1", "My Policy 1", 300, DateTime.Today.AddDays(1), new Duration_Monthly(), DateTime.Today.AddDays(100), availableRiders1, agentList[0].myCustomers.getCustomer("001")));
            agentList[0].myCustomers.getCustomer("002").AddPolicy(new InsurancePolicy("2", "Policy 2", "My Policy 2", 15, DateTime.Today.AddDays(5), new Duration_Monthly(),DateTime.Today.AddDays(100), availableRiders2, agentList[0].myCustomers.getCustomer("001")));
            agentList[0].myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("3", "Policy 3", "My Policy 3", 1000, DateTime.Today.AddDays(-2), new Duration_Monthly(), DateTime.Today.AddDays(100), availableRiders3, agentList[0].myCustomers.getCustomer("001")));

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
                                    CreatePolicy(agentList);
                                    //Brandon's Function
                                    break;

                                case 4:
                                    Console.WriteLine("View Customer Policies");
                                    //Jourdan's Function        
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
                                    Console.WriteLine("\nNot yet implemented\n");
                                    AdminstratorMainMenu();
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
                                    CreatePolicy(agentList);
                                    //Brandon's Function
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
                                    //Samuel's Function
                                    displayCustomerPolicies(agentList[0].myCustomers, receiptList);
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

        public static void displayCustomerPolicies(CustomerCollection customerCollection, List<Receipt> receiptList)
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
                    payPremiumByCreditCard(myPolicy, receiptList);
                }
                else if (policyNum != "-1") { Console.WriteLine("Policy not found. Please try again"); }
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        public static void payPremiumByCreditCard(InsurancePolicy p, List<Receipt> receiptList)
        {
            Console.WriteLine("Use Case Changes to \"Pay Premium By Credit Card\"");
            p.Duration.AddPayDate(p);
            receiptList.Add(new Receipt(p));
            p.AutoState();
        }
        // Richeton's Individual Code

        public static void EditPolicy(Customer customer)
        {
            Console.WriteLine("Please select the index of the customer's policy you wish to edit :  ");
            int customerIndex = Convert.ToInt16(Console.ReadLine());

            InsurancePolicy myPolicy = customer.MyPolicies.GetPolicy(customerIndex);


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
                        AddRider(ref myPolicy);
                        break;

                    case 2:
                        PayPremiumByCheque(ref myPolicy, customer);
                        break;

                    case 3:
                        EditPolicy(customer);
                        break;


                }
            }

            Environment.Exit(1);

        }


        public static void AddRider(ref InsurancePolicy p)
        {
            Console.WriteLine("No.\t\t\t\tDesc\t\t\t\tAdditional Premium\t\t\t\tAdditional Payout\t\t\t\t\n==============");
            foreach (Rider r in p.AvailableRider)
                Console.WriteLine("No.{0}\t\t\tDesc{1}\t\t\tAdditional Premium{2}\t\t\tAdditional Payout{3}\t\t\t\n==============", r, r.Desc, r.AdditionalPremium, r.AdditionalPayout);

            int option = Convert.ToInt16(Console.ReadLine());

            p.AddRider(p.AvailableRider[option]);
        }

        public static void PayPremiumByCheque(ref InsurancePolicy p, Customer customer)
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
                    EditPolicy(customer);
                    break;
                }
                else
                {
                    Console.WriteLine("Please key in a valid option");
                    continue;
                }
            }
        }
        // Jourdan's Code
        public static void viewPolicies(CustomerCollection customerCollection)
        {
            Console.WriteLine("View Policies\n");
            // possibly a while loop that goes through
            // customerCollection and displays the policies
            string accNum = null;
            foreach (Customer cust in customerCollection.List)
            {
                List<InsurancePolicy> policyList = cust.GetPoliciesByLapsed();
                foreach (InsurancePolicy policy in policyList)
                {
                    Console.WriteLine("Acc Number: {0}, Policy: {1}", policy.Number, policy.Name);
                }
                accNum = Console.ReadLine();
            }
            while (true)
            {
                Console.WriteLine("------------------\n");
                Console.WriteLine("1. Filter Policy\n");
                Console.WriteLine("2. Generate Alert\n");
                Console.WriteLine("3. Edit Policy\n");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("------------------\n");
                Console.WriteLine("Select your option: ");
                int viewOption = Convert.ToInt32(Console.ReadLine());
                if (viewOption == 1)
                {
                    // filter implementation

                }

                else if (viewOption == 2)
                {
                    // wilson's code
                }

                else if (viewOption == 3)
                {
                    EditPolicy(customerCollection.getCustomer(accNum)); //richeton's code
                }

                else if (viewOption == 4)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("That is not a valid option");
                }
            }
        }
        // Wilson's Code

        // Brandon's Code
        public static void CreatePolicy(List<Agent> agentList)
        {
            Console.WriteLine("Create New Policy");
            Console.WriteLine("Please input the client's account number: ");
            string clientAccNum = Console.ReadLine();
            if (agentList[0].myCustomers.getCustomer(clientAccNum).GetPoliciesByLapsed().Count != 0)
                return;
            else
            {
                Console.WriteLine("1 - Insurance Policy | 2 - Medical Insurance | 3 - Travel Insurance\nPlease input the policy type: ");
                int policyType = Convert.ToInt32(Console.ReadLine());
                switch (policyType)
                {
                    case 1:
                        agentList[0].myCustomers.getCustomer("001").AddPolicy(new InsurancePolicy("1", "Policy 1", "My Policy 1", 300, DateTime.Today.AddDays(1), new Duration_Monthly(), DateTime.Today.AddDays(100), new List<Rider>(), agentList[0].myCustomers.getCustomer("001")));
                        break;
                    case 2:
                        agentList[0].myCustomers.getCustomer("001").AddPolicy(new MedicalInsurance("2", "Policy 2", "My Policy 2", 300, DateTime.Today.AddDays(1), new Duration_Monthly(), DateTime.Today.AddDays(100), new List<Rider>(), agentList[0].myCustomers.getCustomer("001")));
                        break;
                    case 3:
                        agentList[0].myCustomers.getCustomer("001").AddPolicy(new TravelInsurance("3", "Policy 3", "My Policy 3", 300, DateTime.Today.AddDays(1), new Duration_Monthly(), DateTime.Today.AddDays(100), new List<Rider>(),  agentList[0].myCustomers.getCustomer("001")));
                        break;
                }
            }
        }
    }
}