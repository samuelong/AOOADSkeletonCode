using AOOADSkeletonCode.Entities.Policies;
using AOOADSkeletonCode.Interfaces.IPolicyCollection;
using AOOADSkeletonCode.Interfaces.IPolicyState;

namespace AOOADSkeletonCode.Interfaces.IPolicyIterator
{
    class Policy_TerminatedIterator : PolicyIterator
    {
        public Policy_TerminatedIterator(PolicyCollection collection) : base(collection)
        {

        }

        override public object Next()
        {
            _currIndex++;
            InsurancePolicy p = _collection.GetPolicy(_currIndex);
            if (p.State is Policy_TerminatedState)
            {
                return p;
            }
            return null;
        }
    }
}
