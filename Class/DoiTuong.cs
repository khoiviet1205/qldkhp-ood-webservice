using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLHPHP.Class
{
    class DoiTuong:QuanLy
    {
        private string maDoiTuong;

        public string MaDoiTuong
        {
            get { return maDoiTuong; }
            set { maDoiTuong = value; }
        }
        private string tenDoiTuong;

        public string TenDoiTuong
        {
            get { return tenDoiTuong; }
            set { tenDoiTuong = value; }
        }
        private int tiLeGiam;

        public int TiLeGiam
        {
            get { return tiLeGiam; }
            set { tiLeGiam = value; }
        }
        public override void Them()
        {
            base.Them();
            Service.ThemDoiTuong(maDoiTuong, tenDoiTuong, tiLeGiam);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaDoiTuong(maDoiTuong);
            
        }
        public override void Sua()
        {
            base.Sua();
            Service.SuaDoiTuong(maDoiTuong, tenDoiTuong, tiLeGiam);
        }
        public DataSet ThongTinDoiTuong()
        {
           return  Service.ThongTinDoiTuong();
        }

    }
}
