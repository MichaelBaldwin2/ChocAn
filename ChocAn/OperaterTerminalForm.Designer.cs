namespace ChocAn
{
    partial class OperaterTerminalForm
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
            this.manageMemberButton = new System.Windows.Forms.Button();
            this.manageProviderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageMemberButton
            // 
            this.manageMemberButton.Location = new System.Drawing.Point(315, 12);
            this.manageMemberButton.Name = "manageMemberButton";
            this.manageMemberButton.Size = new System.Drawing.Size(166, 38);
            this.manageMemberButton.TabIndex = 0;
            this.manageMemberButton.Text = "Manage Member";
            this.manageMemberButton.UseVisualStyleBackColor = true;
            this.manageMemberButton.Click += new System.EventHandler(this.manageMemberButton_Click);
            // 
            // manageProviderButton
            // 
            this.manageProviderButton.Location = new System.Drawing.Point(315, 96);
            this.manageProviderButton.Name = "manageProviderButton";
            this.manageProviderButton.Size = new System.Drawing.Size(166, 38);
            this.manageProviderButton.TabIndex = 1;
            this.manageProviderButton.Text = "Manage Provider";
            this.manageProviderButton.UseVisualStyleBackColor = true;
            this.manageProviderButton.Click += new System.EventHandler(this.manageProviderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(315, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OperaterTerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.manageProviderButton);
            this.Controls.Add(this.manageMemberButton);
            this.Name = "OperaterTerminalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperaterTerminalForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OperaterTerminalForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageMemberButton;
        private System.Windows.Forms.Button manageProviderButton;
        private System.Windows.Forms.Button exitButton;
    }
}