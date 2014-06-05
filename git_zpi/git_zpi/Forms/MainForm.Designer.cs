namespace git_zpi.Forms
{
    partial class MainForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.openFileDialogEdi = new System.Windows.Forms.OpenFileDialog();
            this.newUserButton = new System.Windows.Forms.Button();
            this.buttonGenerujFakture = new System.Windows.Forms.Button();
            this.usersListButton = new System.Windows.Forms.Button();
            this.panelEdi = new System.Windows.Forms.Panel();
            this.labelEdi = new System.Windows.Forms.Label();
            this.buttonEdiFile = new System.Windows.Forms.Button();
            this.panelKreskowe = new System.Windows.Forms.Panel();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.pictureBoxKreskowe = new System.Windows.Forms.PictureBox();
            this.buttonKreskowe = new System.Windows.Forms.Button();
            this.comboBoxKreskowe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEdi.SuspendLayout();
            this.panelKreskowe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKreskowe)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(822, 13);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // openFileDialogEdi
            // 
            this.openFileDialogEdi.DefaultExt = "edi";
            this.openFileDialogEdi.FileName = "openFileDialog1";
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(741, 13);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(75, 23);
            this.newUserButton.TabIndex = 1;
            this.newUserButton.Text = "New user";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // buttonGenerujFakture
            // 
            this.buttonGenerujFakture.Location = new System.Drawing.Point(533, 12);
            this.buttonGenerujFakture.Name = "buttonGenerujFakture";
            this.buttonGenerujFakture.Size = new System.Drawing.Size(121, 23);
            this.buttonGenerujFakture.TabIndex = 5;
            this.buttonGenerujFakture.Text = "Generuj fakture";
            this.buttonGenerujFakture.UseVisualStyleBackColor = true;
            this.buttonGenerujFakture.Click += new System.EventHandler(this.buttonGenerujFakture_Click);
            // 
            // usersListButton
            // 
            this.usersListButton.Location = new System.Drawing.Point(660, 12);
            this.usersListButton.Name = "usersListButton";
            this.usersListButton.Size = new System.Drawing.Size(75, 23);
            this.usersListButton.TabIndex = 6;
            this.usersListButton.Text = "List of users";
            this.usersListButton.UseVisualStyleBackColor = true;
            this.usersListButton.Click += new System.EventHandler(this.usersListButton_Click);
            // 
            // panelEdi
            // 
            this.panelEdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdi.Controls.Add(this.labelEdi);
            this.panelEdi.Controls.Add(this.buttonEdiFile);
            this.panelEdi.Location = new System.Drawing.Point(12, 13);
            this.panelEdi.Name = "panelEdi";
            this.panelEdi.Size = new System.Drawing.Size(230, 67);
            this.panelEdi.TabIndex = 7;
            // 
            // labelEdi
            // 
            this.labelEdi.AutoSize = true;
            this.labelEdi.Location = new System.Drawing.Point(3, 0);
            this.labelEdi.Name = "labelEdi";
            this.labelEdi.Size = new System.Drawing.Size(25, 13);
            this.labelEdi.TabIndex = 0;
            this.labelEdi.Text = "EDI";
            // 
            // buttonEdiFile
            // 
            this.buttonEdiFile.Location = new System.Drawing.Point(9, 30);
            this.buttonEdiFile.Name = "buttonEdiFile";
            this.buttonEdiFile.Size = new System.Drawing.Size(121, 23);
            this.buttonEdiFile.TabIndex = 0;
            this.buttonEdiFile.Text = "Edi z pliku";
            this.buttonEdiFile.UseVisualStyleBackColor = true;
            this.buttonEdiFile.Click += new System.EventHandler(this.buttonEdiFile_Click);
            // 
            // panelKreskowe
            // 
            this.panelKreskowe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKreskowe.Controls.Add(this.textBoxBarcode);
            this.panelKreskowe.Controls.Add(this.pictureBoxKreskowe);
            this.panelKreskowe.Controls.Add(this.buttonKreskowe);
            this.panelKreskowe.Controls.Add(this.comboBoxKreskowe);
            this.panelKreskowe.Controls.Add(this.label1);
            this.panelKreskowe.Location = new System.Drawing.Point(12, 86);
            this.panelKreskowe.Name = "panelKreskowe";
            this.panelKreskowe.Size = new System.Drawing.Size(485, 138);
            this.panelKreskowe.TabIndex = 8;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(9, 61);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(121, 20);
            this.textBoxBarcode.TabIndex = 4;
            // 
            // pictureBoxKreskowe
            // 
            this.pictureBoxKreskowe.Location = new System.Drawing.Point(157, 19);
            this.pictureBoxKreskowe.Name = "pictureBoxKreskowe";
            this.pictureBoxKreskowe.Size = new System.Drawing.Size(311, 101);
            this.pictureBoxKreskowe.TabIndex = 3;
            this.pictureBoxKreskowe.TabStop = false;
            // 
            // buttonKreskowe
            // 
            this.buttonKreskowe.Location = new System.Drawing.Point(9, 97);
            this.buttonKreskowe.Name = "buttonKreskowe";
            this.buttonKreskowe.Size = new System.Drawing.Size(121, 23);
            this.buttonKreskowe.TabIndex = 2;
            this.buttonKreskowe.Text = "Generuj Kod";
            this.buttonKreskowe.UseVisualStyleBackColor = true;
            this.buttonKreskowe.Click += new System.EventHandler(this.buttonKreskowe_Click);
            // 
            // comboBoxKreskowe
            // 
            this.comboBoxKreskowe.FormattingEnabled = true;
            this.comboBoxKreskowe.Location = new System.Drawing.Point(9, 33);
            this.comboBoxKreskowe.Name = "comboBoxKreskowe";
            this.comboBoxKreskowe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKreskowe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kody kreskowe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 551);
            this.Controls.Add(this.panelKreskowe);
            this.Controls.Add(this.panelEdi);
            this.Controls.Add(this.usersListButton);
            this.Controls.Add(this.buttonGenerujFakture);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.LogoutButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelEdi.ResumeLayout(false);
            this.panelEdi.PerformLayout();
            this.panelKreskowe.ResumeLayout(false);
            this.panelKreskowe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKreskowe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogEdi;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button buttonGenerujFakture;
        private System.Windows.Forms.Button usersListButton;
        private System.Windows.Forms.Panel panelEdi;
        private System.Windows.Forms.Label labelEdi;
        private System.Windows.Forms.Button buttonEdiFile;
        private System.Windows.Forms.Panel panelKreskowe;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.PictureBox pictureBoxKreskowe;
        private System.Windows.Forms.Button buttonKreskowe;
        private System.Windows.Forms.ComboBox comboBoxKreskowe;
        private System.Windows.Forms.Label label1;
    }
}