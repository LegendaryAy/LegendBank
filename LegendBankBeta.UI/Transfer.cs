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
    public partial class Transfer : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        public Transfer(IAccountRepository accountRepository)
        {
            InitializeComponent();
            _accountRepository = accountRepository;
        }

        /// <summary>
        /// Transfer
        /// </summary>
        private void transferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var sendAcc = Datalog.loggedAcct[0];
                var receiveAcc = accNo.Text;
                var amount = Decimal.Parse(transferAmount.Text);
                var notes = note.Text;
                var me = _accountRepository.Transfer(sendAcc, receiveAcc, amount, notes);
                MessageBox.Show(me);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            accNo.Text = "";
            transferAmount.Text = "";
            note.Text = "";
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
