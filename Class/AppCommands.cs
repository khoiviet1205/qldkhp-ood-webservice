using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;

namespace QLHPHP
{
    /// <summary>
    /// Represents all application commands.
    /// </summary>
    public class AppCommands
    {
        private THCommands _DanhSachSVCommands = new THCommands();
        /// <summary>
        /// Lay cac lenh lien quan den danh sach sinh vien
        /// </summary>
        public THCommands DanhSachSVCommands
        {
            get { return _DanhSachSVCommands; }
            set { _DanhSachSVCommands = value; }
        }

        private THCommands _NhapSinhVienCommands = new THCommands();
        /// <summary>
        /// Lay cac lenh lien quan den Nhap sinh vien
        /// </summary>
        public THCommands NhapSinhVienCommands
        {
            get { return _NhapSinhVienCommands; }
            set { _NhapSinhVienCommands = value; }
        }

        private THCommands _KhoaNganhCommands = new THCommands();
        /// <summary>
        /// Lay cac lenh lien quan den Khoa-Nganh
        /// </summary>
        public THCommands KhoaNganhCommands
        {
            get { return _KhoaNganhCommands; }
            set { _KhoaNganhCommands = value; }
        }

        private THCommands _QuanLyMonHocCommands = new THCommands();
        /// <summary>
        /// Lay cac lenh lien quan den Quan ly mon hoc
        /// </summary>
        public THCommands QuanLyMonHocCommands
        {
            get { return _QuanLyMonHocCommands; }
            set { _QuanLyMonHocCommands = value; }
        }

        private THCommands _DangKyMonHocCommands = new THCommands();
        /// <summary>
        /// Lay cac lenh lien quan den Dang ky mon hoc
        /// </summary>
        public THCommands DangKyMonHocCommands
        {
            get { return _DangKyMonHocCommands; }
            set { _DangKyMonHocCommands = value; }
        }

        private THCommands _ChiTietDangKyCommands = new THCommands();
        /// <summary>
        /// Lay cac lenh lien den Chi tiet dang ky mon hoc
        /// </summary>
        public THCommands ChiTietDangKyCommands
        {
            get { return _ChiTietDangKyCommands; }
            set { _ChiTietDangKyCommands = value; }
        }

        private THCommands _ThemKhoaCommands = new THCommands();
        /// <summary>
        /// Cac lenh lien quan den Them Khoa
        /// </summary>
        public THCommands ThemKhoaCommands
        {
            get { return _ThemKhoaCommands; }
            set { _ThemKhoaCommands = value; }
        }

        private THCommands _ThemNganhCommands = new THCommands();
        /// <summary>
        /// Cac lenh lien quan den Them Nganh
        /// </summary>
        public THCommands ThemNganhCommands
        {
            get { return _ThemNganhCommands; }
            set { _ThemNganhCommands = value; }
        }

        private THCommands _ChiTietNganhCommands = new THCommands();
        /// <summary>
        /// Cac lenh lien quan den Them Chi Tiet Nganh
        /// </summary>
        public THCommands ChiTietNganhCommands
        {
            get { return _ChiTietNganhCommands; }
            set { _ChiTietNganhCommands = value; }
        }

        private THCommands _QuyDinhCommands = new THCommands();
        /// <summary>
        /// Cac lenh lien quan den Quy Dinh 
        /// </summary>
        public THCommands QuyDinhCommands
        {
            get { return _QuyDinhCommands; }
            set { _QuyDinhCommands = value; }
        }

        private THCommands _TimKiemCommands = new THCommands();
        /// <summary>
        /// Cac lenh lien quan den Tim Kiem
        /// </summary>
        public THCommands TimKiemCommands
        {
            get { return _TimKiemCommands; }
            set { _TimKiemCommands = value; }
        }

        private THCommands _CapNhapThongTinCommands = new THCommands();
        /// <summary>
        /// Cac lenh lien quan den cap nhap thong tin
        /// </summary>
        public THCommands CapNhapThongTinCommands
        {
            get { return _CapNhapThongTinCommands; }
            set { _CapNhapThongTinCommands = value; }
        }

        private THCommands _MonHocTichLuyCommands = new THCommands();
        /// <summary>
        /// Cac lenh ve mon hoc tich luy
        /// </summary>
        public THCommands MonHocTichLuyCommands
        {
            get { return _MonHocTichLuyCommands; }
            set { _MonHocTichLuyCommands = value; }
        }

        private THCommands _HocPhiCommands = new THCommands();
        /// <summary>
        /// Cac lenh ve hoc phi
        /// </summary>
        public THCommands HocPhiCommands
        {
            get { return _HocPhiCommands; }
            set { _HocPhiCommands = value; }
        }

        private THCommands _DSDaDongHocPhiCommands = new THCommands();
        /// <summary>
        /// danh sach sv da dong hoc phi
        /// </summary>
        public THCommands DSDaDongHocPhiCommands
        {
            get { return _DSDaDongHocPhiCommands; }
            set { _DSDaDongHocPhiCommands = value; }
        }

        private THCommands _LapPhieuThuCommands = new THCommands();
        /// <summary>
        /// lap phieu thu
        /// </summary>
        public THCommands LapPhieuThuCommands
        {
            get { return _LapPhieuThuCommands; }
            set { _LapPhieuThuCommands = value; }
        }

        private THCommands _ReportCommands = new THCommands();
        /// <summary>
        /// Report
        /// </summary>
        public THCommands ReportComands
        {
            get { return _ReportCommands; }
            set { _ReportCommands = value; }
        }

        private THCommands _AboutCommands = new THCommands();
        /// <summary>
        /// Thong tin nhom
        /// </summary>
        public THCommands AboutCommands
        {
            get { return _AboutCommands; }
            set { _AboutCommands = value; }
        }

        private Command _SlideStartControl;
        /// <summary>
        /// Toggles start control visibility.
        /// </summary>
        public Command ToggleStartControl
        {
            get { return _SlideStartControl; }
            set { _SlideStartControl = value; }
        }

        private Command _ChangeMetroTheme;
        /// <summary>
        /// Changes the Metro theme.
        /// </summary>
        public Command ChangeMetroTheme
        {
            get { return _ChangeMetroTheme; }
            set { _ChangeMetroTheme = value; }
        }

        
    }

    public class THCommands
    {
        private Command _New;
        public Command New
        {
            get { return _New; }
            set { _New = value; }
        }

        private Command _Cancel;
        public Command Cancel
        {
            get { return _Cancel; }
            set { _Cancel = value; }
        }
    }
}
