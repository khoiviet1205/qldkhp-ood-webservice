using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLHPHP.Class;
namespace QLHPHP.View
{
    public partial class FormSV : DevComponents.DotNetBar.Metro.MetroForm
    {
        SinhVien sv = new SinhVien();
        PhieuDangKi dangki = new PhieuDangKi();
        DataTable table;
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            this.Text = "Xin chào sinh viên " + FormMain.TenSV;

            sv.MSSV = int.Parse(FormMain.TaiKhoan);
            dangki.Mssv = sv.MSSV;
            table = sv.ThongTin().Tables["SINHVIEN"];
            lbHoTen.DataBindings.Clear();
            lbHoTen.DataBindings.Add("Text", table, "HoTen");
            lbMSSV.DataBindings.Clear();
            lbMSSV.DataBindings.Add("Text", table, "MSSV");
            lbGioiTinh.DataBindings.Clear();
            lbGioiTinh.DataBindings.Add("Text", table, "GioiTinh");
            lbNgaySinh.DataBindings.Clear();
            lbNgaySinh.DataBindings.Add("Text", table, "NgaySinh");
            lbNgaySinh.Text = lbNgaySinh.Text.Substring(0, 9);
            lbNganh.DataBindings.Clear();
            lbNganh.DataBindings.Add("Text", table, "TenNganh");
            lbDoiTuong.DataBindings.Clear();
            lbDoiTuong.DataBindings.Add("Text", table, "TenDoiTuong");
            //

            GwDKMonhoc.DataSource = sv.ThongTinDKMonHoc().Tables["SINHVIEN"];
            foreach (DataGridViewRow row in GwDKMonhoc.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[5];
                if (chk.Selected == true)
                {
                    chk.Selected = false;
                }
                else
                {
                    chk.Selected = true;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauMoi.Text.Trim().Equals(""))
                {
                    ToastNotification.Show(this, "Chưa nhập mật khẩu mới !");
                }
                else
                {
                    sv.Service.SuaTaiKhoan(sv.MSSV.ToString(), txtMatKhauMoi.Text.Trim(), 0);
                    ToastNotification.Show(this, "Đổi thành công!");
                    txtMatKhauMoi.Text = "";
                }

            }
            catch (Exception)
            {

                ToastNotification.Show(this, "Không thành công!");
            }

        }

        private void txtDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                sv.XoaPhieuDKMonHoc();
                dangki.Xoa();
                sv.ThemPhieuDKMonHoc();
                int maxsophieu = int.Parse(sv.MaxPhieuDangKi());
                for (int i = 0; i < GwDKMonhoc.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(GwDKMonhoc.Rows[i].Cells["chon"].Value) == true && !Convert.ToString(GwDKMonhoc.Rows[i].Cells[1].Value).Equals(""))
                    {
                        dangki.MaMonHoc = Convert.ToString(GwDKMonhoc.Rows[i].Cells[1].Value);
                        dangki.Them();
                    }

                }
                ToastNotification.Show(this, "Đã đăng ký thành công!");
            }
            catch
            {
                ToastNotification.Show(this, "Đã đăng ký không thành công!");
            }
        }
    }
}