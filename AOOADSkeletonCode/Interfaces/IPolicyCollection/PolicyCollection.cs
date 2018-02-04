using System;
using System.Collections.Generic;
using System.Linq;
using AOOADSkeletonCode.Entities.Policies;
using AOOADSkeletonCode.Interfaces.IPolicyIterator;

namespace AOOADSkeletonCode.Interfaces.IPolicyCollection
{
    class PolicyCollection : IPolicyCollection
    {
        private List<InsurancePolicy> _list = new List<InsurancePolicy>();
        public List<InsurancePolicy> policyList
        {
            get { return _list; }
            set { _list = value; }
        }
        public IPolicyIterator.IPolicyIterator CreateIterator()
        {
            return new PolicyIterator(this);
        }

        public IPolicyIterator.IPolicyIterator CreateActiveIterator()
        {
            return new Policy_ActiveIterator(this);
        }
        public IPolicyIterator.IPolicyIterator CreateLapsedIterator()
        {
            return new Policy_LapsedIterator(this);
        }
        public IPolicyIterator.IPolicyIterator CreateTerminatedIterator()
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
