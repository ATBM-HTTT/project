namespace DA_PhanHe1
{
    partial class FormUserPriv
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserPrivGridView = new System.Windows.Forms.DataGridView();
            this.table_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIVILEGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRANTABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUserPrivExit = new System.Windows.Forms.Button();
            this.btnUserPrivSearch = new System.Windows.Forms.Button();
            this.txtUserPriv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxGrant = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnUserPrivRevoke = new System.Windows.Forms.Button();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserPrivGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Privileges";
            // 
            // UserPrivGridView
            // 
            this.UserPrivGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserPrivGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_name,
            this.PRIVILEGE,
            this.COLUMN_NAME,
            this.GRANTABLE});
            this.UserPrivGridView.Location = new System.Drawing.Point(0, 138);
            this.UserPrivGridView.Name = "UserPrivGridView";
            this.UserPrivGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserPrivGridView.Size = new System.Drawing.Size(530, 379);
            this.UserPrivGridView.TabIndex = 1;
            // 
            // table_name
            // 
            this.table_name.DataPropertyName = "table_name";
            this.table_name.HeaderText = "Table name";
            this.table_name.Name = "table_name";
            this.table_name.Width = 150;
            // 
            // PRIVILEGE
            // 
            this.PRIVILEGE.DataPropertyName = "PRIVILEGE";
            this.PRIVILEGE.HeaderText = "PRIVILEGE";
            this.PRIVILEGE.Name = "PRIVILEGE";
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.Width = 150;
            // 
            // GRANTABLE
            // 
            this.GRANTABLE.DataPropertyName = "GRANTABLE";
            this.GRANTABLE.HeaderText = "GRANTABLE";
            this.GRANTABLE.Name = "GRANTABLE";
            // 
            // btnUserPrivExit
            // 
            this.btnUserPrivExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivExit.Location = new System.Drawing.Point(467, 523);
            this.btnUserPrivExit.Name = "btnUserPrivExit";
            this.btnUserPrivExit.Size = new System.Drawing.Size(63, 29);
            this.btnUserPrivExit.TabIndex = 3;
            this.btnUserPrivExit.Text = "Exit";
            this.btnUserPrivExit.UseVisualStyleBackColor = true;
            this.btnUserPrivExit.Click += new System.EventHandler(this.btnUserPrivEdit_Click);
            // 
            // btnUserPrivSearch
            // 
            this.btnUserPrivSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivSearch.Location = new System.Drawing.Point(246, 65);
            this.btnUserPrivSearch.Name = "btnUserPrivSearch";
            this.btnUserPrivSearch.Size = new System.Drawing.Size(70, 29);
            this.btnUserPrivSearch.TabIndex = 11;
            this.btnUserPrivSearch.Text = "Search";
            this.btnUserPrivSearch.UseVisualStyleBackColor = true;
            this.btnUserPrivSearch.Click += new System.EventHandler(this.btnUserPrivSeach_Click);
            // 
            // txtUserPriv
            // 
            this.txtUserPriv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPriv.Location = new System.Drawing.Point(11, 65);
            this.txtUserPriv.Name = "txtUserPriv";
            this.txtUserPriv.Size = new System.Drawing.Size(223, 29);
            this.txtUserPriv.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Permission";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "On";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Column";
            // 
            // checkBoxGrant
            // 
            this.checkBoxGrant.AutoSize = true;
            this.checkBoxGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGrant.Location = new System.Drawing.Point(707, 382);
            this.checkBoxGrant.Name = "checkBoxGrant";
            this.checkBoxGrant.Size = new System.Drawing.Size(214, 25);
            this.checkBoxGrant.TabIndex = 14;
            this.checkBoxGrant.Text = "Grant with another user";
            this.checkBoxGrant.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(809, 446);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(87, 34);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Grant";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnUserPrivRevoke
            // 
            this.btnUserPrivRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivRevoke.Location = new System.Drawing.Point(613, 446);
            this.btnUserPrivRevoke.Name = "btnUserPrivRevoke";
            this.btnUserPrivRevoke.Size = new System.Drawing.Size(86, 34);
            this.btnUserPrivRevoke.TabIndex = 3;
            this.btnUserPrivRevoke.Text = "Revoke";
            this.btnUserPrivRevoke.UseVisualStyleBackColor = true;
            this.btnUserPrivRevoke.Click += new System.EventHandler(this.btnUserPrivRevoke_Click);
            // 
            // cbPermission
            // 
            this.cbPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.cbPermission.Location = new System.Drawing.Point(707, 181);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(223, 28);
            this.cbPermission.TabIndex = 17;
            this.cbPermission.SelectedIndexChanged += new System.EventHandler(this.cbPermission_SelectedIndexChanged);
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(707, 244);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(223, 28);
            this.cbTable.TabIndex = 18;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // cbColumn
            // 
            this.cbColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Items.AddRange(new object[] {
            "ALL COLUMN"});
            this.cbColumn.Location = new System.Drawing.Point(707, 315);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(223, 28);
            this.cbColumn.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUserPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbPermission);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.checkBoxGrant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUserPrivSearch);
            this.Controls.Add(this.txtUserPriv);
            this.Controls.Add(this.btnUserPrivRevoke);
            this.Controls.Add(this.btnUserPrivExit);
            this.Controls.Add(this.UserPrivGridView);
            this.Controls.Add(this.label1);
            this.Name = "FormUserPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormUserPriv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPrivGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UserPrivGridView;
        private System.Windows.Forms.Button btnUserPrivExit;
        private System.Windows.Forms.Button btnUserPrivSearch;
        private System.Windows.Forms.TextBox txtUserPriv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxGrant;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnUserPrivRevoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIVILEGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRANTABLE;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.Button button1;
    }
}