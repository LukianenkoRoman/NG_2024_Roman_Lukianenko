using system;

namespace Task_1
{
    public class Client
    {
        Transaction transaction = new Transaction();
        Balance balance = new Balance();

        private int _acountNumber = _clientid;
        private int _clientid;
        private string _clientname;

        public void ClientId()
        {
            return _clientid;
        }

        public void deposit()
        {
            transaction.RecordTrans();
        }

        public void getBalance()
        {
            balance.getbalance();
        }
    }
}