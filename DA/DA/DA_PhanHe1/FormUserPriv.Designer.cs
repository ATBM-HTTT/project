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
            this.btnUserPrivView = new System.Windows.Forms.Button();
            this.txtUserPriv = new System.Windows.Forms.TextBox();
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
            this.UserPrivGridView.Size = new System.Drawing.Size(530, 425);
            this.UserPrivGridView.TabIndex = 1;
            // 
            // btnUserPrivExit
            // 
            this.btnUserPrivExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivExit.Location = new System.Drawing.Point(457, 91);
            this.btnUserPrivExit.Name = "btnUserPrivExit";
            this.btnUserPrivExit.Size = new System.Drawing.Size(63, 29);
            this.btnUserPrivExit.TabIndex = 3;
            this.btnUserPrivExit.Text = "Exit";
            this.btnUserPrivExit.UseVisualStyleBackColor = true;
            this.btnUserPrivExit.Click += new System.EventHandler(this.btnUserPrivEdit_Click);
            // 
            // btnUserPrivView
            // 
            this.btnUserPrivView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivView.Location = new System.Drawing.Point(247, 91);
            this.btnUserPrivView.Name = "btnUserPrivView";
            this.btnUserPrivView.Size = new System.Drawing.Size(70, 29);
            this.btnUserPrivView.TabIndex = 11;
            this.btnUserPrivView.Text = "View";
            this.btnUserPrivView.UseVisualStyleBackColor = true;
            this.btnUserPrivView.Click += new System.EventHandler(this.btnUserPrivView_Click);
            // 
            // txtUserPriv
            // 
            this.txtUserPriv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPriv.Location = new System.Drawing.Point(12, 91);
            this.txtUserPriv.Name = "txtUserPriv";
            this.txtUserPriv.Size = new System.Drawing.Size(223, 29);
            this.txtUserPriv.TabIndex = 10;
            // 
            // FormUserPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 561);
            this.Controls.Add(this.btnUserPrivView);
            this.Controls.Add(this.txtUserPriv);
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
        private System.Windows.Forms.Button btnUserPrivView;
        private System.Windows.Forms.TextBox txtUserPriv;
    }
}