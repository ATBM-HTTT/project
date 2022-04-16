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
            this.btnUserPrivExit = new System.Windows.Forms.Button();
            this.RolePrivGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RolePrivGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRolePrivView
            // 
            this.btnRolePrivView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolePrivView.Location = new System.Drawing.Point(199, 84);
            this.btnRolePrivView.Name = "btnRolePrivView";
            this.btnRolePrivView.Size = new System.Drawing.Size(70, 29);
            this.btnRolePrivView.TabIndex = 16;
            this.btnRolePrivView.Text = "View";
            this.btnRolePrivView.UseVisualStyleBackColor = true;
            this.btnRolePrivView.Click += new System.EventHandler(this.btnRolePrivView_Click);
            // 
            // txtRolePriv
            // 
            this.txtRolePriv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolePriv.Location = new System.Drawing.Point(12, 85);
            this.txtRolePriv.Name = "txtRolePriv";
            this.txtRolePriv.Size = new System.Drawing.Size(181, 29);
            this.txtRolePriv.TabIndex = 15;
            // 
            // btnUserPrivExit
            // 
            this.btnUserPrivExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivExit.Location = new System.Drawing.Point(388, 84);
            this.btnUserPrivExit.Name = "btnUserPrivExit";
            this.btnUserPrivExit.Size = new System.Drawing.Size(63, 29);
            this.btnUserPrivExit.TabIndex = 14;
            this.btnUserPrivExit.Text = "Exit";
            this.btnUserPrivExit.UseVisualStyleBackColor = true;
            this.btnUserPrivExit.Click += new System.EventHandler(this.btnUserPrivExit_Click);
            // 
            // RolePrivGridView
            // 
            this.RolePrivGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolePrivGridView.Location = new System.Drawing.Point(-2, 132);
            this.RolePrivGridView.Name = "RolePrivGridView";
            this.RolePrivGridView.Size = new System.Drawing.Size(465, 425);
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
            this.label2.Location = new System.Drawing.Point(137, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Role Privileges";
            // 
            // FormRoleViewPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRolePrivView);
            this.Controls.Add(this.txtRolePriv);
            this.Controls.Add(this.btnUserPrivExit);
            this.Controls.Add(this.RolePrivGridView);
            this.Controls.Add(this.label1);
            this.Name = "FormRoleViewPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoleViewPriv";
            ((System.ComponentModel.ISupportInitialize)(this.RolePrivGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRolePrivView;
        private System.Windows.Forms.TextBox txtRolePriv;
        private System.Windows.Forms.Button btnUserPrivExit;
        private System.Windows.Forms.DataGridView RolePrivGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}