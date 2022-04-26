﻿
namespace QuanLyKyTucXa.PresentationLayer
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaLoaiPhong = new System.Windows.Forms.Label();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.cbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPhongTrong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.maloaiphong,
            this.matoa,
            this.trangthai});
            this.dgvPhong.Location = new System.Drawing.Point(339, 168);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(627, 383);
            this.dgvPhong.TabIndex = 35;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 70;
            // 
            // maloaiphong
            // 
            this.maloaiphong.DataPropertyName = "maloaiphong";
            this.maloaiphong.HeaderText = "Mã loại phòng";
            this.maloaiphong.MinimumWidth = 6;
            this.maloaiphong.Name = "maloaiphong";
            this.maloaiphong.Width = 110;
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "matoa";
            this.matoa.HeaderText = "Mã tòa";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 110;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 120;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(554, 86);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(446, 86);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 37;
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
            this.btnThem.Location = new System.Drawing.Point(339, 86);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(161, 345);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(159, 22);
            this.txtMaToa.TabIndex = 61;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(15, 429);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(130, 18);
            this.lblTrangThai.TabIndex = 59;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(161, 168);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(159, 22);
            this.txtMaPhong.TabIndex = 55;
            // 
            // lblMaLoaiPhong
            // 
            this.lblMaLoaiPhong.AutoSize = true;
            this.lblMaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiPhong.Location = new System.Drawing.Point(44, 261);
            this.lblMaLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLoaiPhong.Name = "lblMaLoaiPhong";
            this.lblMaLoaiPhong.Size = new System.Drawing.Size(101, 18);
            this.lblMaLoaiPhong.TabIndex = 58;
            this.lblMaLoaiPhong.Text = "Mã loại phòng";
            // 
            // lblMaToa
            // 
            this.lblMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToa.Location = new System.Drawing.Point(75, 344);
            this.lblMaToa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.Size = new System.Drawing.Size(70, 22);
            this.lblMaToa.TabIndex = 57;
            this.lblMaToa.Text = "Mã tòa";
            this.lblMaToa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(55, 168);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(90, 21);
            this.lblMaPhong.TabIndex = 54;
            this.lblMaPhong.Text = "Mã phòng";
            this.lblMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaPhong.Click += new System.EventHandler(this.lblMaPhong_Click);
            // 
            // cbMaLoaiPhong
            // 
            this.cbMaLoaiPhong.FormattingEnabled = true;
            this.cbMaLoaiPhong.Items.AddRange(new object[] {
            "ML2",
            "ML4",
            "PQ4",
            "PQ8"});
            this.cbMaLoaiPhong.Location = new System.Drawing.Point(161, 260);
            this.cbMaLoaiPhong.Name = "cbMaLoaiPhong";
            this.cbMaLoaiPhong.Size = new System.Drawing.Size(159, 24);
            this.cbMaLoaiPhong.TabIndex = 62;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Còn",
            "Hết"});
            this.cbTrangThai.Location = new System.Drawing.Point(161, 429);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(159, 24);
            this.cbTrangThai.TabIndex = 63;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(657, 86);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 65;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPhongTrong
            // 
            this.btnPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPhongTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongTrong.Location = new System.Drawing.Point(772, 114);
            this.btnPhongTrong.Name = "btnPhongTrong";
            this.btnPhongTrong.Size = new System.Drawing.Size(134, 46);
            this.btnPhongTrong.TabIndex = 66;
            this.btnPhongTrong.Text = "Hiển thị danh sách phòng trống";
            this.btnPhongTrong.UseVisualStyleBackColor = false;
            this.btnPhongTrong.Click += new System.EventHandler(this.btnPhongTrong_Click);
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.btnPhongTrong);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.cbMaLoaiPhong);
            this.Controls.Add(this.txtMaToa);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblMaLoaiPhong);
            this.Controls.Add(this.lblMaToa);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhong);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaLoaiPhong;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.ComboBox cbMaLoaiPhong;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPhongTrong;
    }
}