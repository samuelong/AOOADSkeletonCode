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
        private string _number;
        private string _name;
        private string _desc;
        private DateTime _payDate;
        private DateTime _endDate;
        private decimal _premium;
        private PolicyState _state;

        //GET SET
        public string Number
        {
            get { return _number; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Desc
        {
            get { return _desc; }
        }
        public DateTime PayDate
        {
            get { return _payDate; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
        }
        public decimal Premium
        {
            get { return _premium; }
        }
        public PolicyState State
        {
            get { return _state; }
        }

        //Constructor
        public InsurancePolicy(string number, string name, string desc, decimal premium, DateTime payDate, DateTime endDate)
        {
            _number = number;
            _name = name;
            _desc = desc;
            _premium = premium;
            _payDate = payDate;
            _endDate = endDate;
            _state = new Policy_ActiveState(this);
        }

        public void SetPolicyState(PolicyState state)
        {
            _state = state;
        }

        public bool IsLapsed()
        {
            return PayDate.Date < DateTime.Today ? true : false;
        }

        public void SetLapsed()
        {
            if (IsLapsed() == true)
            {
                SetPolicyState(new Policy_LapsedState(this));
            }
        }
    }
}
