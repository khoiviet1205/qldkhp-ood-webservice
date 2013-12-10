using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLHPHP.Class;
using System.Data;

namespace QLHPHP
{
    public partial class TimKiemControl : UserControl
    {
        public TimKiemControl()
        {
            InitializeComponent();
        }
        SinhVien sv = new SinhVien();
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
                btnClose.Command = newValue.TimKiemCommands.Cancel;

            }
            else
            {
                btnClose.Command = null;

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnTimNangCao_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Trim()!="")
            {
                sv.MSSV = int.Parse(txtMSSV.Text);
            }

            sv.Hoten = txtHoTen.Text.Trim();
            sv.Gioitinh = txtGioiTinh.Text.Trim();
            sv.Madoituong = txtMaDoiTuong.Text.Trim();
            sv.Manganh = txtTenNganh.Text.Trim();
            sv.Diachi = txtDiaChi.Text.Trim();
            sv.Email = txtemail.Text.Trim();
            dgvDSTK.DataSource = sv.TimKiem().Tables["SinhVien"];
        }

    }
}
