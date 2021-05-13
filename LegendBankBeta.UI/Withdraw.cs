using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LegendBankBeta.UI
{
    public partial class Withdraw : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        public Withdraw(IAccountRepository accountRepository)
        {
            InitializeComponent();
            _accountRepository = accountRepository;
        }

        /// <summary>
        /// Withdrawal
        /// </summary>
        private void depositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var account = Datalog.loggedAcct[0];
                var amount = Decimal.Parse(withdrawAmount.Text);
                var me = _accountRepository.Withdraw(account, amount);
                MessageBox.Show(me);
                withdrawAmount.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
