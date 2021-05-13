using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendBankBeta.Lib.Core.Interfaces
{
    public interface IAccountRepository //AccountRepository Interface
    {
        
        string CreateAccount(decimal initial, string customerId);
        string CreateCurrentAccount(decimal initial, string customerId);
        Account GetAccountById(string accountId);
        List<Account> GetAccountList(string customerId);
        string Deposit(Account acct, decimal amount);
        string Withdraw(Account acct, decimal amount);
        string Transfer(Account sendAccount, string receiveAccount, decimal amount, string note);
        decimal GetBalance(Account acct);
        List<Transaction> GetAllTransactionsbyAccountId(string accountId);



    }
}
