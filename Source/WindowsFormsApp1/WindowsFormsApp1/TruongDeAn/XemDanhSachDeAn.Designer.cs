namespace WindowsFormsApp1.TruongDeAn
{
    partial class XemDanhSachDeAn
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
            this.xemDanhSachDeAnLabel = new System.Windows.Forms.TextBox();
            this.deAnDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deAnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // xemDanhSachDeAnLabel
            // 
            this.xemDanhSachDeAnLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xemDanhSachDeAnLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemDanhSachDeAnLabel.ForeColor = System.Drawing.Color.Red;
            this.xemDanhSachDeAnLabel.Location = new System.Drawing.Point(279, 74);
            this.xemDanhSachDeAnLabel.Name = "xemDanhSachDeAnLabel";
            this.xemDanhSachDeAnLabel.Size = new System.Drawing.Size(278, 37);
            this.xemDanhSachDeAnLabel.TabIndex = 18;
            this.xemDanhSachDeAnLabel.Text = "Xem danh sách đề án";
            // 
            // deAnDataGridView
            // 
            this.deAnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deAnDataGridView.Location = new System.Drawing.Point(9, 151);
            this.deAnDataGridView.Name = "deAnDataGridView";
            this.deAnDataGridView.Size = new System.Drawing.Size(851, 396);
            this.deAnDataGridView.TabIndex = 19;
            // 
            // XemDanhSachDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(872, 559);
            this.Controls.Add(this.deAnDataGridView);
            this.Controls.Add(this.xemDanhSachDeAnLabel);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XemDanhSachDeAn";
            this.Text = "Xem danh sách đề án";
            ((System.ComponentModel.ISupportInitialize)(this.deAnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox xemDanhSachDeAnLabel;
        private System.Windows.Forms.DataGridView deAnDataGridView;
    }
}