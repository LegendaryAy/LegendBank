using LegendBankBeta.Lib.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LegendBankBeta.Lib.Models
{
    //Account Class and properties
    public class Account
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; } = Utilities.GenerateNum();
        public virtual string AccountType { get; set; } 
        public virtual decimal MinimumAmount { get; set; } 
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();

        
    }
}
