namespace AOOADSkeletonCode.Entities
{
    class Agent
    {
        private string _accNum;
        private string _name;
        private CustomerCollection _myCustomers = new CustomerCollection();
        public CustomerCollection myCustomers
        {
            get { return _myCustomers; }
        }
        public Agent()
        {

        }

        public decimal calculatePay()
        {
            decimal pay = 0 ;
            return pay;
        }

        public void addCustomer(string accNum)
        {
            _myCustomers.addCustomer(accNum);
        }
    }
}
