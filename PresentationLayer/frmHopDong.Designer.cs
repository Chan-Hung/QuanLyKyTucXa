
namespace QuanLyKyTucXa.PresentationLayer
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.lblSoPhongToiDa = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblSoTang = new System.Windows.Forms.Label();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayky = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoPhongToiDa
            // 
            this.lblSoPhongToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongToiDa.Location = new System.Drawing.Point(19, 433);
            this.lblSoPhongToiDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhongToiDa.Name = "lblSoPhongToiDa";
            this.lblSoPhongToiDa.Size = new System.Drawing.Size(130, 18);
            this.lblSoPhongToiDa.TabIndex = 59;
            this.lblSoPhongToiDa.Text = "Ngày kết thúc HĐ";
            this.lblSoPhongToiDa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(165, 265);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(159, 22);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(165, 180);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(159, 22);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucChua.Location = new System.Drawing.Point(62, 349);
            this.lblSucChua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(87, 18);
            this.lblSucChua.TabIndex = 58;
            this.lblSucChua.Text = "Ngày ký HĐ";
            this.lblSucChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoTang
            // 
            this.lblSoTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTang.Location = new System.Drawing.Point(79, 266);
            this.lblSoTang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTang.Name = "lblSoTang";
            this.lblSoTang.Size = new System.Drawing.Size(70, 22);
            this.lblSoTang.TabIndex = 57;
            this.lblSoTang.Text = "Mã SV";
            this.lblSoTang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaToa
            // 
            this.lblMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToa.Location = new System.Drawing.Point(39, 181);
            this.lblMaToa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.Size = new System.Drawing.Size(110, 21);
            this.lblMaToa.TabIndex = 54;
            this.lblMaToa.Text = "Mã hợp đồng";
            this.lblMaToa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.masv,
            this.ngaykhd,
            this.ngaykthd});
            this.dgvHopDong.Location = new System.Drawing.Point(339, 180);
            this.dgvHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.Size = new System.Drawing.Size(627, 383);
            this.dgvHopDong.TabIndex = 62;
            this.dgvHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã hợp đồng";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.Width = 90;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã SV";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 80;
            // 
            // ngaykhd
            // 
            this.ngaykhd.DataPropertyName = "ngaykhd";
            this.ngaykhd.HeaderText = "Ngày ký HĐ";
            this.ngaykhd.MinimumWidth = 6;
            this.ngaykhd.Name = "ngaykhd";
            this.ngaykhd.Width = 120;
            // 
            // ngaykthd
            // 
            this.ngaykthd.DataPropertyName = "ngaykthd";
            this.ngaykthd.HeaderText = "Ngày kết thúc HĐ";
            this.ngaykthd.MinimumWidth = 6;
            this.ngaykthd.Name = "ngaykthd";
            this.ngaykthd.Width = 120;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(557, 98);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(449, 98);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(342, 98);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayky
            // 
            this.dtpNgayky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayky.Location = new System.Drawing.Point(165, 349);
            this.dtpNgayky.Name = "dtpNgayky";
            this.dtpNgayky.Size = new System.Drawing.Size(159, 22);
            this.dtpNgayky.TabIndex = 3;
            // 
            // dtpNgayketthuc
            // 
            this.dtpNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayketthuc.Location = new System.Drawing.Point(165, 433);
            this.dtpNgayketthuc.Name = "dtpNgayketthuc";
            this.dtpNgayketthuc.Size = new System.Drawing.Size(159, 22);
            this.dtpNgayketthuc.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(669, 98);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtpNgayketthuc);
            this.Controls.Add(this.dtpNgayky);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.lblSoPhongToiDa);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblSoTang);
            this.Controls.Add(this.lblMaToa);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoPhongToiDa;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblSoTang;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayky;
        private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykthd;
        private System.Windows.Forms.Button btnRefresh;
    }
}