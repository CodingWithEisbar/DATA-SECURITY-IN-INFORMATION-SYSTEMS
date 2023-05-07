namespace WindowsFormsApp1.Admin
{
    partial class GrantAndEditPrivilegesUserOrRule
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
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.cbbPrivilege = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbRoleOrUserName = new System.Windows.Forms.TextBox();
            this.txbColumn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chboxWithGrantOption = new System.Windows.Forms.CheckBox();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.cbbUSER = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbbTable
            // 
            this.cbbTable.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Items.AddRange(new object[] {
            "NHANVIEN",
            "PHONGBAN",
            "DEAN",
            "PHANCONG"});
            this.cbbTable.Location = new System.Drawing.Point(291, 269);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(219, 31);
            this.cbbTable.TabIndex = 5;
            this.cbbTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbPrivilege
            // 
            this.cbbPrivilege.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivilege.FormattingEnabled = true;
            this.cbbPrivilege.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE",
            "DELETE",
            "SELECT"});
            this.cbbPrivilege.Location = new System.Drawing.Point(291, 182);
            this.cbbPrivilege.Name = "cbbPrivilege";
            this.cbbPrivilege.Size = new System.Drawing.Size(219, 31);
            this.cbbPrivilege.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bảng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cột(Update)";
  
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivilege.Location = new System.Drawing.Point(196, 540);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(159, 34);
            this.btnGrantPrivilege.TabIndex = 11;
            this.btnGrantPrivilege.Text = "Cấp Quyền";
            this.btnGrantPrivilege.UseVisualStyleBackColor = true;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(555, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 37);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Gán quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "ROLE/USER NAME";
            // 
            // txbRoleOrUserName
            // 
            this.txbRoleOrUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoleOrUserName.Location = new System.Drawing.Point(291, 98);
            this.txbRoleOrUserName.Name = "txbRoleOrUserName";
            this.txbRoleOrUserName.Size = new System.Drawing.Size(219, 32);
            this.txbRoleOrUserName.TabIndex = 21;
            // 
            // txbColumn
            // 
            this.txbColumn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbColumn.Location = new System.Drawing.Point(291, 346);
            this.txbColumn.Name = "txbColumn";
            this.txbColumn.Size = new System.Drawing.Size(219, 32);
            this.txbColumn.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(627, 280);
            this.dataGridView1.TabIndex = 23;
     
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "(Dựa vào bảng bên cạnh để điền)";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "vd: x,y,z";
            // 
            // chboxWithGrantOption
            // 
            this.chboxWithGrantOption.AutoSize = true;
            this.chboxWithGrantOption.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxWithGrantOption.Location = new System.Drawing.Point(196, 462);
            this.chboxWithGrantOption.Name = "chboxWithGrantOption";
            this.chboxWithGrantOption.Size = new System.Drawing.Size(172, 27);
            this.chboxWithGrantOption.TabIndex = 27;
            this.chboxWithGrantOption.Text = "with grant option";
            this.chboxWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantRole.Location = new System.Drawing.Point(814, 540);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(159, 34);
            this.btnGrantRole.TabIndex = 28;
            this.btnGrantRole.Text = "Gán Role";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Grant Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(848, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "to user";
            // 
            // cbbRole
            // 
            this.cbbRole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(610, 461);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(219, 31);
            this.cbbRole.TabIndex = 33;

            // 
            // cbbUSER
            // 
            this.cbbUSER.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUSER.FormattingEnabled = true;
            this.cbbUSER.Location = new System.Drawing.Point(947, 462);
            this.cbbUSER.Name = "cbbUSER";
            this.cbbUSER.Size = new System.Drawing.Size(219, 31);
            this.cbbUSER.TabIndex = 34;
            // 
            // GrantAndEditPrivilegesUserOrRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1216, 642);
            this.Controls.Add(this.cbbUSER);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGrantRole);
            this.Controls.Add(this.chboxWithGrantOption);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbColumn);
            this.Controls.Add(this.txbRoleOrUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnGrantPrivilege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPrivilege);
            this.Controls.Add(this.cbbTable);
            this.Controls.Add(this.btnBack);
            this.Name = "GrantAndEditPrivilegesUserOrRule";
            this.Text = "GrantAndEditPrivilegesUserOrRule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.ComboBox cbbPrivilege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrantPrivilege;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbRoleOrUserName;
        private System.Windows.Forms.TextBox txbColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chboxWithGrantOption;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.ComboBox cbbUSER;
    }
}