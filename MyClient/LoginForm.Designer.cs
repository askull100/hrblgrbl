namespace Login
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.ServerIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.HostButton = new System.Windows.Forms.Button();
            this.h_passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.h_ServerIPAddress = new System.Windows.Forms.TextBox();
            this.h_errorLabel = new System.Windows.Forms.Label();
            this.passwordOn = new System.Windows.Forms.CheckBox();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.DataPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(71, 217);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 37);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.Location = new System.Drawing.Point(42, 103);
            this.ServerIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.Size = new System.Drawing.Size(165, 22);
            this.ServerIPAddress.TabIndex = 15;
            this.ServerIPAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(172, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 46);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tic Tac Toe";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(42, 170);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(165, 22);
            this.passwordTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(68, 258);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(79, 17);
            this.errorLabel.TabIndex = 28;
            this.errorLabel.Text = "Error Label";
            // 
            // HostButton
            // 
            this.HostButton.Location = new System.Drawing.Point(368, 216);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(100, 38);
            this.HostButton.TabIndex = 29;
            this.HostButton.Text = "Host Game";
            this.HostButton.UseVisualStyleBackColor = true;
            this.HostButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
            // h_passwordTextBox
            // 
            this.h_passwordTextBox.Location = new System.Drawing.Point(340, 170);
            this.h_passwordTextBox.Name = "h_passwordTextBox";
            this.h_passwordTextBox.Size = new System.Drawing.Size(165, 22);
            this.h_passwordTextBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Server IP Address";
            // 
            // h_ServerIPAddress
            // 
            this.h_ServerIPAddress.Location = new System.Drawing.Point(340, 103);
            this.h_ServerIPAddress.Name = "h_ServerIPAddress";
            this.h_ServerIPAddress.Size = new System.Drawing.Size(165, 22);
            this.h_ServerIPAddress.TabIndex = 33;
            // 
            // h_errorLabel
            // 
            this.h_errorLabel.AutoSize = true;
            this.h_errorLabel.ForeColor = System.Drawing.Color.Red;
            this.h_errorLabel.Location = new System.Drawing.Point(365, 257);
            this.h_errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h_errorLabel.Name = "h_errorLabel";
            this.h_errorLabel.Size = new System.Drawing.Size(79, 17);
            this.h_errorLabel.TabIndex = 34;
            this.h_errorLabel.Text = "Error Label";
            // 
            // passwordOn
            // 
            this.passwordOn.AutoSize = true;
            this.passwordOn.Checked = true;
            this.passwordOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.passwordOn.Location = new System.Drawing.Point(521, 174);
            this.passwordOn.Name = "passwordOn";
            this.passwordOn.Size = new System.Drawing.Size(18, 17);
            this.passwordOn.TabIndex = 35;
            this.passwordOn.UseVisualStyleBackColor = true;
            this.passwordOn.CheckedChanged += new System.EventHandler(this.passwordOn_CheckedChanged);
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(225, 103);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(100, 22);
            this.PortNumber.TabIndex = 36;
            this.PortNumber.Text = "8080";
            // 
            // DataPort
            // 
            this.DataPort.Location = new System.Drawing.Point(225, 131);
            this.DataPort.Name = "DataPort";
            this.DataPort.Size = new System.Drawing.Size(100, 22);
            this.DataPort.TabIndex = 37;
            this.DataPort.Text = "8090";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Port Numbers";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataPort);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.passwordOn);
            this.Controls.Add(this.h_errorLabel);
            this.Controls.Add(this.h_ServerIPAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.h_passwordTextBox);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ServerIPAddress);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox ServerIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.TextBox h_passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox h_ServerIPAddress;
        private System.Windows.Forms.Label h_errorLabel;
        private System.Windows.Forms.CheckBox passwordOn;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.TextBox DataPort;
        private System.Windows.Forms.Label label6;
    }
}

