using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class InsurancePolicy
    {
        //References
        private PolicyState ActiveState;
        private PolicyState LapsedState;
        private PolicyState TerminatedState;


        //List of riders that can be applied
        //Link to Customer
        private int no;
        private Customer customer;
        public string name;
        public string desc;
        public DateTime payDate;
        public DateTime endDate;
        public decimal premium;
        public PolicyState state;

        //Constructor
        public InsurancePolicy(string name, string desc, decimal premium, DateTime payDate, DateTime endDate, Customer customer)
        {
            this.name = name;
            this.desc = desc;
            this.premium = premium;
            this.payDate = payDate;
            this.endDate = endDate;
            this.customer = customer;
            state = new Policy_ActiveState(this);
        }

        public void setPolicyState(PolicyState state)
        {
            this.state = state;
        }
    }
}
