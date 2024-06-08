using System;
using System.Transactions;

namespace Task_1
{
    public class Client
    {
        private int _accountNumber;
        private int _clientId;
        private string _clientName;

        private Transaction transaction;
        private Balance balance;
        private List<Transaction> transactions = new List<Transaction>();


        public List<Transaction> GetTransactions()
        {
            return transactions;
        }

        public Client(int clientId, string clientName)
        {
            _clientId = clientId;
            _clientName = clientName;
            _accountNumber = clientId;

            transaction = new Transaction();
            balance = new Balance(_clientId);
        }

        public int ClientId()
        {
            return _clientId;
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