namespace ChocAn
{
    partial class MainWindow
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
            System.Windows.Forms.Button operatorTerminalButton;
            this.managerTerminalButton = new System.Windows.Forms.Button();
            this.providerTerminalButton = new System.Windows.Forms.Button();
            operatorTerminalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operatorTerminalButton
            // 
            operatorTerminalButton.Location = new System.Drawing.Point(307, 153);
            operatorTerminalButton.Name = "operatorTerminalButton";
            operatorTerminalButton.Size = new System.Drawing.Size(178, 36);
            operatorTerminalButton.TabIndex = 2;
            operatorTerminalButton.Text = "Operator Terminal";
            operatorTerminalButton.UseVisualStyleBackColor = true;
            operatorTerminalButton.Click += new System.EventHandler(this.operatorTerminalButton_Click);
            // 
            // managerTerminalButton
            // 
            this.managerTerminalButton.Location = new System.Drawing.Point(307, 12);
            this.managerTerminalButton.Name = "managerTerminalButton";
            this.managerTerminalButton.Size = new System.Drawing.Size(178, 36);
            this.managerTerminalButton.TabIndex = 0;
            this.managerTerminalButton.Text = "Manager Terminal";
            this.managerTerminalButton.UseVisualStyleBackColor = true;
            this.managerTerminalButton.Click += new System.EventHandler(this.managerTerminalButton_Click);
            // 
            // providerTerminalButton
            // 
            this.providerTerminalButton.Location = new System.Drawing.Point(307, 80);
            this.providerTerminalButton.Name = "providerTerminalButton";
            this.providerTerminalButton.Size = new System.Drawing.Size(178, 36);
            this.providerTerminalButton.TabIndex = 1;
            this.providerTerminalButton.Text = "Provider Terminal";
            this.providerTerminalButton.UseVisualStyleBackColor = true;
            this.providerTerminalButton.Click += new System.EventHandler(this.providerTerminalButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(operatorTerminalButton);
            this.Controls.Add(this.providerTerminalButton);
            this.Controls.Add(this.managerTerminalButton);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChocAn System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managerTerminalButton;
        private System.Windows.Forms.Button providerTerminalButton;
    }
}

