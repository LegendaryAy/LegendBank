
namespace LegendBankBeta.UI
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.label2 = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.depositAmount = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(217, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 40);
            this.label2.TabIndex = 41;
            this.label2.Text = "Enter Deposit Amount";
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.depositBtn.FlatAppearance.BorderSize = 0;
            this.depositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositBtn.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.ForeColor = System.Drawing.Color.White;
            this.depositBtn.Location = new System.Drawing.Point(89, 396);
            this.depositBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(632, 74);
            this.depositBtn.TabIndex = 40;
            this.depositBtn.Text = "CONTINUE";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // depositAmount
            // 
            this.depositAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(219)))));
            this.depositAmount.Location = new System.Drawing.Point(167, 288);
            this.depositAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(546, 32);
            this.depositAmount.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(77, 338);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 1);
            this.panel5.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositAmount);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Deposit";
            this.Size = new System.Drawing.Size(799, 590);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.TextBox depositAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
