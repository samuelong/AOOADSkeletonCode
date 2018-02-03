using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class PolicyCollection : IPolicyCollection
    {
        private List<InsurancePolicy> list = new List<InsurancePolicy>();

        IPolicyIterator IPolicyCollection.CreateIterator()
        {
            return new PolicyIterator(this);
        }

        public InsurancePolicy GetItem(int index)
        {
            return list[index];
        }

        public void AddItem(InsurancePolicy item)
        {
            list.Add(item);
        }

        public void RemoveItem(int index)
        {
            list.RemoveAt(index);
        }

        public int Count()
        {
            return list.Count();
        }
    }
}
