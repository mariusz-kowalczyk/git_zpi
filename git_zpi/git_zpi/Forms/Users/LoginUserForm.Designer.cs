namespace git_zpi.Forms.Users
{
    partial class LoginUserForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Location = new System.Drawing.Point(13, 13);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(367, 236);
            this.loginPanel.TabIndex = 0;
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.loginPanel);
            this.Name = "LoginUserForm";
            this.Text = "LoginUserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;

    }
}