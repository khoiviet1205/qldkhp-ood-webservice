namespace QLHPHP
{
    partial class StartControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.NhapSinhVien = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.DanhSachSinhVien = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.QuanLyMonHoc = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.DangKyMonHoc = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.TimKiem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ThongTinKhoaNganh = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ThayDoiQuyDinh = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.HocPhi = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.BaoCaoThongKe = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.CapNhapThongTin = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.TroGiup = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ThôngTin = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.DongHo = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelX1.Location = new System.Drawing.Point(90, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(647, 40);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Quản Lý Đăng Ký Học Phần Và Học Phí";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // itemPanel1
            // 
            this.itemPanel1.AutoScroll = true;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.itemPanel1.Location = new System.Drawing.Point(3, 61);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(773, 295);
            this.itemPanel1.TabIndex = 3;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 6;
            this.itemContainer1.MinimumSize = new System.Drawing.Size(750, 290);
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ResizeItemsToFit = false;
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.NhapSinhVien,
            this.DanhSachSinhVien,
            this.QuanLyMonHoc,
            this.DangKyMonHoc,
            this.TimKiem,
            this.ThongTinKhoaNganh,
            this.ThayDoiQuyDinh,
            this.HocPhi,
            this.BaoCaoThongKe,
            this.CapNhapThongTin,
            this.TroGiup,
            this.ThôngTin});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // NhapSinhVien
            // 
            this.NhapSinhVien.Image = global::QLHPHP.Properties.Resources.Invoice;
            this.NhapSinhVien.Name = "NhapSinhVien";
            this.NhapSinhVien.SymbolColor = System.Drawing.Color.Empty;
            this.NhapSinhVien.Text = "<font size=\"+4\">Nhập<br/>Sinh Viên</font>";
            this.NhapSinhVien.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.NhapSinhVien.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.NhapSinhVien.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.NhapSinhVien.TileStyle.BackColorGradientAngle = 45;
            this.NhapSinhVien.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NhapSinhVien.TileStyle.PaddingBottom = 4;
            this.NhapSinhVien.TileStyle.PaddingLeft = 4;
            this.NhapSinhVien.TileStyle.PaddingRight = 4;
            this.NhapSinhVien.TileStyle.PaddingTop = 4;
            this.NhapSinhVien.TileStyle.TextColor = System.Drawing.Color.White;
            this.NhapSinhVien.Click += new System.EventHandler(this.NhapSinhVien_Click);
            // 
            // DanhSachSinhVien
            // 
            this.DanhSachSinhVien.Image = global::QLHPHP.Properties.Resources.contact;
            this.DanhSachSinhVien.Name = "DanhSachSinhVien";
            this.DanhSachSinhVien.SymbolColor = System.Drawing.Color.Empty;
            this.DanhSachSinhVien.Text = "<font size=\"+4\">Danh Sách<br/>Sinh Viên</font>";
            this.DanhSachSinhVien.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.DanhSachSinhVien.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(42)))));
            this.DanhSachSinhVien.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(177)))), ((int)(((byte)(51)))));
            this.DanhSachSinhVien.TileStyle.BackColorGradientAngle = 45;
            this.DanhSachSinhVien.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DanhSachSinhVien.TileStyle.PaddingBottom = 4;
            this.DanhSachSinhVien.TileStyle.PaddingLeft = 4;
            this.DanhSachSinhVien.TileStyle.PaddingRight = 4;
            this.DanhSachSinhVien.TileStyle.PaddingTop = 4;
            this.DanhSachSinhVien.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // QuanLyMonHoc
            // 
            this.QuanLyMonHoc.Image = global::QLHPHP.Properties.Resources.TableReportt;
            this.QuanLyMonHoc.Name = "QuanLyMonHoc";
            this.QuanLyMonHoc.SymbolColor = System.Drawing.Color.Empty;
            this.QuanLyMonHoc.Text = "<font size=\"+4\">Quản Lý<br/>Môn Học</font>";
            this.QuanLyMonHoc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.QuanLyMonHoc.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // DangKyMonHoc
            // 
            this.DangKyMonHoc.Image = global::QLHPHP.Properties.Resources.Details;
            this.DangKyMonHoc.Name = "DangKyMonHoc";
            this.DangKyMonHoc.SymbolColor = System.Drawing.Color.Empty;
            this.DangKyMonHoc.Text = "<font size=\"+4\">Quản Lý<br/>ĐK Học Phần</font>";
            this.DangKyMonHoc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.DangKyMonHoc.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.DangKyMonHoc.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.DangKyMonHoc.TileStyle.BackColorGradientAngle = 45;
            this.DangKyMonHoc.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DangKyMonHoc.TileStyle.PaddingBottom = 4;
            this.DangKyMonHoc.TileStyle.PaddingLeft = 4;
            this.DangKyMonHoc.TileStyle.PaddingRight = 4;
            this.DangKyMonHoc.TileStyle.PaddingTop = 4;
            this.DangKyMonHoc.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // TimKiem
            // 
            this.TimKiem.Image = global::QLHPHP.Properties.Resources.Web;
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.SymbolColor = System.Drawing.Color.Empty;
            this.TimKiem.Text = "<font size=\"+4\">Tìm Kiếm</font>";
            this.TimKiem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            // 
            // 
            // 
            this.TimKiem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.TimKiem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            this.TimKiem.TileStyle.BackColorGradientAngle = 45;
            this.TimKiem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TimKiem.TileStyle.PaddingBottom = 4;
            this.TimKiem.TileStyle.PaddingLeft = 4;
            this.TimKiem.TileStyle.PaddingRight = 4;
            this.TimKiem.TileStyle.PaddingTop = 4;
            this.TimKiem.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // ThongTinKhoaNganh
            // 
            this.ThongTinKhoaNganh.Image = global::QLHPHP.Properties.Resources.TableReportt;
            this.ThongTinKhoaNganh.Name = "ThongTinKhoaNganh";
            this.ThongTinKhoaNganh.SymbolColor = System.Drawing.Color.Empty;
            this.ThongTinKhoaNganh.Text = "<font size=\"+4\">Thông Tin<br/>Khoa-Ngành</font>";
            this.ThongTinKhoaNganh.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.ThongTinKhoaNganh.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.ThongTinKhoaNganh.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.ThongTinKhoaNganh.TileStyle.BackColorGradientAngle = 45;
            this.ThongTinKhoaNganh.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ThongTinKhoaNganh.TileStyle.PaddingBottom = 4;
            this.ThongTinKhoaNganh.TileStyle.PaddingLeft = 4;
            this.ThongTinKhoaNganh.TileStyle.PaddingRight = 4;
            this.ThongTinKhoaNganh.TileStyle.PaddingTop = 4;
            this.ThongTinKhoaNganh.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // ThayDoiQuyDinh
            // 
            this.ThayDoiQuyDinh.Image = global::QLHPHP.Properties.Resources.Help;
            this.ThayDoiQuyDinh.Name = "ThayDoiQuyDinh";
            this.ThayDoiQuyDinh.SymbolColor = System.Drawing.Color.Empty;
            this.ThayDoiQuyDinh.Text = "<font size=\"+4\">Thay Đổi<br/>Quy Định</font>";
            this.ThayDoiQuyDinh.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.ThayDoiQuyDinh.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(102)))), ((int)(((byte)(168)))));
            this.ThayDoiQuyDinh.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.ThayDoiQuyDinh.TileStyle.BackColorGradientAngle = 45;
            this.ThayDoiQuyDinh.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ThayDoiQuyDinh.TileStyle.PaddingBottom = 4;
            this.ThayDoiQuyDinh.TileStyle.PaddingLeft = 4;
            this.ThayDoiQuyDinh.TileStyle.PaddingRight = 4;
            this.ThayDoiQuyDinh.TileStyle.PaddingTop = 4;
            this.ThayDoiQuyDinh.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // HocPhi
            // 
            this.HocPhi.Image = global::QLHPHP.Properties.Resources.Unpaid;
            this.HocPhi.Name = "HocPhi";
            this.HocPhi.SymbolColor = System.Drawing.Color.Empty;
            this.HocPhi.Text = "<font size=\"+4\">Học Phí</font>";
            this.HocPhi.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.HocPhi.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.HocPhi.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.HocPhi.TileStyle.BackColorGradientAngle = 45;
            this.HocPhi.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HocPhi.TileStyle.PaddingBottom = 4;
            this.HocPhi.TileStyle.PaddingLeft = 4;
            this.HocPhi.TileStyle.PaddingRight = 4;
            this.HocPhi.TileStyle.PaddingTop = 4;
            this.HocPhi.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // BaoCaoThongKe
            // 
            this.BaoCaoThongKe.Image = global::QLHPHP.Properties.Resources.Charts;
            this.BaoCaoThongKe.Name = "BaoCaoThongKe";
            this.BaoCaoThongKe.SymbolColor = System.Drawing.Color.Empty;
            this.BaoCaoThongKe.Text = "<font size=\"+4\">Báo Cáo<br/>Thống Kê</font>";
            this.BaoCaoThongKe.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed;
            // 
            // 
            // 
            this.BaoCaoThongKe.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.BaoCaoThongKe.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.BaoCaoThongKe.TileStyle.BackColorGradientAngle = 45;
            this.BaoCaoThongKe.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BaoCaoThongKe.TileStyle.PaddingBottom = 4;
            this.BaoCaoThongKe.TileStyle.PaddingLeft = 4;
            this.BaoCaoThongKe.TileStyle.PaddingRight = 4;
            this.BaoCaoThongKe.TileStyle.PaddingTop = 4;
            this.BaoCaoThongKe.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // CapNhapThongTin
            // 
            this.CapNhapThongTin.Image = global::QLHPHP.Properties.Resources.Web;
            this.CapNhapThongTin.Name = "CapNhapThongTin";
            this.CapNhapThongTin.SymbolColor = System.Drawing.Color.Empty;
            this.CapNhapThongTin.Text = "<font size=\"+4\">Cập Nhập Thông Tin </font>";
            this.CapNhapThongTin.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.CapNhapThongTin.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // TroGiup
            // 
            this.TroGiup.Image = global::QLHPHP.Properties.Resources.messanger;
            this.TroGiup.Name = "TroGiup";
            this.TroGiup.SymbolColor = System.Drawing.Color.Empty;
            this.TroGiup.Text = "<font size=\"+4\">Trợ Giúp</font>";
            this.TroGiup.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.TroGiup.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ThôngTin
            // 
            this.ThôngTin.Image = global::QLHPHP.Properties.Resources.contact;
            this.ThôngTin.Name = "ThôngTin";
            this.ThôngTin.SymbolColor = System.Drawing.Color.Empty;
            this.ThôngTin.Text = "<font size=\"+4\">Thông Tin Tác Giả</font>";
            this.ThôngTin.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            // 
            // 
            // 
            this.ThôngTin.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(743, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 47);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "<div align=\"right\"><font size=\"+4\">Viet</font><br/>Quan Tri</div>";
            // 
            // DongHo
            // 
            this.DongHo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DongHo.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.DongHo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DongHo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DongHo.Location = new System.Drawing.Point(696, 60);
            this.DongHo.Name = "DongHo";
            this.DongHo.Size = new System.Drawing.Size(165, 23);
            this.DongHo.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::QLHPHP.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(811, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // StartControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DongHo);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.itemPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StartControl";
            this.Size = new System.Drawing.Size(861, 418);
            this.Load += new System.EventHandler(this.StartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem NhapSinhVien;
        private DevComponents.DotNetBar.Metro.MetroTileItem DanhSachSinhVien;
        private DevComponents.DotNetBar.Metro.MetroTileItem DangKyMonHoc;
        private DevComponents.DotNetBar.Metro.MetroTileItem TimKiem;
        private DevComponents.DotNetBar.Metro.MetroTileItem ThongTinKhoaNganh;
        private DevComponents.DotNetBar.Metro.MetroTileItem ThayDoiQuyDinh;
        private DevComponents.DotNetBar.Metro.MetroTileItem HocPhi;
        private DevComponents.DotNetBar.Metro.MetroTileItem BaoCaoThongKe;
        private DevComponents.DotNetBar.Metro.MetroTileItem QuanLyMonHoc;
        private DevComponents.DotNetBar.Metro.MetroTileItem CapNhapThongTin;
        private DevComponents.DotNetBar.Metro.MetroTileItem TroGiup;
        private DevComponents.DotNetBar.Metro.MetroTileItem ThôngTin;
        private DevComponents.DotNetBar.LabelX DongHo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
