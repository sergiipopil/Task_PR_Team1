using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_PR_Team1.Classes
{
    internal class PaymentInfo
    {
        private int _IBAN;
        private int _transactionId;

        public int IBAN { get { return _IBAN;} set { _IBAN = value; } }
        public int TransactionId { get { return _transactionId; } set { _transactionId = value; } }

        public string GetTransactionData() {
            return $"IBAN: {IBAN}; TransactionId: {TransactionId}";
        }
    }
}
