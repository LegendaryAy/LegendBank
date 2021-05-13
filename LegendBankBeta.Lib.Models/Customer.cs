using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LegendBankBeta.Lib.Models
{
    //Customer Class and properties
    public class Customer
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public User User { get; set; }
        public ICollection<Account> Accounts { get; set; } = new HashSet<Account>();
    }
}
