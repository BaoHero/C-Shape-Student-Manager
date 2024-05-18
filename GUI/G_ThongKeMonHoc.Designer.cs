namespace QuanLyBienLai
{
    partial class G_ThongKeMonHoc
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
            this.dgvThongKeMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKeMonHoc
            // 
            this.dgvThongKeMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvThongKeMonHoc.Location = new System.Drawing.Point(16, 86);
            this.dgvThongKeMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThongKeMonHoc.Name = "dgvThongKeMonHoc";
            this.dgvThongKeMonHoc.RowHeadersWidth = 51;
            this.dgvThongKeMonHoc.Size = new System.Drawing.Size(711, 610);
            this.dgvThongKeMonHoc.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaGiangVien";
            this.Column1.HeaderText = "Mã Giảng Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenGiangVien";
            this.Column2.HeaderText = "Tên Giảng Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CacMonHoc";
            this.Column3.HeaderText = "Tên Môn Học";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // G_ThongKeMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 709);
            this.Controls.Add(this.dgvThongKeMonHoc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "G_ThongKeMonHoc";
            this.Text = "Thống kê môn học";
            this.Load += new System.EventHandler(this.G_ThongKeMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKeMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}