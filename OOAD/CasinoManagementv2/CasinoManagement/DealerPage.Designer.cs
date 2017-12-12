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
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmTake = new System.Windows.Forms.Button();
            this.btnConfirmGive = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtGiveFunds = new System.Windows.Forms.TextBox();
            this.txtRemoveFunds = new System.Windows.Forms.TextBox();
            this.txtGamblerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxGamblers
            // 
            this.listBoxGamblers.FormattingEnabled = true;
            this.listBoxGamblers.Location = new System.Drawing.Point(12, 108);
            this.listBoxGamblers.Name = "listBoxGamblers";
            this.listBoxGamblers.Size = new System.Drawing.Size(229, 186);
            this.listBoxGamblers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Current Active Gamblers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Give Funds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remove Funds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // btnConfirmTake
            // 
            this.btnConfirmTake.Location = new System.Drawing.Point(503, 138);
            this.btnConfirmTake.Name = "btnConfirmTake";
            this.btnConfirmTake.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmTake.TabIndex = 5;
            this.btnConfirmTake.Text = "Confirm";
            this.btnConfirmTake.UseVisualStyleBackColor = true;
            this.btnConfirmTake.Click += new System.EventHandler(this.btnConfirmTake_Click);
            // 
            // btnConfirmGive
            // 
            this.btnConfirmGive.Location = new System.Drawing.Point(503, 106);
            this.btnConfirmGive.Name = "btnConfirmGive";
            this.btnConfirmGive.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmGive.TabIndex = 6;
            this.btnConfirmGive.Text = "Confirm";
            this.btnConfirmGive.UseVisualStyleBackColor = true;
            this.btnConfirmGive.Click += new System.EventHandler(this.btnConfirmGive_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(12, 315);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(75, 23);
            this.btnFlag.TabIndex = 7;
            this.btnFlag.Text = "Flag";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(293, 243);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(100, 23);
            this.btnViewSchedule.TabIndex = 8;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Location = new System.Drawing.Point(417, 243);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(104, 23);
            this.btnViewMessages.TabIndex = 9;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(396, 333);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtGiveFunds
            // 
            this.txtGiveFunds.Location = new System.Drawing.Point(381, 108);
            this.txtGiveFunds.Name = "txtGiveFunds";
            this.txtGiveFunds.Size = new System.Drawing.Size(100, 20);
            this.txtGiveFunds.TabIndex = 11;
            // 
            // txtRemoveFunds
            // 
            this.txtRemoveFunds.Location = new System.Drawing.Point(381, 140);
            this.txtRemoveFunds.Name = "txtRemoveFunds";
            this.txtRemoveFunds.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveFunds.TabIndex = 12;
            // 
            // txtGamblerName
            // 
            this.txtGamblerName.Location = new System.Drawing.Point(381, 76);
            this.txtGamblerName.Name = "txtGamblerName";
            this.txtGamblerName.Size = new System.Drawing.Size(100, 20);
            this.txtGamblerName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gambler Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DealerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 399);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGamblerName);
            this.Controls.Add(this.txtRemoveFunds);
            this.Controls.Add(this.txtGiveFunds);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnConfirmGive);
            this.Controls.Add(this.btnConfirmTake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGamblers);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmTake;
        private System.Windows.Forms.Button btnConfirmGive;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtGiveFunds;
        private System.Windows.Forms.TextBox txtRemoveFunds;
        private System.Windows.Forms.TextBox txtGamblerName;
        private System.Windows.Forms.Label label5;
    }
}