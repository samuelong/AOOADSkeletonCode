using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Interfaces.IPolicyDuration
{
    class Duration_OneTime : IPolicyDuration
    {
        public bool AddPayDate(InsurancePolicy p)
        {
            return false;
        }
    }
}
