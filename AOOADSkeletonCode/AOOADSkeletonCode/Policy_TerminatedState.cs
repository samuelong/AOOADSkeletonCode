using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class Policy_TerminatedState : PolicyState
    {
        private InsurancePolicy policy;
        public Policy_TerminatedState(InsurancePolicy policy)
        {
            this.policy = policy;
        }
    }
}
