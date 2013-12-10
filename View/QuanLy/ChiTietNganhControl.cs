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
    public partial class ChiTietNganhControl : UserControl
    {
        public ChiTietNganhControl()
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

        /// <summary>
        /// Tải danh sách môn học vào datagridview
        /// </summary>
        private void LoadListMon()
        {
            
        }

        private void ChiTietNganhControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThemChiTietNganh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
