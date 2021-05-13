
namespace LegendBankBeta.UI
{
    partial class SelectAccount
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
            this.accts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accts
            // 
            this.accts.BackColor = System.Drawing.Color.White;
            this.accts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.accts.FormattingEnabled = true;
            this.accts.Location = new System.Drawing.Point(86, 138);
            this.accts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accts.Name = "accts";
            this.accts.Size = new System.Drawing.Size(632, 40);
            this.accts.TabIndex = 44;
            this.accts.SelectedIndexChanged += new System.EventHandler(this.accts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(291, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Account";
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.continueBtn.FlatAppearance.BorderSize = 0;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continueBtn.ForeColor = System.Drawing.Color.White;
            this.continueBtn.Location = new System.Drawing.Point(86, 250);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(632, 74);
            this.continueBtn.TabIndex = 42;
            this.continueBtn.Text = "CONTINUE";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // SelectAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.continueBtn);
            this.Name = "SelectAccount";
            this.Text = "SelectAccount";
            this.Load += new System.EventHandler(this.SelectAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox accts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continueBtn;
    }
}