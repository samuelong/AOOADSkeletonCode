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
        public Agent(string accNum, string name)
        {
            _accNum = accNum;
            _name = name;
        }

        public decimal calculatePay()
        {
            decimal pay = 0 ;
            return pay;
        }

        public void addCustomer(Customer customer)
        {
            _myCustomers.addCustomer(customer);
        }
    }
}
