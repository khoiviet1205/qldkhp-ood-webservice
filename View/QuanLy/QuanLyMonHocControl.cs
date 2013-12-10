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
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimMon_TextChanged_1(object sender, EventArgs e)
        {
            monhoc.Tenmonhoc = txtTimMon.Text.Trim();
            dgvDSMonHoc.DataSource = monhoc.TimMonHoc().Tables["MonHoc"];
        }
    }
}
