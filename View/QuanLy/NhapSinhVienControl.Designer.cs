namespace QLHPHP
{
    partial class NhapSinhVienControl
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.cbbMaNganh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbMaDoiTuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbbGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Nam = new DevComponents.Editors.ComboItem();
            this.Nu = new DevComponents.Editors.ComboItem();
            this.khac = new DevComponents.Editors.ComboItem();
            this.labelHoTen = new DevComponents.DotNetBar.LabelX();
            this.labelNgaySinh = new DevComponents.DotNetBar.LabelX();
            this.labelGioiTinh = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMaDoiTuong = new DevComponents.DotNetBar.LabelX();
            this.labelMaNganh = new DevComponents.DotNetBar.LabelX();
            this.labelDiaChi = new DevComponents.DotNetBar.LabelX();
            this.labelEmail = new DevComponents.DotNetBar.LabelX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.LuuSinhVien = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnReset);
            this.panelEx1.Controls.Add(this.cbbMaNganh);
            this.panelEx1.Controls.Add(this.cbbMaDoiTuong);
            this.panelEx1.Controls.Add(this.dtNgaySinh);
            this.panelEx1.Controls.Add(this.cbbGioiTinh);
            this.panelEx1.Controls.Add(this.labelHoTen);
            this.panelEx1.Controls.Add(this.labelNgaySinh);
            this.panelEx1.Controls.Add(this.labelGioiTinh);
            this.panelEx1.Controls.Add(this.txtEmail);
            this.panelEx1.Controls.Add(this.txtDiaChi);
            this.panelEx1.Controls.Add(this.labelMaDoiTuong);
            this.panelEx1.Controls.Add(this.labelMaNganh);
            this.panelEx1.Controls.Add(this.labelDiaChi);
            this.panelEx1.Controls.Add(this.labelEmail);
            this.panelEx1.Controls.Add(this.txtHoTen);
            this.panelEx1.Controls.Add(this.cancelButton);
            this.panelEx1.Controls.Add(this.LuuSinhVien);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(419, 375);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(92, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 29);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.Symbol = "";
            this.btnReset.TabIndex = 10;
            this.btnReset.Tooltip = "Nhập lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbbMaNganh
            // 
            this.cbbMaNganh.DisplayMember = "Text";
            this.cbbMaNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaNganh.FormattingEnabled = true;
            this.cbbMaNganh.ItemHeight = 16;
            this.cbbMaNganh.Location = new System.Drawing.Point(172, 211);
            this.cbbMaNganh.Name = "cbbMaNganh";
            this.cbbMaNganh.Size = new System.Drawing.Size(121, 22);
            this.cbbMaNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbMaNganh.TabIndex = 7;
            // 
            // cbbMaDoiTuong
            // 
            this.cbbMaDoiTuong.DisplayMember = "Text";
            this.cbbMaDoiTuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaDoiTuong.FormattingEnabled = true;
            this.cbbMaDoiTuong.ItemHeight = 16;
            this.cbbMaDoiTuong.Location = new System.Drawing.Point(172, 185);
            this.cbbMaDoiTuong.Name = "cbbMaDoiTuong";
            this.cbbMaDoiTuong.Size = new System.Drawing.Size(121, 22);
            this.cbbMaDoiTuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbMaDoiTuong.TabIndex = 6;
            this.cbbMaDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cbbMaDoiTuong_SelectedIndexChanged);
            // 
            // dtNgaySinh
            // 
            // 
            // 
            // 
            this.dtNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgaySinh.ButtonDropDown.Visible = true;
            this.dtNgaySinh.IsPopupCalendarOpen = false;
            this.dtNgaySinh.Location = new System.Drawing.Point(172, 121);
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.dtNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(120, 22);
            this.dtNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgaySinh.TabIndex = 1;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DisplayMember = "Text";
            this.cbbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.ItemHeight = 16;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            this.Nam,
            this.Nu,
            this.khac});
            this.cbbGioiTinh.Location = new System.Drawing.Point(172, 153);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(121, 22);
            this.cbbGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbGioiTinh.TabIndex = 2;
            // 
            // Nam
            // 
            this.Nam.Text = "Nam";
            // 
            // Nu
            // 
            this.Nu.Text = "Nữ";
            // 
            // khac
            // 
            this.khac.Text = "Khác";
            // 
            // labelHoTen
            // 
            this.labelHoTen.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelHoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(95, 90);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(52, 18);
            this.labelHoTen.TabIndex = 34;
            this.labelHoTen.Text = "Họ Tên:";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(92, 123);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(66, 20);
            this.labelNgaySinh.TabIndex = 36;
            this.labelNgaySinh.Text = "Ngày Sinh:";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelGioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioiTinh.Location = new System.Drawing.Point(92, 153);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(63, 20);
            this.labelGioiTinh.TabIndex = 37;
            this.labelGioiTinh.Text = "Giới Tính:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(172, 239);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(172, 267);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(188, 37);
            this.txtDiaChi.TabIndex = 9;
            // 
            // labelMaDoiTuong
            // 
            this.labelMaDoiTuong.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMaDoiTuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMaDoiTuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDoiTuong.Location = new System.Drawing.Point(92, 187);
            this.labelMaDoiTuong.Name = "labelMaDoiTuong";
            this.labelMaDoiTuong.Size = new System.Drawing.Size(66, 20);
            this.labelMaDoiTuong.TabIndex = 39;
            this.labelMaDoiTuong.Text = "Đối Tượng:";
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMaNganh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMaNganh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNganh.Location = new System.Drawing.Point(92, 213);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(73, 20);
            this.labelMaNganh.TabIndex = 40;
            this.labelMaNganh.Text = "Mã Ngành:";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(92, 267);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(51, 20);
            this.labelDiaChi.TabIndex = 42;
            this.labelDiaChi.Text = "Địa Chỉ:";
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(92, 239);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 20);
            this.labelEmail.TabIndex = 43;
            this.labelEmail.Text = "Email:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(172, 87);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(131, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(283, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 29);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.Symbol = "";
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Tooltip = "Quay lại";
            // 
            // LuuSinhVien
            // 
            this.LuuSinhVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LuuSinhVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LuuSinhVien.Location = new System.Drawing.Point(184, 330);
            this.LuuSinhVien.Name = "LuuSinhVien";
            this.LuuSinhVien.Size = new System.Drawing.Size(73, 29);
            this.LuuSinhVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LuuSinhVien.Symbol = "";
            this.LuuSinhVien.TabIndex = 11;
            this.LuuSinhVien.Tooltip = "Thêm sinh viên";
            this.LuuSinhVien.Click += new System.EventHandler(this.LuuSinhVien_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(78, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(324, 44);
            this.labelX5.TabIndex = 30;
            this.labelX5.Text = "Nhập Thông Tin Sinh Viên";
            // 
            // NhapSinhVienControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "NhapSinhVienControl";
            this.Size = new System.Drawing.Size(424, 378);
            this.Load += new System.EventHandler(this.NhapSinhVienControl_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX LuuSinhVien;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelHoTen;
        private DevComponents.DotNetBar.LabelX labelNgaySinh;
        private DevComponents.DotNetBar.LabelX labelGioiTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.LabelX labelMaDoiTuong;
        private DevComponents.DotNetBar.LabelX labelMaNganh;
        private DevComponents.DotNetBar.LabelX labelDiaChi;
        private DevComponents.DotNetBar.LabelX labelEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgaySinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbGioiTinh;
        private DevComponents.Editors.ComboItem Nam;
        private DevComponents.Editors.ComboItem Nu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbMaDoiTuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbMaNganh;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.Editors.ComboItem khac;
    }
}
