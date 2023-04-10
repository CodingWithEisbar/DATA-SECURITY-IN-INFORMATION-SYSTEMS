namespace WindowsFormsApp1.Admin
{
    partial class TableAndView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAllTable = new System.Windows.Forms.Button();
            this.btnShowAllView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(55, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1213, 346);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnShowAllTable
            // 
            this.btnShowAllTable.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTable.Location = new System.Drawing.Point(355, 184);
            this.btnShowAllTable.Name = "btnShowAllTable";
            this.btnShowAllTable.Size = new System.Drawing.Size(137, 31);
            this.btnShowAllTable.TabIndex = 6;
            this.btnShowAllTable.Text = "Xem Bảng";
            this.btnShowAllTable.UseVisualStyleBackColor = true;
            this.btnShowAllTable.Click += new System.EventHandler(this.btnShowAllTable_Click);
            // 
            // btnShowAllView
            // 
            this.btnShowAllView.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllView.Location = new System.Drawing.Point(737, 184);
            this.btnShowAllView.Name = "btnShowAllView";
            this.btnShowAllView.Size = new System.Drawing.Size(131, 31);
            this.btnShowAllView.TabIndex = 7;
            this.btnShowAllView.Text = "Xem View";
            this.btnShowAllView.UseVisualStyleBackColor = true;
            this.btnShowAllView.Click += new System.EventHandler(this.btnShowAllView_Click);
            // 
            // TableAndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 641);
            this.Controls.Add(this.btnShowAllView);
            this.Controls.Add(this.btnShowAllTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Name = "TableAndView";
            this.Text = "TableAndView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAllTable;
        private System.Windows.Forms.Button btnShowAllView;
    }
}