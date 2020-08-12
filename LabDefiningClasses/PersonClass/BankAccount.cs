using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass
{
   public class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }




    }

}
