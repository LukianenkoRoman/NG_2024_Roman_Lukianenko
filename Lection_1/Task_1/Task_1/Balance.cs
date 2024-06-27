using System;

namespace Task_1
{
    public class Balance
    {
        private int _BalanceId;
        private float _BalanceAmount;

        public Balance(int balanceId)
        {
            _BalanceId = balanceId;
            _BalanceAmount = 0; 
        }

        public float GetBalance()
        {
            return _BalanceAmount;
        }

        public void UpdateBalance(float amount)
        {
            _BalanceAmount += amount;
        }
    }
}