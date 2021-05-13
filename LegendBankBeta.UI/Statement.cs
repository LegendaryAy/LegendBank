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
    public partial class Statement : UserControl
    {
        private readonly IAccountRepository _accountRepository;


        public Statement(IAccountRepository accountRepository)
        {
            InitializeComponent();
            _accountRepository = accountRepository;
        }

        /// <summary>
        /// Gets The Statement of Account 
        /// </summary>
        private void getStatement_Click(object sender, EventArgs e)
        {
            statementView.Items.Clear();
            try
            {
                var account = Datalog.loggedAcct[0];
                var list = _accountRepository.GetAllTransactionsbyAccountId(account.Id);

                foreach (var trans in list)
                {
                    var row = new string[] { trans.Date.ToString(), trans.Type, account.AccountNumber, trans.Amount.ToString(), trans.Notes };
                    var lvi = new ListViewItem(row);
                    statementView.Items.Add(lvi);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
