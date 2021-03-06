namespace DA_PhanHe1
{
    partial class FormMenu
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.User = new System.Windows.Forms.TabPage();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserViewPriv = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserRefresh = new System.Windows.Forms.Button();
            this.btnUserSeach = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.TabPage();
            this.btnViewRolePriv = new System.Windows.Forms.Button();
            this.RoleGridView = new System.Windows.Forms.DataGridView();
            this.btnRoleDelete = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.btnRoleRefresh = new System.Windows.Forms.Button();
            this.btnRoleSearch = new System.Windows.Forms.Button();
            this.txtRoleSearch = new System.Windows.Forms.TextBox();
            this.role_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authentication_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.common = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.User);
            this.TabControl.Controls.Add(this.Role);
            this.TabControl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(671, 431);
            this.TabControl.TabIndex = 0;
            // 
            // User
            // 
            this.User.Controls.Add(this.UserGridView);
            this.User.Controls.Add(this.btnUserDelete);
            this.User.Controls.Add(this.btnUserViewPriv);
            this.User.Controls.Add(this.btnUserAdd);
            this.User.Controls.Add(this.btnUserRefresh);
            this.User.Controls.Add(this.btnUserSeach);
            this.User.Controls.Add(this.txtUserSearch);
            this.User.Location = new System.Drawing.Point(4, 31);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(663, 396);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            // 
            // UserGridView
            // 
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.created,
            this.last_login,
            this.account_status});
            this.UserGridView.Location = new System.Drawing.Point(6, 85);
            this.UserGridView.MultiSelect = false;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(657, 311);
            this.UserGridView.TabIndex = 10;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 150;
            // 
            // created
            // 
            this.created.DataPropertyName = "created";
            this.created.HeaderText = "Created";
            this.created.Name = "created";
            this.created.ReadOnly = true;
            this.created.Width = 150;
            // 
            // last_login
            // 
            this.last_login.DataPropertyName = "last_login";
            this.last_login.HeaderText = "Last login";
            this.last_login.Name = "last_login";
            this.last_login.ReadOnly = true;
            this.last_login.Width = 150;
            // 
            // account_status
            // 
            this.account_status.DataPropertyName = "account_status";
            this.account_status.HeaderText = "Status";
            this.account_status.Name = "account_status";
            this.account_status.ReadOnly = true;
            this.account_status.Width = 150;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(458, 14);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(66, 29);
            this.btnUserDelete.TabIndex = 6;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserViewPriv
            // 
            this.btnUserViewPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserViewPriv.Location = new System.Drawing.Point(530, 14);
            this.btnUserViewPriv.Name = "btnUserViewPriv";
            this.btnUserViewPriv.Size = new System.Drawing.Size(119, 29);
            this.btnUserViewPriv.TabIndex = 7;
            this.btnUserViewPriv.Text = "View privileges";
            this.btnUserViewPriv.UseVisualStyleBackColor = true;
            this.btnUserViewPriv.Click += new System.EventHandler(this.btnUserViewPriv_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.Location = new System.Drawing.Point(386, 14);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(66, 29);
            this.btnUserAdd.TabIndex = 8;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserRefresh
            // 
            this.btnUserRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRefresh.Location = new System.Drawing.Point(6, 50);
            this.btnUserRefresh.Name = "btnUserRefresh";
            this.btnUserRefresh.Size = new System.Drawing.Size(70, 29);
            this.btnUserRefresh.TabIndex = 9;
            this.btnUserRefresh.Text = "Refresh";
            this.btnUserRefresh.UseVisualStyleBackColor = true;
            this.btnUserRefresh.Click += new System.EventHandler(this.btnUserRefresh_Click);
            // 
            // btnUserSeach
            // 
            this.btnUserSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSeach.Location = new System.Drawing.Point(241, 15);
            this.btnUserSeach.Name = "btnUserSeach";
            this.btnUserSeach.Size = new System.Drawing.Size(70, 29);
            this.btnUserSeach.TabIndex = 9;
            this.btnUserSeach.Text = "Search";
            this.btnUserSeach.UseVisualStyleBackColor = true;
            this.btnUserSeach.Click += new System.EventHandler(this.btnUserSeach_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(6, 15);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(223, 29);
            this.txtUserSearch.TabIndex = 4;
            // 
            // Role
            // 
            this.Role.Controls.Add(this.btnViewRolePriv);
            this.Role.Controls.Add(this.RoleGridView);
            this.Role.Controls.Add(this.btnRoleDelete);
            this.Role.Controls.Add(this.btnRoleAdd);
            this.Role.Controls.Add(this.btnRoleRefresh);
            this.Role.Controls.Add(this.btnRoleSearch);
            this.Role.Controls.Add(this.txtRoleSearch);
            this.Role.Location = new System.Drawing.Point(4, 31);
            this.Role.Name = "Role";
            this.Role.Padding = new System.Windows.Forms.Padding(3);
            this.Role.Size = new System.Drawing.Size(663, 396);
            this.Role.TabIndex = 1;
            this.Role.Text = "Role";
            this.Role.UseVisualStyleBackColor = true;
            // 
            // btnViewRolePriv
            // 
            this.btnViewRolePriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRolePriv.Location = new System.Drawing.Point(541, 18);
            this.btnViewRolePriv.Name = "btnViewRolePriv";
            this.btnViewRolePriv.Size = new System.Drawing.Size(119, 29);
            this.btnViewRolePriv.TabIndex = 20;
            this.btnViewRolePriv.Text = "View privileges";
            this.btnViewRolePriv.UseVisualStyleBackColor = true;
            this.btnViewRolePriv.Click += new System.EventHandler(this.btnViewRolePriv_Click);
            // 
            // RoleGridView
            // 
            this.RoleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.role_col,
            this.password_required,
            this.authentication_type,
            this.common});
            this.RoleGridView.Location = new System.Drawing.Point(4, 87);
            this.RoleGridView.MultiSelect = false;
            this.RoleGridView.Name = "RoleGridView";
            this.RoleGridView.ReadOnly = true;
            this.RoleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleGridView.Size = new System.Drawing.Size(658, 306);
            this.RoleGridView.TabIndex = 18;
            // 
            // btnRoleDelete
            // 
            this.btnRoleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleDelete.Location = new System.Drawing.Point(469, 17);
            this.btnRoleDelete.Name = "btnRoleDelete";
            this.btnRoleDelete.Size = new System.Drawing.Size(66, 29);
            this.btnRoleDelete.TabIndex = 13;
            this.btnRoleDelete.Text = "Delete";
            this.btnRoleDelete.UseVisualStyleBackColor = true;
            this.btnRoleDelete.Click += new System.EventHandler(this.btnRoleDelete_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAdd.Location = new System.Drawing.Point(397, 17);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(66, 29);
            this.btnRoleAdd.TabIndex = 15;
            this.btnRoleAdd.Text = "Add";
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // btnRoleRefresh
            // 
            this.btnRoleRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleRefresh.Location = new System.Drawing.Point(6, 52);
            this.btnRoleRefresh.Name = "btnRoleRefresh";
            this.btnRoleRefresh.Size = new System.Drawing.Size(70, 29);
            this.btnRoleRefresh.TabIndex = 16;
            this.btnRoleRefresh.Text = "Refresh";
            this.btnRoleRefresh.UseVisualStyleBackColor = true;
            this.btnRoleRefresh.Click += new System.EventHandler(this.btnRoleRefresh_Click);
            // 
            // btnRoleSearch
            // 
            this.btnRoleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleSearch.Location = new System.Drawing.Point(241, 17);
            this.btnRoleSearch.Name = "btnRoleSearch";
            this.btnRoleSearch.Size = new System.Drawing.Size(70, 29);
            this.btnRoleSearch.TabIndex = 16;
            this.btnRoleSearch.Text = "Search";
            this.btnRoleSearch.UseVisualStyleBackColor = true;
            this.btnRoleSearch.Click += new System.EventHandler(this.btnRoleSearch_Click);
            // 
            // txtRoleSearch
            // 
            this.txtRoleSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleSearch.Location = new System.Drawing.Point(6, 17);
            this.txtRoleSearch.Name = "txtRoleSearch";
            this.txtRoleSearch.Size = new System.Drawing.Size(223, 29);
            this.txtRoleSearch.TabIndex = 11;
            // 
            // role_col
            // 
            this.role_col.DataPropertyName = "role";
            this.role_col.HeaderText = "Role";
            this.role_col.Name = "role_col";
            this.role_col.ReadOnly = true;
            this.role_col.Width = 150;
            // 
            // password_required
            // 
            this.password_required.DataPropertyName = "password_required";
            this.password_required.HeaderText = "Password Required";
            this.password_required.Name = "password_required";
            this.password_required.ReadOnly = true;
            this.password_required.Width = 150;
            // 
            // authentication_type
            // 
            this.authentication_type.DataPropertyName = "authentication_type";
            this.authentication_type.HeaderText = "Authentication Type";
            this.authentication_type.Name = "authentication_type";
            this.authentication_type.ReadOnly = true;
            this.authentication_type.Width = 150;
            // 
            // common
            // 
            this.common.DataPropertyName = "common";
            this.common.HeaderText = "Common";
            this.common.Name = "common";
            this.common.ReadOnly = true;
            this.common.Width = 150;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 459);
            this.Controls.Add(this.TabControl);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.TabControl.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.Role.ResumeLayout(false);
            this.Role.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.TabPage Role;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserViewPriv;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserSeach;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Button btnRoleDelete;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.Button btnRoleSearch;
        private System.Windows.Forms.TextBox txtRoleSearch;
        private System.Windows.Forms.Button btnUserRefresh;
        private System.Windows.Forms.Button btnRoleRefresh;
        private System.Windows.Forms.DataGridView RoleGridView;
        private System.Windows.Forms.Button btnViewRolePriv;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn created;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_required;
        private System.Windows.Forms.DataGridViewTextBoxColumn authentication_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn common;
    }
}