using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Threading;
using QLHPHP.Service;
using System.Data;
using System.Data.SqlClient;
namespace QLHPHP.View
{
    public partial class FormMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        QLHPHP.Service.QLSoapClient ql = new QLSoapClient();
        public static string TaiKhoan;
        public static String TenSV;
        public FormMain()
        {
            InitializeComponent();
        }
        private void DangNhap()
        {
            if (txtUser.Text.Trim().Equals(""))
            {
                ToastNotification.Show(this, "Chưa nhập User !");
            }
            else if (txtMatKhau.Text.Trim().Equals(""))
            {
                ToastNotification.Show(this, "Chưa nhập PassWord !");
            }

            else
            {
                try
                {
                    int key = int.Parse(ql.DangNhap(txtUser.Text.Trim(), txtMatKhau.Text.Trim()));
                    if (key == 1)
                    {
                        this.Hide();
                        FormQL ql1 = new FormQL();
                        ql1.Show();
                    }
                    FormMain.TaiKhoan = txtUser.Text.Trim();
                    FormMain.TenSV = ql.LayTenDangNhap(int.Parse(txtUser.Text.Trim()));
                    if (key == 0)
                    {
                        this.Hide();
                        FormSV sv = new FormSV();
                        sv.Show();
                    }


                }
                catch (Exception)
                {


                    ToastNotification.Show(this, "Tài khoản không tồn tại !");
                }
            }

        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            DangNhap();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        private void reflectionImage1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }

        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
    }
}