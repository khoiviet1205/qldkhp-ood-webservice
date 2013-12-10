using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHPHP.Class
{
    class PhieuDangKi : QuanLy
    {
        private string maMonHoc;

        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }
        private int mssv;

        public int Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        public override void Them()
        {
            base.Them();
            Service.ThemCTPhieuDK(Mssv, maMonHoc);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaPhieuDKMonHoc(Mssv);
            Service.XoaCTPHIEUDK(Mssv);
            
        }
        public void XoaBangMaMon()
        {
            Service.XoaCTPHIEUDKBangMaMon(maMonHoc);
        }

    
    }
}
