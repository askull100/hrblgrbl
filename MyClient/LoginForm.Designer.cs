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
            this.errorLabel = new System.Windows.Forms.Label();
            this.HostButton = new System.Windows.Forms.Button();
            this.h_errorLabel = new System.Windows.Forms.Label();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.DataPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(32, 110);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 30);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.Location = new System.Drawing.Point(32, 84);
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.Size = new System.Drawing.Size(125, 20);
            this.ServerIPAddress.TabIndex = 15;
            this.ServerIPAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(46, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tic Tac Toe";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(29, 143);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(58, 13);
            this.errorLabel.TabIndex = 28;
            this.errorLabel.Text = "Error Label";
            // 
            // HostButton
            // 
            this.HostButton.Location = new System.Drawing.Point(170, 134);
            this.HostButton.Margin = new System.Windows.Forms.Padding(2);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(75, 31);
            this.HostButton.TabIndex = 29;
            this.HostButton.Text = "Host Game";
            this.HostButton.UseVisualStyleBackColor = true;
            this.HostButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
            // h_errorLabel
            // 
            this.h_errorLabel.AutoSize = true;
            this.h_errorLabel.ForeColor = System.Drawing.Color.Red;
            this.h_errorLabel.Location = new System.Drawing.Point(167, 167);
            this.h_errorLabel.Name = "h_errorLabel";
            this.h_errorLabel.Size = new System.Drawing.Size(58, 13);
            this.h_errorLabel.TabIndex = 34;
            this.h_errorLabel.Text = "Error Label";
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(169, 84);
            this.PortNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(76, 20);
            this.PortNumber.TabIndex = 36;
            this.PortNumber.Text = "8080";
            // 
            // DataPort
            // 
            this.DataPort.Location = new System.Drawing.Point(169, 106);
            this.DataPort.Margin = new System.Windows.Forms.Padding(2);
            this.DataPort.Name = "DataPort";
            this.DataPort.Size = new System.Drawing.Size(76, 20);
            this.DataPort.TabIndex = 37;
            this.DataPort.Text = "8090";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Port Numbers";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 201);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataPort);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.h_errorLabel);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ServerIPAddress);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.Label h_errorLabel;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.TextBox DataPort;
        private System.Windows.Forms.Label label6;
    }
}

