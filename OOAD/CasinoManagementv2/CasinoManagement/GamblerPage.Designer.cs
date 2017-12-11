namespace CasinoManagement
{
    partial class GamblerPage
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
            this.lblFundsTxt = new System.Windows.Forms.Label();
            this.lblFunds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.btnRemoveFunds = new System.Windows.Forms.Button();
            this.txtAddFunds = new System.Windows.Forms.TextBox();
            this.txtRemoveFunds = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFundsTxt
            // 
            this.lblFundsTxt.AutoSize = true;
            this.lblFundsTxt.Location = new System.Drawing.Point(167, 69);
            this.lblFundsTxt.Name = "lblFundsTxt";
            this.lblFundsTxt.Size = new System.Drawing.Size(76, 13);
            this.lblFundsTxt.TabIndex = 0;
            this.lblFundsTxt.Text = "Current Funds:";
            // 
            // lblFunds
            // 
            this.lblFunds.AutoSize = true;
            this.lblFunds.Location = new System.Drawing.Point(274, 69);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(13, 13);
            this.lblFunds.TabIndex = 1;
            this.lblFunds.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Funds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remove Funds:";
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.Location = new System.Drawing.Point(310, 107);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(75, 23);
            this.btnAddFunds.TabIndex = 4;
            this.btnAddFunds.Text = "Confirm";
            this.btnAddFunds.UseVisualStyleBackColor = true;
            this.btnAddFunds.Click += new System.EventHandler(this.btnAddFunds_Click);
            // 
            // btnRemoveFunds
            // 
            this.btnRemoveFunds.Location = new System.Drawing.Point(310, 137);
            this.btnRemoveFunds.Name = "btnRemoveFunds";
            this.btnRemoveFunds.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFunds.TabIndex = 5;
            this.btnRemoveFunds.Text = "Confirm";
            this.btnRemoveFunds.UseVisualStyleBackColor = true;
            this.btnRemoveFunds.Click += new System.EventHandler(this.btnRemoveFunds_Click);
            // 
            // txtAddFunds
            // 
            this.txtAddFunds.Location = new System.Drawing.Point(186, 104);
            this.txtAddFunds.Name = "txtAddFunds";
            this.txtAddFunds.Size = new System.Drawing.Size(100, 20);
            this.txtAddFunds.TabIndex = 6;
            // 
            // txtRemoveFunds
            // 
            this.txtRemoveFunds.Location = new System.Drawing.Point(186, 137);
            this.txtRemoveFunds.Name = "txtRemoveFunds";
            this.txtRemoveFunds.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveFunds.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(333, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // GamblerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 315);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtRemoveFunds);
            this.Controls.Add(this.txtAddFunds);
            this.Controls.Add(this.btnRemoveFunds);
            this.Controls.Add(this.btnAddFunds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFunds);
            this.Controls.Add(this.lblFundsTxt);
            this.Name = "GamblerPage";
            this.Text = "GamblerPage";
            this.Load += new System.EventHandler(this.GamblerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFundsTxt;
        private System.Windows.Forms.Label lblFunds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFunds;
        private System.Windows.Forms.Button btnRemoveFunds;
        private System.Windows.Forms.TextBox txtAddFunds;
        private System.Windows.Forms.TextBox txtRemoveFunds;
        private System.Windows.Forms.Button btnLogout;
    }
}