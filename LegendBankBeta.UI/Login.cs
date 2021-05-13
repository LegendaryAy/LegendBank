using LegendBankBeta.Lib.Commons;
using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendBankBeta.UI
{
    public partial class Login : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly LegendBankContext _context;

        public Login(IAuthRepository authRepository, IUserRepository userRepository, IAccountRepository accountRepository, LegendBankContext context)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _context = context;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  Exits Application
        /// </summary>
        private void ExitLink_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  Register Form
        /// </summary>
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register newR = new Register(_authRepository, _userRepository, _accountRepository, _context);
            newR.Show();
        }

        /// <summary>
        /// User Login
        /// </summary>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            try
            {
                _authRepository.Login(email, password);
                MessageBox.Show("Login Successful");
                this.Hide();
                SelectAccount select = new SelectAccount(_authRepository, _userRepository, _accountRepository, _context);
                select.Show();


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }
    }
}
