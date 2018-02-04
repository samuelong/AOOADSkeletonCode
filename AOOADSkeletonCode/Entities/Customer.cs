using System.Collections.Generic;
using AOOADSkeletonCode.Interfaces.IPolicyCollection;
using AOOADSkeletonCode.Entities.Policies;
using AOOADSkeletonCode.Interfaces.IPolicyIterator;

namespace AOOADSkeletonCode.Entities
{
    class Customer
    {
        private PolicyCollection _myPolicies = new PolicyCollection();
        public PolicyCollection MyPolicies
        {
            get { return _myPolicies; }
            set { _myPolicies = value; }
        }

        private Agent _myAgent;

        public Agent MyAgent
        {
            get { return _myAgent; }
        }

        private string _accNum;
        public string AccNum
        {
            get { return _accNum; }
        }

        // Constructor
        public Customer(string accNum)
        {
            _accNum = accNum;
        }

        // Adds policy to list
        public void AddPolicy(InsurancePolicy policy)
        {
            _myPolicies.AddItem(policy);
        }

        // Returns a list of policies that is Lapsed
        public List<InsurancePolicy> GetPoliciesByLapsed()
        {
            List<InsurancePolicy> list = new List<InsurancePolicy>();
            IPolicyIterator iter = _myPolicies.CreateLapsedIterator();
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
