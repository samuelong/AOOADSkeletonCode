using System;
using System.Collections.Generic;
using AOOADSkeletonCode.Interfaces.IPolicyDuration;

namespace AOOADSkeletonCode.Entities.Policies
{
    class TravelInsurance : InsurancePolicy
    {
        public TravelInsurance(string number, string name, string desc, decimal premium, DateTime payDate, IPolicyDuration duration, DateTime endDate, List<Rider> rAL, Customer customer) : base(number, name, desc, premium, payDate, duration, endDate, rAL, customer)
        {
        }
    }
}
