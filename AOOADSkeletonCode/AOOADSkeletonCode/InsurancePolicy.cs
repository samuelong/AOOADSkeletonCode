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
        private IPolicyState ActiveState;
        private IPolicyState LapsedState;
        private IPolicyState TerminatedState;


        //List of riders that can be applied
        private string _number;
        private string _name;
        private string _desc;
        private DateTime _payDate;
        private DateTime _endDate;
        private decimal _premium;
        private IPolicyState _state;

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
            set { _payDate = value; }
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
        public IPolicyState State
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
            ActiveState = new Policy_ActiveState(this);
            LapsedState = new Policy_LapsedState(this);
            TerminatedState = new Policy_TerminatedState(this);
            AutoState();
        }

        public void SetPolicyState(IPolicyState state)
        {
            _state = state;
        }

        public bool IsLapsed()
        {
            return PayDate.Date < DateTime.Today ? true : false;
        }
        public bool IsTerminated()
        {
            return EndDate.Date < DateTime.Today ? true : false;
        }

        public void AutoState()
        {
            if (IsLapsed())
            {
                SetPolicyState(LapsedState);
            }
            else if (IsTerminated())
            {
                SetPolicyState(TerminatedState);
            }
            else { SetPolicyState(ActiveState); }
        }
    }
}
