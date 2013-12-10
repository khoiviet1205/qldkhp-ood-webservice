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
    public partial class KhoaNganhControl : UserControl
    {

        public KhoaNganhControl()
        {
            InitializeComponent();
        }
        public static string MaNganhStatic;
        private AppCommands _Commands;
        Khoa khoa = new Khoa();
        Nganh nganh = new Nganh();
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
                //DongButton.Command = newValue.KhoaNganhControlCommands.Cancel;
                DongButton.Command = newValue.KhoaNganhCommands.Cancel;
            }
            else
            {
                DongButton.Command = null;

            }
        }

        private void KhoaNganhControl_Load(object sender, EventArgs e)
        {
            LoadListKhoa();
            cbKhoa.DataSource = khoa.ThongTinKhoa().Tables["KHOA"];
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        // Load list khoa vao dataGridView
        public void LoadListKhoa()
        {
            dgvKhoa.DataSource = khoa.ThongTinKhoa().Tables["KHOA"];
        }
        /// <summary>
        /// Load danh sách ngành
        /// </summary>
        private void LoadListNganh()
        {
            try
            {
                khoa.MaKhoa = cbKhoa.SelectedValue.ToString();
                dgvNganh.DataSource = khoa.NganhCuaKhoa();
            }
            catch
            {
                ToastNotification.Show(this, "Có lỗi trong quá trình lấy dữ liệu!");

            }
        }

        private void buttonThemKhoa_Click(object sender, EventArgs e)
        {
            buttonThemKhoa.Command = _Commands.ThemKhoaCommands.New;
        }

        private void buttonLamMoiKhoa_Click(object sender, EventArgs e)
        {
            LoadListKhoa();
        }

        private void buttonXoaKhoa_Click(object sender, EventArgs e)
        {
            khoa.MaKhoa = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            string name = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            if (khoa.MaKhoa != "")
            {
                try
                {
                    khoa.Xoa();
                    LoadListKhoa();
                    ToastNotification.Show(this, "Đã xóa khoa " + name + " thành công");

                }
                catch
                {
                    ToastNotification.Show(this, "Lỗi!");

                }
            }
            else
            {
                ToastNotification.Show(this, "Vui lòng chọn Khoa để xóa!");

            }
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadListNganh();
        }

        private void buttonThemNganh_Click(object sender, EventArgs e)
        {
           
            buttonThemNganh.Command = _Commands.ThemNganhCommands.New;
        }

        private void buttonXoaNganh_Click(object sender, EventArgs e)
        {
            nganh.MaNganh = dgvNganh.CurrentRow.Cells["MaNganh"].Value.ToString();
            string name = dgvNganh.CurrentRow.Cells[1].Value.ToString();
            if (nganh.MaNganh != "")
            {
                try
                {
                    nganh.Xoa();
                    LoadListNganh();
                    ToastNotification.Show(this, "Đã xóa ngành " + name + " thành công");

                }
                catch
                {
                    ToastNotification.Show(this, "Lỗi!");

                }
            }
            else
            {
                ToastNotification.Show(this, "Vui lòng chọn Khoa để xóa!");

            }
        }

        private void buttonLamMoiNganh_Click(object sender, EventArgs e)
        {
            LoadListNganh();
        }

        private void btnChiTietNganh_Click(object sender, EventArgs e)
        {
            btnChiTietNganh.Command = _Commands.ChiTietNganhCommands.New;
        }

        private void superTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void buttonThemKhoa_Click_1(object sender, EventArgs e)
        {
            buttonThemKhoa.Command = _Commands.ThemKhoaCommands.New;
        }

        private void dgvNganh_Click(object sender, EventArgs e)
        {
            MaNganhStatic = dgvNganh.CurrentRow.Cells["MaNganh"].Value.ToString() ;
        }


        private void buttonXoaKhoa_Click_1(object sender, EventArgs e)
        {
            khoa.MaKhoa = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            string name = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            if (khoa.MaKhoa != "")
            {
                try
                {
                    khoa.Xoa();
                    LoadListKhoa();
                    ToastNotification.Show(this, "Đã xóa khoa " + name + " thành công");

                }
                catch
                {
                    ToastNotification.Show(this, "Lỗi!");

                }
            }
            else
            {
                ToastNotification.Show(this, "Vui lòng chọn Khoa để xóa!");


            }
        }

        private void buttonLamMoiKhoa_Click_1(object sender, EventArgs e)
        {
            LoadListKhoa();
        }

        private void buttonThemNganh_Click_1(object sender, EventArgs e)
        {
            buttonThemNganh.Command = _Commands.ThemNganhCommands.New;
        }

        private void buttonXoaNganh_Click_1(object sender, EventArgs e)
        {
            nganh.MaNganh = dgvNganh.CurrentRow.Cells["MaNganh"].Value.ToString();
            string name = dgvNganh.CurrentRow.Cells[1].Value.ToString();
            if (nganh.MaNganh != "")
            {
                try
                {
                    nganh.Xoa();
                    LoadListNganh();
                    ToastNotification.Show(this, "Đã xóa ngành " + name + " thành công");

                }
                catch
                {
                    ToastNotification.Show(this, "Lỗi!");

                }
            }
            else
            {
                ToastNotification.Show(this, "Vui lòng chọn ngành để xóa!");

            }
        }

        private void buttonLamMoiNganh_Click_1(object sender, EventArgs e)
        {
            LoadListNganh();
        }

        private void btnChiTietNganh_Click_1(object sender, EventArgs e)
        {
            btnChiTietNganh.Command = _Commands.ChiTietNganhCommands.New;
        }







    }
}
