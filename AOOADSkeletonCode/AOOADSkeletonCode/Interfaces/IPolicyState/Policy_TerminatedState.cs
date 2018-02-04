using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Interfaces.IPolicyState
{
    class Policy_TerminatedState : IPolicyState
    {
        private InsurancePolicy policy;
        public Policy_TerminatedState(InsurancePolicy policy)
        {
            this.policy = policy;
        }
    }
}
