namespace WindowsFormsApp1.TruongDeAn
{
    partial class TruongDeAn_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChinhSuaThongTinDeAn = new System.Windows.Forms.Button();
            this.btnXemDeAn = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.truongDeAnTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnChinhSuaThongTinDeAn);
            this.panel1.Controls.Add(this.btnXemDeAn);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 629);
            this.panel1.TabIndex = 6;
            // 
            // btnChinhSuaThongTinDeAn
            // 
            this.btnChinhSuaThongTinDeAn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChinhSuaThongTinDeAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSuaThongTinDeAn.FlatAppearance.BorderSize = 0;
            this.btnChinhSuaThongTinDeAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChinhSuaThongTinDeAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChinhSuaThongTinDeAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaThongTinDeAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaThongTinDeAn.Location = new System.Drawing.Point(0, 152);
            this.btnChinhSuaThongTinDeAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChinhSuaThongTinDeAn.Name = "btnChinhSuaThongTinDeAn";
            this.btnChinhSuaThongTinDeAn.Size = new System.Drawing.Size(512, 66);
            this.btnChinhSuaThongTinDeAn.TabIndex = 4;
            this.btnChinhSuaThongTinDeAn.Text = "Chỉnh sửa/Cập nhật đề án";
            this.btnChinhSuaThongTinDeAn.UseVisualStyleBackColor = false;
            this.btnChinhSuaThongTinDeAn.Click += new System.EventHandler(this.btnChinhSuaThongTinDeAn_Click);
            // 
            // btnXemDeAn
            // 
            this.btnXemDeAn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXemDeAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemDeAn.FlatAppearance.BorderSize = 0;
            this.btnXemDeAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXemDeAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXemDeAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDeAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDeAn.Location = new System.Drawing.Point(0, 75);
            this.btnXemDeAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemDeAn.Name = "btnXemDeAn";
            this.btnXemDeAn.Size = new System.Drawing.Size(508, 66);
            this.btnXemDeAn.TabIndex = 3;
            this.btnXemDeAn.Text = "Xem đề án";
            this.btnXemDeAn.UseVisualStyleBackColor = false;
            this.btnXemDeAn.Click += new System.EventHandler(this.btnXemDeAn_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(4, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(502, 66);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.truongDeAnTextbox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 338);
            this.panel2.TabIndex = 5;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(177, 142);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(168, 52);
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
            this.txbUserName.Location = new System.Drawing.Point(177, 109);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(168, 33);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // truongDeAnTextbox
            // 
            this.truongDeAnTextbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.truongDeAnTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truongDeAnTextbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truongDeAnTextbox.ForeColor = System.Drawing.Color.Red;
            this.truongDeAnTextbox.Location = new System.Drawing.Point(98, 57);
            this.truongDeAnTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.truongDeAnTextbox.Name = "truongDeAnTextbox";
            this.truongDeAnTextbox.ReadOnly = true;
            this.truongDeAnTextbox.Size = new System.Drawing.Size(324, 42);
            this.truongDeAnTextbox.TabIndex = 0;
            this.truongDeAnTextbox.Text = "TRƯỞNG ĐỀ ÁN";
            this.truongDeAnTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TruongDeAn_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TruongDeAn_Main";
            this.Text = "DashBoard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox truongDeAnTextbox;
        private System.Windows.Forms.Button btnXemDeAn;
        private System.Windows.Forms.Button btnChinhSuaThongTinDeAn;
    }
}