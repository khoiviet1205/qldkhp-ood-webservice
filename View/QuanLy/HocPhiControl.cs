using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLHPHP
{
    public partial class HocPhiControl : UserControl
    {
        public HocPhiControl()
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
                btnDong.Command = newValue.HocPhiCommands.Cancel;
            }
            else
            {
                btnDong.Command = null;
            }
        }

        private void binding()
        {
           
        }

        private void HocPhiControl_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimSV_TextChanged(object sender, EventArgs e)
        {
            
        }

        

    }
}
