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
            this.btnUserPrivExit = new System.Windows.Forms.Button();
            this.btnUserPrivSearch = new System.Windows.Forms.Button();
            this.txtUserPriv = new System.Windows.Forms.TextBox();
            this.btnUserPrivRevoke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserPrivGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Privileges";
            // 
            // UserPrivGridView
            // 
            this.UserPrivGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserPrivGridView.Location = new System.Drawing.Point(0, 138);
            this.UserPrivGridView.Name = "UserPrivGridView";
            this.UserPrivGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserPrivGridView.Size = new System.Drawing.Size(530, 379);
            this.UserPrivGridView.TabIndex = 1;
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
            this.btnUserPrivSearch.Location = new System.Drawing.Point(247, 91);
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
            this.txtUserPriv.Location = new System.Drawing.Point(12, 91);
            this.txtUserPriv.Name = "txtUserPriv";
            this.txtUserPriv.Size = new System.Drawing.Size(223, 29);
            this.txtUserPriv.TabIndex = 10;
            // 
            // btnUserPrivRevoke
            // 
            this.btnUserPrivRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivRevoke.Location = new System.Drawing.Point(448, 91);
            this.btnUserPrivRevoke.Name = "btnUserPrivRevoke";
            this.btnUserPrivRevoke.Size = new System.Drawing.Size(82, 29);
            this.btnUserPrivRevoke.TabIndex = 3;
            this.btnUserPrivRevoke.Text = "Revoke";
            this.btnUserPrivRevoke.UseVisualStyleBackColor = true;
            this.btnUserPrivRevoke.Click += new System.EventHandler(this.btnUserPrivRevoke_Click);
            // 
            // FormUserPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 561);
            this.Controls.Add(this.btnUserPrivSearch);
            this.Controls.Add(this.txtUserPriv);
            this.Controls.Add(this.btnUserPrivRevoke);
            this.Controls.Add(this.btnUserPrivExit);
            this.Controls.Add(this.UserPrivGridView);
            this.Controls.Add(this.label1);
            this.Name = "FormUserPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnUserPrivRevoke;
    }
}