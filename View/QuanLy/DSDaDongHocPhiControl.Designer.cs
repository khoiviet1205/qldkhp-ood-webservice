namespace QLHPHP
{
    partial class DSDaDongHocPhiControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvDSDaDongHP = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieuDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaDongHP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnDong);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.dgvDSDaDongHP);
            this.panelEx1.Location = new System.Drawing.Point(3, 3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(620, 406);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Location = new System.Drawing.Point(528, 365);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 32);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.Symbol = "";
            this.btnDong.TabIndex = 1;
            this.btnDong.Tooltip = "Quay lại";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(150, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(344, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "DANH SÁCH SINH VIÊN ĐÃ ĐÓNG HỌC PHÍ";
            // 
            // dgvDSDaDongHP
            // 
            this.dgvDSDaDongHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDaDongHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.SoPhieuDK,
            this.SoTienThu,
            this.NgayLap});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSDaDongHP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSDaDongHP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSDaDongHP.Location = new System.Drawing.Point(13, 60);
            this.dgvDSDaDongHP.Name = "dgvDSDaDongHP";
            this.dgvDSDaDongHP.Size = new System.Drawing.Size(590, 294);
            this.dgvDSDaDongHP.TabIndex = 0;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã SV";
            this.MSSV.Name = "MSSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // SoPhieuDK
            // 
            this.SoPhieuDK.DataPropertyName = "SoPhieuDK";
            this.SoPhieuDK.HeaderText = "SPĐK";
            this.SoPhieuDK.Name = "SoPhieuDK";
            this.SoPhieuDK.Width = 70;
            // 
            // SoTienThu
            // 
            this.SoTienThu.DataPropertyName = "SoTienThu";
            this.SoTienThu.HeaderText = "Tiền Đã Đóng";
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.Width = 120;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Nộp";
            this.NgayLap.Name = "NgayLap";
            // 
            // DSDaDongHocPhiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "DSDaDongHocPhiControl";
            this.Size = new System.Drawing.Size(626, 412);
            this.Load += new System.EventHandler(this.DSDaDongHocPhiControl_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaDongHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSDaDongHP;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
    }
}
