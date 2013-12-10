using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLHPHP.Class;
namespace QLHPHP
{
    public partial class NhapSinhVienControl : UserControl
    {

        DanhSachSVControl _Muon = new DanhSachSVControl();
        public NhapSinhVienControl()
        {
            InitializeComponent();
        }
        Nganh nganh = new Nganh();
        DoiTuong doituong = new DoiTuong();
        SinhVien sinhvien = new SinhVien();
        TaiKhoan taikhoan = new TaiKhoan();
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

                cancelButton.Command = newValue.NhapSinhVienCommands.Cancel;
            }
            else
            {

                cancelButton.Command = null;
            }
        }

        //Load danh sach huyen len cbbMaHuyen
        private void LoadDSHuyenInCbb()
        {

        }

        //Load danh sach tinh len cbbTinh
        private void LoadDSTinhInCbb()
        {

        }
        //Load danh sach doi tuong len cbbMaDoiTuong
        private void LoadDSDoiTuongInCbb()
        {

        }

        //Load danh sach nganh len cbbMaNganh
        private void LoadDSNganhInCbb()
        {

        }
        public void Reset()
        {
            txtHoTen.Text = "";
            dtNgaySinh.Text = "";
            cbbGioiTinh.Text = "Chọn Giới Tính";
            cbbMaDoiTuong.Text = "Chọn Đối Tượng";
            cbbMaNganh.Text = "Chọn Ngành";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }

        private void LuuSinhVien_Click(object sender, EventArgs e)
        {
         
            if (txtHoTen.Text == "")
            {
                ToastNotification.Show(this, "Chưa nhập họ tên sinh viên");
            }
            else if (dtNgaySinh.Text == "")
            {
                ToastNotification.Show(this, "Chưa chọn ngày sinh");
            }
            else if (cbbGioiTinh.Text == "Chọn Giới Tính")
            {
                ToastNotification.Show(this, "Chưa chọn giới tính");
            }

            else if (cbbMaDoiTuong.Text.Trim() == "Chọn Đối Tượng")
            {
                ToastNotification.Show(this, "Chưa chọn đối tượng");
            }
            else if (cbbMaNganh.Text.Trim() == "Chọn Ngành")
            {
                ToastNotification.Show(this, "Chưa chọn ngành");
            }
            else
            {
                try
                {
                    sinhvien.Hoten = txtHoTen.Text;

                    sinhvien.Ngaysinh = dtNgaySinh.Value.ToString();// dtNgaySinh.Value.Month.ToString() + "/" + dtNgaySinh.Value.Day.ToString() + "/" + dtNgaySinh.Value.Year.ToString();

                    sinhvien.Gioitinh = cbbGioiTinh.Text;
                    sinhvien.Madoituong = cbbMaDoiTuong.SelectedValue.ToString();
                    sinhvien.Manganh = cbbMaNganh.SelectedValue.ToString();
                    sinhvien.Email = txtEmail.Text.ToString();
                    sinhvien.Diachi = txtDiaChi.Text.ToString();
                    sinhvien.Them();
                    //
                    taikhoan.Taikhoan = sinhvien.MaxMaSinhVien();
                    taikhoan.Key = 0;
                    taikhoan.Matkhau = taikhoan.Taikhoan;
                    taikhoan.Them();
                    ToastNotification.Show(this, "Đã thêm thành công!");
                    Reset();
                }
                catch (Exception)
                {

                    //throw;
                }

            }

        }

        private void NhapSinhVienControl_Load(object sender, EventArgs e)
        {
            cbbMaNganh.DataSource = nganh.ThongTinNganh().Tables["Nganh"];
            cbbMaNganh.DisplayMember = "TenNganh";
            cbbMaNganh.ValueMember = "MaNganh";

            cbbMaDoiTuong.DataSource = doituong.ThongTinDoiTuong().Tables["DoiTuong"];
            cbbMaDoiTuong.DisplayMember = "TenDoiTuong";
            cbbMaDoiTuong.ValueMember = "MaDoiTuong";

            cbbGioiTinh.Text = "Chọn Giới Tính";
            cbbMaDoiTuong.Text = "Chọn Đối Tượng";
            cbbMaNganh.Text = "Chọn Ngành";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cbbTinh_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {


        }

        private void cbbMaDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
