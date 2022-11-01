using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    enum TypeOfAccounts
    {
        Checking, 
        Savings,
        CD,
        Loan
    } 
    /// <summary>
    /// This represents a bank account where you can withdraw or deposit money into the account
    /// </summary>
    internal class Account
    {
        private static int lastAccountNumber = 0;
        #region Properties
        /// <summary>
        /// Unique account number
        /// </summary>
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; private set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructor 
        public Account()
        {
            // lastAccountNumber += 1;
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion


    }
}