﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHPHP.Service {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.QLSoap")]
    public interface QLSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemSinhVien(string hoten, string ngaysinh, string gioitinh, string diachi, string email, string madoituong, string manganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaSinhVien(int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaSinhVien(int MSSV, string hoten, string ngaysinh, string gioitinh, string diachi, string email, string madoituong, string manganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThongTinSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ThongTinSinhVien(int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DanhSachSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet DanhSachSinhVien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimTheoTen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet TimTheoTen(string Hoten);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThongTinDangKyMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ThongTinDangKyMonHoc(int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SinhVienDKMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable SinhVienDKMonHoc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MaxMaSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MaxMaSinhVien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimKiem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet TimKiem(string MSSV, string hoten, string gioitinh, string diachi, string email, string doituong, string nganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TongTCSinhVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TongTCSinhVien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemNganh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemNganh(string MaNganh, string TenNganh, string MaKhoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaNganh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaNganh(string MaNganh, string TenNganh, string MaKhoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaNganh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaNganh(string MaNganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThongTinNganh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ThongTinNganh();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NganhCuaKhoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable NganhCuaKhoa(string MaKhoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonHocCuaNganh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable MonHocCuaNganh(string MaNganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonHocKhongThuocNganh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable MonHocKhongThuocNganh(string MaNganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemKhoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemKhoa(string MaKhoa, string TenKhoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaKhoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaKhoa(string MaKhoa, string TenKhoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaKhoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaKhoa(string MaKhoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThongTinKhoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ThongTinKhoa();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemMonHoc(string MaMonHoc, string TenMonHoc, int SoTCLT, int SoTCTH, string MaNganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaMonHoc(string MaMonHoc, string TenMonHoc, int SoTCLT, int SoTCTH, string MaNganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaMonHoc(string MaMon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DanhSachMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet DanhSachMonHoc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet TimMonHoc(string TenMonHoc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NganhCuaMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet NganhCuaMonHoc(string MaMonHoc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemNganhMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemNganhMonHoc(string MaMonHoc, string MaNganh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemDoiTuong", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemDoiTuong(string MaDoiTuong, string TenDoiTuong, int TiLegiam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaDoiTuong", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaDoiTuong(string MaDoiTuong, string TenDoiTuong, int TiLegiam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaDoiTuong", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaDoiTuong(string MaDoiTuong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThongTinDoiTuong", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ThongTinDoiTuong();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemPhieuDKMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemPhieuDKMonHoc(int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaPhieuDKMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaPhieuDKMonHoc(int MaPhieu, int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaPhieuDKMonHoc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaPhieuDKMonHoc(int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MaxPhieuDangKi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MaxPhieuDangKi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemCTPhieuDK", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemCTPhieuDK(int MSSV, string MaMonHoc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaCTPHIEUDK", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaCTPHIEUDK(int MSSV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaCTPHIEUDKBangMaMon", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaCTPHIEUDKBangMaMon(string Mamon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemPhieuThu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemPhieuThu(int MaPhieu, int MaPhieuDK, int SoTien, string NgayLap);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaPhieuThu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaPhieuThu(int MaPhieu, int MaPhieuDK, int SoTien, string NgayLap);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaPhieuThu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaPhieuThu(int MaPhieu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemThamSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemThamSo(string TenThamSo, int GiaTri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaThamSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaThamSo(string TenThamSo, int GiaTri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaThamSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaThamSo(string TenThamSo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemTaiKhoan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ThemTaiKhoan(string Ten, string MatKhau, int key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaTaiKhoan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SuaTaiKhoan(string Ten, string MatKhau, int key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaTaiKhoan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void XoaTaiKhoan(string TenTaiKhoan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DangNhap", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string DangNhap(string ten, string mk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LayTenDangNhap", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string LayTenDangNhap(int mssv);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface QLSoapChannel : QLHPHP.Service.QLSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QLSoapClient : System.ServiceModel.ClientBase<QLHPHP.Service.QLSoap>, QLHPHP.Service.QLSoap {
        
        public QLSoapClient() {
        }
        
        public QLSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QLSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QLSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QLSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ThemSinhVien(string hoten, string ngaysinh, string gioitinh, string diachi, string email, string madoituong, string manganh) {
            base.Channel.ThemSinhVien(hoten, ngaysinh, gioitinh, diachi, email, madoituong, manganh);
        }
        
        public void XoaSinhVien(int MSSV) {
            base.Channel.XoaSinhVien(MSSV);
        }
        
        public void SuaSinhVien(int MSSV, string hoten, string ngaysinh, string gioitinh, string diachi, string email, string madoituong, string manganh) {
            base.Channel.SuaSinhVien(MSSV, hoten, ngaysinh, gioitinh, diachi, email, madoituong, manganh);
        }
        
        public System.Data.DataSet ThongTinSinhVien(int MSSV) {
            return base.Channel.ThongTinSinhVien(MSSV);
        }
        
        public System.Data.DataSet DanhSachSinhVien() {
            return base.Channel.DanhSachSinhVien();
        }
        
        public System.Data.DataSet TimTheoTen(string Hoten) {
            return base.Channel.TimTheoTen(Hoten);
        }
        
        public System.Data.DataSet ThongTinDangKyMonHoc(int MSSV) {
            return base.Channel.ThongTinDangKyMonHoc(MSSV);
        }
        
        public System.Data.DataTable SinhVienDKMonHoc() {
            return base.Channel.SinhVienDKMonHoc();
        }
        
        public string MaxMaSinhVien() {
            return base.Channel.MaxMaSinhVien();
        }
        
        public System.Data.DataSet TimKiem(string MSSV, string hoten, string gioitinh, string diachi, string email, string doituong, string nganh) {
            return base.Channel.TimKiem(MSSV, hoten, gioitinh, diachi, email, doituong, nganh);
        }
        
        public System.Data.DataTable TongTCSinhVien() {
            return base.Channel.TongTCSinhVien();
        }
        
        public void ThemNganh(string MaNganh, string TenNganh, string MaKhoa) {
            base.Channel.ThemNganh(MaNganh, TenNganh, MaKhoa);
        }
        
        public void SuaNganh(string MaNganh, string TenNganh, string MaKhoa) {
            base.Channel.SuaNganh(MaNganh, TenNganh, MaKhoa);
        }
        
        public void XoaNganh(string MaNganh) {
            base.Channel.XoaNganh(MaNganh);
        }
        
        public System.Data.DataSet ThongTinNganh() {
            return base.Channel.ThongTinNganh();
        }
        
        public System.Data.DataTable NganhCuaKhoa(string MaKhoa) {
            return base.Channel.NganhCuaKhoa(MaKhoa);
        }
        
        public System.Data.DataTable MonHocCuaNganh(string MaNganh) {
            return base.Channel.MonHocCuaNganh(MaNganh);
        }
        
        public System.Data.DataTable MonHocKhongThuocNganh(string MaNganh) {
            return base.Channel.MonHocKhongThuocNganh(MaNganh);
        }
        
        public void ThemKhoa(string MaKhoa, string TenKhoa) {
            base.Channel.ThemKhoa(MaKhoa, TenKhoa);
        }
        
        public void SuaKhoa(string MaKhoa, string TenKhoa) {
            base.Channel.SuaKhoa(MaKhoa, TenKhoa);
        }
        
        public void XoaKhoa(string MaKhoa) {
            base.Channel.XoaKhoa(MaKhoa);
        }
        
        public System.Data.DataSet ThongTinKhoa() {
            return base.Channel.ThongTinKhoa();
        }
        
        public void ThemMonHoc(string MaMonHoc, string TenMonHoc, int SoTCLT, int SoTCTH, string MaNganh) {
            base.Channel.ThemMonHoc(MaMonHoc, TenMonHoc, SoTCLT, SoTCTH, MaNganh);
        }
        
        public void SuaMonHoc(string MaMonHoc, string TenMonHoc, int SoTCLT, int SoTCTH, string MaNganh) {
            base.Channel.SuaMonHoc(MaMonHoc, TenMonHoc, SoTCLT, SoTCTH, MaNganh);
        }
        
        public void XoaMonHoc(string MaMon) {
            base.Channel.XoaMonHoc(MaMon);
        }
        
        public System.Data.DataSet DanhSachMonHoc() {
            return base.Channel.DanhSachMonHoc();
        }
        
        public System.Data.DataSet TimMonHoc(string TenMonHoc) {
            return base.Channel.TimMonHoc(TenMonHoc);
        }
        
        public System.Data.DataSet NganhCuaMonHoc(string MaMonHoc) {
            return base.Channel.NganhCuaMonHoc(MaMonHoc);
        }
        
        public void ThemNganhMonHoc(string MaMonHoc, string MaNganh) {
            base.Channel.ThemNganhMonHoc(MaMonHoc, MaNganh);
        }
        
        public void ThemDoiTuong(string MaDoiTuong, string TenDoiTuong, int TiLegiam) {
            base.Channel.ThemDoiTuong(MaDoiTuong, TenDoiTuong, TiLegiam);
        }
        
        public void SuaDoiTuong(string MaDoiTuong, string TenDoiTuong, int TiLegiam) {
            base.Channel.SuaDoiTuong(MaDoiTuong, TenDoiTuong, TiLegiam);
        }
        
        public void XoaDoiTuong(string MaDoiTuong) {
            base.Channel.XoaDoiTuong(MaDoiTuong);
        }
        
        public System.Data.DataSet ThongTinDoiTuong() {
            return base.Channel.ThongTinDoiTuong();
        }
        
        public void ThemPhieuDKMonHoc(int MSSV) {
            base.Channel.ThemPhieuDKMonHoc(MSSV);
        }
        
        public void SuaPhieuDKMonHoc(int MaPhieu, int MSSV) {
            base.Channel.SuaPhieuDKMonHoc(MaPhieu, MSSV);
        }
        
        public void XoaPhieuDKMonHoc(int MSSV) {
            base.Channel.XoaPhieuDKMonHoc(MSSV);
        }
        
        public string MaxPhieuDangKi() {
            return base.Channel.MaxPhieuDangKi();
        }
        
        public void ThemCTPhieuDK(int MSSV, string MaMonHoc) {
            base.Channel.ThemCTPhieuDK(MSSV, MaMonHoc);
        }
        
        public void XoaCTPHIEUDK(int MSSV) {
            base.Channel.XoaCTPHIEUDK(MSSV);
        }
        
        public void XoaCTPHIEUDKBangMaMon(string Mamon) {
            base.Channel.XoaCTPHIEUDKBangMaMon(Mamon);
        }
        
        public void ThemPhieuThu(int MaPhieu, int MaPhieuDK, int SoTien, string NgayLap) {
            base.Channel.ThemPhieuThu(MaPhieu, MaPhieuDK, SoTien, NgayLap);
        }
        
        public void SuaPhieuThu(int MaPhieu, int MaPhieuDK, int SoTien, string NgayLap) {
            base.Channel.SuaPhieuThu(MaPhieu, MaPhieuDK, SoTien, NgayLap);
        }
        
        public void XoaPhieuThu(int MaPhieu) {
            base.Channel.XoaPhieuThu(MaPhieu);
        }
        
        public void ThemThamSo(string TenThamSo, int GiaTri) {
            base.Channel.ThemThamSo(TenThamSo, GiaTri);
        }
        
        public void SuaThamSo(string TenThamSo, int GiaTri) {
            base.Channel.SuaThamSo(TenThamSo, GiaTri);
        }
        
        public void XoaThamSo(string TenThamSo) {
            base.Channel.XoaThamSo(TenThamSo);
        }
        
        public void ThemTaiKhoan(string Ten, string MatKhau, int key) {
            base.Channel.ThemTaiKhoan(Ten, MatKhau, key);
        }
        
        public void SuaTaiKhoan(string Ten, string MatKhau, int key) {
            base.Channel.SuaTaiKhoan(Ten, MatKhau, key);
        }
        
        public void XoaTaiKhoan(string TenTaiKhoan) {
            base.Channel.XoaTaiKhoan(TenTaiKhoan);
        }
        
        public string DangNhap(string ten, string mk) {
            return base.Channel.DangNhap(ten, mk);
        }
        
        public string LayTenDangNhap(int mssv) {
            return base.Channel.LayTenDangNhap(mssv);
        }
    }
}
