
namespace QuanLyKyTucXa.PresentationLayer
{
    partial class frmTienDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTienDien));
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.txtsptd = new System.Windows.Forms.TextBox();
            this.lblSoPhongToiDa = new System.Windows.Forms.Label();
            this.txtSoTang = new System.Windows.Forms.TextBox();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblSoDienTieuThu = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.dgvSoDienTieuThu = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodientieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonggiatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDienTieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(165, 387);
            this.txtSucChua.Margin = new System.Windows.Forms.Padding(4);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(159, 22);
            this.txtSucChua.TabIndex = 54;
            // 
            // txtsptd
            // 
            this.txtsptd.Location = new System.Drawing.Point(165, 461);
            this.txtsptd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsptd.Name = "txtsptd";
            this.txtsptd.Size = new System.Drawing.Size(159, 22);
            this.txtsptd.TabIndex = 55;
            // 
            // lblSoPhongToiDa
            // 
            this.lblSoPhongToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongToiDa.Location = new System.Drawing.Point(13, 465);
            this.lblSoPhongToiDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhongToiDa.Name = "lblSoPhongToiDa";
            this.lblSoPhongToiDa.Size = new System.Drawing.Size(130, 18);
            this.lblSoPhongToiDa.TabIndex = 59;
            this.lblSoPhongToiDa.Text = "Số phòng tối đa";
            this.lblSoPhongToiDa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoTang
            // 
            this.txtSoTang.Location = new System.Drawing.Point(165, 245);
            this.txtSoTang.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.Size = new System.Drawing.Size(159, 22);
            this.txtSoTang.TabIndex = 53;
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(165, 178);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(159, 22);
            this.txtMaToa.TabIndex = 52;
            // 
            // lblSoDienTieuThu
            // 
            this.lblSoDienTieuThu.AutoSize = true;
            this.lblSoDienTieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienTieuThu.Location = new System.Drawing.Point(23, 388);
            this.lblSoDienTieuThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDienTieuThu.Name = "lblSoDienTieuThu";
            this.lblSoDienTieuThu.Size = new System.Drawing.Size(109, 18);
            this.lblSoDienTieuThu.TabIndex = 58;
            this.lblSoDienTieuThu.Text = "Số điện tiêu thụ";
            this.lblSoDienTieuThu.Click += new System.EventHandler(this.lblSoDienTieuThu_Click);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(35, 244);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(97, 22);
            this.lblMaPhong.TabIndex = 57;
            this.lblMaPhong.Text = "Mã phòng";
            this.lblMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaPhong.Click += new System.EventHandler(this.lblMaPhong_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(32, 179);
            this.lblMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(100, 21);
            this.lblMaHoaDon.TabIndex = 56;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            this.lblMaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSoDienTieuThu
            // 
            this.dgvSoDienTieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSoDienTieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoDienTieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maphong,
            this.ngaylap,
            this.sodientieuthu,
            this.tonggiatri});
            this.dgvSoDienTieuThu.Location = new System.Drawing.Point(348, 178);
            this.dgvSoDienTieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoDienTieuThu.Name = "dgvSoDienTieuThu";
            this.dgvSoDienTieuThu.RowHeadersWidth = 51;
            this.dgvSoDienTieuThu.Size = new System.Drawing.Size(627, 383);
            this.dgvSoDienTieuThu.TabIndex = 60;
            this.dgvSoDienTieuThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoDienTieuThu_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(702, 96);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 64;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(589, 96);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(473, 96);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(350, 96);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 315);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 65;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(13, 314);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(127, 22);
            this.lblNgayLap.TabIndex = 66;
            this.lblNgayLap.Text = "Ngày lập hóa đơn";
            this.lblNgayLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Width = 70;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 110;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Width = 110;
            // 
            // sodientieuthu
            // 
            this.sodientieuthu.DataPropertyName = "sodientieuthu";
            this.sodientieuthu.HeaderText = "Số điện tiêu thụ";
            this.sodientieuthu.MinimumWidth = 6;
            this.sodientieuthu.Name = "sodientieuthu";
            this.sodientieuthu.Width = 120;
            // 
            // tonggiatri
            // 
            this.tonggiatri.DataPropertyName = "tonggiatri";
            this.tonggiatri.HeaderText = "Tổng giá trị";
            this.tonggiatri.MinimumWidth = 6;
            this.tonggiatri.Name = "tonggiatri";
            this.tonggiatri.Width = 125;
            // 
            // frmTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSoDienTieuThu);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.txtsptd);
            this.Controls.Add(this.lblSoPhongToiDa);
            this.Controls.Add(this.txtSoTang);
            this.Controls.Add(this.txtMaToa);
            this.Controls.Add(this.lblSoDienTieuThu);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblMaHoaDon);
            this.Name = "frmTienDien";
            this.Text = "frmTienDien";
            this.Load += new System.EventHandler(this.frmTienDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDienTieuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.TextBox txtsptd;
        private System.Windows.Forms.Label lblSoPhongToiDa;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label lblSoDienTieuThu;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.DataGridView dgvSoDienTieuThu;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodientieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonggiatri;
    }
}