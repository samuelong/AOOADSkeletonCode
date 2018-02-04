using AOOADSkeletonCode.Entities.Policies;
using System;

namespace AOOADSkeletonCode.Interfaces.IPolicyDuration
{
    class Duration_Yearly : IPolicyDuration
    {
        public bool AddPayDate(InsurancePolicy p)
        {
            if (p.PayDate < DateTime.Today)
            {
                p.PayDate = p.PayDate.AddYears(1);
                return true;
            }
            return false;
        }
    }
}
