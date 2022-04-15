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
            this.btnUserGrant = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserRefresh = new System.Windows.Forms.Button();
            this.btnUserSeach = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.TabPage();
            this.RoleGridView = new System.Windows.Forms.DataGridView();
            this.btnRoleGrant = new System.Windows.Forms.Button();
            this.btnRoleDelete = new System.Windows.Forms.Button();
            this.btnRoleEdit = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.btnRoleRefresh = new System.Windows.Forms.Button();
            this.btnRoleSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.TabControl.Size = new System.Drawing.Size(871, 431);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // User
            // 
            this.User.Controls.Add(this.UserGridView);
            this.User.Controls.Add(this.btnUserGrant);
            this.User.Controls.Add(this.btnUserDelete);
            this.User.Controls.Add(this.btnUserEdit);
            this.User.Controls.Add(this.btnUserAdd);
            this.User.Controls.Add(this.btnUserRefresh);
            this.User.Controls.Add(this.btnUserSeach);
            this.User.Controls.Add(this.txtUserSearch);
            this.User.Location = new System.Drawing.Point(4, 31);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(863, 396);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            // 
            // UserGridView
            // 
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(6, 85);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.Size = new System.Drawing.Size(854, 311);
            this.UserGridView.TabIndex = 10;
            this.UserGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUserGrant
            // 
            this.btnUserGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserGrant.Location = new System.Drawing.Point(794, 14);
            this.btnUserGrant.Name = "btnUserGrant";
            this.btnUserGrant.Size = new System.Drawing.Size(66, 29);
            this.btnUserGrant.TabIndex = 5;
            this.btnUserGrant.Text = "Grant";
            this.btnUserGrant.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(725, 14);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(66, 29);
            this.btnUserDelete.TabIndex = 6;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserEdit.Location = new System.Drawing.Point(656, 14);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(66, 29);
            this.btnUserEdit.TabIndex = 7;
            this.btnUserEdit.Text = "Edit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.Location = new System.Drawing.Point(587, 14);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(66, 29);
            this.btnUserAdd.TabIndex = 8;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = true;
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
            this.btnUserRefresh.Click += new System.EventHandler(this.button1_Click_2);
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
            this.Role.Controls.Add(this.RoleGridView);
            this.Role.Controls.Add(this.btnRoleGrant);
            this.Role.Controls.Add(this.btnRoleDelete);
            this.Role.Controls.Add(this.btnRoleEdit);
            this.Role.Controls.Add(this.btnRoleAdd);
            this.Role.Controls.Add(this.btnRoleRefresh);
            this.Role.Controls.Add(this.btnRoleSearch);
            this.Role.Controls.Add(this.textBox1);
            this.Role.Location = new System.Drawing.Point(4, 31);
            this.Role.Name = "Role";
            this.Role.Padding = new System.Windows.Forms.Padding(3);
            this.Role.Size = new System.Drawing.Size(863, 396);
            this.Role.TabIndex = 1;
            this.Role.Text = "Role";
            this.Role.UseVisualStyleBackColor = true;
            // 
            // RoleGridView
            // 
            this.RoleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleGridView.Location = new System.Drawing.Point(6, 86);
            this.RoleGridView.Name = "RoleGridView";
            this.RoleGridView.Size = new System.Drawing.Size(854, 307);
            this.RoleGridView.TabIndex = 17;
            this.RoleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnRoleGrant
            // 
            this.btnRoleGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleGrant.Location = new System.Drawing.Point(794, 16);
            this.btnRoleGrant.Name = "btnRoleGrant";
            this.btnRoleGrant.Size = new System.Drawing.Size(66, 29);
            this.btnRoleGrant.TabIndex = 12;
            this.btnRoleGrant.Text = "Grant";
            this.btnRoleGrant.UseVisualStyleBackColor = true;
            this.btnRoleGrant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRoleDelete
            // 
            this.btnRoleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleDelete.Location = new System.Drawing.Point(725, 16);
            this.btnRoleDelete.Name = "btnRoleDelete";
            this.btnRoleDelete.Size = new System.Drawing.Size(66, 29);
            this.btnRoleDelete.TabIndex = 13;
            this.btnRoleDelete.Text = "Delete";
            this.btnRoleDelete.UseVisualStyleBackColor = true;
            this.btnRoleDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRoleEdit
            // 
            this.btnRoleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleEdit.Location = new System.Drawing.Point(656, 16);
            this.btnRoleEdit.Name = "btnRoleEdit";
            this.btnRoleEdit.Size = new System.Drawing.Size(66, 29);
            this.btnRoleEdit.TabIndex = 14;
            this.btnRoleEdit.Text = "Edit";
            this.btnRoleEdit.UseVisualStyleBackColor = true;
            this.btnRoleEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAdd.Location = new System.Drawing.Point(587, 16);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(66, 29);
            this.btnRoleAdd.TabIndex = 15;
            this.btnRoleAdd.Text = "Add";
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.button4_Click);
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
            this.btnRoleRefresh.Click += new System.EventHandler(this.button5_Click);
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
            this.btnRoleSearch.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 29);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 459);
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
        private System.Windows.Forms.Button btnUserGrant;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserSeach;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.DataGridView RoleGridView;
        private System.Windows.Forms.Button btnRoleGrant;
        private System.Windows.Forms.Button btnRoleDelete;
        private System.Windows.Forms.Button btnRoleEdit;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.Button btnRoleSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUserRefresh;
        private System.Windows.Forms.Button btnRoleRefresh;
    }
}