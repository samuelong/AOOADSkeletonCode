﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class TravelInsurance : InsurancePolicy
    {
        public TravelInsurance(string number, string name, string desc, decimal premium, DateTime payDate, DateTime endDate) : base(number, name, desc, premium, payDate, endDate)
        {
        }
    }
}