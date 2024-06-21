using system;

namespace Task_1 
{
    public class Transaction
    {
        private int _transid;
        private float _transamount;
        private datetime _transtime;

        public void RecordTrans()
        {
            set { _transid = value; }
            set { _transamount = value; }
            set { _transtime = value; }
        }

        public TransDetails()
        {
            return _transid;
            return _transamount;
            return _transtime;
        }
    }
}