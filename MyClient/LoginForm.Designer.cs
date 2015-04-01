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
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(177, 191);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 30);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.Location = new System.Drawing.Point(153, 83);
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.Size = new System.Drawing.Size(125, 20);
            this.ServerIPAddress.TabIndex = 15;
            this.ServerIPAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(129, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tic Tac Toe";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(153, 144);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 20);
            this.passwordTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(270, 200);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(58, 13);
            this.errorLabel.TabIndex = 28;
            this.errorLabel.Text = "Error Label";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 273);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
    }
}

