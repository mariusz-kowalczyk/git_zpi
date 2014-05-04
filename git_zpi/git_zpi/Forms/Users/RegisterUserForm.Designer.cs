namespace git_zpi.Forms.Users
{
    partial class RegisterUserForm
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
            this.registerPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerPanel.Controls.Add(this.cancelButton);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.lastnameTextBox);
            this.registerPanel.Controls.Add(this.lastnameLabel);
            this.registerPanel.Controls.Add(this.firstnameTextBox);
            this.registerPanel.Controls.Add(this.firstnameLabel);
            this.registerPanel.Controls.Add(this.passwordTextBox);
            this.registerPanel.Controls.Add(this.passwordLabel);
            this.registerPanel.Controls.Add(this.loginTextBox);
            this.registerPanel.Controls.Add(this.loginLabel);
            this.registerPanel.Location = new System.Drawing.Point(12, 12);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(368, 260);
            this.registerPanel.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(60, 33);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(111, 30);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(236, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(40, 73);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(111, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(236, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(41, 113);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(52, 13);
            this.firstnameLabel.TabIndex = 4;
            this.firstnameLabel.Text = "Firstname";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(111, 110);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.firstnameTextBox.TabIndex = 5;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(40, 153);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(53, 13);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Lastname";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(111, 150);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.lastnameTextBox.TabIndex = 7;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(271, 190);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(190, 190);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 284);
            this.Controls.Add(this.registerPanel);
            this.Name = "RegisterUserForm";
            this.Text = "RegisterUserForm";
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
    }
}