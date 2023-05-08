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
            this.btnBack.Location = new System.Drawing.Point(14, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 52);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // xemDanhSachDeAnLabel
            // 
            this.xemDanhSachDeAnLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xemDanhSachDeAnLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemDanhSachDeAnLabel.ForeColor = System.Drawing.Color.Red;
            this.xemDanhSachDeAnLabel.Location = new System.Drawing.Point(335, 111);
            this.xemDanhSachDeAnLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xemDanhSachDeAnLabel.Name = "xemDanhSachDeAnLabel";
            this.xemDanhSachDeAnLabel.Size = new System.Drawing.Size(417, 56);
            this.xemDanhSachDeAnLabel.TabIndex = 18;
            this.xemDanhSachDeAnLabel.Text = "Xem danh sách đề án";
            // 
            // deAnDataGridView
            // 
            this.deAnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deAnDataGridView.Location = new System.Drawing.Point(16, 177);
            this.deAnDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deAnDataGridView.Name = "deAnDataGridView";
            this.deAnDataGridView.ReadOnly = true;
            this.deAnDataGridView.RowHeadersWidth = 62;
            this.deAnDataGridView.Size = new System.Drawing.Size(1068, 443);
            this.deAnDataGridView.TabIndex = 19;
            // 
            // XemDanhSachDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1097, 634);
            this.Controls.Add(this.deAnDataGridView);
            this.Controls.Add(this.xemDanhSachDeAnLabel);
            this.Controls.Add(this.btnBack);
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