using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class PolicyIterator : IPolicyIterator
    {
        protected PolicyCollection _collection;
        protected int _currIndex;

        public PolicyIterator(PolicyCollection collection)
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

        virtual public bool HasNext()
        {
            if (_currIndex + 1 < _collection.Count())
            {
                return true;
            }
            return false;
        }

        virtual public object Next()
        {
            _currIndex++;
            //IMPLEMENTATION FOR FILTERING

            //
            return _collection.GetPolicy(_currIndex); // RETURN SOMETHING
        }

        public void Reset()
        {
            _currIndex = -1;
        }
    }
}
