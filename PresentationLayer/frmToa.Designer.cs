
namespace QuanLyKyTucXa.PresentationLayer
{
    partial class frmToa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToa));
            this.dgvToa = new System.Windows.Forms.DataGridView();
            this.MaToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhongToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.txtSoTang = new System.Windows.Forms.TextBox();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.txtSoPhongToiDa = new System.Windows.Forms.TextBox();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.lblSoTang = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblSoPhongToiDa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.XoaTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvToa
            // 
            this.dgvToa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaToa,
            this.SoTang,
            this.SucChua,
            this.SoPhongToiDa});
            this.dgvToa.Location = new System.Drawing.Point(16, 207);
            this.dgvToa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToa.Name = "dgvToa";
            this.dgvToa.RowHeadersWidth = 51;
            this.dgvToa.Size = new System.Drawing.Size(741, 382);
            this.dgvToa.TabIndex = 33;
            this.dgvToa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToa_CellClick_1);
            // 
            // MaToa
            // 
            this.MaToa.DataPropertyName = "MaToa";
            this.MaToa.HeaderText = "Mã Tòa";
            this.MaToa.MinimumWidth = 6;
            this.MaToa.Name = "MaToa";
            this.MaToa.Width = 125;
            // 
            // SoTang
            // 
            this.SoTang.DataPropertyName = "SoTang";
            this.SoTang.HeaderText = "Số tầng";
            this.SoTang.MinimumWidth = 6;
            this.SoTang.Name = "SoTang";
            this.SoTang.Width = 125;
            // 
            // SucChua
            // 
            this.SucChua.DataPropertyName = "SucChua";
            this.SucChua.HeaderText = "Sức chứa";
            this.SucChua.MinimumWidth = 6;
            this.SucChua.Name = "SucChua";
            this.SucChua.Width = 125;
            // 
            // SoPhongToiDa
            // 
            this.SoPhongToiDa.DataPropertyName = "SoPhongToiDa";
            this.SoPhongToiDa.HeaderText = "Số phòng tối đa";
            this.SoPhongToiDa.MinimumWidth = 6;
            this.SoPhongToiDa.Name = "SoPhongToiDa";
            this.SoPhongToiDa.Width = 125;
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(140, 69);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(159, 22);
            this.txtMaToa.TabIndex = 34;
            // 
            // txtSoTang
            // 
            this.txtSoTang.Location = new System.Drawing.Point(140, 117);
            this.txtSoTang.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.Size = new System.Drawing.Size(159, 22);
            this.txtSoTang.TabIndex = 35;
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(572, 64);
            this.txtSucChua.Margin = new System.Windows.Forms.Padding(4);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(159, 22);
            this.txtSucChua.TabIndex = 36;
            // 
            // txtSoPhongToiDa
            // 
            this.txtSoPhongToiDa.Location = new System.Drawing.Point(572, 117);
            this.txtSoPhongToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPhongToiDa.Name = "txtSoPhongToiDa";
            this.txtSoPhongToiDa.Size = new System.Drawing.Size(159, 22);
            this.txtSoPhongToiDa.TabIndex = 37;
            // 
            // lblMaToa
            // 
            this.lblMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToa.Location = new System.Drawing.Point(51, 68);
            this.lblMaToa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.Size = new System.Drawing.Size(77, 21);
            this.lblMaToa.TabIndex = 39;
            this.lblMaToa.Text = "Mã tòa";
            // 
            // lblSoTang
            // 
            this.lblSoTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTang.Location = new System.Drawing.Point(51, 117);
            this.lblSoTang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTang.Name = "lblSoTang";
            this.lblSoTang.Size = new System.Drawing.Size(81, 21);
            this.lblSoTang.TabIndex = 40;
            this.lblSoTang.Text = "Số tầng";
            // 
            // lblSucChua
            // 
            this.lblSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucChua.Location = new System.Drawing.Point(467, 63);
            this.lblSucChua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(97, 21);
            this.lblSucChua.TabIndex = 41;
            this.lblSucChua.Text = "Sức chứa";
            // 
            // lblSoPhongToiDa
            // 
            this.lblSoPhongToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongToiDa.Location = new System.Drawing.Point(415, 121);
            this.lblSoPhongToiDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhongToiDa.Name = "lblSoPhongToiDa";
            this.lblSoPhongToiDa.Size = new System.Drawing.Size(149, 21);
            this.lblSoPhongToiDa.TabIndex = 42;
            this.lblSoPhongToiDa.Text = "Số phòng tối đa";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(823, 207);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(823, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.button1.Size = new System.Drawing.Size(80, 74);
            this.button1.TabIndex = 44;
            this.button1.Text = "Sửa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(823, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.button2.Size = new System.Drawing.Size(80, 74);
            this.button2.TabIndex = 45;
            this.button2.Text = "Xóa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // XoaTextBox
            // 
            this.XoaTextBox.Location = new System.Drawing.Point(728, 159);
            this.XoaTextBox.Name = "XoaTextBox";
            this.XoaTextBox.Size = new System.Drawing.Size(75, 23);
            this.XoaTextBox.TabIndex = 46;
            this.XoaTextBox.Text = "Clear";
            this.XoaTextBox.UseVisualStyleBackColor = true;
            this.XoaTextBox.Click += new System.EventHandler(this.XoaTextBox_Click);
            // 
            // frmToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.XoaTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblSoPhongToiDa);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblSoTang);
            this.Controls.Add(this.lblMaToa);
            this.Controls.Add(this.txtSoPhongToiDa);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.txtSoTang);
            this.Controls.Add(this.txtMaToa);
            this.Controls.Add(this.dgvToa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToa";
            this.Text = "frmToa";
            this.Load += new System.EventHandler(this.frmToa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhongToiDa;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.TextBox txtSoPhongToiDa;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.Label lblSoTang;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblSoPhongToiDa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button XoaTextBox;
    }
}