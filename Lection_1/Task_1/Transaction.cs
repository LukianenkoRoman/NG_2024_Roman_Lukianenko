using System;

namespace Task_1 
{
    public class Transaction
    {
        private int _transId;
        private float _transAmount;
        private int _transTime;

        public void RecordTrans(int transId, float transAmount, int transTime)
        {
            _transId = transId;
            _transAmount = transAmount;
            _transTime = transTime;
        }

        public (int TransId, float TransAmount, int TransTime) TransDetails()
        {
            return (_transId, _transAmount, _transTime);
        }
    }
}