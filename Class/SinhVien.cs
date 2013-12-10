using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHPHP.Service;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QLHPHP.Class
{
    class SinhVien : QuanLy
    {
        private int Mssv;
        
        public int MSSV
        {
            get { return Mssv; }
            set { Mssv = value; }
        }
        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private string ngaysinh;

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string madoituong;

        public string Madoituong
        {
            get { return madoituong; }
            set { madoituong = value; }
        }
        private string manganh;

        public string Manganh
        {
            get { return manganh; }
            set { manganh = value; }
        }

        public override void Them()
        {
            base.Them();
            Service.ThemSinhVien(hoten, ngaysinh, gioitinh, diachi, email, madoituong, manganh);
        }
        public override void Xoa()
        {
            base.Xoa();
            Service.XoaSinhVien(Mssv);
        }
        public override void Sua()
        {
            base.Sua();
            Service.SuaSinhVien(Mssv, hoten, ngaysinh, gioitinh, diachi, email, madoituong, manganh);
        }
        public DataSet ThongTin()
        {
            return Service.ThongTinSinhVien(Mssv);
        }
        public DataSet DanhSachSinhVien()
        {
            return Service.DanhSachSinhVien();
        }
        public DataSet ThongTinDKMonHoc()
        {
            return Service.ThongTinDangKyMonHoc(Mssv);
        }
        public DataSet TimTheoTen()
        {
            return Service.TimTheoTen(hoten);
        }
        public void ThemPhieuDKMonHoc()
        {
            Service.ThemPhieuDKMonHoc(Mssv);
        }
        public string MaxMaSinhVien()
        {
            return Service.MaxMaSinhVien();
        }
        public string MaxPhieuDangKi()
        {
            return Service.MaxPhieuDangKi();
        }
        public void XoaPhieuDKMonHoc()
        {
            Service.XoaPhieuDKMonHoc(Mssv);
        }
        public DataSet TimKiem()
        {
           return Service.TimKiem(Mssv.ToString(), hoten, gioitinh, diachi, email, madoituong, manganh);
        }
    }

}
