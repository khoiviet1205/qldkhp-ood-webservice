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
    public partial class ThemNganhControl : UserControl
    {
        public ThemNganhControl()
        {
            InitializeComponent();
        }

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
                //buttonDong.Command = newValue.ThemKhoaCommands.Cancel;
                buttonDong.Command = newValue.ThemNganhCommands.Cancel;
            }
            else
            {
                buttonDong.Command = null;
                //buttonDong.Command = null;

            }
        }
        // Load list khoa vao cbbKhoa2
        private void LoadListKhoaInCbb2()
        {
            cbbKhoa2.DataSource = khoa.ThongTinKhoa().Tables["KHOA"];
            cbbKhoa2.DisplayMember = "TenKhoa";
            cbbKhoa2.ValueMember = "MaKhoa";
        }
        public void Reset()
        {
            txtTenNganh.Text = "";
            txtMaNganh.Text = "";
        }
        private void ThemNganhControl_Load(object sender, EventArgs e)
        {
            LoadListKhoaInCbb2();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (txtTenNganh.Text == "")
            {
                ToastNotification.Show(this, "Chưa nhập tên khoa ");
            }
            else if (txtMaNganh.Text == "")
            {
                ToastNotification.Show(this, "Chưa nhập mã khoa");
            }
            else
            {
                try
                {
                    nganh.TenNganh = txtMaNganh.Text;
                    nganh.MaNganh = txtMaNganh.Text;
                    nganh.Them();
                    ToastNotification.Show(this, "Đã thêm thành công!");
                    Reset();
                }
                catch (Exception)
                {

                }
            }
        }
        


    }
}
