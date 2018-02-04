using AOOADSkeletonCode.Entities.Policies;
using System;

namespace AOOADSkeletonCode.Interfaces.IPolicyDuration
{
    class Duration_Monthly : IPolicyDuration
    {
        public bool AddPayDate(InsurancePolicy p)
        {
            if (p.PayDate < DateTime.Today)
            {
                p.PayDate = p.PayDate.AddMonths(1);
                return true;
            }
            return false;
        }
    }
}
