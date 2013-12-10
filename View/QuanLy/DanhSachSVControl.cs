using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using QLHPHP.Class;
namespace QLHPHP
{
    public partial class DanhSachSVControl : UserControl
    {
        public DanhSachSVControl()
        {
            InitializeComponent();
        }
        SinhVien sv = new SinhVien();
        DoiTuong doituong = new DoiTuong();
        Nganh nganh = new Nganh();
        private AppCommands _Commands;

        /// <summary>
        /// Gets or sets the commands associated with the control.
        /// </summary>
        public AppCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    AppCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        /// <summary>
        /// Called when Commands property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnCommandsChanged(AppCommands oldValue, AppCommands newValue)
        {
            if (newValue != null)
            {
                buttonDong.Command = newValue.DanhSachSVCommands.Cancel;
            }
            else
            {
                buttonDong.Command = null;
            }
        }

        private void binding()
        {
            txtMaSinhVien.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("Text", dgvDSSV.DataSource, "MSSV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDSSV.DataSource, "HoTen");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dgvDSSV.DataSource, "NgaySinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvDSSV.DataSource, "GioiTinh");
            txtMaDoiTuong.DataBindings.Clear();
            txtMaDoiTuong.DataBindings.Add("Text", dgvDSSV.DataSource, "TenDoiTuong");
            txtMaNganh.DataBindings.Clear();
            txtMaNganh.DataBindings.Add("Text", dgvDSSV.DataSource, "TenNganh");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSSV.DataSource, "Email");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSSV.DataSource, "DiaChi");
        }
        private void DanhSachSVControl_Load(object sender, EventArgs e)
        {

            dgvDSSV.DataSource = sv.DanhSachSinhVien().Tables["SINHVIEN"];
            txtMaDoiTuong.DataSource = doituong.ThongTinDoiTuong().Tables["DoiTuong"];
            txtMaDoiTuong.DisplayMember = "TenDoiTuong";
            txtMaDoiTuong.ValueMember = "MaDoiTuong";
            txtMaNganh.DataSource = nganh.ThongTinNganh().Tables["Nganh"];
            txtMaNganh.DisplayMember = "TenNganh";
            txtMaNganh.ValueMember = "MaNganh";

            txtGioiTinh.Text = "Chọn Giới Tính";
            txtMaDoiTuong.Text = "Chọn Đối Tượng";
            txtMaNganh.Text = "Chọn Ngành";

        }

        public void LoadDSSinhVien()
        {

        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {

        }
        public void Reset()
        {
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "Chọn Giới Tính";
            txtMaDoiTuong.Text = "Chọn Đối Tượng";
            txtMaNganh.Text = "Chọn Ngành";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }
        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                sv.MSSV = int.Parse(txtMaSinhVien.Text); ;
                sv.Xoa();
                ToastNotification.Show(this, "Đã xóa thành công!");
                dgvDSSV.DataSource = sv.DanhSachSinhVien().Tables["SINHVIEN"];
                Reset();
            }
            catch
            {
                ToastNotification.Show(this, "Không thế xóa sinh viên này!");
            }
        }

        private void btnCapNhatDSSV_Click(object sender, EventArgs e)
        {
           

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                ToastNotification.Show(this, "Chưa nhập họ tên sinh viên");
            }
            else if (txtNgaySinh.Text == "")
            {
                ToastNotification.Show(this, "Chưa chọn ngày sinh");
            }
            else if (txtGioiTinh.Text == "Chọn Giới Tính")
            {
                ToastNotification.Show(this, "Chưa chọn giới tính");
            }

            else if (txtMaDoiTuong.Text.Trim() == "Chọn Đối Tượng")
            {
                ToastNotification.Show(this, "Chưa chọn đối tượng");
            }
            else if (txtMaNganh.Text.Trim() == "Chọn Ngành")
            {
                ToastNotification.Show(this, "Chưa chọn ngành");
            }
            else
            {
                sv.MSSV = int.Parse(txtMaSinhVien.Text);
                sv.Ngaysinh = txtNgaySinh.Value.ToString();
                sv.Hoten = txtHoTen.Text;
                sv.Gioitinh = txtGioiTinh.Text;
                sv.Madoituong = txtMaDoiTuong.SelectedValue.ToString();
                sv.Manganh = txtMaNganh.SelectedValue.ToString();
                sv.Diachi = txtDiaChi.Text;
                sv.Email = txtEmail.Text;
                sv.Sua();
                ToastNotification.Show(this, "Đã sửa thành công!");
                dgvDSSV.DataSource = sv.DanhSachSinhVien().Tables["SINHVIEN"];
                Reset();
            }
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }



        private void btnXemCT_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            sv.Hoten = txtNoiDung.Text;
            dgvDSSV.DataSource = sv.TimTheoTen().Tables["SINHVIEN"];
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void txtMaDoiTuong_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            sv.Hoten = txtNoiDung.Text;
            dgvDSSV.DataSource = sv.TimTheoTen().Tables["SINHVIEN"];
        }




    }
}
