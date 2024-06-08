using system;

namespace Task_1
{
    public class Balabce
    {
        Client client = new Client();
        Transaction transaction = new Transaction();

        
        int id = client.ClientID();

        private int _balanceid = id;

        private int _balanceamount;
        
        public getbalance()
        {
            return _balanceamount;
        }

        public updateBalance()
        {
            transaclion.TransDetails();
            int sum = _transamount;
            _balanceamount + sum;
        }
    }
}