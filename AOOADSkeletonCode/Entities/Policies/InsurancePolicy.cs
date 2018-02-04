using AOOADSkeletonCode.Interfaces.IPolicyState;
using AOOADSkeletonCode.Interfaces.IPolicyDuration;
using System;
using System.Collections.Generic;

namespace AOOADSkeletonCode.Entities.Policies
{
    class InsurancePolicy
    {
        //References
        private IPolicyState ActiveState;
        private IPolicyState LapsedState;
        private IPolicyState TerminatedState;

        private string _number;
        private string _name;
        private string _desc;
        private DateTime _payDate;
        private DateTime _endDate;
        private decimal _premium;
        private IPolicyState _state;
        private IPolicyDuration _duration;
        private Customer _customer;

        private List<Rider> riderSelectedList;
        private List<Rider> riderAvailableList;

        //GET SETw
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
        public IPolicyDuration Duration
        {
            get { return _duration; }
        }
        public List<Rider> AvailableRider
        {
            get { return riderAvailableList; }
        }

        //Constructor
        public InsurancePolicy(string number, string name, string desc, decimal premium, DateTime payDate, IPolicyDuration duration, DateTime endDate, List<Rider> rAL, Customer customer)
        {
            _number = number;
            _name = name;
            _desc = desc;
            _premium = premium;
            _payDate = payDate;
            _endDate = endDate;
            riderAvailableList = rAL;
            ActiveState = new Policy_ActiveState(this);
            LapsedState = new Policy_LapsedState(this);
            TerminatedState = new Policy_TerminatedState(this);
            _duration = duration;
            _customer = customer;
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

        public void AddRider(Rider r)
        {
            riderSelectedList.Add(r);
        }
    }
}
