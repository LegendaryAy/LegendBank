
namespace LegendBankBeta.UI
{
    partial class Statement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getStatement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statementView = new System.Windows.Forms.ListView();
            this.transdate = new System.Windows.Forms.ColumnHeader();
            this.accountType = new System.Windows.Forms.ColumnHeader();
            this.accountNo = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.Notes = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // getStatement
            // 
            this.getStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.getStatement.FlatAppearance.BorderSize = 0;
            this.getStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getStatement.ForeColor = System.Drawing.Color.White;
            this.getStatement.Location = new System.Drawing.Point(544, 19);
            this.getStatement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getStatement.Name = "getStatement";
            this.getStatement.Size = new System.Drawing.Size(229, 59);
            this.getStatement.TabIndex = 5;
            this.getStatement.Text = "Get Statement";
            this.getStatement.UseVisualStyleBackColor = false;
            this.getStatement.Click += new System.EventHandler(this.getStatement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statement of Account";
            // 
            // statementView
            // 
            this.statementView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transdate,
            this.accountType,
            this.accountNo,
            this.amount,
            this.Notes});
            this.statementView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statementView.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statementView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.statementView.GridLines = true;
            this.statementView.HideSelection = false;
            this.statementView.Location = new System.Drawing.Point(0, 107);
            this.statementView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statementView.Name = "statementView";
            this.statementView.Size = new System.Drawing.Size(799, 483);
            this.statementView.TabIndex = 3;
            this.statementView.UseCompatibleStateImageBehavior = false;
            this.statementView.View = System.Windows.Forms.View.Details;
            // 
            // transdate
            // 
            this.transdate.Text = "Date";
            this.transdate.Width = 150;
            // 
            // accountType
            // 
            this.accountType.Text = "Account Type";
            this.accountType.Width = 170;
            // 
            // accountNo
            // 
            this.accountNo.Text = "Account Number";
            this.accountNo.Width = 170;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 150;
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            this.Notes.Width = 150;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.getStatement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statementView);
            this.Name = "Statement";
            this.Size = new System.Drawing.Size(799, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getStatement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView statementView;
        private System.Windows.Forms.ColumnHeader transdate;
        private System.Windows.Forms.ColumnHeader accountType;
        private System.Windows.Forms.ColumnHeader accountNo;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader Notes;
    }
}
