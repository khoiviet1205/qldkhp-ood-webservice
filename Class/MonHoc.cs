using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLHPHP.Class
{
    class MonHoc : QuanLy
    {
        private string mamonhoc;

        public string Mamonhoc
        {
            get { return mamonhoc; }
            set { mamonhoc = value; }
        }
        private string tenmonhoc;

        public string Tenmonhoc
        {
            get { return tenmonhoc; }
            set { tenmonhoc = value; }
        }
        private int sotclt;

        public int Sotclt
        {
            get { return sotclt; }
            set { sotclt = value; }
        }
        private int sotcth;

        public int Sotcth
        {
            get { return sotcth; }
            set { sotcth = value; }
        }
        private string manganh;

        public string Manganh
        {
            get { return manganh; }
            set { manganh = value; }
        }
        private int slToiDa;

        public int SlToiDa
        {
            get { return slToiDa; }
            set { slToiDa = value; }
        }
        public override void Them()
        {
            base.Them();
            Service.ThemMonHoc(mamonhoc, tenmonhoc, sotclt, sotcth,slToiDa);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaCTPHIEUDKBangMaMon(mamonhoc);
            Service.XoaMonHocNganh(mamonhoc);
            Service.XoaMonHoc(mamonhoc);
        }
        public override void Sua()
        {
            base.Sua();
            Service.SuaMonHoc(mamonhoc, tenmonhoc, sotclt, sotcth, manganh,slToiDa);
        }
        public DataSet DanhSachMonHoc()
        {
            return Service.DanhSachMonHoc();
        }
        public DataSet TimMonHoc()
        {
            return Service.TimMonHoc(tenmonhoc);
        }
        public DataSet NganhCuaMonHoc()
        {
            return Service.NganhCuaMonHoc(mamonhoc);
        }
        public DataTable SinhVienDKMonHoc()
        {
            return Service.SinhVienDKMonHoc();
        }
        public void ThemNganhMonHoc()
        {
            Service.ThemNganhMonHoc(Mamonhoc, manganh);
        }
        public void XoaMonRaKhoiNganh()
        {
            Service.XoaMonRaKhoiNganh(Mamonhoc, manganh);
        }
    }
}
