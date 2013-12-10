using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QLHPHP
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
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
                //btnDong.Command = newValue.ReportComands.Cancel;
                buttonDong.Command = newValue.ReportComands.Cancel;

            }
            else
            {
                //btnDong.Command = null;
                buttonDong.Command = null;
            }
        }

        private void btnShowRP_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            
            
        }

       

        

        
    }
}
