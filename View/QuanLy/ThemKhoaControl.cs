﻿using System;
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
    public partial class ThemKhoaControl : UserControl
    {
        KhoaNganhControl _Muon = new KhoaNganhControl();
        //AppCommands newGT;
        public ThemKhoaControl()
        {
            InitializeComponent();
        }

        private AppCommands _Commands;
        Khoa khoa = new Khoa();
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
                buttonDong.Command = newValue.ThemKhoaCommands.Cancel;
            }
            else
            {
                buttonDong.Command = null;
                
            }
        }
        public void Reset()
        {
            txtTenKhoa.Text = "";
            txtMaKhoa.Text = "";
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text == "")
            {
                ToastNotification.Show(this, "Chưa nhập tên khoa ");
            }
            else if (txtMaKhoa.Text == "")
            {
                ToastNotification.Show(this, "Chưa nhập mã khoa");
            }
            else 
            {
                try
                {
                    khoa.TenKhoa = txtTenKhoa.Text;
                    khoa.MaKhoa = txtMaKhoa.Text;
                    khoa.Them();
                    ToastNotification.Show(this, "Đã thêm thành công!");
                    Reset();
                }
                catch(Exception)
                { 
                
                }
            }
        }
    }
}
