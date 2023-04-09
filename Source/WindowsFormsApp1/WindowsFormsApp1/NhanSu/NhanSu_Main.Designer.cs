
namespace WindowsFormsApp1.NhanSu
{
    partial class NhanSu_Main
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile_Nhansu = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 259);
            this.panel2.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(157, 168);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(149, 42);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Log Out";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(157, 87);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(149, 27);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(91, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(288, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nhân viên nhân sự";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDepartment);
            this.panel1.Controls.Add(this.btnProfile_Nhansu);
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 503);
            this.panel1.TabIndex = 3;
            // 
            // btnProfile_Nhansu
            // 
            this.btnProfile_Nhansu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile_Nhansu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile_Nhansu.FlatAppearance.BorderSize = 0;
            this.btnProfile_Nhansu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProfile_Nhansu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProfile_Nhansu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile_Nhansu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile_Nhansu.Location = new System.Drawing.Point(4, 0);
            this.btnProfile_Nhansu.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile_Nhansu.Name = "btnProfile_Nhansu";
            this.btnProfile_Nhansu.Size = new System.Drawing.Size(447, 53);
            this.btnProfile_Nhansu.TabIndex = 2;
            this.btnProfile_Nhansu.Text = "Profile";
            this.btnProfile_Nhansu.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(4, 61);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(447, 53);
            this.btnDepartment.TabIndex = 3;
            this.btnDepartment.Text = "Phòng Ban";
            this.btnDepartment.UseVisualStyleBackColor = false;
            // 
            // NhanSu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "NhanSu_Main";
            this.Text = "NhanSu";
            this.Load += new System.EventHandler(this.NhanSu_Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile_Nhansu;
        private System.Windows.Forms.Button btnDepartment;
    }
}