using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
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
