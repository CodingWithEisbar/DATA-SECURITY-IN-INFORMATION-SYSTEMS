namespace WindowsFormsApp1.TruongDeAn
{
    partial class ThongTinTruongDeAn
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
            this.thongTinTruongDeAnLabel = new System.Windows.Forms.TextBox();
            this.thongTinTruongDADataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTruongDADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(18, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 52);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // thongTinTruongDeAnLabel
            // 
            this.thongTinTruongDeAnLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thongTinTruongDeAnLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinTruongDeAnLabel.ForeColor = System.Drawing.Color.Red;
            this.thongTinTruongDeAnLabel.Location = new System.Drawing.Point(414, 103);
            this.thongTinTruongDeAnLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thongTinTruongDeAnLabel.Name = "thongTinTruongDeAnLabel";
            this.thongTinTruongDeAnLabel.Size = new System.Drawing.Size(462, 56);
            this.thongTinTruongDeAnLabel.TabIndex = 19;
            this.thongTinTruongDeAnLabel.Text = "Thông tin trưởng đề án";
            // 
            // thongTinTruongDADataGridView
            // 
            this.thongTinTruongDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongTinTruongDADataGridView.Location = new System.Drawing.Point(18, 200);
            this.thongTinTruongDADataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thongTinTruongDADataGridView.Name = "thongTinTruongDADataGridView";
            this.thongTinTruongDADataGridView.ReadOnly = true;
            this.thongTinTruongDADataGridView.RowHeadersWidth = 62;
            this.thongTinTruongDADataGridView.Size = new System.Drawing.Size(1292, 552);
            this.thongTinTruongDADataGridView.TabIndex = 20;
            // 
            // ThongTinTruongDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1329, 771);
            this.Controls.Add(this.thongTinTruongDADataGridView);
            this.Controls.Add(this.thongTinTruongDeAnLabel);
            this.Controls.Add(this.btnBack);
            this.Name = "ThongTinTruongDeAn";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Trưởng đề án";
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTruongDADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox thongTinTruongDeAnLabel;
        private System.Windows.Forms.DataGridView thongTinTruongDADataGridView;
    }
}