using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLHPHP
{
    
    public partial class StartControl : DevComponents.DotNetBar.Controls.SlidePanel
    {
        
        public StartControl()
        {
            InitializeComponent();

            // Add self-updating chart to the sales tile
            MicroChartItem chart = new MicroChartItem();
            chart.ChartType = eMicroChartType.Column;
            chart.ChartWidth = QuanLyMonHoc.TileSize.Width - 26;
            chart.ChartHeight = QuanLyMonHoc.TileSize.Height - 30;
            chart.DataPoints = GetRandomDataPoints(false, 12);
            chart.TooltipValueFormatString = "C"; // Currency format for tooltips
            chart.ColumnChartStyle.PositiveBarColor = Color.White;
        }

        protected override void OnResize(EventArgs e)
        {
            // Center the panel
            itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, ((this.Height - labelX1.Height - 16) - itemPanel1.Height) / 2 + labelX1.Height + 16);
            base.OnResize(e);
        }

        private AppCommands _Commands;
        /// <summary>
        /// Gets or sets the commands associated with the control.
        /// </summary>
        public AppCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    AppCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        /// <summary>
        /// Called when Commands property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnCommandsChanged(AppCommands oldValue, AppCommands newValue)
        {
            if (newValue != null)
            {
                NhapSinhVien.Command = newValue.NhapSinhVienCommands.New;
                DanhSachSinhVien.Command = newValue.DanhSachSVCommands.New;
                QuanLyMonHoc.Command = newValue.QuanLyMonHocCommands.New;
                DangKyMonHoc.Command = newValue.DangKyMonHocCommands.New;
                //BaoCaoThongKe.Command = newValue.ToggleStartControl;
                BaoCaoThongKe.Command = newValue.ReportComands.New;
                HocPhi.Command = newValue.HocPhiCommands.New;
                CapNhapThongTin.Command = newValue.CapNhapThongTinCommands.New;
                TimKiem.Command = newValue.TimKiemCommands.New;
                ThongTinKhoaNganh.Command = newValue.KhoaNganhCommands.New;
                ThayDoiQuyDinh.Command = newValue.QuyDinhCommands.New;
                TroGiup.Command = newValue.AboutCommands.New;
                ThôngTin.Command = newValue.AboutCommands.New;
            }
            else
            {
                DanhSachSinhVien.Command = null;
                NhapSinhVien.Command = null;
                QuanLyMonHoc.Command = null;
                BaoCaoThongKe.Command = null;
                HocPhi.Command = null;
                DangKyMonHoc.Command = null;
                TimKiem.Command = null;
                ThongTinKhoaNganh.Command = null;
                ThayDoiQuyDinh.Command = null;
                CapNhapThongTin.Command = null;
                TroGiup.Command = null;
                ThôngTin.Command = null;
                
            }
        }

        private List<double> GetRandomDataPoints(bool allowNegative, int pointsToCreate)
        {
            List<double> points = new List<double>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Random rnd2 = new Random();

            for (int i = 0; i < pointsToCreate; i++)
            {
                points.Add(allowNegative ? ((rnd2.Next(500) > 250 ? 1 : -1) * rnd.Next(1000)) : rnd.Next(1000));
            }

            return points;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DongHo.Text = DateTime.Now.ToString();
            
        }

        private void StartControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void NhapSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void DangKyMonHoc_Click(object sender, EventArgs e)
        {

        }
    }
}
