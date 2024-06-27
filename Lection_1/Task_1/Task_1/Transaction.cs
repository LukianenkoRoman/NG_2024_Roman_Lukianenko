using System;

namespace Task_1 
{
    public class Transaction
    {
        public int TransId;
        public float TransAmount;
        public int TransTime;

        public void RecordTrans(int transId, float transAmount, int transTime)
        {
            TransId = transId;
            TransAmount = transAmount;
            TransTime = transTime;
        }

        public (int TransId, float TransAmount, int TransTime) TransDetails()
        {
            return (TransId, TransAmount, TransTime);
        }
    }
}