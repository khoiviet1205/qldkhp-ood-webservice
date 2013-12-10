using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLHPHP.Class
{
    class Nganh : QuanLy
    {
        private string maNganh;

        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string tenNganh;

        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }
        private string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

        public override void Them()
        {
            base.Them();
            Service.ThemNganh(maNganh, tenNganh, maKhoa);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaNganh(maNganh);
        }
        public override void Sua()
        {
            base.Sua();
            Service.SuaNganh(maNganh, tenNganh, maKhoa);

        }
        public DataSet ThongTinNganh()
        {
           return  Service.ThongTinNganh();
        }

    }
}
