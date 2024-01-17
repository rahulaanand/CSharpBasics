using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication
{
    public class AddBankAccount
    {
        public string AccNumber { get; }
        public string User { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in Alltransactions)
                {
                    balance += item.amount;
                }

                return balance;
            }
        }
        private static int AccountNumber = 123456;
        public AddBankAccount(string name, decimal intialbalance)
        {
            this.User = name;
            MakeDeposit(intialbalance, DateTime.Today, "Initial balance");
            this.AccNumber = AccountNumber.ToString();
            AccountNumber++;
        }

        private List<Transaction> Alltransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid Amount");
            }
            var deposit = new Transaction(amount, date, note);
            Alltransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid Amount");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient Balance");
            }
            var withdrawal = new Transaction(-amount, date, note);
            Alltransactions.Add(withdrawal);
        }
    }
}
