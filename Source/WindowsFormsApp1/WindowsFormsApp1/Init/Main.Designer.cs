namespace WindowsFormsApp1.Admin
{
    partial class Main
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txbShowUSERNAME = new System.Windows.Forms.TextBox();
            this.txbSHOWUSERROLE = new System.Windows.Forms.TextBox();
            this.btnUSER = new System.Windows.Forms.Button();
            this.btnPrivilege = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.btnRevokePrivilege = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowTableView = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.txbShowUSERNAME);
            this.panel2.Controls.Add(this.txbSHOWUSERROLE);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 265);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(116, 139);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txbShowUSERNAME
            // 
            this.txbShowUSERNAME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbShowUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbShowUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbShowUSERNAME.Location = new System.Drawing.Point(116, 73);
            this.txbShowUSERNAME.Name = "txbShowUSERNAME";
            this.txbShowUSERNAME.ReadOnly = true;
            this.txbShowUSERNAME.Size = new System.Drawing.Size(112, 22);
            this.txbShowUSERNAME.TabIndex = 1;
            this.txbShowUSERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSHOWUSERROLE
            // 
            this.txbSHOWUSERROLE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbSHOWUSERROLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSHOWUSERROLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSHOWUSERROLE.ForeColor = System.Drawing.Color.Red;
            this.txbSHOWUSERROLE.Location = new System.Drawing.Point(105, 15);
            this.txbSHOWUSERROLE.Name = "txbSHOWUSERROLE";
            this.txbSHOWUSERROLE.ReadOnly = true;
            this.txbSHOWUSERROLE.Size = new System.Drawing.Size(134, 22);
            this.txbSHOWUSERROLE.TabIndex = 0;
            this.txbSHOWUSERROLE.Text = "DBA";
            this.txbSHOWUSERROLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSHOWUSERROLE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUSER
            // 
            this.btnUSER.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUSER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUSER.FlatAppearance.BorderSize = 0;
            this.btnUSER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUSER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUSER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSER.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSER.Location = new System.Drawing.Point(3, 0);
            this.btnUSER.Name = "btnUSER";
            this.btnUSER.Size = new System.Drawing.Size(335, 43);
            this.btnUSER.TabIndex = 2;
            this.btnUSER.Text = "User";
            this.btnUSER.UseVisualStyleBackColor = false;
            this.btnUSER.Click += new System.EventHandler(this.btnUSER_Click);
            // 
            // btnPrivilege
            // 
            this.btnPrivilege.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrivilege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrivilege.FlatAppearance.BorderSize = 0;
            this.btnPrivilege.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrivilege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrivilege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivilege.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivilege.Location = new System.Drawing.Point(3, 49);
            this.btnPrivilege.Name = "btnPrivilege";
            this.btnPrivilege.Size = new System.Drawing.Size(335, 43);
            this.btnPrivilege.TabIndex = 3;
            this.btnPrivilege.Text = "Privileges User/Role";
            this.btnPrivilege.UseVisualStyleBackColor = false;
            this.btnPrivilege.Click += new System.EventHandler(this.btnPrivilege_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(3, 98);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(335, 43);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create User/Role";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(335, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete User/Role";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(3, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(335, 43);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrantPrivilege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrantPrivilege.FlatAppearance.BorderSize = 0;
            this.btnGrantPrivilege.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGrantPrivilege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGrantPrivilege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantPrivilege.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivilege.Location = new System.Drawing.Point(3, 251);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(335, 43);
            this.btnGrantPrivilege.TabIndex = 7;
            this.btnGrantPrivilege.Text = "Grant And Edit Privileges User/Role";
            this.btnGrantPrivilege.UseVisualStyleBackColor = false;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // btnRevokePrivilege
            // 
            this.btnRevokePrivilege.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRevokePrivilege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevokePrivilege.FlatAppearance.BorderSize = 0;
            this.btnRevokePrivilege.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRevokePrivilege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRevokePrivilege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevokePrivilege.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokePrivilege.Location = new System.Drawing.Point(3, 300);
            this.btnRevokePrivilege.Name = "btnRevokePrivilege";
            this.btnRevokePrivilege.Size = new System.Drawing.Size(335, 43);
            this.btnRevokePrivilege.TabIndex = 8;
            this.btnRevokePrivilege.Text = "Revoke Privileges User/Role";
            this.btnRevokePrivilege.UseVisualStyleBackColor = false;
            this.btnRevokePrivilege.Click += new System.EventHandler(this.btnRevokePrivilege_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnShowTableView);
            this.panel1.Controls.Add(this.btnRevokePrivilege);
            this.panel1.Controls.Add(this.btnUSER);
            this.panel1.Controls.Add(this.btnGrantPrivilege);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnPrivilege);
            this.panel1.Location = new System.Drawing.Point(0, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 409);
            this.panel1.TabIndex = 0;
            // 
            // btnShowTableView
            // 
            this.btnShowTableView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowTableView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowTableView.FlatAppearance.BorderSize = 0;
            this.btnShowTableView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnShowTableView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnShowTableView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTableView.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTableView.Location = new System.Drawing.Point(6, 349);
            this.btnShowTableView.Name = "btnShowTableView";
            this.btnShowTableView.Size = new System.Drawing.Size(332, 43);
            this.btnShowTableView.TabIndex = 9;
            this.btnShowTableView.Text = "Table/View";
            this.btnShowTableView.UseVisualStyleBackColor = false;
            this.btnShowTableView.Click += new System.EventHandler(this.btnShowTableView_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1129, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSHOWUSERROLE;
        private System.Windows.Forms.TextBox txbShowUSERNAME;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUSER;
        private System.Windows.Forms.Button btnPrivilege;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGrantPrivilege;
        private System.Windows.Forms.Button btnRevokePrivilege;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowTableView;
    }
}