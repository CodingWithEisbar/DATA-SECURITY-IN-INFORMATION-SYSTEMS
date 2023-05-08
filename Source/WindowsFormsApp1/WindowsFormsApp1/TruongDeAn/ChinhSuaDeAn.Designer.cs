namespace WindowsFormsApp1.TruongDeAn
{
    partial class ChinhSuaDeAn
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
            this.chinhSuaDanhSachDeAnLabel = new System.Windows.Forms.TextBox();
            this.chinhSuaDataGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSuaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(18, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chinhSuaDanhSachDeAnLabel
            // 
            this.chinhSuaDanhSachDeAnLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chinhSuaDanhSachDeAnLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chinhSuaDanhSachDeAnLabel.ForeColor = System.Drawing.Color.Red;
            this.chinhSuaDanhSachDeAnLabel.Location = new System.Drawing.Point(370, 84);
            this.chinhSuaDanhSachDeAnLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chinhSuaDanhSachDeAnLabel.Name = "chinhSuaDanhSachDeAnLabel";
            this.chinhSuaDanhSachDeAnLabel.Size = new System.Drawing.Size(526, 56);
            this.chinhSuaDanhSachDeAnLabel.TabIndex = 19;
            this.chinhSuaDanhSachDeAnLabel.Text = "Chỉnh sửa danh sách đề án";
            // 
            // chinhSuaDataGridView
            // 
            this.chinhSuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chinhSuaDataGridView.Location = new System.Drawing.Point(12, 170);
            this.chinhSuaDataGridView.Name = "chinhSuaDataGridView";
            this.chinhSuaDataGridView.RowHeadersWidth = 62;
            this.chinhSuaDataGridView.RowTemplate.Height = 28;
            this.chinhSuaDataGridView.Size = new System.Drawing.Size(1182, 483);
            this.chinhSuaDataGridView.TabIndex = 20;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(512, 659);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(177, 52);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ChinhSuaDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1206, 725);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.chinhSuaDataGridView);
            this.Controls.Add(this.chinhSuaDanhSachDeAnLabel);
            this.Controls.Add(this.btnBack);
            this.Name = "ChinhSuaDeAn";
            this.Text = "Chỉnh sửa đề án";
            ((System.ComponentModel.ISupportInitialize)(this.chinhSuaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox chinhSuaDanhSachDeAnLabel;
        private System.Windows.Forms.DataGridView chinhSuaDataGridView;
        private System.Windows.Forms.Button updateButton;
    }
}