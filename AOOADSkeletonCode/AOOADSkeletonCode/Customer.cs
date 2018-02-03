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
        public PolicyCollection MyPolicies
        {
            get { return _myPolicies; }
            set { _myPolicies = value; }
        }
        private string _accNum;

        public string AccNum
        {
            get { return _accNum; }
        }
        public Customer(string accNum)
        {
            _accNum = accNum;
        }

        public void AddPolicy(InsurancePolicy policy)
        {
            _myPolicies.AddItem(policy);
        }

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
