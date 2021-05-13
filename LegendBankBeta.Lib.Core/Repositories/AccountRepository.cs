using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendBankBeta.Lib.Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly LegendBankContext _context;

        public AccountRepository(LegendBankContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates new Savings Account
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <param name="customerId"></param>
        public string CreateAccount(decimal initialBalance, string customerId)
        {
            var account = new Account
            {
                Balance = initialBalance,
                CustomerId = customerId,
                AccountType = "Savings Account",
                MinimumAmount = 1000.00m
            };
            _context.Accounts.Add(account);
            _context.SaveChanges();
            var acct = GetAccountById(account.Id);
            var trans = new Transaction
            {
                Amount = initialBalance,
                Notes = "Initial Deposit",
                Type = acct.AccountType,
                AccountId = acct.Id
            };
            _context.Transactions.Add(trans);
            _context.SaveChanges();
            return account.Id;
        }

        /// <summary>
        /// Creates new Current Account 
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <param name="customerId"></param>
        public string CreateCurrentAccount(decimal initialBalance, string customerId)
        {
            var account = new Account
            {
                Balance = initialBalance,
                CustomerId = customerId,
                AccountType = "Current Account",
                MinimumAmount = 0.00m
            };
            _context.Accounts.Add(account);
            _context.SaveChanges();
            var acct = GetAccountById(account.Id);
            var trans = new Transaction
            {
                Amount = initialBalance,
                Notes = "Initial Deposit",
                Type = acct.AccountType,
                AccountId = acct.Id
            };
            _context.Transactions.Add(trans);
            _context.SaveChanges();
            return account.Id;
        }

        /// <summary>
        /// Deposit amount into account and logs the transaction in the database
        /// </summary>
        /// <param name="acct"></param>
        /// <param name="amount"></param>
        public string Deposit(Account acct, decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException("Invalid Amount");
            }
            else
            {
                var trans = new Transaction
                {
                    Amount = amount,
                    Notes = "Deposit",
                    Type = acct.AccountType,
                    AccountId = acct.Id
                };
                _context.Transactions.Add(trans);
                _context.SaveChanges();
            }
            return "Transaction Successful";

        }

        /// <summary>
        /// Gets Account By Account ID
        /// </summary>
        /// <param name="accountId"></param>
        public Account GetAccountById(string accountId)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Id == accountId);
            return account;
        }

        /// <summary>
        /// Gets the list of accounts owned by one customer using customer ID
        /// </summary>
        /// <param name="customerId"></param>
        public List<Account> GetAccountList(string customerId)
        {
            var accounts = _context.Accounts.Select(a => a).ToList();
            return accounts;
        }

        /// <summary>
        /// Gets the list of transactions in one account using account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public List<Transaction> GetAllTransactionsbyAccountId(string accountId)
        {
            var transactions = _context.Transactions.Where(t => t.AccountId == accountId).ToList();
            return transactions;
        }

        /// <summary>
        /// Gets the balance of the account
        /// </summary>
        /// <param name="acct"></param>
        public decimal GetBalance(Account acct)
        {
            var balance = 0m;
            var transactions = _context.Transactions.Where(t => t.AccountId == acct.Id).ToList();
            foreach (var item in transactions)
            {
                balance += item.Amount;
            }
            return balance;
        }

        /// <summary>
        /// Checks if Transfer Account is Valid, Transfers amount and logs the transaction in the database     
        /// </summary>
        /// <param name="sendAccount"></param>
        /// <param name="receiveAccount"></param>
        /// <param name="amount"></param>
        /// <param name="note"></param>
        public string Transfer(Account sendAccount, string receiveAccount, decimal amount, string note)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.AccountNumber == receiveAccount);
            var balance = GetBalance(sendAccount);
            if (amount < 0)
            {
                throw new InvalidOperationException("Invalid Amount");
            }
            else if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }
            else if (balance - amount < sendAccount.MinimumAmount)
            {
                throw new InvalidOperationException("You have reached the minimum amount allowed on your account");
            }
            else
            {
                if (receiveAccount == account.AccountNumber)
                {
                    var sendTrans = new Transaction
                    {
                        Amount = -amount,
                        Notes = note,
                        Type = sendAccount.AccountType,
                        AccountId = sendAccount.Id
                    };
                    var receiveTrans = new Transaction
                    {
                        Amount = amount,
                        Notes = note,
                        Type = account.AccountType,
                        AccountId = account.Id
                    };
                    _context.Transactions.AddRange(sendTrans, receiveTrans);
                    _context.SaveChanges();
                    var message = "Transaction sucessful";
                    return message;
                }
                else
                {
                    throw new InvalidOperationException("The account is not registed with this bank");
                }
            }
        }

        /// <summary>
        /// Withdraw amount from account and logs the transaction in the database
        /// </summary>
        /// <param name="acct"></param>
        /// <param name="amount"></param>
        public string Withdraw(Account acct, decimal amount)
        {
            var balance = GetBalance(acct);
            if (amount < 0)
            {
                throw new InvalidOperationException("Invalid Amount");
            }
            else if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }
            else
            {
                if (balance - amount < acct.MinimumAmount)
                {
                    throw new InvalidOperationException("You have reached the minimum amount allowed on your account");
                }
                else
                {
                    var trans = new Transaction
                    {
                        Amount = -amount,
                        Notes = "Withdrawal",
                        Type = acct.AccountType,
                        AccountId = acct.Id
                    };
                    _context.Transactions.Add(trans);
                    _context.SaveChanges();
                }
            }

            return "Transaction Successful";
        }
    }
}
