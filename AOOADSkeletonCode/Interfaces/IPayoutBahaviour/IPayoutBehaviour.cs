using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Interfaces.IPayoutBahaviour
{
    interface IPayoutBehaviour
    {
        decimal ReturnPayout(InsurancePolicy p);
    }
}
