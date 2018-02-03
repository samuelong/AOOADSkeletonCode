using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class Policy_LapsedIterator : PolicyIterator
    {
        public Policy_LapsedIterator(PolicyCollection collection) : base(collection)
        {
            _collection = collection;
            _currIndex = 0;
            InsurancePolicy p;
            do
            {
                p = _collection.GetPolicy(_currIndex);
                if (p == null)
                    break;
            } while (p.State is Policy_LapsedState);
        }

        override public object Next()
        {
            _currIndex++;
            InsurancePolicy p = _collection.GetPolicy(_currIndex);
            if (p.State is Policy_LapsedState)
            {
                return p;
            }
            return null;
        }
    }
}
