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
    public partial class QuanLyMonHocControl : UserControl
    {
        public QuanLyMonHocControl()
        {
            InitializeComponent();
        }
        private MonHoc monhoc = new MonHoc();

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
                buttonDong.Command = newValue.QuanLyMonHocCommands.Cancel;
            }
            else
            {
                buttonDong.Command = null;
            }
        }

        private void QuanLyMonHocControl_Load(object sender, EventArgs e)
        {
            dgvDSMonHoc.DataSource = monhoc.DanhSachMonHoc().Tables["MonHoc"];
        }
        private void Reset()
        {
            txtMaMonHoc.Text = "";
            txtTenMonHoc.Text = "";
            txtTCLT.Text = "";
            txtTCTH.Text = "";
            txtTongSoTC.Text = "";
            MaxSL.Text = "";
        }

        private void binding()
        {
            txtMaMonHoc.DataBindings.Clear();
            txtMaMonHoc.DataBindings.Add("Text", dgvDSMonHoc.DataSource, "MaMon");
            txtTenMonHoc.DataBindings.Clear();
            txtTenMonHoc.DataBindings.Add("Text", dgvDSMonHoc.DataSource, "TenMonHoc");
            txtTCLT.DataBindings.Clear();
            txtTCLT.DataBindings.Add("Text", dgvDSMonHoc.DataSource, "SoTCLT");
            txtTCTH.DataBindings.Clear();
            txtTCTH.DataBindings.Add("Text", dgvDSMonHoc.DataSource, "SoTCTH");
            int x = int.Parse(txtTCLT.Text.Trim()) + int.Parse(txtTCTH.Text.Trim());
            txtTongSoTC.Text = x.ToString();
            MaxSL.DataBindings.Clear();
            MaxSL.DataBindings.Add("Text", dgvDSMonHoc.DataSource, "SoSVToiDa");
        }

        private void LoadDSMonHoc()
        {

        }
        private void LoadDSLoaiMon()
        {

        }

        private void bindingMH()
        {


        }

        private void dgvDSMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                binding();
                monhoc.Mamonhoc = txtMaMonHoc.Text;
                dgvDSNganh.DataSource = monhoc.NganhCuaMonHoc().Tables["MonHoc"];
            }
            catch (Exception)
            {

            }

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private bool ThongBao()
        {
            if (txtMaMonHoc.Text.Trim() == "")
            {
                ToastNotification.Show(this, "Chưa nhập mã môn học !");
                return false;
            }
            else if (txtTenMonHoc.Text.Trim() == "")
            {
                ToastNotification.Show(this, "Chưa nhập tên môn học !");
                return false;
            }
            else if (txtTCLT.Text.Trim() == "")
            {
                ToastNotification.Show(this, "Chưa nhập số tín chỉ lý thuyết !");
                return false;
            }
            if (txtTCTH.Text.Trim() == "")
            {
                ToastNotification.Show(this, "Chưa nhập tín chỉ thực hành học !");
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThongBao())
            {
                try
                {
                    monhoc.Mamonhoc = txtMaMonHoc.Text;
                    monhoc.Tenmonhoc = txtTenMonHoc.Text;
                    monhoc.Sotclt = int.Parse(txtTCLT.Text);
                    monhoc.Sotcth = int.Parse(txtTCTH.Text);
                    monhoc.Manganh = "";
                    monhoc.SlToiDa = int.Parse(MaxSL.Text);
                    monhoc.Them();
                    dgvDSMonHoc.DataSource = monhoc.DanhSachMonHoc().Tables["MonHoc"];
                    ToastNotification.Show(this, "Thêm Thành Công !");
                    Reset();
                }
                catch (Exception)
                {

                    ToastNotification.Show(this, "Thêm không Thành Công !");
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text.Trim() == "")
            {
                ToastNotification.Show(this, "Chưa nhập mã môn học !");
            }
            else
            {
                try
                {
                    monhoc.Mamonhoc = txtMaMonHoc.Text;
                    monhoc.Xoa();
                    dgvDSMonHoc.DataSource = monhoc.DanhSachMonHoc().Tables["MonHoc"];
                    ToastNotification.Show(this, "Xóa Thành Công !");
                    Reset();
                }
                catch (Exception)
                {

                    ToastNotification.Show(this, "Xóa không Thành Công !");
                }
            }

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ThongBao())
            {
                try
                {
                    monhoc.Mamonhoc = txtMaMonHoc.Text;
                    monhoc.Tenmonhoc = txtTenMonHoc.Text;
                    monhoc.Sotclt = int.Parse(txtTCLT.Text);
                    monhoc.Sotcth = int.Parse(txtTCTH.Text);
                    monhoc.Manganh = "";
                    monhoc.SlToiDa = int.Parse(MaxSL.Text);
                    monhoc.Sua();
                    dgvDSMonHoc.DataSource = monhoc.DanhSachMonHoc().Tables["MonHoc"];
                    ToastNotification.Show(this, "Sửa Thành Công !");
                    Reset();
                }
                catch (Exception)
                {

                    ToastNotification.Show(this, "Sửa không Thành Công !");
                }
            }

        }

        private void txtTimMon_TextChanged_1(object sender, EventArgs e)
        {
            monhoc.Tenmonhoc = txtTimMon.Text.Trim();
            dgvDSMonHoc.DataSource = monhoc.TimMonHoc().Tables["MonHoc"];
        }



        
    }
}
