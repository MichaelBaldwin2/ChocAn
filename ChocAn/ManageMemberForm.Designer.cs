namespace ChocAn
{
    partial class ManageMemberForm
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
            this.addMemberButton = new System.Windows.Forms.Button();
            this.updateMemberButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(290, 12);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(189, 43);
            this.addMemberButton.TabIndex = 0;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // updateMemberButton
            // 
            this.updateMemberButton.Location = new System.Drawing.Point(290, 94);
            this.updateMemberButton.Name = "updateMemberButton";
            this.updateMemberButton.Size = new System.Drawing.Size(189, 43);
            this.updateMemberButton.TabIndex = 1;
            this.updateMemberButton.Text = "Update Member";
            this.updateMemberButton.UseVisualStyleBackColor = true;
            this.updateMemberButton.Click += new System.EventHandler(this.updateMemberButton_Click);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(290, 177);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(189, 43);
            this.deleteMemberButton.TabIndex = 2;
            this.deleteMemberButton.Text = "Delete Member";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(290, 289);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 43);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManageMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.updateMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Name = "ManageMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMemberForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageMemberForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button updateMemberButton;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button ExitButton;
    }
}