using LegendBankBeta.Lib.Commons;
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
    public partial class Register : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly LegendBankContext _context;
        public Register(IAuthRepository authRepository, IUserRepository userRepository, IAccountRepository accountRepository, LegendBankContext context)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _context = context;
        }
        /// <summary>
        /// Registers Customer
        /// </summary>
        private string[] Registration()
        {
            var firstName = txtFname.Text;
            var lastName = txtLname.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var result = Utilities.GenerateHash(password);
            var accType = accountType.Items[accountType.SelectedIndex].ToString();
            var initial = Decimal.Parse(initialDeposit.Text);
            if (Utilities.validateEmail(email) == false)
            {
                throw new Exception("Email not Valid");
            }
            else if (initial < 0)
            {
                throw new Exception("Invalid Amount");
            }
            else
            {
                if (accType == "Savings")
                {
                    if (initial < 1000)
                    {
                        throw new Exception("You must Register with N1000 minimum");
                    }
                    else
                    {
                        var customerId = _authRepository.Register(firstName, lastName, email, result[0], result[1]);
                        var accountId = _accountRepository.CreateAccount(initial, customerId);
                        MessageBox.Show("Registration Successful");
                        return new string[] { customerId, accountId };
                    }
                }
                else
                {
                    var customerId = _authRepository.Register(firstName, lastName, email, result[0], result[1]);
                    var accountId = _accountRepository.CreateCurrentAccount(initial, customerId);
                    MessageBox.Show("Registration Successful");
                    return new string[] { customerId, accountId };
                }
            }
        }

        /// <summary>
        /// Logs In newly created account
        /// </summary>
        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Datalog.loggedAcct.Clear();
                Datalog.loggedUser.Clear();
                var details = Registration();
                var customer = _userRepository.GetCustomerById(details[0]);
                var account = _accountRepository.GetAccountById(details[1]);
                Datalog.loggedUser.Add(customer);
                Datalog.loggedAcct.Add(account);
                this.Hide();
                DashBoard lg = new DashBoard(_authRepository, _userRepository, _accountRepository, _context);
                lg.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void accountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
