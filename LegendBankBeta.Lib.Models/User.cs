using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LegendBankBeta.Lib.Models
{
    //User Class and properties
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [EmailAddress] [Required]
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

    }
}
