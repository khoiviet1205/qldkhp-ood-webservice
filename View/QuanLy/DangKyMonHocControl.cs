﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLHPHP
{
    public partial class DangKyMonHocControl : UserControl
    {
        public DangKyMonHocControl()
        {
            InitializeComponent();
        }

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
                buttonDong.Command = newValue.DangKyMonHocCommands.Cancel;
            }
            else
            {
                buttonDong.Command = null;
            }
        }

        private void btnChiTietDKMonHoc_Click(object sender, EventArgs e)
        {
            
        }

        
        private void DangKyMonHocControl_Load(object sender, EventArgs e)
        {
           
        }

        //Load list khoa vao cbb
        private void LoadDSKhoaInCbb()
        {
            
        }

        //Load danh sach nganh len cbb
        private void LoadDSNganhInCbb()
        {
           
        }

        private void CapNhatDSMonHoc()
        {
           
        }

        public void btnDangKyMonHoc_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}