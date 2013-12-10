using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using System.Diagnostics;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Metro.ColorTables;

namespace QLHPHP
{
    public partial class FormQL : MetroAppForm
    {
        StartControl _StartControl = null; // Start control displayed on startup
        AppCommands _Commands = null; // All application commands
        public FormQL()
        {
            InitializeComponent();
            

            // Prepare commands
            _Commands = new AppCommands();

            _Commands.ToggleStartControl = new Command(components);
            _Commands.ToggleStartControl.Executed += new EventHandler(ToggleStartControlExecuted);

            // Danhsachsinhvien related commands
            _Commands.DanhSachSVCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.DanhSachSVCommands.New.Executed += NewDanhSachSVControl;
            _Commands.DanhSachSVCommands.Cancel = new Command(components);
            _Commands.DanhSachSVCommands.Cancel.Executed += CancelDanhSachSV;

            // NhapSinhVien related commands
            _Commands.NhapSinhVienCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.NhapSinhVienCommands.New.Executed += NewNhapSinhVien;
            _Commands.NhapSinhVienCommands.Cancel = new Command(components);
            _Commands.NhapSinhVienCommands.Cancel.Executed += CancelNhapSinhVien;
           
            // KhoaNganhControl related commands
            _Commands.KhoaNganhCommands.New = new Command(components);
            _Commands.KhoaNganhCommands.New.Executed += NewKhoaNganhControl;
            _Commands.KhoaNganhCommands.Cancel = new Command(components);
            _Commands.KhoaNganhCommands.Cancel.Executed += CancelKhoaNganhControl;

            // QuanLyMonHocControl related commands
            _Commands.QuanLyMonHocCommands.New = new Command(components);
            _Commands.QuanLyMonHocCommands.New.Executed += NewQuanLyMonHocControl;
            _Commands.QuanLyMonHocCommands.Cancel = new Command(components);
            _Commands.QuanLyMonHocCommands.Cancel.Executed += CancelQuanLyMonHocControl;

            // DangKyMonHocControl related commands
            _Commands.DangKyMonHocCommands.New = new Command(components);
            _Commands.DangKyMonHocCommands.New.Executed += NewDangKyMonHocControl;
            _Commands.DangKyMonHocCommands.Cancel = new Command(components);
            _Commands.DangKyMonHocCommands.Cancel.Executed += CancelDangKyMonHocControl;

            // ChiTietDangKy related commands
            _Commands.ChiTietDangKyCommands.New = new Command(components);
            _Commands.ChiTietDangKyCommands.New.Executed += NewChiTietDangKyControl;
            _Commands.ChiTietDangKyCommands.Cancel = new Command(components);
            _Commands.ChiTietDangKyCommands.Cancel.Executed += CancelChiTietDangKyControl;

            // ThemKhoa related commands
            _Commands.ThemKhoaCommands.New = new Command(components);
            _Commands.ThemKhoaCommands.New.Executed += NewThemKhoaControl;
            _Commands.ThemKhoaCommands.Cancel = new Command(components);
            _Commands.ThemKhoaCommands.Cancel.Executed += CancelThemKhoaControl;

            // ThemNganh related commands
            _Commands.ThemNganhCommands.New = new Command(components);
            _Commands.ThemNganhCommands.New.Executed += NewThemNganhControl;
            _Commands.ThemNganhCommands.Cancel = new Command(components);
            _Commands.ThemNganhCommands.Cancel.Executed += CancelThemNganhControl;

            // ChiTietNganh related commands
            _Commands.ChiTietNganhCommands.New = new Command(components);
            _Commands.ChiTietNganhCommands.New.Executed += NewChiTietNganhControl;
            _Commands.ChiTietNganhCommands.Cancel = new Command(components);
            _Commands.ChiTietNganhCommands.Cancel.Executed += CancelChiTietNganhControl;
            // QuyDinh related commands
            _Commands.QuyDinhCommands.New = new Command(components);
            _Commands.QuyDinhCommands.New.Executed += NewQuyDinhControl;
            _Commands.QuyDinhCommands.Cancel = new Command(components);
            _Commands.QuyDinhCommands.Cancel.Executed += CancelQuyDinhControl;

            // TimKiem related commands
            _Commands.TimKiemCommands.New = new Command(components);
            _Commands.TimKiemCommands.New.Executed += NewTimKiemControl;
            _Commands.TimKiemCommands.Cancel = new Command(components);
            _Commands.TimKiemCommands.Cancel.Executed += CancelTimKiemControl;

            // CapNhapThongTin related commands
            _Commands.CapNhapThongTinCommands.New = new Command(components);
            _Commands.CapNhapThongTinCommands.New.Executed += NewCapNhapThongTinControl;
            _Commands.CapNhapThongTinCommands.Cancel = new Command(components);
            _Commands.CapNhapThongTinCommands.Cancel.Executed += CancelCapNhapThongTinControl;

            // MonHocTichLuy related commands
            _Commands.MonHocTichLuyCommands.New = new Command(components);
            _Commands.MonHocTichLuyCommands.New.Executed += NewMonHocTichLuyControl;
            _Commands.MonHocTichLuyCommands.Cancel = new Command(components);
            _Commands.MonHocTichLuyCommands.Cancel.Executed += CancelMonHocTichLuyControl;

            // HocPhi related commands
            _Commands.HocPhiCommands.New = new Command(components);
            _Commands.HocPhiCommands.New.Executed += NewHocPhiControl;
            _Commands.HocPhiCommands.Cancel = new Command(components);
            _Commands.HocPhiCommands.Cancel.Executed += CancelHocPhiControl;

            // DSDaDongHocPhi related commands
            _Commands.DSDaDongHocPhiCommands.New = new Command(components);
            _Commands.DSDaDongHocPhiCommands.New.Executed += NewDSDaDongHocPhiControl;
            _Commands.DSDaDongHocPhiCommands.Cancel = new Command(components);
            _Commands.DSDaDongHocPhiCommands.Cancel.Executed += CancelDSDaDongHocPhiControl;

            // LapPhieuThu related commmands
            _Commands.LapPhieuThuCommands.New = new Command(components);
            _Commands.LapPhieuThuCommands.New.Executed += NewLapPhieuThuControl;
            _Commands.LapPhieuThuCommands.Cancel = new Command(components);
            _Commands.LapPhieuThuCommands.Cancel.Executed += CancelLapPhieuThuControl;

            // Report related commands
            _Commands.ReportComands.New = new Command(components);
            _Commands.ReportComands.New.Executed += NewReportControl;
            _Commands.ReportComands.Cancel = new Command(components);
            _Commands.ReportComands.Cancel.Executed += CancelReportControl;

            // About related commands
            _Commands.AboutCommands.New = new Command(components);
            _Commands.AboutCommands.New.Executed += NewAboutControl;
            _Commands.AboutCommands.Cancel = new Command(components);
            _Commands.AboutCommands.Cancel.Executed += CancelAboutControl;

            this.SuspendLayout();
            _StartControl = new StartControl();
            _StartControl.Commands = _Commands;
            this.Controls.Add(_StartControl);
            _StartControl.BringToFront();
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            //_StartControl.Click += new EventHandler(StartControl_Click);
            this.ResumeLayout(false);

            // Add metro color themes
            MetroColorGeneratorParameters[] metroThemes = MetroColorGeneratorParameters.GetAllPredefinedThemes();
            foreach (MetroColorGeneratorParameters mt in metroThemes)
            {
                ButtonItem theme = new ButtonItem(mt.ThemeName, mt.ThemeName);
                theme.Command = _Commands.ChangeMetroTheme;
                theme.CommandParameter = mt;
                //colorThemeButton.SubItems.Add(theme);
            }

            
        }

