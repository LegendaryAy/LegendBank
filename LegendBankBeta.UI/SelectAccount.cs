using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LegendBankBeta.UI
{
    public partial class SelectAccount : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly LegendBankContext _context;
        public SelectAccount(IAuthRepository authRepository, IUserRepository userRepository, IAccountRepository accountRepository, LegendBankContext context)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _context = context;
        }

        /// <summary>
        /// Displays all account of user
        /// </summary>
        private void SelectAccount_Load(object sender, EventArgs e)
        {
            var user = Datalog.loggedUser[0];
            var list = _context.Accounts.Where(a => a.Customer.Id == user.Id).ToList();
            foreach (var account in list)
            {
                var details = $"{account.AccountNumber} {account.AccountType}";
                accts.Items.Add(details);
            }
        }
        /// <summary>
        /// Goes to Dashboard
        /// </summary>
        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard db = new DashBoard(_authRepository, _userRepository, _accountRepository, _context);
            db.Show();
        }

        /// <summary>
        /// Selects Account for Operations
        /// </summary>
        private void accts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datalog.loggedAcct.Clear();
            var user = Datalog.loggedUser[0];
            var list = _context.Accounts.Where(a => a.Customer.Id == user.Id).ToList();
            var selected = accts.SelectedIndex;
            Datalog.loggedAcct.Add(list[selected]);
        }
    }
}
