﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class TravelInsurance : InsurancePolicy
    {
        public TravelInsurance(string name, string desc, decimal premium, DateTime payDate, DateTime endDate, Customer customer) : base(name, desc, premium, payDate, endDate, customer)
        {
        }
    }
}
