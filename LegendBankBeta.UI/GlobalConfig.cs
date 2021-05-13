using System;
using System.Collections.Generic;
using System.Text;
using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Core.Repositories;
using LegendBankBeta.Lib.Data;
using Microsoft.EntityFrameworkCore;

namespace LegendBankBeta.UI
{
    public class GlobalConfig
    {
        public static IAccountRepository IAccountInstance { get; set; }
        public static IUserRepository IUserInstance { get; set; }
        public static IAuthRepository IAuthInstance { get; set; }
        public static LegendBankContext context { get; set; }


        /// <summary>
        /// Creates new instance of dependency classes 
        /// </summary>
        public static void AddInstance()
        {
            //var options = new DbContextOptionsBuilder<LegendBankContext>().UseSqlite(@"Data Source=C:\Users\hp\Documents\Projects\LegendBankBeta\LegendBankBeta.Lib.Data\LegendBank.db").Options;
            context = new LegendBankContext();
            IAccountInstance = new AccountRepository(context);
            IUserInstance = new UserRepository(context);
            IAuthInstance = new AuthRepository(context, IUserInstance);

        }
        
        /// <summary>
        /// Removes the instance 
        /// </summary>
        public static void RemoveInstance()
        {
            context = null;
            IAccountInstance = null;
            IUserInstance = null;
            IAuthInstance = null;
        }
    }
}
