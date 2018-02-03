using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADSkeletonCode
{
    class PolicyIterator : IPolicyIterator
    {
        PolicyCollection collection;
        int Currindex;

        public PolicyIterator(PolicyCollection collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            if (Currindex+1 < collection.Count())
            {
                return true;
            }
            return false;
        }

        public object Next()
        {
            Currindex++;
            //IMPLEMENTATION FOR FILTERING

            //
            return collection.GetItem(Currindex); // RETURN SOMETHING
        }
    }
}
