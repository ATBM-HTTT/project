namespace DA_PhanHe1
{
    partial class FormUserList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.btnUserSeach = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserGrant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(12, 102);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(229, 29);
            this.txtUserSearch.TabIndex = 2;
            // 
            // btnUserSeach
            // 
            this.btnUserSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSeach.Location = new System.Drawing.Point(247, 102);
            this.btnUserSeach.Name = "btnUserSeach";
            this.btnUserSeach.Size = new System.Drawing.Size(63, 29);
            this.btnUserSeach.TabIndex = 3;
            this.btnUserSeach.Text = "Search";
            this.btnUserSeach.UseVisualStyleBackColor = true;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.Location = new System.Drawing.Point(602, 101);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(63, 29);
            this.btnUserAdd.TabIndex = 3;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserEdit.Location = new System.Drawing.Point(671, 101);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(63, 29);
            this.btnUserEdit.TabIndex = 3;
            this.btnUserEdit.Text = "Edit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(740, 101);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(63, 29);
            this.btnUserDelete.TabIndex = 3;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnUserGrant
            // 
            this.btnUserGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserGrant.Location = new System.Drawing.Point(809, 101);
            this.btnUserGrant.Name = "btnUserGrant";
            this.btnUserGrant.Size = new System.Drawing.Size(63, 29);
            this.btnUserGrant.TabIndex = 3;
            this.btnUserGrant.Text = "Grant";
            this.btnUserGrant.UseVisualStyleBackColor = true;
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnUserGrant);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnUserEdit);
            this.Controls.Add(this.btnUserAdd);
            this.Controls.Add(this.btnUserSeach);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormUserList";
            this.Text = "FormUserList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Button btnUserSeach;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserGrant;
    }
}