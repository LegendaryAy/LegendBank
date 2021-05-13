
namespace LegendBankBeta.UI
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.Display = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.newAccount = new System.Windows.Forms.Button();
            this.statement = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.accountBalance = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.Controls.Add(this.label1);
            this.Display.Controls.Add(this.pictureBox2);
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Location = new System.Drawing.Point(329, 185);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(799, 590);
            this.Display.TabIndex = 6;
            this.Display.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(65, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Legend Bank";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(256, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.newAccount);
            this.panel1.Controls.Add(this.statement);
            this.panel1.Controls.Add(this.transfer);
            this.panel1.Controls.Add(this.withdraw);
            this.panel1.Controls.Add(this.deposit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 590);
            this.panel1.TabIndex = 5;
            // 
            // logOut
            // 
            this.logOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(0, 486);
            this.logOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(329, 108);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "LogOut";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // newAccount
            // 
            this.newAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.newAccount.FlatAppearance.BorderSize = 0;
            this.newAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newAccount.ForeColor = System.Drawing.Color.White;
            this.newAccount.Location = new System.Drawing.Point(0, 388);
            this.newAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(329, 98);
            this.newAccount.TabIndex = 5;
            this.newAccount.Text = "Create Another Account";
            this.newAccount.UseVisualStyleBackColor = true;
            this.newAccount.Click += new System.EventHandler(this.newAccount_Click);
            // 
            // statement
            // 
            this.statement.Dock = System.Windows.Forms.DockStyle.Top;
            this.statement.FlatAppearance.BorderSize = 0;
            this.statement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statement.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statement.ForeColor = System.Drawing.Color.White;
            this.statement.Location = new System.Drawing.Point(0, 288);
            this.statement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statement.Name = "statement";
            this.statement.Size = new System.Drawing.Size(329, 100);
            this.statement.TabIndex = 4;
            this.statement.Text = "Statement of Account";
            this.statement.UseVisualStyleBackColor = true;
            this.statement.Click += new System.EventHandler(this.statement_Click);
            // 
            // transfer
            // 
            this.transfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.transfer.FlatAppearance.BorderSize = 0;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transfer.ForeColor = System.Drawing.Color.White;
            this.transfer.Location = new System.Drawing.Point(0, 198);
            this.transfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(329, 90);
            this.transfer.TabIndex = 3;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // withdraw
            // 
            this.withdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.withdraw.FlatAppearance.BorderSize = 0;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.Location = new System.Drawing.Point(0, 98);
            this.withdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(329, 100);
            this.withdraw.TabIndex = 2;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.deposit.FlatAppearance.BorderSize = 0;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit.ForeColor = System.Drawing.Color.White;
            this.deposit.Location = new System.Drawing.Point(0, 0);
            this.deposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(329, 98);
            this.deposit.TabIndex = 1;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.refreshButton);
            this.header.Controls.Add(this.accountBalance);
            this.header.Controls.Add(this.accountNumber);
            this.header.Controls.Add(this.userName);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1128, 185);
            this.header.TabIndex = 4;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.refreshButton.Location = new System.Drawing.Point(882, 95);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 41);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // accountBalance
            // 
            this.accountBalance.AutoSize = true;
            this.accountBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.accountBalance.Location = new System.Drawing.Point(868, 42);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(235, 36);
            this.accountBalance.TabIndex = 3;
            this.accountBalance.Text = "Account Balance";
            // 
            // accountNumber
            // 
            this.accountNumber.AutoSize = true;
            this.accountNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.accountNumber.Location = new System.Drawing.Point(149, 94);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(244, 36);
            this.accountNumber.TabIndex = 2;
            this.accountNumber.Text = "Account Number";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.userName.Location = new System.Drawing.Point(149, 42);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(210, 36);
            this.userName.TabIndex = 1;
            this.userName.Text = "Welcome User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 775);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button newAccount;
        private System.Windows.Forms.Button statement;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button refreshButton;
        public System.Windows.Forms.Label accountBalance;
        private System.Windows.Forms.Label accountNumber;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}