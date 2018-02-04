namespace AOOADSkeletonCode.Entities
{
    class Rider
    {
        private string _desc;
        private decimal _additionalPremium;
        private decimal _additionalPayout;

        //Consrtructor
        public Rider() { }
        public Rider(string d, decimal aPre, decimal aPay)
        {
            _desc = d;
            _additionalPremium = aPre;
            _additionalPayout = aPay;
        }

        //GET SET

        public string Desc
        {
            get { return _desc; }
        }

        public decimal AdditionalPremium
        {
            get { return _additionalPremium; }
        }

        public decimal AdditionalPayout
        {
            get { return _additionalPayout; }
        }
    }
}
