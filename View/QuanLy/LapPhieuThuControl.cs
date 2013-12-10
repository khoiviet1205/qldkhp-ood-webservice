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
    public partial class LapPhieuThuControl : UserControl
    {
        public LapPhieuThuControl()
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
                btnDong.Command = newValue.LapPhieuThuCommands.Cancel;
            }
            else
            {
                btnDong.Command = null;
            }
        }

        private void LapPhieuThuControl_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSoTienDaDong_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
