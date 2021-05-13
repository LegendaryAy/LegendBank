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
    public partial class DashBoard : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly LegendBankContext _context;
        public DashBoard(IAuthRepository authRepository, IUserRepository userRepository, IAccountRepository accountRepository, LegendBankContext context)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _context = context;
            changeDetails();
        }

        /// <summary>
        /// Main control for the UserControl forms
        /// </summary>
        /// <param name="control"></param>
        public void showControl(Control control)
        {
            Display.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Display.Controls.Add(control);
        }
        
        /// <summary>
        /// Changes the details on the dashboard to the user's
        /// </summary>
        public void changeDetails()
        {
            var user = Datalog.loggedUser[0];
            userName.Text = $"{user.FirstName} {user.LastName}";
            var account = Datalog.loggedAcct[0];
            accountNumber.Text = account.AccountNumber;
            accountBalance.Text = "N" + _accountRepository.GetBalance(account).ToString();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {

        }
        //Deposit usercontrol
        private void deposit_Click(object sender, EventArgs e)
        {
            Deposit newdep = new Deposit(_authRepository, _userRepository, _accountRepository, _context);
            showControl(newdep);
        }

        //Withdrawal usercontrol
        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw newWith = new Withdraw(_accountRepository);
            showControl(newWith);
        }

        //Transfer usercontrol
        private void transfer_Click(object sender, EventArgs e)
        {
            Transfer newTrans = new Transfer(_accountRepository);
            showControl(newTrans);
        }

        //statement of account usercontrol
        private void statement_Click(object sender, EventArgs e)
        {
            Statement newTrans = new Statement(_accountRepository);
            showControl(newTrans);
        }

        //Log out button
        private void logOut_Click(object sender, EventArgs e)
        {
            var message = _authRepository.Logout();
            MessageBox.Show(message);
            this.Hide();
            Login ls = new Login(_authRepository, _userRepository, _accountRepository, _context);
            ls.Show();
        }
        
        //Create new Account UserControl
        private void newAccount_Click(object sender, EventArgs e)
        {
            CreateAccount create = new CreateAccount(_authRepository,_userRepository, _accountRepository, _context);
            showControl(create);
        }

        //Refresh button
        private void refreshButton_Click(object sender, EventArgs e)
        {
            var acct = Datalog.loggedAcct[0];
            var temp = "N" + _accountRepository.GetBalance(acct).ToString();
            accountBalance.Text = temp;
        }
    }
}
