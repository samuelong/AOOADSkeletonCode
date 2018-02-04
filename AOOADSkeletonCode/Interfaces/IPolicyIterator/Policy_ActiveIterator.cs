using AOOADSkeletonCode.Interfaces.IPolicyCollection;
using AOOADSkeletonCode.Interfaces.IPolicyState;
using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Interfaces.IPolicyIterator
{
    class Policy_ActiveIterator : PolicyIterator
    {
        public Policy_ActiveIterator(PolicyCollection collection) : base(collection)
        {

        }

        override public object Next()
        {
            _currIndex++;
            InsurancePolicy p = _collection.GetPolicy(_currIndex);
            if (p.State is Policy_ActiveState)
            {
                return p;
            }
            return null;
        }
    }
}
