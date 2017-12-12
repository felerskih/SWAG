namespace CasinoManagement
{
    partial class MessagePage
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
            this.cboRecieveMessages = new System.Windows.Forms.ComboBox();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.txtRecieveMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboRecieveMessages
            // 
            this.cboRecieveMessages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecieveMessages.FormattingEnabled = true;
            this.cboRecieveMessages.Location = new System.Drawing.Point(224, 64);
            this.cboRecieveMessages.Name = "cboRecieveMessages";
            this.cboRecieveMessages.Size = new System.Drawing.Size(121, 21);
            this.cboRecieveMessages.TabIndex = 1;
            this.cboRecieveMessages.SelectedIndexChanged += new System.EventHandler(this.cboRecieveMessages_SelectedIndexChanged);
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(48, 92);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(121, 104);
            this.txtSendMessage.TabIndex = 2;
            // 
            // txtRecieveMessage
            // 
            this.txtRecieveMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecieveMessage.Location = new System.Drawing.Point(224, 91);
            this.txtRecieveMessage.Multiline = true;
            this.txtRecieveMessage.Name = "txtRecieveMessage";
            this.txtRecieveMessage.Size = new System.Drawing.Size(121, 105);
            this.txtRecieveMessage.TabIndex = 3;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(48, 203);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(299, 270);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MessagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtRecieveMessage);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.cboRecieveMessages);
            this.Name = "MessagePage";
            this.Text = "MessagePage";
            this.Load += new System.EventHandler(this.MessagePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboRecieveMessages;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.TextBox txtRecieveMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}