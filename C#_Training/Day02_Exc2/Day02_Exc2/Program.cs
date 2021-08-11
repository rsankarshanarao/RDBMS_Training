/*Create a class called BankAccount and have default constructor to take balance
as 500 and another parameterized to take other than 500.
*/
using System;

namespace Day02_Exc2
{
    /// <summary>
    /// Class Bank Account
    /// </summary>
    class BankAccount
    {
        long Balance;
        /// <summary>
        /// Constructor to Create a Bank Account with default Balance 500
        /// </summary>
        public BankAccount()
        {
            Balance = 500;
        }
        /// <summary>
        /// Constructor to Create a Bank Account with Balance Input
        /// </summary>
        /// <param name="bal">Balance</param>
        public BankAccount(int bal)
        {
            Balance = bal;
        }

        public long FetchBalance()
        {
            return Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object Bankaccount with no parameters " +
                "as input using BankAccount b = new BankAccount()");
            BankAccount b = new BankAccount();
            Console.WriteLine("Balance is: " + b.FetchBalance());
            Console.WriteLine("");
            Console.WriteLine("Creating object Bankaccount with parameters 10000 for Balance " +
                "as input using BankAccount b = new BankAccount(10000)");
            BankAccount b1= new BankAccount(10000);
            Console.WriteLine("Balance is: " + b1.FetchBalance());
        }
    }
}
