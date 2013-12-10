using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHPHP.Class
{
    class TaiKhoan : QuanLy
    {
        private string taikhoan;

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        private int key;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }
        public override void Them()
        {
            base.Them();
            Service.ThemTaiKhoan(taikhoan, matkhau, key);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaTaiKhoan(taikhoan);
        }
        public override void Sua()
        {
            base.Sua();
            Service.SuaTaiKhoan(taikhoan, matkhau, key);
        }
    }
}
