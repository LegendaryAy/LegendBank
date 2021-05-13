using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendBankBeta.Lib.Data
{
    public static class Datalog
    {
        /// <summary>
        /// Stores the user logged in in the app 
        /// </summary>
        public static List<Customer> loggedUser { get; set; } = new List<Customer>();

        /// <summary>
        /// Stores the account logged in in the app
        /// </summary>
        public static List<Account> loggedAcct { get; set; } = new List<Account>();
    }
}
