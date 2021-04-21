namespace CasinoManagement
{
    partial class RegisterUserPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlManageRegis = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRegisManager = new System.Windows.Forms.Button();
            this.btnRegisDealer = new System.Windows.Forms.Button();
            this.pnlGamblerRegis = new System.Windows.Forms.Panel();
            this.pnlManageRegis.SuspendLayout();
            this.pnlGamblerRegis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(179, 107);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(132, 22);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(179, 140);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPass.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(87, 187);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 28);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register Gambler";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(4, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlManageRegis
            // 
            this.pnlManageRegis.Controls.Add(this.btnReturn);
            this.pnlManageRegis.Controls.Add(this.btnRegisManager);
            this.pnlManageRegis.Controls.Add(this.btnRegisDealer);
            this.pnlManageRegis.Location = new System.Drawing.Point(16, 223);
            this.pnlManageRegis.Margin = new System.Windows.Forms.Padding(4);
            this.pnlManageRegis.Name = "pnlManageRegis";
            this.pnlManageRegis.Size = new System.Drawing.Size(364, 91);
            this.pnlManageRegis.TabIndex = 8;
            this.pnlManageRegis.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(248, 39);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRegisManager
            // 
            this.btnRegisManager.Location = new System.Drawing.Point(71, 39);
            this.btnRegisManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisManager.Name = "btnRegisManager";
            this.btnRegisManager.Size = new System.Drawing.Size(137, 28);
            this.btnRegisManager.TabIndex = 1;
            this.btnRegisManager.Text = "Register Manager";
            this.btnRegisManager.UseVisualStyleBackColor = true;
            this.btnRegisManager.Click += new System.EventHandler(this.btnRegisManager_Click);
            // 
            // btnRegisDealer
            // 
            this.btnRegisDealer.Location = new System.Drawing.Point(71, 4);
            this.btnRegisDealer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisDealer.Name = "btnRegisDealer";
            this.btnRegisDealer.Size = new System.Drawing.Size(123, 28);
            this.btnRegisDealer.TabIndex = 0;
            this.btnRegisDealer.Text = "Register Dealer";
            this.btnRegisDealer.UseVisualStyleBackColor = true;
            this.btnRegisDealer.Click += new System.EventHandler(this.btnRegisDealer_Click);
            // 
            // pnlGamblerRegis
            // 
            this.pnlGamblerRegis.Controls.Add(this.btnCancel);
            this.pnlGamblerRegis.Location = new System.Drawing.Point(260, 172);
            this.pnlGamblerRegis.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGamblerRegis.Name = "pnlGamblerRegis";
            this.pnlGamblerRegis.Size = new System.Drawing.Size(120, 55);
            this.pnlGamblerRegis.TabIndex = 9;
            // 
            // RegisterUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 362);
            this.Controls.Add(this.pnlGamblerRegis);
            this.Controls.Add(this.pnlManageRegis);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterUserPage";
            this.Text = "RegisterUserPage";
            this.pnlManageRegis.ResumeLayout(false);
            this.pnlGamblerRegis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlManageRegis;
        private System.Windows.Forms.Button btnRegisManager;
        private System.Windows.Forms.Button btnRegisDealer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlGamblerRegis;
    }
}