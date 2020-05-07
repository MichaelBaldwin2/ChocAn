namespace ChocAn
{
    partial class ManagerTerminalForm
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
            this.generateSummaryReportButton = new System.Windows.Forms.Button();
            this.generateMemberReportButton = new System.Windows.Forms.Button();
            this.generateAllMemberReportsButton = new System.Windows.Forms.Button();
            this.generateAllProviderReportsButton = new System.Windows.Forms.Button();
            this.generateProviderReportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateSummaryReportButton
            // 
            this.generateSummaryReportButton.Location = new System.Drawing.Point(286, 12);
            this.generateSummaryReportButton.Name = "generateSummaryReportButton";
            this.generateSummaryReportButton.Size = new System.Drawing.Size(175, 50);
            this.generateSummaryReportButton.TabIndex = 0;
            this.generateSummaryReportButton.Text = "Generate Summary Report";
            this.generateSummaryReportButton.UseVisualStyleBackColor = true;
            this.generateSummaryReportButton.Click += new System.EventHandler(this.generateSummaryReportButton_Click);
            // 
            // generateMemberReportButton
            // 
            this.generateMemberReportButton.Location = new System.Drawing.Point(286, 83);
            this.generateMemberReportButton.Name = "generateMemberReportButton";
            this.generateMemberReportButton.Size = new System.Drawing.Size(175, 50);
            this.generateMemberReportButton.TabIndex = 1;
            this.generateMemberReportButton.Text = "Generate Member Report";
            this.generateMemberReportButton.UseVisualStyleBackColor = true;
            this.generateMemberReportButton.Click += new System.EventHandler(this.generateMemberReportButton_Click);
            // 
            // generateAllMemberReportsButton
            // 
            this.generateAllMemberReportsButton.Location = new System.Drawing.Point(286, 229);
            this.generateAllMemberReportsButton.Name = "generateAllMemberReportsButton";
            this.generateAllMemberReportsButton.Size = new System.Drawing.Size(175, 50);
            this.generateAllMemberReportsButton.TabIndex = 3;
            this.generateAllMemberReportsButton.Text = "Generate All Member Reports";
            this.generateAllMemberReportsButton.UseVisualStyleBackColor = true;
            this.generateAllMemberReportsButton.Click += new System.EventHandler(this.generateAllMemberReportsButton_Click);
            // 
            // generateAllProviderReportsButton
            // 
            this.generateAllProviderReportsButton.Location = new System.Drawing.Point(286, 308);
            this.generateAllProviderReportsButton.Name = "generateAllProviderReportsButton";
            this.generateAllProviderReportsButton.Size = new System.Drawing.Size(175, 50);
            this.generateAllProviderReportsButton.TabIndex = 4;
            this.generateAllProviderReportsButton.Text = "Generate All Provider Reports";
            this.generateAllProviderReportsButton.UseVisualStyleBackColor = true;
            this.generateAllProviderReportsButton.Click += new System.EventHandler(this.generateAllProviderReportsButton_Click);
            // 
            // generateProviderReportButton
            // 
            this.generateProviderReportButton.Location = new System.Drawing.Point(286, 155);
            this.generateProviderReportButton.Name = "generateProviderReportButton";
            this.generateProviderReportButton.Size = new System.Drawing.Size(175, 50);
            this.generateProviderReportButton.TabIndex = 5;
            this.generateProviderReportButton.Text = "Generate Provider Report";
            this.generateProviderReportButton.UseVisualStyleBackColor = true;
            this.generateProviderReportButton.Click += new System.EventHandler(this.generateProviderReportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(286, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(175, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ManagerTerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateProviderReportButton);
            this.Controls.Add(this.generateAllProviderReportsButton);
            this.Controls.Add(this.generateAllMemberReportsButton);
            this.Controls.Add(this.generateMemberReportButton);
            this.Controls.Add(this.generateSummaryReportButton);
            this.Name = "ManagerTerminalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerTerminalForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateSummaryReportButton;
        private System.Windows.Forms.Button generateMemberReportButton;
        private System.Windows.Forms.Button generateAllMemberReportsButton;
        private System.Windows.Forms.Button generateAllProviderReportsButton;
        private System.Windows.Forms.Button generateProviderReportButton;
        private System.Windows.Forms.Button exitButton;
    }
}