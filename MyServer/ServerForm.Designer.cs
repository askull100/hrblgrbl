namespace Server
{
    partial class ServerForm
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
            this.ListOfConnections = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ListOfCommands = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players";
            // 
            // ListOfConnections
            // 
            this.ListOfConnections.FormattingEnabled = true;
            this.ListOfConnections.Location = new System.Drawing.Point(15, 55);
            this.ListOfConnections.Name = "ListOfConnections";
            this.ListOfConnections.Size = new System.Drawing.Size(93, 225);
            this.ListOfConnections.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(371, 7);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(59, 45);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start Server";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ListOfCommands
            // 
            this.ListOfCommands.FormattingEnabled = true;
            this.ListOfCommands.Location = new System.Drawing.Point(114, 55);
            this.ListOfCommands.Name = "ListOfCommands";
            this.ListOfCommands.Size = new System.Drawing.Size(251, 225);
            this.ListOfCommands.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actions";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListOfCommands);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ListOfConnections);
            this.Controls.Add(this.label1);
            this.Name = "ServerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListOfConnections;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox ListOfCommands;
        private System.Windows.Forms.Label label2;
    }
}

