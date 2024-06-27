using System;
using System.Transactions;

namespace Task_1
{
    public class Client : Person
    {
        private int _AccountNumber;
        private int _ClientId;
        private string _ClientName;

        private Transaction transaction;
        private Balance balance;
        private List<Transaction> transactions = new List<Transaction>();


        public List<Transaction> GetTransactions()
        {
            return transactions;
        }

        public Client(int personId, string address, int clientId, string clientName)
            :base(personId, address)
        {
            _ClientId = personId;
            _ClientName = clientName;
            _AccountNumber = personId;

            transaction = new Transaction();
            balance = new Balance(_ClientId);
        }

        public int ClientId()
        {
            return _ClientId;
        }

        public void Deposit(int transId, float transAmount, int transTime)
        {
            transaction.RecordTrans(transId, transAmount, transTime);
            balance.UpdateBalance(transAmount);
       
        }

        public float GetBalance()
        {
            return balance.GetBalance();
        }
    }
}