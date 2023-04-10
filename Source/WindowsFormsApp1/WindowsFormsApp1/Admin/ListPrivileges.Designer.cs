namespace WindowsFormsApp1.Admin
{
    partial class ListPrivileges
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
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbUserOrRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowTablePrivilege = new System.Windows.Forms.Button();
            this.btnOnColUpdatePriv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(31, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(414, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 37);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Quyền của người dùng";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 325);
            this.dataGridView1.TabIndex = 6;
            // 
            // txbUserOrRole
            // 
            this.txbUserOrRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserOrRole.Location = new System.Drawing.Point(554, 159);
            this.txbUserOrRole.Name = "txbUserOrRole";
            this.txbUserOrRole.Size = new System.Drawing.Size(316, 39);
            this.txbUserOrRole.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên User/Role";
            // 
            // btnShowTablePrivilege
            // 
            this.btnShowTablePrivilege.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTablePrivilege.Location = new System.Drawing.Point(381, 245);
            this.btnShowTablePrivilege.Name = "btnShowTablePrivilege";
            this.btnShowTablePrivilege.Size = new System.Drawing.Size(118, 34);
            this.btnShowTablePrivilege.TabIndex = 9;
            this.btnShowTablePrivilege.Text = "Xem";
            this.btnShowTablePrivilege.UseVisualStyleBackColor = true;
            this.btnShowTablePrivilege.Click += new System.EventHandler(this.btnShowTablePrivilege_Click);
            // 
            // btnOnColUpdatePriv
            // 
            this.btnOnColUpdatePriv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnColUpdatePriv.Location = new System.Drawing.Point(652, 245);
            this.btnOnColUpdatePriv.Name = "btnOnColUpdatePriv";
            this.btnOnColUpdatePriv.Size = new System.Drawing.Size(218, 34);
            this.btnOnColUpdatePriv.TabIndex = 10;
            this.btnOnColUpdatePriv.Text = "Xem update theo cột";
            this.btnOnColUpdatePriv.UseVisualStyleBackColor = true;
            this.btnOnColUpdatePriv.Click += new System.EventHandler(this.btnOnColUpdatePriv_Click);
            // 
            // ListPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 667);
            this.Controls.Add(this.btnOnColUpdatePriv);
            this.Controls.Add(this.btnShowTablePrivilege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbUserOrRole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnBack);
            this.Name = "ListPrivileges";
            this.Text = "ListPrivileges";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbUserOrRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTablePrivilege;
        private System.Windows.Forms.Button btnOnColUpdatePriv;
    }
}