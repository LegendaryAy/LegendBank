using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendBankBeta.Lib.Core.Interfaces
{
    public interface IAuthRepository //Authentication Repository Interface
    {
        string Register(string firstName, string lastName, string email, byte[] passwordhash, byte[] passwordsalt);
        bool Login(string email, string password);
        string Logout();
    }
}
