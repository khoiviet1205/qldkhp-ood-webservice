using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLHPHP.Class
{
    class Khoa:QuanLy
    {
        private string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        private string tenKhoa;

        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }

        public override void Them()
        {
            base.Them();
            Service.ThemKhoa(maKhoa, tenKhoa);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaKhoa(maKhoa);
        }
        public override void Sua()
        {
            base.Sua();
            Service.SuaKhoa(maKhoa, tenKhoa);
        }
        public DataSet ThongTinKhoa()
        {
            return Service.ThongTinKhoa();
        }
        public DataTable NganhCuaKhoa()
        {
            return Service.NganhCuaKhoa(maKhoa);
        }
    }
}
