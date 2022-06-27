namespace DA_PhanHe1
{
    partial class FormRoleViewPriv
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
            this.btnRolePrivView = new System.Windows.Forms.Button();
            this.txtRolePriv = new System.Windows.Forms.TextBox();
            this.RolePrivGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.checkBoxGrant = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUserPrivExit = new System.Windows.Forms.Button();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIVILEGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRANTABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RolePrivGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRolePrivView
            // 
            this.btnRolePrivView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolePrivView.Location = new System.Drawing.Point(245, 77);
            this.btnRolePrivView.Name = "btnRolePrivView";
            this.btnRolePrivView.Size = new System.Drawing.Size(70, 29);
            this.btnRolePrivView.TabIndex = 16;
            this.btnRolePrivView.Text = "Search";
            this.btnRolePrivView.UseVisualStyleBackColor = true;
            this.btnRolePrivView.Click += new System.EventHandler(this.btnRolePrivView_Click);
            // 
            // txtRolePriv
            // 
            this.txtRolePriv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolePriv.Location = new System.Drawing.Point(12, 77);
            this.txtRolePriv.Name = "txtRolePriv";
            this.txtRolePriv.Size = new System.Drawing.Size(209, 29);
            this.txtRolePriv.TabIndex = 15;
            // 
            // RolePrivGridView
            // 
            this.RolePrivGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolePrivGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLE_NAME,
            this.PRIVILEGE,
            this.COLUMN_NAME,
            this.GRANTABLE});
            this.RolePrivGridView.Location = new System.Drawing.Point(-2, 152);
            this.RolePrivGridView.Name = "RolePrivGridView";
            this.RolePrivGridView.Size = new System.Drawing.Size(465, 345);
            this.RolePrivGridView.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, -44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Privileges";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Role Privileges";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(732, 433);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(85, 34);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.Text = "Grant";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // checkBoxGrant
            // 
            this.checkBoxGrant.AutoSize = true;
            this.checkBoxGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGrant.Location = new System.Drawing.Point(638, 369);
            this.checkBoxGrant.Name = "checkBoxGrant";
            this.checkBoxGrant.Size = new System.Drawing.Size(214, 25);
            this.checkBoxGrant.TabIndex = 25;
            this.checkBoxGrant.Text = "Grant with another user";
            this.checkBoxGrant.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Permission";
            // 
            // btnUserPrivExit
            // 
            this.btnUserPrivExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivExit.Location = new System.Drawing.Point(567, 433);
            this.btnUserPrivExit.Name = "btnUserPrivExit";
            this.btnUserPrivExit.Size = new System.Drawing.Size(85, 34);
            this.btnUserPrivExit.TabIndex = 14;
            this.btnUserPrivExit.Text = "Revoke";
            this.btnUserPrivExit.UseVisualStyleBackColor = true;
            this.btnUserPrivExit.Click += new System.EventHandler(this.btnUserPrivExit_Click);
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
            this.cbPermission.Location = new System.Drawing.Point(663, 164);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(189, 28);
            this.cbPermission.TabIndex = 27;
            this.cbPermission.SelectedIndexChanged += new System.EventHandler(this.cbPermission_SelectedIndexChanged);
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(663, 231);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(189, 28);
            this.cbTable.TabIndex = 28;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // cbColumn
            // 
            this.cbColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Location = new System.Drawing.Point(663, 298);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(189, 28);
            this.cbColumn.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.TABLE_NAME.HeaderText = "TABLE_NAME";
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.Width = 120;
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
            // 
            // GRANTABLE
            // 
            this.GRANTABLE.DataPropertyName = "GRANTABLE";
            this.GRANTABLE.HeaderText = "GRANTABLE";
            this.GRANTABLE.Name = "GRANTABLE";
            // 
            // Refesh
            // 
            this.Refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refesh.Location = new System.Drawing.Point(12, 114);
            this.Refesh.Name = "Refesh";
            this.Refesh.Size = new System.Drawing.Size(75, 32);
            this.Refesh.TabIndex = 31;
            this.Refesh.Text = "Refesh";
            this.Refesh.UseVisualStyleBackColor = true;
            this.Refesh.Click += new System.EventHandler(this.Refesh_Click);
            // 
            // FormRoleViewPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 555);
            this.Controls.Add(this.Refesh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbPermission);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.checkBoxGrant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRolePrivView);
            this.Controls.Add(this.txtRolePriv);
            this.Controls.Add(this.btnUserPrivExit);
            this.Controls.Add(this.RolePrivGridView);
            this.Controls.Add(this.label1);
            this.Name = "FormRoleViewPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoleViewPriv";
            this.Load += new System.EventHandler(this.FormRoleViewPriv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolePrivGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRolePrivView;
        private System.Windows.Forms.TextBox txtRolePriv;
        private System.Windows.Forms.DataGridView RolePrivGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.CheckBox checkBoxGrant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUserPrivExit;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIVILEGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRANTABLE;
        private System.Windows.Forms.Button Refesh;
    }
}