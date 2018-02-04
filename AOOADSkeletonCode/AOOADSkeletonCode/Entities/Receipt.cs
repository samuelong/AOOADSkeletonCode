using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOADSkeletonCode.Entities.Policies;

namespace AOOADSkeletonCode.Entities
{
    class Receipt
    {
        private static int _receiptNumIncrement = 0;
        private string _receiptNum;
        public string ReceiptNum
        {
            get { return _receiptNum; }
        }
        private DateTime _paidDate;
        public DateTime PaidDate
        {
            get { return _paidDate; }
        }
        private InsurancePolicy _policy;
        public InsurancePolicy Policy
        {
            get { return _policy; }
        }

        public Receipt(InsurancePolicy policy)
        {
            _receiptNum = _receiptNumIncrement.ToString();
            _receiptNumIncrement++;
            _paidDate = DateTime.Today;
            _policy = policy;
        }
    }
}
