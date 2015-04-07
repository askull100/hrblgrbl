namespace Client
{
    partial class GameClient
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
            this.gameButton1 = new System.Windows.Forms.Button();
            this.gameButton2 = new System.Windows.Forms.Button();
            this.gameButton3 = new System.Windows.Forms.Button();
            this.gameButton4 = new System.Windows.Forms.Button();
            this.gameButton5 = new System.Windows.Forms.Button();
            this.gameButton6 = new System.Windows.Forms.Button();
            this.gameButton7 = new System.Windows.Forms.Button();
            this.gameButton8 = new System.Windows.Forms.Button();
            this.gameButton9 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.playerTurnLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameButton1
            // 
            this.gameButton1.Location = new System.Drawing.Point(96, 61);
            this.gameButton1.Name = "gameButton1";
            this.gameButton1.Size = new System.Drawing.Size(37, 37);
            this.gameButton1.TabIndex = 0;
            this.gameButton1.Text = "-";
            this.gameButton1.UseVisualStyleBackColor = true;
            this.gameButton1.Click += new System.EventHandler(this.gameButton1_Click);
            // 
            // gameButton2
            // 
            this.gameButton2.Location = new System.Drawing.Point(139, 61);
            this.gameButton2.Name = "gameButton2";
            this.gameButton2.Size = new System.Drawing.Size(37, 37);
            this.gameButton2.TabIndex = 1;
            this.gameButton2.Text = "-";
            this.gameButton2.UseVisualStyleBackColor = true;
            this.gameButton2.Click += new System.EventHandler(this.gameButton2_Click);
            // 
            // gameButton3
            // 
            this.gameButton3.Location = new System.Drawing.Point(182, 61);
            this.gameButton3.Name = "gameButton3";
            this.gameButton3.Size = new System.Drawing.Size(37, 37);
            this.gameButton3.TabIndex = 2;
            this.gameButton3.Text = "-";
            this.gameButton3.UseVisualStyleBackColor = true;
            this.gameButton3.Click += new System.EventHandler(this.gameButton3_Click);
            // 
            // gameButton4
            // 
            this.gameButton4.Location = new System.Drawing.Point(96, 104);
            this.gameButton4.Name = "gameButton4";
            this.gameButton4.Size = new System.Drawing.Size(37, 37);
            this.gameButton4.TabIndex = 3;
            this.gameButton4.Text = "-";
            this.gameButton4.UseVisualStyleBackColor = true;
            this.gameButton4.Click += new System.EventHandler(this.gameButton4_Click);
            // 
            // gameButton5
            // 
            this.gameButton5.Location = new System.Drawing.Point(139, 104);
            this.gameButton5.Name = "gameButton5";
            this.gameButton5.Size = new System.Drawing.Size(37, 37);
            this.gameButton5.TabIndex = 4;
            this.gameButton5.Text = "-";
            this.gameButton5.UseVisualStyleBackColor = true;
            this.gameButton5.Click += new System.EventHandler(this.gameButton5_Click);
            // 
            // gameButton6
            // 
            this.gameButton6.Location = new System.Drawing.Point(182, 104);
            this.gameButton6.Name = "gameButton6";
            this.gameButton6.Size = new System.Drawing.Size(37, 37);
            this.gameButton6.TabIndex = 5;
            this.gameButton6.Text = "-";
            this.gameButton6.UseVisualStyleBackColor = true;
            this.gameButton6.Click += new System.EventHandler(this.gameButton6_Click);
            // 
            // gameButton7
            // 
            this.gameButton7.Location = new System.Drawing.Point(96, 147);
            this.gameButton7.Name = "gameButton7";
            this.gameButton7.Size = new System.Drawing.Size(37, 37);
            this.gameButton7.TabIndex = 6;
            this.gameButton7.Text = "-";
            this.gameButton7.UseVisualStyleBackColor = true;
            this.gameButton7.Click += new System.EventHandler(this.gameButton7_Click);
            // 
            // gameButton8
            // 
            this.gameButton8.Location = new System.Drawing.Point(139, 147);
            this.gameButton8.Name = "gameButton8";
            this.gameButton8.Size = new System.Drawing.Size(37, 37);
            this.gameButton8.TabIndex = 7;
            this.gameButton8.Text = "-";
            this.gameButton8.UseVisualStyleBackColor = true;
            this.gameButton8.Click += new System.EventHandler(this.gameButton8_Click);
            // 
            // gameButton9
            // 
            this.gameButton9.Location = new System.Drawing.Point(182, 147);
            this.gameButton9.Name = "gameButton9";
            this.gameButton9.Size = new System.Drawing.Size(37, 37);
            this.gameButton9.TabIndex = 8;
            this.gameButton9.Text = "-";
            this.gameButton9.UseVisualStyleBackColor = true;
            this.gameButton9.Click += new System.EventHandler(this.gameButton9_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(271, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(53, 23);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "LogOut";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // playerTurnLabel
            // 
            this.playerTurnLabel.AutoSize = true;
            this.playerTurnLabel.Location = new System.Drawing.Point(106, 218);
            this.playerTurnLabel.Name = "playerTurnLabel";
            this.playerTurnLabel.Size = new System.Drawing.Size(100, 13);
            this.playerTurnLabel.TabIndex = 10;
            this.playerTurnLabel.Text = "It is Player X\'s Turn.";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(55, 21);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(58, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Error Label";
            // 
            // GameClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 293);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.playerTurnLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.gameButton9);
            this.Controls.Add(this.gameButton8);
            this.Controls.Add(this.gameButton7);
            this.Controls.Add(this.gameButton6);
            this.Controls.Add(this.gameButton5);
            this.Controls.Add(this.gameButton4);
            this.Controls.Add(this.gameButton3);
            this.Controls.Add(this.gameButton2);
            this.Controls.Add(this.gameButton1);
            this.Name = "GameClient";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameButton1;
        private System.Windows.Forms.Button gameButton2;
        private System.Windows.Forms.Button gameButton3;
        private System.Windows.Forms.Button gameButton4;
        private System.Windows.Forms.Button gameButton5;
        private System.Windows.Forms.Button gameButton6;
        private System.Windows.Forms.Button gameButton7;
        private System.Windows.Forms.Button gameButton8;
        private System.Windows.Forms.Button gameButton9;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label playerTurnLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

