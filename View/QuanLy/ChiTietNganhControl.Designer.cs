namespace QLHPHP
{
    partial class ChiTietNganhControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnThemChiTietNganh = new DevComponents.DotNetBar.ButtonX();
            this.txtMaMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbbNganh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvXemDSMon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTCTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTCLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSMHKhongThuocNganh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnXemMonCuaNganh = new DevComponents.DotNetBar.ButtonX();
            this.lBdgv = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDSMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMHKhongThuocNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lBdgv);
            this.panelEx1.Controls.Add(this.btnXemMonCuaNganh);
            this.panelEx1.Controls.Add(this.BtnThem);
            this.panelEx1.Controls.Add(this.DSMHKhongThuocNganh);
            this.panelEx1.Controls.Add(this.dgvXemDSMon);
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.btnThemChiTietNganh);
            this.panelEx1.Controls.Add(this.txtMaMon);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.cbbNganh);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Location = new System.Drawing.Point(3, 3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(491, 319);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(401, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 5;
            this.btnClose.Tooltip = "Quay lại ";
            // 
            // btnThemChiTietNganh
            // 
            this.btnThemChiTietNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemChiTietNganh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemChiTietNganh.Location = new System.Drawing.Point(308, 206);
            this.btnThemChiTietNganh.Name = "btnThemChiTietNganh";
            this.btnThemChiTietNganh.Size = new System.Drawing.Size(75, 30);
            this.btnThemChiTietNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemChiTietNganh.Symbol = "";
            this.btnThemChiTietNganh.TabIndex = 4;
            this.btnThemChiTietNganh.Tooltip = "Thêm chi tiết ngành";
            this.btnThemChiTietNganh.Click += new System.EventHandler(this.btnThemChiTietNganh_Click);
            // 
            // txtMaMon
            // 
            this.txtMaMon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMaMon.Border.Class = "TextBoxBorder";
            this.txtMaMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaMon.ForeColor = System.Drawing.Color.Black;
            this.txtMaMon.Location = new System.Drawing.Point(331, 105);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(100, 20);
            this.txtMaMon.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(273, 105);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Mã Môn:";
            // 
            // cbbNganh
            // 
            this.cbbNganh.DisplayMember = "Text";
            this.cbbNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.ItemHeight = 14;
            this.cbbNganh.Location = new System.Drawing.Point(331, 69);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(137, 20);
            this.cbbNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbNganh.TabIndex = 1;
            this.cbbNganh.SelectedValueChanged += new System.EventHandler(this.cbbNganh_SelectedValueChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(273, 66);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Ngành:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(289, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(170, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "THÊM CHI TIẾT NGÀNH";
            // 
            // dgvXemDSMon
            // 
            this.dgvXemDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonHoc,
            this.TenMonHoc,
            this.SoTCTH,
            this.SoTCLT,
            this.TongTC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXemDSMon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXemDSMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvXemDSMon.Location = new System.Drawing.Point(3, 66);
            this.dgvXemDSMon.Name = "dgvXemDSMon";
            this.dgvXemDSMon.Size = new System.Drawing.Size(267, 238);
            this.dgvXemDSMon.TabIndex = 0;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMon";
            this.MaMonHoc.HeaderText = "Mã Môn";
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Width = 70;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên Môn";
            this.TenMonHoc.Name = "TenMonHoc";
            // 
            // SoTCTH
            // 
            this.SoTCTH.DataPropertyName = "SoTCTH";
            this.SoTCTH.HeaderText = "TC Thực hành";
            this.SoTCTH.Name = "SoTCTH";
            this.SoTCTH.Visible = false;
            // 
            // SoTCLT
            // 
            this.SoTCLT.DataPropertyName = "SoTCLT";
            this.SoTCLT.HeaderText = "TC Lý thuyết";
            this.SoTCLT.Name = "SoTCLT";
            this.SoTCLT.Visible = false;
            // 
            // TongTC
            // 
            this.TongTC.DataPropertyName = "TongTC";
            this.TongTC.HeaderText = "Số Tín Chỉ";
            this.TongTC.Name = "TongTC";
            this.TongTC.Visible = false;
            // 
            // DSMHKhongThuocNganh
            // 
            this.DSMHKhongThuocNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSMHKhongThuocNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.Ten,
            this.TH,
            this.LT,
            this.Tong});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DSMHKhongThuocNganh.DefaultCellStyle = dataGridViewCellStyle1;
            this.DSMHKhongThuocNganh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DSMHKhongThuocNganh.Location = new System.Drawing.Point(3, 66);
            this.DSMHKhongThuocNganh.Name = "DSMHKhongThuocNganh";
            this.DSMHKhongThuocNganh.Size = new System.Drawing.Size(267, 238);
            this.DSMHKhongThuocNganh.TabIndex = 6;
            this.DSMHKhongThuocNganh.Visible = false;
            this.DSMHKhongThuocNganh.Click += new System.EventHandler(this.DSMHKhongThuocNganh_Click);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 70;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TenMonHoc";
            this.Ten.HeaderText = "Tên Môn";
            this.Ten.Name = "Ten";
            this.Ten.Width = 154;
            // 
            // TH
            // 
            this.TH.DataPropertyName = "SoTCTH";
            this.TH.HeaderText = "Số TCTH";
            this.TH.Name = "TH";
            this.TH.Visible = false;
            // 
            // LT
            // 
            this.LT.DataPropertyName = "SoTCLT";
            this.LT.HeaderText = "Số TCLT";
            this.LT.Name = "LT";
            this.LT.Visible = false;
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "TongTC";
            this.Tong.HeaderText = "Tổng TC";
            this.Tong.Name = "Tong";
            this.Tong.Visible = false;
            // 
            // BtnThem
            // 
            this.BtnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnThem.Location = new System.Drawing.Point(308, 206);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 30);
            this.BtnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnThem.Symbol = "";
            this.BtnThem.TabIndex = 7;
            this.BtnThem.Tooltip = "Thêm chi tiết ngành";
            this.BtnThem.Visible = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnXemMonCuaNganh
            // 
            this.btnXemMonCuaNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXemMonCuaNganh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXemMonCuaNganh.Location = new System.Drawing.Point(308, 252);
            this.btnXemMonCuaNganh.Name = "btnXemMonCuaNganh";
            this.btnXemMonCuaNganh.Size = new System.Drawing.Size(75, 30);
            this.btnXemMonCuaNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXemMonCuaNganh.Symbol = "";
            this.btnXemMonCuaNganh.TabIndex = 8;
            this.btnXemMonCuaNganh.Tooltip = "Xem môn của Ngành !";
            this.btnXemMonCuaNganh.Visible = false;
            this.btnXemMonCuaNganh.Click += new System.EventHandler(this.btnXemMonCuaNganh_Click);
            // 
            // lBdgv
            // 
            // 
            // 
            // 
            this.lBdgv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lBdgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBdgv.Location = new System.Drawing.Point(30, 26);
            this.lBdgv.Name = "lBdgv";
            this.lBdgv.Size = new System.Drawing.Size(208, 23);
            this.lBdgv.TabIndex = 9;
            this.lBdgv.Text = "Môn Học Thuộc Ngành";
            // 
            // ChiTietNganhControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "ChiTietNganhControl";
            this.Size = new System.Drawing.Size(496, 326);
            this.Load += new System.EventHandler(this.ChiTietNganhControl_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDSMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMHKhongThuocNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvXemDSMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaMon;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbNganh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnThemChiTietNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTCTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTCLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTC;
        private DevComponents.DotNetBar.Controls.DataGridViewX DSMHKhongThuocNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private DevComponents.DotNetBar.ButtonX BtnThem;
        private DevComponents.DotNetBar.ButtonX btnXemMonCuaNganh;
        private DevComponents.DotNetBar.LabelX lBdgv;
    }
}
