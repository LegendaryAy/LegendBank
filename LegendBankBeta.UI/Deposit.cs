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
    public partial class Deposit : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly LegendBankContext _context;
        public Deposit(IAuthRepository authRepository,IUserRepository userRepository, IAccountRepository accountRepository, LegendBankContext context)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _context = context;
        }

        /// <summary>
        /// Deposit
        /// </summary>
        private void depositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var account = Datalog.loggedAcct[0];
                var deposit = Decimal.Parse(depositAmount.Text);
                var m = _accountRepository.Deposit(account, deposit);
                MessageBox.Show(m);
                DashBoard s = new DashBoard(_authRepository, _userRepository, _accountRepository, _context);
                s.accountBalance.Text = "N" + _accountRepository.GetBalance(account).ToString();
                depositAmount.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
