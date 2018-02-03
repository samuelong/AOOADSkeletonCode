using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
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
