namespace WindowsFormsApp1.TaiChinh
{
    partial class ThongTinTaiChinh
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
            this.thongTinTaiChinhLabel = new System.Windows.Forms.TextBox();
            this.thongTinTaiChinhDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiChinhDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // thongTinTaiChinhLabel
            // 
            this.thongTinTaiChinhLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thongTinTaiChinhLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinTaiChinhLabel.ForeColor = System.Drawing.Color.Red;
            this.thongTinTaiChinhLabel.Location = new System.Drawing.Point(235, 70);
            this.thongTinTaiChinhLabel.Name = "thongTinTaiChinhLabel";
            this.thongTinTaiChinhLabel.Size = new System.Drawing.Size(394, 37);
            this.thongTinTaiChinhLabel.TabIndex = 20;
            this.thongTinTaiChinhLabel.Text = "Thông tin nhân viên tài chính";
            // 
            // thongTinTaiChinhDataGridView
            // 
            this.thongTinTaiChinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongTinTaiChinhDataGridView.Location = new System.Drawing.Point(12, 113);
            this.thongTinTaiChinhDataGridView.Name = "thongTinTaiChinhDataGridView";
            this.thongTinTaiChinhDataGridView.ReadOnly = true;
            this.thongTinTaiChinhDataGridView.RowHeadersWidth = 62;
            this.thongTinTaiChinhDataGridView.Size = new System.Drawing.Size(861, 359);
            this.thongTinTaiChinhDataGridView.TabIndex = 21;
            // 
            // ThongTinTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(882, 481);
            this.Controls.Add(this.thongTinTaiChinhDataGridView);
            this.Controls.Add(this.thongTinTaiChinhLabel);
            this.Controls.Add(this.btnBack);
            this.Name = "ThongTinTaiChinh";
            this.Text = "Thông tin Tài chính";
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiChinhDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox thongTinTaiChinhLabel;
        private System.Windows.Forms.DataGridView thongTinTaiChinhDataGridView;
    }
}