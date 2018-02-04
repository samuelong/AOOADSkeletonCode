﻿using AOOADSkeletonCode.Entities;
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

            //Option 0 exits the program
            while (option != 0)
            {                

                while (true)
                {
                    MainMenu();

                    //Asks user for inputted option
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\nInvalid option detected. Please enter a valid option.\n");
                        continue;
                    }
                }

                //All Options
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nOption 1: Agent\n");
                        AgentMainMenu();
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("\nOption 2: Administrator");
                        AdminstratorMainMenu();
                        Console.WriteLine("\n");

                    case 3:
                        Console.WriteLine("Option 3: Customer");
                        CustomerMainMenu();
                        Console.WriteLine("\n");
                }
            }
            
            Console.ReadKey();
        }
                
        static void MainMenu()
        /*Displays the main menu*/
        {
            Console.WriteLine("     Provident Life System        ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Agent");
            Console.WriteLine("2. Administrator");
            Console.WriteLine("3. Customer");
            Console.Write("Enter your role: ");
        }


        static void AgentMainMenu()
        /*Displays the main menu*/
        {
            Console.WriteLine("     Provident Life System (Agent)       ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Edit Agent Info");
            Console.WriteLine("2. Register Customer");
            Console.WriteLine("3. Create New Policy");
            Console.WriteLine("4. View Customer Policies");
            Console.WriteLine("5. Back");
            Console.Write("Select an option: ");
        }

        static void AdminstratorMainMenu()
        /*Displays the main menu*/
        {
            Console.WriteLine("     Provident Life System (Administrator)       ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Edit Policy Types");
            Console.WriteLine("2. Register Agent");
            Console.WriteLine("3. Edit Agent Info");
            Console.WriteLine("4. Register Customer");
            Console.WriteLine("5. Create New Policy");
            Console.WriteLine("6. View Customer Policies (All)");
            Console.WriteLine("7. Back");
            Console.Write("Select an option: ");
        }


        static void CustomerMainMenu()
        /*Displays the main menu*/
        {
            Console.WriteLine("     Provident Life System (Customer)       ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. View Policies");
            Console.WriteLine("2. Back");            
            Console.Write("Select an option: ");
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
    }
}