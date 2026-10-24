namespace Game3
{
    partial class frmThanhTich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.cboLocCapDo = new System.Windows.Forms.ComboBox();
            this.lblLocCapDo = new System.Windows.Forms.Label();
            this.dgvThanhTich = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnXoaLichSu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhTich)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblSubTitle.Location = new System.Drawing.Point(0, 52);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(850, 33);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Ưu tiên xếp hạng: Cấp độ Khó -> Trung bình -> Dễ | Thời gian hoàn thành nhanh nhấ" +
    "t";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label1.Size = new System.Drawing.Size(850, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "🏆 BẢNG XẾP HẠNG THÀNH TÍCH 🏆";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlFilter.Controls.Add(this.lblTongSo);
            this.pnlFilter.Controls.Add(this.cboLocCapDo);
            this.pnlFilter.Controls.Add(this.lblLocCapDo);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 85);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(850, 48);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblTongSo
            // 
            this.lblTongSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTongSo.Location = new System.Drawing.Point(550, 13);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(280, 23);
            this.lblTongSo.TabIndex = 2;
            this.lblTongSo.Text = "Tổng số kỷ lục: 0";
            this.lblTongSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLocCapDo
            // 
            this.cboLocCapDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocCapDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocCapDo.FormattingEnabled = true;
            this.cboLocCapDo.Items.AddRange(new object[] {
            "Tất cả",
            "Khó",
            "Trung bình",
            "Dễ"});
            this.cboLocCapDo.Location = new System.Drawing.Point(140, 10);
            this.cboLocCapDo.Name = "cboLocCapDo";
            this.cboLocCapDo.Size = new System.Drawing.Size(160, 36);
            this.cboLocCapDo.TabIndex = 1;
            this.cboLocCapDo.SelectedIndexChanged += new System.EventHandler(this.cboLocCapDo_SelectedIndexChanged);
            // 
            // lblLocCapDo
            // 
            this.lblLocCapDo.AutoSize = true;
            this.lblLocCapDo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocCapDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblLocCapDo.Location = new System.Drawing.Point(20, 13);
            this.lblLocCapDo.Name = "lblLocCapDo";
            this.lblLocCapDo.Size = new System.Drawing.Size(133, 28);
            this.lblLocCapDo.TabIndex = 0;
            this.lblLocCapDo.Text = "Lọc theo cấp:";
            // 
            // dgvThanhTich
            // 
            this.dgvThanhTich.AllowUserToAddRows = false;
            this.dgvThanhTich.AllowUserToDeleteRows = false;
            this.dgvThanhTich.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvThanhTich.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvThanhTich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThanhTich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhTich.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhTich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThanhTich.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThanhTich.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvThanhTich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvThanhTich.ColumnHeadersHeight = 44;
            this.dgvThanhTich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThanhTich.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvThanhTich.EnableHeadersVisualStyles = false;
            this.dgvThanhTich.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvThanhTich.Location = new System.Drawing.Point(20, 145);
            this.dgvThanhTich.MultiSelect = false;
            this.dgvThanhTich.Name = "dgvThanhTich";
            this.dgvThanhTich.ReadOnly = true;
            this.dgvThanhTich.RowHeadersVisible = false;
            this.dgvThanhTich.RowHeadersWidth = 62;
            this.dgvThanhTich.RowTemplate.Height = 38;
            this.dgvThanhTich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhTich.Size = new System.Drawing.Size(810, 315);
            this.dgvThanhTich.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlFooter.Controls.Add(this.btnXoaLichSu);
            this.pnlFooter.Controls.Add(this.btnDong);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 472);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(850, 58);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnXoaLichSu
            // 
            this.btnXoaLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaLichSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLichSu.FlatAppearance.BorderSize = 0;
            this.btnXoaLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLichSu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaLichSu.ForeColor = System.Drawing.Color.White;
            this.btnXoaLichSu.Location = new System.Drawing.Point(20, 11);
            this.btnXoaLichSu.Name = "btnXoaLichSu";
            this.btnXoaLichSu.Size = new System.Drawing.Size(150, 36);
            this.btnXoaLichSu.TabIndex = 0;
            this.btnXoaLichSu.Text = "🗑 Xóa lịch sử";
            this.btnXoaLichSu.UseVisualStyleBackColor = false;
            this.btnXoaLichSu.Click += new System.EventHandler(this.btnXoaLichSu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(700, 11);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 36);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThanhTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.Controls.Add(this.dgvThanhTich);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(750, 480);
            this.Name = "frmThanhTich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Xếp Hạng Thành Tích";
            this.Load += new System.EventHandler(this.frmThanhTich_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhTich)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThanhTich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblLocCapDo;
        private System.Windows.Forms.ComboBox cboLocCapDo;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnXoaLichSu;
        private System.Windows.Forms.Button btnDong;
    }
}