using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TRANTHAONUONG_6551071060_VP104_LTTQ.Models;

namespace TRANTHAONUONG_6551071060_VP104_LTTQ
{

    public partial class Form1 : Form
    {
        private string? selectedMaNhanVien;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadNhanVien();
            ClearInputs();

        }

        private void LoadNhanVien(string? maCanChon = null)
        {
            try
            {
                using DuLieuContext db = new DuLieuContext();

                var danhSach = db.NhanViens
                    .AsNoTracking()
                    .OrderBy(nv => nv.MaNhanVien)
                    .ToList();

                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = danhSach;

                if (dgvNhanVien.Columns.Contains("MaNhanVien"))
                {
                    dgvNhanVien.Columns["MaNhanVien"]!.HeaderText = "Mã nhân viên";
                    dgvNhanVien.Columns["TenNhanVien"]!.HeaderText = "Tên nhân viên";
                    dgvNhanVien.Columns["LuongCoBan"]!.HeaderText = "Lương cơ bản";

                    dgvNhanVien.Columns["MaNhanVien"]!.Width = 95;
                    dgvNhanVien.Columns["TenNhanVien"]!.Width = 160;
                    dgvNhanVien.Columns["LuongCoBan"]!.Width = 110;
                }

                dgvNhanVien.ClearSelection();

                if (!string.IsNullOrWhiteSpace(maCanChon))
                {
                    foreach (DataGridViewRow row in dgvNhanVien.Rows)
                    {
                        if (Convert.ToString(
                            row.Cells["MaNhanVien"].Value) == maCanChon)
                        {
                            row.Selected = true;
                            dgvNhanVien.CurrentCell = row.Cells["MaNhanVien"];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tải được danh sách nhân viên!\n\n" +
                    "Hãy kiểm tra SQL Server, database DuLieu và bảng NhanVien.\n\n" +
                    "Chi tiết: " + ex.Message,
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DgvNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvNhanVien.SelectedRows[0];

            if (row.IsNewRow ||
                row.Cells["MaNhanVien"].Value == null)
                return;

            selectedMaNhanVien =
                Convert.ToString(row.Cells["MaNhanVien"].Value);

            txtMaNhanVien.Text = selectedMaNhanVien ?? "";
            txtTenNhanVien.Text =
                Convert.ToString(row.Cells["TenNhanVien"].Value) ?? "";
            txtLuongCoBan.Text =
                Convert.ToString(row.Cells["LuongCoBan"].Value) ?? "";

            txtMaNhanVien.ReadOnly = true;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void BtnThem_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using DuLieuContext db = new DuLieuContext();

                string ma = txtMaNhanVien.Text.Trim();

                bool daTonTai = db.NhanViens
                    .Any(nv => nv.MaNhanVien == ma);

                if (daTonTai)
                {
                    MessageBox.Show(
                        "Mã nhân viên đã tồn tại. Vui lòng nhập mã khác!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMaNhanVien.Focus();
                    return;
                }

                NhanVien nv = new NhanVien
                {
                    MaNhanVien = ma,
                    TenNhanVien = txtTenNhanVien.Text.Trim(),
                    LuongCoBan = txtLuongCoBan.Text.Trim()
                };

                db.NhanViens.Add(nv);
                db.SaveChanges();

                MessageBox.Show(
                    "Thêm nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadNhanVien();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void BtnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                using DuLieuContext db = new DuLieuContext();

                NhanVien? nv = db.NhanViens
                    .FirstOrDefault(x =>
                        x.MaNhanVien == selectedMaNhanVien);

                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần sửa!");
                    LoadNhanVien();
                    ClearInputs();
                    return;
                }

                nv.TenNhanVien = txtTenNhanVien.Text.Trim();
                nv.LuongCoBan = txtLuongCoBan.Text.Trim();

                db.SaveChanges();

                MessageBox.Show(
                    "Cập nhật nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadNhanVien();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using DuLieuContext db = new DuLieuContext();

                NhanVien? nv = db.NhanViens
                    .FirstOrDefault(x =>
                        x.MaNhanVien == selectedMaNhanVien);

                if (nv == null)
                {
                    MessageBox.Show("nhân viên không còn tồn tại!");
                    ClearInputs();
                    LoadNhanVien();
                    return;
                }

                db.NhanViens.Remove(nv);
                db.SaveChanges();

                MessageBox.Show(
                    "Xóa nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadNhanVien();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void TxtLuongCoBan_KeyPress(
            object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !txtLuongCoBan.Text.Contains('.') &&
                !txtLuongCoBan.Text.Contains(','))
                return;

            e.Handled = true;
        }

        private bool ValidateInputs()
        {
            string ma = txtMaNhanVien.Text.Trim();
            string ten = txtTenNhanVien.Text.Trim();
            string luongcobanText = txtLuongCoBan.Text.Trim()
                .Replace(',', '.');

            if (ma == "" || ten == "" || luongcobanText == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin nhân viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (ma.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được vượt quá 10 ký tự!");
                txtMaNhanVien.Focus();
                return false;
            }

            if (!decimal.TryParse(
                    luongcobanText,
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out decimal luongcoban))

            {
                MessageBox.Show(
                    "Lương cơ bản không được bỏ trống");

                txtLuongCoBan.Focus();
                return false;
            }

            txtLuongCoBan.Text =
                luongcoban.ToString("0.##", CultureInfo.InvariantCulture);

            return true;
        }

        private void ClearInputs()
        {
            selectedMaNhanVien = null;

            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtLuongCoBan.Text = "";

            dgvNhanVien.ClearSelection();
            dgvNhanVien.CurrentCell = null;

            SetDefaultState();

            txtMaNhanVien.Focus();

        }

        private void SetDefaultState()
        {
            txtMaNhanVien.ReadOnly = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private static void ShowDatabaseError(Exception ex)
        {
            MessageBox.Show(
                "Thao tác với cơ sở dữ liệu thất bại!\n\n" +
                "Chi tiết: " + ex.Message,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        
    }

}
