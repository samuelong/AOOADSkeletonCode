﻿using System;
using AOOADSkeletonCode.Interfaces.IPolicyDuration;

namespace AOOADSkeletonCode.Entities.Policies
{
    class MedicalInsurance : InsurancePolicy
    {
        public MedicalInsurance(string number, string name, string desc, decimal premium, DateTime payDate, IPolicyDuration duration, DateTime endDate, Customer customer) : base(number, name, desc, premium, payDate, duration, endDate, customer)
        {
        }
    }
}
