using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LegendBankBeta.Lib.Models
{
    //Transaction Class and properties
    public class Transaction
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Notes { get; set; }
        public string Type { get; set; }
        public Account Account { get; set; }
        public string AccountId { get; set; }
    }
}
