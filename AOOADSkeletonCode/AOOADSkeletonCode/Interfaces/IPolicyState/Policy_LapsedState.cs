using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Interfaces.IPolicyState
{
    class Policy_LapsedState : IPolicyState
    {
        private InsurancePolicy policy;
        public Policy_LapsedState(InsurancePolicy policy)
        {
            this.policy = policy;
        }
    }
}
