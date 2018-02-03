using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class Customer
    {
        private PolicyCollection _myPolicies = new PolicyCollection();
        private string _id;
        public Customer(string id)
        {
            _id = id;
        }

        public string GetId()
        {
            return _id;
        }
        public void AddPolicy(InsurancePolicy policy)
        {
            _myPolicies.AddItem(policy);
        }

        public List<InsurancePolicy> GetPolicies()
        {
            return _myPolicies.GetPolicyCollection();
        }

        public List<InsurancePolicy> GetPoliciesByLapsed()
        {
            List<InsurancePolicy> list = new List<InsurancePolicy>();
            PolicyIterator iter = (PolicyIterator) _myPolicies.CreateIterator();
            while (iter.HasNext())
            {
                InsurancePolicy policy = (InsurancePolicy) iter.Next();
                if (policy != null)
                {
                    list.Add(policy);
                }
            }
            return list;
        }
    }
}
