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
            this.label6 = new System.Windows.Forms.Label();
            this.txtColGrant = new System.Windows.Forms.TextBox();
            this.txtOnGrant = new System.Windows.Forms.TextBox();
            this.txtPerGrant = new System.Windows.Forms.TextBox();
            this.btnUserPrivExit = new System.Windows.Forms.Button();
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
            this.btnRolePrivView.Text = "Search";
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
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(777, 433);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 34);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.Text = "Accept";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Grant";
            // 
            // txtColGrant
            // 
            this.txtColGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColGrant.Location = new System.Drawing.Point(638, 297);
            this.txtColGrant.Name = "txtColGrant";
            this.txtColGrant.Size = new System.Drawing.Size(223, 29);
            this.txtColGrant.TabIndex = 18;
            // 
            // txtOnGrant
            // 
            this.txtOnGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnGrant.Location = new System.Drawing.Point(638, 230);
            this.txtOnGrant.Name = "txtOnGrant";
            this.txtOnGrant.Size = new System.Drawing.Size(223, 29);
            this.txtOnGrant.TabIndex = 19;
            this.txtOnGrant.TextChanged += new System.EventHandler(this.txtOnGrant_TextChanged);
            // 
            // txtPerGrant
            // 
            this.txtPerGrant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerGrant.Location = new System.Drawing.Point(638, 163);
            this.txtPerGrant.Name = "txtPerGrant";
            this.txtPerGrant.Size = new System.Drawing.Size(223, 29);
            this.txtPerGrant.TabIndex = 20;
            this.txtPerGrant.TextChanged += new System.EventHandler(this.txtPerGrant_TextChanged);
            // 
            // btnUserPrivExit
            // 
            this.btnUserPrivExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivExit.Location = new System.Drawing.Point(388, 84);
            this.btnUserPrivExit.Name = "btnUserPrivExit";
            this.btnUserPrivExit.Size = new System.Drawing.Size(75, 29);
            this.btnUserPrivExit.TabIndex = 14;
            this.btnUserPrivExit.Text = "Revoke";
            this.btnUserPrivExit.UseVisualStyleBackColor = true;
            this.btnUserPrivExit.Click += new System.EventHandler(this.btnUserPrivExit_Click);
            // 
            // FormRoleViewPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 555);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.checkBoxGrant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColGrant);
            this.Controls.Add(this.txtOnGrant);
            this.Controls.Add(this.txtPerGrant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRolePrivView);
            this.Controls.Add(this.txtRolePriv);
            this.Controls.Add(this.btnUserPrivExit);
            this.Controls.Add(this.RolePrivGridView);
            this.Controls.Add(this.label1);
            this.Name = "FormRoleViewPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoleViewPriv";
            this.Load += new System.EventHandler(this.FormRoleViewPriv_Load_1);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColGrant;
        private System.Windows.Forms.TextBox txtOnGrant;
        private System.Windows.Forms.TextBox txtPerGrant;
        private System.Windows.Forms.Button btnUserPrivExit;
    }
}