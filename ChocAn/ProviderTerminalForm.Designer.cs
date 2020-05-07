namespace ChocAn
{
    partial class ProviderTerminalForm
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
            this.validateMemberButton = new System.Windows.Forms.Button();
            this.billChocAnButton = new System.Windows.Forms.Button();
            this.RequestButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // validateMemberButton
            // 
            this.validateMemberButton.Location = new System.Drawing.Point(294, 12);
            this.validateMemberButton.Name = "validateMemberButton";
            this.validateMemberButton.Size = new System.Drawing.Size(203, 44);
            this.validateMemberButton.TabIndex = 0;
            this.validateMemberButton.Text = "Validate Member";
            this.validateMemberButton.UseVisualStyleBackColor = true;
            this.validateMemberButton.Click += new System.EventHandler(this.validateMemberButton_Click);
            // 
            // billChocAnButton
            // 
            this.billChocAnButton.Location = new System.Drawing.Point(294, 99);
            this.billChocAnButton.Name = "billChocAnButton";
            this.billChocAnButton.Size = new System.Drawing.Size(203, 44);
            this.billChocAnButton.TabIndex = 1;
            this.billChocAnButton.Text = "Bill ChocAn";
            this.billChocAnButton.UseVisualStyleBackColor = true;
            this.billChocAnButton.Click += new System.EventHandler(this.billChocAnButton_Click);
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(294, 194);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(203, 44);
            this.RequestButton.TabIndex = 2;
            this.RequestButton.Text = "Request Provider Directory";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(294, 283);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ProviderTerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.billChocAnButton);
            this.Controls.Add(this.validateMemberButton);
            this.Name = "ProviderTerminalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderTerminalForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProviderTerminalForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button validateMemberButton;
        private System.Windows.Forms.Button billChocAnButton;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Button exitButton;
    }
}