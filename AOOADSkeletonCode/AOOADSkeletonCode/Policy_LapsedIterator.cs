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
