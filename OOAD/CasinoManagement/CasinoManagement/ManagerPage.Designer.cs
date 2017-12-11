namespace CasinoManagement
{
    partial class ManagerPage
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
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFlagGamblers = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUnflag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(33, 37);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(94, 23);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.Location = new System.Drawing.Point(156, 36);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(88, 23);
            this.btnEditSchedule.TabIndex = 1;
            this.btnEditSchedule.Text = "Edit Schedule";
            this.btnEditSchedule.UseVisualStyleBackColor = true;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Location = new System.Drawing.Point(156, 83);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(103, 23);
            this.btnViewMessages.TabIndex = 2;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Flagged Gamblers";
            // 
            // lstFlagGamblers
            // 
            this.lstFlagGamblers.FormattingEnabled = true;
            this.lstFlagGamblers.Location = new System.Drawing.Point(33, 155);
            this.lstFlagGamblers.Name = "lstFlagGamblers";
            this.lstFlagGamblers.Size = new System.Drawing.Size(183, 134);
            this.lstFlagGamblers.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(369, 304);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUnflag
            // 
            this.btnUnflag.Location = new System.Drawing.Point(33, 304);
            this.btnUnflag.Name = "btnUnflag";
            this.btnUnflag.Size = new System.Drawing.Size(75, 23);
            this.btnUnflag.TabIndex = 6;
            this.btnUnflag.Text = "Unflag";
            this.btnUnflag.UseVisualStyleBackColor = true;
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 393);
            this.Controls.Add(this.btnUnflag);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lstFlagGamblers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnEditSchedule);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "ManagerPage";
            this.Text = "Manager Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFlagGamblers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUnflag;
    }
}