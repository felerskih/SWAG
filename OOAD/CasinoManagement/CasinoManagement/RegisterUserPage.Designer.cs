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
            this.lblValid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(142, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(255, 87);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(30, 13);
            this.lblValid.TabIndex = 3;
            this.lblValid.Text = "Valid";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(65, 152);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register Gambler";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
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
            this.pnlManageRegis.Location = new System.Drawing.Point(12, 181);
            this.pnlManageRegis.Name = "pnlManageRegis";
            this.pnlManageRegis.Size = new System.Drawing.Size(273, 74);
            this.pnlManageRegis.TabIndex = 8;
            this.pnlManageRegis.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(186, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRegisManager
            // 
            this.btnRegisManager.Location = new System.Drawing.Point(53, 32);
            this.btnRegisManager.Name = "btnRegisManager";
            this.btnRegisManager.Size = new System.Drawing.Size(103, 23);
            this.btnRegisManager.TabIndex = 1;
            this.btnRegisManager.Text = "Register Manager";
            this.btnRegisManager.UseVisualStyleBackColor = true;
            // 
            // btnRegisDealer
            // 
            this.btnRegisDealer.Location = new System.Drawing.Point(53, 3);
            this.btnRegisDealer.Name = "btnRegisDealer";
            this.btnRegisDealer.Size = new System.Drawing.Size(92, 23);
            this.btnRegisDealer.TabIndex = 0;
            this.btnRegisDealer.Text = "Register Dealer";
            this.btnRegisDealer.UseVisualStyleBackColor = true;
            // 
            // pnlGamblerRegis
            // 
            this.pnlGamblerRegis.Controls.Add(this.btnCancel);
            this.pnlGamblerRegis.Location = new System.Drawing.Point(195, 140);
            this.pnlGamblerRegis.Name = "pnlGamblerRegis";
            this.pnlGamblerRegis.Size = new System.Drawing.Size(90, 45);
            this.pnlGamblerRegis.TabIndex = 9;
            // 
            // RegisterUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 294);
            this.Controls.Add(this.pnlGamblerRegis);
            this.Controls.Add(this.pnlManageRegis);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterUserPage";
            this.Text = "RegisterUserPage";
            this.Load += new System.EventHandler(this.RegisterUserPage_Load);
            this.pnlManageRegis.ResumeLayout(false);
            this.pnlGamblerRegis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlManageRegis;
        private System.Windows.Forms.Button btnRegisManager;
        private System.Windows.Forms.Button btnRegisDealer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlGamblerRegis;
    }
}