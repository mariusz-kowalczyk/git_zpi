namespace git_zpi.Forms.Users
{
    partial class ListUserForm
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
            this.components = new System.ComponentModel.Container();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditLink = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.loginColumn,
            this.firstnameColumn,
            this.lastnameColumn,
            this.createdAtColumn,
            this.updatedAtColumn,
            this.EditLink});
            this.usersDataGridView.DataSource = this.userModelBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(13, 13);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(1000, 253);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellContentClick);
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(git_zpi.Models.UserModel);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // loginColumn
            // 
            this.loginColumn.DataPropertyName = "Login";
            this.loginColumn.HeaderText = "Login";
            this.loginColumn.Name = "loginColumn";
            this.loginColumn.ReadOnly = true;
            this.loginColumn.Width = 150;
            // 
            // firstnameColumn
            // 
            this.firstnameColumn.DataPropertyName = "Firstname";
            this.firstnameColumn.HeaderText = "Firstname";
            this.firstnameColumn.Name = "firstnameColumn";
            this.firstnameColumn.Width = 200;
            // 
            // lastnameColumn
            // 
            this.lastnameColumn.DataPropertyName = "Lastname";
            this.lastnameColumn.HeaderText = "Lastname";
            this.lastnameColumn.Name = "lastnameColumn";
            this.lastnameColumn.Width = 200;
            // 
            // createdAtColumn
            // 
            this.createdAtColumn.DataPropertyName = "CreatedAt";
            this.createdAtColumn.HeaderText = "CreatedAt";
            this.createdAtColumn.Name = "createdAtColumn";
            this.createdAtColumn.ReadOnly = true;
            // 
            // updatedAtColumn
            // 
            this.updatedAtColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtColumn.HeaderText = "UpdatedAt";
            this.updatedAtColumn.Name = "updatedAtColumn";
            this.updatedAtColumn.ReadOnly = true;
            // 
            // EditLink
            // 
            this.EditLink.HeaderText = "Edit";
            this.EditLink.Name = "EditLink";
            this.EditLink.ReadOnly = true;
            this.EditLink.Text = "Edit";
            this.EditLink.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // ListUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 487);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "ListUserForm";
            this.Text = "ListUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtColumn;
        private System.Windows.Forms.DataGridViewLinkColumn EditLink;

    }
}