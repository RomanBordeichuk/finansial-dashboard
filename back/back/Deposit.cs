﻿namespace back
{
    record DepositId(int id);
    record DepositJson(int id, double amount);
    record DepositBalanceJson(
        List<DepositJson> deposits, BalanceJson balance);

    public class Deposit
    {
        private int id;
        private double amount;

        public int Id
        {
            set { }
            get { return id; }
        }
        public double Amount
        {
            set { }
            get { return amount; }
        }

        public Deposit(double amount)
        {
            this.amount = amount;
        }
    }
}
