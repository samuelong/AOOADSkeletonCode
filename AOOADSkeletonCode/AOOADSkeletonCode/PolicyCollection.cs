using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class PolicyCollection : IPolicyCollection
    {
        private List<InsurancePolicy> _list = new List<InsurancePolicy>();
        public List<InsurancePolicy> policyList
        {
            get { return _list; }
            set { _list = value; }
        }
        public IPolicyIterator CreateIterator()
        {
            return new PolicyIterator(this);
        }

        public IPolicyIterator CreateActiveIterator()
        {
            return new Policy_ActiveIterator(this);
        }
        public IPolicyIterator CreateLapsedIterator()
        {
            return new Policy_LapsedIterator(this);
        }
        public IPolicyIterator CreateTerminatedIterator()
        {
            return new Policy_TerminatedIterator(this);
        }

        public InsurancePolicy GetPolicy(int index)
        {
            if (index < _list.Count())
                return _list[index];
            return null;
        }

        public InsurancePolicy FindPolicy(Predicate<InsurancePolicy> p)
        {
            return _list.Find(p);
        }

        public void AddItem(InsurancePolicy item)
        {
            _list.Add(item);
        }

        public void RemoveItem(int index)
        {
            _list.RemoveAt(index);
        }

        public int Count()
        {
            return _list.Count();
        }
    }
}
