﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    interface IPolicyCollection
    {
        IPolicyIterator CreateIterator();
    }
}