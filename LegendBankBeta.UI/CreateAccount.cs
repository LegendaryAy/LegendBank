using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LegendBankBeta.UI
{
    public partial class CreateAccount : UserControl
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly LegendBankContext _context;
        public CreateAccount(IAuthRepository authRepository, IUserRepository userRepository, IAccountRepository accountRepository, LegendBankContext context)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _context = context;
        }

        /// <summary>
        /// creates new Account for existing users
        /// </summary>
        /// <param name="customer"></param>
        public string createAccount(Customer customer)
        {
            var accType = accountType.Items[accountType.SelectedIndex].ToString();
            var initial = Decimal.Parse(initialDeposit.Text);
            if (initial < 0)
            {
                throw new Exception("Invalid amount");
            }
            else if (accType == "Savings")
            {

                if (initial < 1000)
                {
                    throw new Exception("You must Register with N1000 minimum");
                }
                else
                {
                    var account = _accountRepository.CreateAccount(initial, customer.Id);
                    return account;
                }
            }
            else
            {
                var account = _accountRepository.CreateCurrentAccount(initial, customer.Id);
                return account;
            }

        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Logs In User
        /// </summary>
        private void registerBtn_Click(object sender, EventArgs e)
        {
            var user = Datalog.loggedUser[0];
            createAccount(user);
            MessageBox.Show("Account Registered, Choose an account to continue");
            this.Hide();
            SelectAccount select = new SelectAccount(_authRepository, _userRepository, _accountRepository, _context);
            select.Show();
        }
    }
}
