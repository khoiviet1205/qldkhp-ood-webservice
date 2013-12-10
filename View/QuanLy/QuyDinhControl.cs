using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLHPHP
{
    public partial class QuyDinhControl : UserControl
    {
        /// <summary>
        /// Cập nhật thông tin các đối tượng miễn giảm học phí
        /// </summary>
        public QuyDinhControl()
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
                buttonDong.Command = newValue.QuyDinhCommands.Cancel;
                //buttonDong.Command = newValue.DanhSachSVCommands.Cancel;
            }
            else
            {
                buttonDong.Command = null;
                //buttonDong.Command = null;
            }
        }

        private void BindingDT()
        {
           
        }

        private void QuyDinhControl_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonThemDoiTuong_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCleanDT_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonXoaDoiTuong_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSuaDoiTuong_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCapNhatDoiTuong_Click(object sender, EventArgs e)
        {
            
        }

        private void BindingTS()
        {
            
        }

        private void buttonCleanTS_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThemThamSo_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonXoaThamSo_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSuaThamSo_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCapNhatThamSo_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
