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
            this.ListOfCommands = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players";
            // 
            // ListOfConnections
            // 
            this.ListOfConnections.FormattingEnabled = true;
            this.ListOfConnections.Location = new System.Drawing.Point(8, 23);
            this.ListOfConnections.Name = "ListOfConnections";
            this.ListOfConnections.Size = new System.Drawing.Size(93, 225);
            this.ListOfConnections.TabIndex = 1;
            // 
            // ListOfCommands
            // 
            this.ListOfCommands.FormattingEnabled = true;
            this.ListOfCommands.Location = new System.Drawing.Point(107, 23);
            this.ListOfCommands.Name = "ListOfCommands";
            this.ListOfCommands.Size = new System.Drawing.Size(251, 225);
            this.ListOfCommands.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actions";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListOfCommands);
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
        private System.Windows.Forms.ListBox ListOfCommands;
        private System.Windows.Forms.Label label2;
    }
}

