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
    public partial class ChiTietNganhControl : UserControl
    {
        public ChiTietNganhControl()
        {
            InitializeComponent();
        }
        bool check = false;
        MonHoc monhoc = new MonHoc();
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
                btnClose.Command = newValue.ChiTietNganhCommands.Cancel;
            }
            else
            {
                btnClose.Command = null;
            }
        }
        /// <summary>
        /// Tải danh sách ngành vào combobox
        /// </summary>
        private void LoadListNganhInCbb()
        {

        }

        /// <summary>
        /// Tải danh sách hk vào combobox
        /// </summary>
        private void LoadListHKInCbb()
        {

        }
        private void reset()
        {
            txtMaMon.Text = "";
            cbbNganh.SelectedValue = nganh.MaNganh;
        }
        /// <summary>
        /// Tải danh sách môn học vào datagridview
        /// </summary>
        private void LoadListMon()
        {

        }

        private void ChiTietNganhControl_Load(object sender, EventArgs e)
        {
            try
            {
                nganh.MaNganh = KhoaNganhControl.MaNganhStatic;
                dgvXemDSMon.DataSource = nganh.MonHocCuaNganh();
                //dgvXemDSMon.DataSource = monhoc.DanhSachMonHoc().Tables["MonHoc"];
                cbbNganh.DataSource = nganh.ThongTinNganh().Tables["Nganh"];
                cbbNganh.DisplayMember = "TenNganh";
                cbbNganh.ValueMember = "MaNganh";
                cbbNganh.SelectedValue = nganh.MaNganh;
                check = true;
            }
            catch (Exception)
            {

                ToastNotification.Show(this, "Chưa Chọn Ngành !");
            }

        }

        private void btnThemChiTietNganh_Click(object sender, EventArgs e)
        {
            dgvXemDSMon.Hide();
            btnThemChiTietNganh.Hide();
            DSMHKhongThuocNganh.Show();
            BtnThem.Show();
            DSMHKhongThuocNganh.DataSource = nganh.MonHocKhongThuocNganh();
            btnXemMonCuaNganh.Show();
            lBdgv.Text = "Môn Học Không Thuộc Ngành";
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void cbbNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (check)
                {
                    nganh.MaNganh = cbbNganh.SelectedValue.ToString();
                    dgvXemDSMon.DataSource = nganh.MonHocCuaNganh();
                    DSMHKhongThuocNganh.DataSource = nganh.MonHocKhongThuocNganh();
                }


            }
            catch (Exception)
            {

                ToastNotification.Show(this, "Chưa Chọn Ngành !");
            }
        }

        private void DSMHKhongThuocNganh_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaMon.DataBindings.Clear();
                txtMaMon.DataBindings.Add("Text", DSMHKhongThuocNganh.DataSource, "Mamon");

            }
            catch (Exception)
            {


            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (cbbNganh.Text.Trim() == "Chọn Ngành")
            {
                ToastNotification.Show(this, "Nhập mã ngành học !");
            }
            else if (txtMaMon.Text.Trim() == "")
            {
                ToastNotification.Show(this, "Nhập mã môn học !");
            }
            else
            {
                try
                {
                    monhoc.Mamonhoc = txtMaMon.Text;
                    monhoc.Manganh = cbbNganh.SelectedValue.ToString();
                    monhoc.ThemNganhMonHoc();
                    dgvXemDSMon.Show();
                    btnThemChiTietNganh.Show();
                    DSMHKhongThuocNganh.Hide();
                    BtnThem.Hide();
                    dgvXemDSMon.DataSource = nganh.MonHocCuaNganh();
                    
                    lBdgv.Text = "Môn Học Thuộc Ngành";
                    reset();
                    btnXemMonCuaNganh.Show();
                    btnXemMonCuaNganh.Hide();
                    ToastNotification.Show(this, "Thêm Thành Công !");
                }
                catch (Exception)
                {

                    ToastNotification.Show(this, "Thất Bại !");
                }
            }

        }

        private void btnXemMonCuaNganh_Click(object sender, EventArgs e)
        {
            nganh.MaNganh = cbbNganh.SelectedValue.ToString();
            dgvXemDSMon.DataSource = nganh.MonHocCuaNganh();
            dgvXemDSMon.Show();
            btnThemChiTietNganh.Show();
            DSMHKhongThuocNganh.Hide();
            BtnThem.Hide();
            lBdgv.Text = "Môn Học Thuộc Ngành";
            reset();
            btnXemMonCuaNganh.Hide();
        }
    }
}