        #region Command Execution   

        private void ChangeMetroThemeExecuted(object sender, EventArgs e)
        {
            ICommandSource source = (ICommandSource)sender;
            MetroColorGeneratorParameters theme = (MetroColorGeneratorParameters)source.CommandParameter;
            StyleManager.MetroColorGeneratorParameters = theme;
        }

        private void ToggleStartControlExecuted(object sender, EventArgs e)
        {
            _StartControl.IsOpen = !_StartControl.IsOpen;
        }

        DanhSachSVControl _DanhSachSVControl = null;
        void NewDanhSachSVControl(object sender, EventArgs e)
        {
            Debug.Assert(_DanhSachSVControl == null);
            _Commands.DanhSachSVCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            _DanhSachSVControl = new DanhSachSVControl();
            _DanhSachSVControl.Commands = _Commands;
            this.ShowModalPanel(_DanhSachSVControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelDanhSachSV(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            Debug.Assert(_DanhSachSVControl != null);
            CloseDanhSachSV();
        }
        private void CloseDanhSachSV()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;
            
            _Commands.DanhSachSVCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(_DanhSachSVControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _DanhSachSVControl.Commands = null;
            _DanhSachSVControl.Dispose();
            _DanhSachSVControl = null;
        }
        
        NhapSinhVienControl _NhapSinhVien = null;
        void NewNhapSinhVien(object sender, EventArgs e)
        {
            Debug.Assert(_NhapSinhVien == null);
            _Commands.NhapSinhVienCommands.New.Enabled = false; // Disable new invoice command to prevent re-entrancy
            _NhapSinhVien = new NhapSinhVienControl();
            _NhapSinhVien.Commands = _Commands;
            this.ShowModalPanel(_NhapSinhVien, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelNhapSinhVien(object sender, EventArgs e)
        {
            // Simply close nhapsinhvien entry form "dialog"
            Debug.Assert(_NhapSinhVien != null);
            CloseNhapSinhVien();
        }
        private void CloseNhapSinhVien()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;
            
            _Commands.NhapSinhVienCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_NhapSinhVien, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _NhapSinhVien.Commands = null;
            _NhapSinhVien.Dispose();
            _NhapSinhVien = null;
        }
      
        KhoaNganhControl _KhoaNganhControl = null;
        void NewKhoaNganhControl(object sender, EventArgs e)
        {
            Debug.Assert(_KhoaNganhControl == null);
            _Commands.KhoaNganhCommands.New.Enabled = false;
            _KhoaNganhControl = new KhoaNganhControl();
            _KhoaNganhControl.Commands = _Commands;
            this.ShowModalPanel(_KhoaNganhControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
         }
        private void CancelKhoaNganhControl(object sender, EventArgs e)
        {
            // Simply close nhapsinhvien entry form "dialog"
            Debug.Assert(_KhoaNganhControl != null);
            CloseKhoaNganhControl();
        }
        private void CloseKhoaNganhControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.KhoaNganhCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_KhoaNganhControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _KhoaNganhControl.Commands = null;
            _KhoaNganhControl.Dispose();
            _KhoaNganhControl = null;
        }

        QuanLyMonHocControl _QuanLyMonHocControl = null;
        void NewQuanLyMonHocControl(object sender, EventArgs e)
        {
            Debug.Assert(_KhoaNganhControl == null);
            _Commands.QuanLyMonHocCommands.New.Enabled = false;
            _QuanLyMonHocControl = new QuanLyMonHocControl();
            _QuanLyMonHocControl.Commands = _Commands;
            this.ShowModalPanel(_QuanLyMonHocControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelQuanLyMonHocControl(object sender, EventArgs e)
        {
            // Simply close nhapsinhvien entry form "dialog"
            Debug.Assert(_QuanLyMonHocControl != null);
            CloseQuanLyMonHocControl();
        }
        private void CloseQuanLyMonHocControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.QuanLyMonHocCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_QuanLyMonHocControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _QuanLyMonHocControl.Commands = null;
            _QuanLyMonHocControl.Dispose();
            _QuanLyMonHocControl = null;
        }

        DangKyMonHocControl _DangKyMonHocControl = null;
        void NewDangKyMonHocControl(object sender, EventArgs e)
        {
            Debug.Assert(_DangKyMonHocControl == null);
            _Commands.DangKyMonHocCommands.New.Enabled = false;
            _DangKyMonHocControl = new DangKyMonHocControl();
            _DangKyMonHocControl.Commands = _Commands;
            this.ShowModalPanel(_DangKyMonHocControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelDangKyMonHocControl(object sender, EventArgs e)
        {
            // Simply close nhapsinhvien entry form "dialog"
            Debug.Assert(_DangKyMonHocControl != null);
            CloseDangKyMonHocControl();
        }
        private void CloseDangKyMonHocControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.DangKyMonHocCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_DangKyMonHocControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _DangKyMonHocControl.Commands = null;
            _DangKyMonHocControl.Dispose();
            _DangKyMonHocControl = null;
        }

        ChiTietDangKyControl _ChiTietDangKyControl = null;
        void NewChiTietDangKyControl(object sender, EventArgs e)
        {
            Debug.Assert(_ChiTietDangKyControl == null);
            _Commands.ChiTietDangKyCommands.New.Enabled = false;
            _ChiTietDangKyControl = new ChiTietDangKyControl();
            _ChiTietDangKyControl.Commands = _Commands;
            this.ShowModalPanel(_ChiTietDangKyControl, DevComponents.DotNetBar.Controls.eSlideSide.Top);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelChiTietDangKyControl(object sender, EventArgs e)
        {
            Debug.Assert(_ChiTietDangKyControl != null);
            CloseChiTietDangKyControl();
        }
        private void CloseChiTietDangKyControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ChiTietDangKyCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_ChiTietDangKyControl, DevComponents.DotNetBar.Controls.eSlideSide.Top);
            _ChiTietDangKyControl.Commands = null;
            _ChiTietDangKyControl.Dispose();
            _ChiTietDangKyControl = null;
        }
        ThemKhoaControl _ThemKhoaControl = null;
        void NewThemKhoaControl(object sender, EventArgs e)
        {
            Debug.Assert(_ThemKhoaControl == null);
            _Commands.ThemKhoaCommands.New.Enabled = false;
            _ThemKhoaControl = new ThemKhoaControl();
            _ThemKhoaControl.Commands = _Commands;
            this.ShowModalPanel(_ThemKhoaControl, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;  
        }
        private void CancelThemKhoaControl(object sender, EventArgs e)
        {
            Debug.Assert(_ThemKhoaControl != null);
            CloseThemKhoaControl();
        }
        private void CloseThemKhoaControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ThemKhoaCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_ThemKhoaControl, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            _ThemKhoaControl.Commands = null;
            _ThemKhoaControl.Dispose();
            _ThemKhoaControl = null;
        }

        ThemNganhControl _ThemNganhControl = null;
        void NewThemNganhControl(object sender, EventArgs e)
        {
            Debug.Assert(_ThemNganhControl == null);
            _Commands.ThemNganhCommands.New.Enabled = false;
            _ThemNganhControl = new ThemNganhControl();
            _ThemNganhControl.Commands = _Commands;
            this.ShowModalPanel(_ThemNganhControl, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelThemNganhControl(object sender, EventArgs e)
        {
            Debug.Assert(_ThemNganhControl != null);
            CloseThemNganhControl();
        }
        private void CloseThemNganhControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ThemNganhCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_ThemNganhControl, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            _ThemNganhControl.Commands = null;
            _ThemNganhControl.Dispose();
            _ThemNganhControl = null;
        }

        ChiTietNganhControl _ChiTietNganhControl = null;
        void NewChiTietNganhControl(object sender, EventArgs e)
        {
            Debug.Assert(_ChiTietNganhControl == null);
            _Commands.ChiTietNganhCommands.New.Enabled = false;
            _ChiTietNganhControl = new ChiTietNganhControl();
            _ChiTietNganhControl.Commands = _Commands;
            this.ShowModalPanel(_ChiTietNganhControl, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelChiTietNganhControl(object sender, EventArgs e)
        {
            Debug.Assert(_ChiTietNganhControl != null);
            CloseChiTietNganhControl();
        }
        private void CloseChiTietNganhControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ChiTietNganhCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_ChiTietNganhControl, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            _ChiTietNganhControl.Commands = null;
            _ChiTietNganhControl.Dispose();
            _ChiTietNganhControl = null;
        }
        QuyDinhControl _QuyDinhControl = null;
        void NewQuyDinhControl(object sender, EventArgs e)
        {
            Debug.Assert(_QuyDinhControl == null);
            _Commands.QuyDinhCommands.New.Enabled = false;
            _QuyDinhControl = new QuyDinhControl();
            _QuyDinhControl.Commands = _Commands;
            this.ShowModalPanel(_QuyDinhControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelQuyDinhControl(object sender, EventArgs e)
        {
            Debug.Assert(_QuyDinhControl != null);
            CloseQuyDinhControl();  
        }
        private void CloseQuyDinhControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.QuyDinhCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_QuyDinhControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _QuyDinhControl.Commands = null;
            _QuyDinhControl.Dispose();
            _QuyDinhControl = null;
        }

        TimKiemControl _TimKiemControl = null;
        void NewTimKiemControl(object sender, EventArgs e)
        {
            Debug.Assert(_TimKiemControl == null);
            _Commands.TimKiemCommands.New.Enabled = false;
            _TimKiemControl = new TimKiemControl();
            _TimKiemControl.Commands = _Commands;
            this.ShowModalPanel(_TimKiemControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelTimKiemControl(object sender, EventArgs e)
        {
            Debug.Assert(_TimKiemControl != null);
            CloseTimKiemControl(); 
        }
        private void CloseTimKiemControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.TimKiemCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_TimKiemControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _TimKiemControl.Commands = null;
            _TimKiemControl.Dispose();
            _TimKiemControl = null;
        }

        CapNhapThongTinControl _CapNhapThongTinControl = null;
        void NewCapNhapThongTinControl(object sender, EventArgs e)
        {
            Debug.Assert(_CapNhapThongTinControl == null);
            _Commands.CapNhapThongTinCommands.New.Enabled = false;
            _CapNhapThongTinControl = new CapNhapThongTinControl();
            _CapNhapThongTinControl.Commands = _Commands;
            this.ShowModalPanel(_CapNhapThongTinControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelCapNhapThongTinControl(object sender, EventArgs e)
        {
            Debug.Assert(_CapNhapThongTinControl != null);
            CloseCapNhapThongTinControl(); 
        }
        private void CloseCapNhapThongTinControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.CapNhapThongTinCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_CapNhapThongTinControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _CapNhapThongTinControl.Commands = null;
            _CapNhapThongTinControl.Dispose();
            _CapNhapThongTinControl = null;
        }

        MonHocTichLuyControl _MonHocTichLuyControl = null;
        void NewMonHocTichLuyControl(object sender, EventArgs e)
        {
            Debug.Assert(_MonHocTichLuyControl == null);
            _Commands.MonHocTichLuyCommands.New.Enabled = false;
            _MonHocTichLuyControl = new MonHocTichLuyControl();
            _MonHocTichLuyControl.Commands = _Commands;
            this.ShowModalPanel(_MonHocTichLuyControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelMonHocTichLuyControl(object sender, EventArgs e)
        {
            Debug.Assert(_MonHocTichLuyControl != null);
            CloseMonHocTichLuyControl(); 
        }
        private void CloseMonHocTichLuyControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.MonHocTichLuyCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_MonHocTichLuyControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _MonHocTichLuyControl.Commands = null;
            _MonHocTichLuyControl.Dispose();
            _MonHocTichLuyControl = null;
        }

        HocPhiControl _HocPhiControl = null;
        void NewHocPhiControl(object sender, EventArgs e)
        {
            Debug.Assert(_HocPhiControl == null);
            _Commands.HocPhiCommands.New.Enabled = false;
            _HocPhiControl = new HocPhiControl();
            _HocPhiControl.Commands = _Commands;
            this.ShowModalPanel(_HocPhiControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelHocPhiControl(object sender, EventArgs e)
        {
            Debug.Assert(_HocPhiControl != null);
            CloseHocPhiControl();
        }
        private void CloseHocPhiControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.HocPhiCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_HocPhiControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _HocPhiControl.Commands = null;
            _HocPhiControl.Dispose();
            _HocPhiControl = null;
        }

        DSDaDongHocPhiControl _DSDaDongHocPhiControl = null;
        void NewDSDaDongHocPhiControl(object sender, EventArgs e)
        {
            Debug.Assert(_DSDaDongHocPhiControl == null);
            _Commands.DSDaDongHocPhiCommands.New.Enabled = false;
            _DSDaDongHocPhiControl = new DSDaDongHocPhiControl();
            _DSDaDongHocPhiControl.Commands = _Commands;
            this.ShowModalPanel(_DSDaDongHocPhiControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelDSDaDongHocPhiControl(object sender, EventArgs e)
        {
            Debug.Assert(_DSDaDongHocPhiControl != null);
            CloseDSDaDongHocPhiControl();
        }
        private void CloseDSDaDongHocPhiControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.DSDaDongHocPhiCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_DSDaDongHocPhiControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _DSDaDongHocPhiControl.Commands = null;
            _DSDaDongHocPhiControl.Dispose();
            _DSDaDongHocPhiControl = null;
        }

        LapPhieuThuControl _LapPhieuThuControl = null;
        void NewLapPhieuThuControl(object sender, EventArgs e)
        {
            Debug.Assert(_LapPhieuThuControl == null);
            _Commands.LapPhieuThuCommands.New.Enabled = false;
            _LapPhieuThuControl = new LapPhieuThuControl();
            _LapPhieuThuControl.Commands = _Commands;
            this.ShowModalPanel(_LapPhieuThuControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelLapPhieuThuControl(object sender, EventArgs e)
        {
            Debug.Assert(_LapPhieuThuControl != null);
            CloseLapPhieuThuControl();
        }
        private void CloseLapPhieuThuControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.LapPhieuThuCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_LapPhieuThuControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            _LapPhieuThuControl.Commands = null;
            _LapPhieuThuControl.Dispose();
            _LapPhieuThuControl = null;
        }

        ReportControl _ReportControl = null;
        void NewReportControl(object sender, EventArgs e)
        {
            Debug.Assert(_ReportControl == null);
            _Commands.ReportComands.New.Enabled = false;
            _ReportControl = new ReportControl();
            _ReportControl.Commands = _Commands;
            this.ShowModalPanel(_ReportControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelReportControl(object sender, EventArgs e)
        {
            Debug.Assert(_ReportControl != null);
            CloseReportControl();
        }
        private void CloseReportControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ReportComands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_ReportControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            _ReportControl.Commands = null;
            _ReportControl.Dispose();
            _ReportControl = null;
        }

        AboutControl _AboutControl = null;
        void NewAboutControl(object sender, EventArgs e)
        {
            Debug.Assert(_AboutControl == null);
            _Commands.AboutCommands.New.Enabled = false;
            _AboutControl = new AboutControl();
            _AboutControl.Commands = _Commands;
            this.ShowModalPanel(_AboutControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelAboutControl(object sender, EventArgs e)
        {
            Debug.Assert(_AboutControl != null);
            CloseAboutControl();
        }
        private void CloseAboutControl()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.AboutCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_AboutControl, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            _AboutControl.Commands = null;
            _AboutControl.Dispose();
            _AboutControl = null;
        }

        #endregion

        #region UI Code
        void StartControl_Click(object sender, EventArgs e)
        {
            _StartControl.IsOpen = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnLoad(e);
        }

        private Rectangle GetStartControlBounds()
        {
            int captionHeight = metroShell1.MetroTabStrip.GetCaptionHeight() + 2;
            Thickness borderThickness = this.GetBorderThickness();
            return new Rectangle((int)borderThickness.Left, captionHeight, this.Width - (int)borderThickness.Horizontal, this.Height - captionHeight - 1);
        }
        private void UpdateControlsSizeAndLocation()
        {
            if (_StartControl != null)
            {
                if (!_StartControl.IsOpen)
                    _StartControl.OpenBounds = GetStartControlBounds();
                else
                    _StartControl.Bounds = GetStartControlBounds();
                if (!IsModalPanelDisplayed)
                    _StartControl.BringToFront();
            }
            //metroToolbar1.Location = new Point((this.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1);
            //metroToolbar2.Location = new Point((this.Width - metroToolbar2.Width) / 2, metroToolbar2.Parent.Height - metroToolbar2.Height - 1);
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnResize(e);
        }

        private void metroAppButton1_ExpandChange(object sender, EventArgs e)
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = !metroAppButton1.Expanded;
        }

        private void metroShell1_SettingsButtonClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "MetroShell Settings Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroShell1_HelpButtonClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "MetroShell Help Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroShell1_SelectedTabChanged(object sender, EventArgs e)
        {
            UpdateControlsSizeAndLocation();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

       

    }
}