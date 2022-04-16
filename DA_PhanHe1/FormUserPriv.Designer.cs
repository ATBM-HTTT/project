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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerGrant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOnGrant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColGrant = new System.Windows.Forms.TextBox();
            this.checkBoxGrant = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Grant";
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
            // txtPerGrant
            // 
            this.txtPerGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerGrant.Location = new System.Drawing.Point(707, 176);
            this.txtPerGrant.Name = "txtPerGrant";
            this.txtPerGrant.Size = new System.Drawing.Size(223, 29);
            this.txtPerGrant.TabIndex = 10;
            this.txtPerGrant.TextChanged += new System.EventHandler(this.txtPerGrant_TextChanged);
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
            // txtOnGrant
            // 
            this.txtOnGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnGrant.Location = new System.Drawing.Point(707, 243);
            this.txtOnGrant.Name = "txtOnGrant";
            this.txtOnGrant.Size = new System.Drawing.Size(223, 29);
            this.txtOnGrant.TabIndex = 10;
            this.txtOnGrant.TextChanged += new System.EventHandler(this.txtOnGrant_TextChanged);
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
            // txtColGrant
            // 
            this.txtColGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColGrant.Location = new System.Drawing.Point(707, 310);
            this.txtColGrant.Name = "txtColGrant";
            this.txtColGrant.Size = new System.Drawing.Size(223, 29);
            this.txtColGrant.TabIndex = 10;
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
            this.btnAccept.Location = new System.Drawing.Point(846, 446);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 34);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
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
            this.ClientSize = new System.Drawing.Size(951, 561);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.checkBoxGrant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColGrant);
            this.Controls.Add(this.txtOnGrant);
            this.Controls.Add(this.txtPerGrant);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerGrant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOnGrant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColGrant;
        private System.Windows.Forms.CheckBox checkBoxGrant;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnUserPrivRevoke;
    }
}