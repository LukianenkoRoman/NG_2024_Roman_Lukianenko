using System;

namespace Task_1
{
    public class Balance
    {
        private int _balanceId;
        private float _balanceAmount;

        public Balance(int balanceId)
        {
            _balanceId = balanceId;
            _balanceAmount = 0; 
        }

        public float GetBalance()
        {
            return _balanceAmount;
        }

        public void UpdateBalance(float amount)
        {
            _balanceAmount += amount;
        }
    }
}