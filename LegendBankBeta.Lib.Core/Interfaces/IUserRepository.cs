using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendBankBeta.Lib.Core.Interfaces
{
    public interface IUserRepository //UserRepository Interface
    {
        string CreateCustomer(string firstName, string lastName);

        string CreateUser(string email, byte[] passwordHash, byte[] passwordSalt, string customerId);

        Customer GetCustomerById(string customerId);
        User GetUserById(string userId);
        

    }
}
