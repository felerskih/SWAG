namespace CasinoManagement
{
    partial class DealerPage
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
            this.listBoxGamblers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmTake = new System.Windows.Forms.Button();
            this.btnConfirmGive = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtGiveFunds = new System.Windows.Forms.TextBox();
            this.txtRemoveFunds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFunds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxGamblers
            // 
            this.listBoxGamblers.FormattingEnabled = true;
            this.listBoxGamblers.ItemHeight = 16;
            this.listBoxGamblers.Location = new System.Drawing.Point(16, 133);
            this.listBoxGamblers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGamblers.Name = "listBoxGamblers";
            this.listBoxGamblers.Size = new System.Drawing.Size(304, 228);
            this.listBoxGamblers.TabIndex = 0;
            this.listBoxGamblers.SelectedIndexChanged += new System.EventHandler(this.listBoxGamblers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Current Active Gamblers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Give Funds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remove Funds:";
            // 
            // btnConfirmTake
            // 
            this.btnConfirmTake.Location = new System.Drawing.Point(671, 170);
            this.btnConfirmTake.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmTake.Name = "btnConfirmTake";
            this.btnConfirmTake.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmTake.TabIndex = 5;
            this.btnConfirmTake.Text = "Confirm";
            this.btnConfirmTake.UseVisualStyleBackColor = true;
            this.btnConfirmTake.Click += new System.EventHandler(this.btnConfirmTake_Click);
            // 
            // btnConfirmGive
            // 
            this.btnConfirmGive.Location = new System.Drawing.Point(671, 130);
            this.btnConfirmGive.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmGive.Name = "btnConfirmGive";
            this.btnConfirmGive.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmGive.TabIndex = 6;
            this.btnConfirmGive.Text = "Confirm";
            this.btnConfirmGive.UseVisualStyleBackColor = true;
            this.btnConfirmGive.Click += new System.EventHandler(this.btnConfirmGive_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(16, 388);
            this.btnFlag.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(100, 28);
            this.btnFlag.TabIndex = 7;
            this.btnFlag.Text = "Flag";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(391, 299);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(133, 28);
            this.btnViewSchedule.TabIndex = 8;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Location = new System.Drawing.Point(556, 299);
            this.btnViewMessages.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(139, 28);
            this.btnViewMessages.TabIndex = 9;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(528, 410);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtGiveFunds
            // 
            this.txtGiveFunds.Location = new System.Drawing.Point(508, 133);
            this.txtGiveFunds.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiveFunds.Name = "txtGiveFunds";
            this.txtGiveFunds.Size = new System.Drawing.Size(132, 22);
            this.txtGiveFunds.TabIndex = 11;
            // 
            // txtRemoveFunds
            // 
            this.txtRemoveFunds.Location = new System.Drawing.Point(508, 172);
            this.txtRemoveFunds.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemoveFunds.Name = "txtRemoveFunds";
            this.txtRemoveFunds.Size = new System.Drawing.Size(132, 22);
            this.txtRemoveFunds.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gambler Funds:";
            // 
            // lblFunds
            // 
            this.lblFunds.AutoSize = true;
            this.lblFunds.Location = new System.Drawing.Point(519, 98);
            this.lblFunds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(44, 17);
            this.lblFunds.TabIndex = 15;
            this.lblFunds.Text = "$0.00";
            // 
            // DealerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 491);
            this.Controls.Add(this.lblFunds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemoveFunds);
            this.Controls.Add(this.txtGiveFunds);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnConfirmGive);
            this.Controls.Add(this.btnConfirmTake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGamblers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DealerPage";
            this.Text = "DealerPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DealerPage_FormClosed);
            this.Load += new System.EventHandler(this.DealerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGamblers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmTake;
        private System.Windows.Forms.Button btnConfirmGive;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtGiveFunds;
        private System.Windows.Forms.TextBox txtRemoveFunds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFunds;
    }
}