using AOOADSkeletonCode.Entities.Policies;
using System;

namespace AOOADSkeletonCode.Interfaces.IPayoutBahaviour
{
    class NoPayout : IPayoutBehaviour
    {
        public decimal ReturnPayout(InsurancePolicy p)
        {
            throw new NotImplementedException();
        }
    }
}
