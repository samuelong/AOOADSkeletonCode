using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Interfaces.IPolicyState
{
    class Policy_ActiveState : IPolicyState
    {
        private InsurancePolicy policy;
        public Policy_ActiveState(InsurancePolicy policy)
        {
            this.policy = policy;
        }
    }
}
