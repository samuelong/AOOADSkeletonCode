using AOOADSkeletonCode.Interfaces.IPolicyCollection;

namespace AOOADSkeletonCode.Interfaces.IPolicyIterator
{
    class PolicyIterator : IPolicyIterator
    {
        protected PolicyCollection _collection;
        protected int _currIndex;

        public PolicyIterator(PolicyCollection collection)
        {
            _collection = collection;
            _currIndex = -1;
        }

        virtual public bool HasNext()
        {
            if (_currIndex + 1 < _collection.Count())
            {
                return true;
            }
            return false;
        }

        virtual public object Next()
        {
            _currIndex++;
            //IMPLEMENTATION FOR FILTERING

            //
            return _collection.GetPolicy(_currIndex); // RETURN SOMETHING
        }

        public void Reset()
        {
            _currIndex = -1;
        }
    }
}
