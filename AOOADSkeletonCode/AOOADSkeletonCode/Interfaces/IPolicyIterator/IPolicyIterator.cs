namespace AOOADSkeletonCode.Interfaces.IPolicyIterator
{
    interface IPolicyIterator
    {
        object Next();
        bool HasNext();
        void Reset();
    }
}
