namespace TRANTHAONUONG_6551071060_VP104_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grBTTNV = new GroupBox();
            lblLuongCoBan = new Label();
            lblTenNV = new Label();
            lblMaNV = new Label();
            txtLuongCoBan = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            grBThaoTac = new GroupBox();
            grBChucNang = new GroupBox();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grBDanhSach = new GroupBox();
            dgvNhanVien = new DataGridView();
            grBTTNV.SuspendLayout();
            grBThaoTac.SuspendLayout();
            grBChucNang.SuspendLayout();
            grBDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grBTTNV
            // 
            grBTTNV.Controls.Add(lblLuongCoBan);
            grBTTNV.Controls.Add(lblTenNV);
            grBTTNV.Controls.Add(lblMaNV);
            grBTTNV.Controls.Add(txtLuongCoBan);
            grBTTNV.Controls.Add(txtTenNhanVien);
            grBTTNV.Controls.Add(txtMaNhanVien);
            grBTTNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grBTTNV.Location = new Point(38, 38);
            grBTTNV.Name = "grBTTNV";
            grBTTNV.Size = new Size(394, 184);
            grBTTNV.TabIndex = 0;
            grBTTNV.TabStop = false;
            grBTTNV.Text = "Thông tin nhân viên";
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.AutoSize = true;
            lblLuongCoBan.Location = new Point(22, 139);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(120, 23);
            lblLuongCoBan.TabIndex = 2;
            lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(17, 86);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(126, 23);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(17, 35);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(125, 23);
            lblMaNV.TabIndex = 1;
            lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(148, 136);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(228, 30);
            txtLuongCoBan.TabIndex = 0;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(148, 79);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(228, 30);
            txtTenNhanVien.TabIndex = 0;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(148, 28);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(228, 30);
            txtMaNhanVien.TabIndex = 0;
            // 
            // grBThaoTac
            // 
            grBThaoTac.Controls.Add(grBChucNang);
            grBThaoTac.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grBThaoTac.Location = new Point(491, 38);
            grBThaoTac.Name = "grBThaoTac";
            grBThaoTac.Size = new Size(310, 184);
            grBThaoTac.TabIndex = 1;
            grBThaoTac.TabStop = false;
            grBThaoTac.Text = "Thao Tác";
            // 
            // grBChucNang
            // 
            grBChucNang.Controls.Add(btnXoa);
            grBChucNang.Controls.Add(btnThoat);
            grBChucNang.Controls.Add(btnSua);
            grBChucNang.Controls.Add(btnThem);
            grBChucNang.Location = new Point(6, 29);
            grBChucNang.Name = "grBChucNang";
            grBChucNang.Size = new Size(298, 149);
            grBChucNang.TabIndex = 0;
            grBChucNang.TabStop = false;
            grBChucNang.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(160, 88);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 45);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += BtnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(160, 25);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 48);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += BtnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(22, 88);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 45);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += BtnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(22, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 48);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += BtnThem_Click;
            // 
            // grBDanhSach
            // 
            grBDanhSach.Controls.Add(dgvNhanVien);
            grBDanhSach.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grBDanhSach.Location = new Point(38, 237);
            grBDanhSach.Name = "grBDanhSach";
            grBDanhSach.Size = new Size(763, 204);
            grBDanhSach.TabIndex = 2;
            grBDanhSach.TabStop = false;
            grBDanhSach.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(6, 29);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(751, 169);
            dgvNhanVien.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 465);
            Controls.Add(grBDanhSach);
            Controls.Add(grBThaoTac);
            Controls.Add(grBTTNV);
            Name = "Form1";
            Text = "Quản lý Nhân viên/ Nhân sự - VP104";
            Load += Form1_Load;
            grBTTNV.ResumeLayout(false);
            grBTTNV.PerformLayout();
            grBThaoTac.ResumeLayout(false);
            grBChucNang.ResumeLayout(false);
            grBDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grBTTNV;
        private Label lblLuongCoBan;
        private Label lblTenNV;
        private Label lblMaNV;
        private TextBox txtLuongCoBan;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private GroupBox grBThaoTac;
        private GroupBox grBChucNang;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private GroupBox grBDanhSach;
        private DataGridView dgvNhanVien;
    }
}
