namespace QLHPHP
{
    partial class KhoaNganhControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNganh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.metroToolbar2 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.buttonThemNganh = new DevComponents.DotNetBar.ButtonItem();
            this.buttonXoaNganh = new DevComponents.DotNetBar.ButtonItem();
            this.buttonLamMoiNganh = new DevComponents.DotNetBar.ButtonItem();
            this.btnChiTietNganh = new DevComponents.DotNetBar.ButtonItem();
            this.tabNganh = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.metroToolbar1 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.buttonThemKhoa = new DevComponents.DotNetBar.ButtonItem();
            this.buttonXoaKhoa = new DevComponents.DotNetBar.ButtonItem();
            this.buttonLamMoiKhoa = new DevComponents.DotNetBar.ButtonItem();
            this.dgvKhoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKhoa = new DevComponents.DotNetBar.SuperTabItem();
            this.DongButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNganh
            // 
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNganh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNganh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNganh.Location = new System.Drawing.Point(112, 101);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.Size = new System.Drawing.Size(342, 181);
            this.dgvNganh.TabIndex = 4;
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã Ngành";
            this.MaNganh.Name = "MaNganh";
            // 
            // TenNganh
            // 
            this.TenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNganh.DataPropertyName = "TenNganh";
            this.TenNganh.HeaderText = "Tên Ngành";
            this.TenNganh.Name = "TenNganh";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DisplayMember = "Text";
            this.cbKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.ItemHeight = 14;
            this.cbKhoa.Location = new System.Drawing.Point(240, 62);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(148, 20);
            this.cbKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbKhoa.TabIndex = 3;
            this.cbKhoa.SelectedValueChanged += new System.EventHandler(this.cbKhoa_SelectedValueChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(182, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Khoa:";
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(3, 3);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 1;
            this.superTabControl1.Size = new System.Drawing.Size(537, 410);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.superTabControl1.TabIndex = 2;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabKhoa,
            this.tabNganh});
            this.superTabControl1.Text = "superTabControl1";
            this.superTabControl1.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.superTabControl1_SelectedTabChanged);
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.labelX1);
            this.superTabControlPanel2.Controls.Add(this.metroToolbar2);
            this.superTabControlPanel2.Controls.Add(this.cbKhoa);
            this.superTabControlPanel2.Controls.Add(this.dgvNganh);
            this.superTabControlPanel2.Controls.Add(this.labelX2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(537, 410);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabNganh;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(156, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(259, 32);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "DANH SÁCH CÁC NGÀNH ";
            // 
            // metroToolbar2
            // 
            this.metroToolbar2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.metroToolbar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroToolbar2.ContainerControlProcessDialogKey = true;
            this.metroToolbar2.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top;
            this.metroToolbar2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroToolbar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonThemNganh,
            this.buttonXoaNganh,
            this.buttonLamMoiNganh,
            this.btnChiTietNganh});
            this.metroToolbar2.Location = new System.Drawing.Point(135, 298);
            this.metroToolbar2.Name = "metroToolbar2";
            this.metroToolbar2.Size = new System.Drawing.Size(289, 46);
            this.metroToolbar2.TabIndex = 5;
            this.metroToolbar2.Text = "metroToolbar2";
            // 
            // buttonThemNganh
            // 
            this.buttonThemNganh.Image = global::QLHPHP.Properties.Resources.NewInvoice1;
            this.buttonThemNganh.Name = "buttonThemNganh";
            this.buttonThemNganh.Text = "buttonItem";
            this.buttonThemNganh.Tooltip = "Thêm Ngành Mới";
            this.buttonThemNganh.Click += new System.EventHandler(this.buttonThemNganh_Click);
            // 
            // buttonXoaNganh
            // 
            this.buttonXoaNganh.Image = global::QLHPHP.Properties.Resources.Delete1;
            this.buttonXoaNganh.Name = "buttonXoaNganh";
            this.buttonXoaNganh.Text = "buttonItem3";
            this.buttonXoaNganh.Tooltip = "Xóa Ngành Đang Chọn";
            this.buttonXoaNganh.Click += new System.EventHandler(this.buttonXoaNganh_Click);
            // 
            // buttonLamMoiNganh
            // 
            this.buttonLamMoiNganh.Image = global::QLHPHP.Properties.Resources.Refresh_button1;
            this.buttonLamMoiNganh.Name = "buttonLamMoiNganh";
            this.buttonLamMoiNganh.Text = "Cập Nhật Danh Sách";
            this.buttonLamMoiNganh.Tooltip = "Cập Nhật Danh Sách";
            this.buttonLamMoiNganh.Click += new System.EventHandler(this.buttonLamMoiNganh_Click);
            // 
            // btnChiTietNganh
            // 
            this.btnChiTietNganh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChiTietNganh.Image = global::QLHPHP.Properties.Resources.Table;
            this.btnChiTietNganh.Name = "btnChiTietNganh";
            this.btnChiTietNganh.Text = "Chi Tiết Ngành";
            this.btnChiTietNganh.Click += new System.EventHandler(this.btnChiTietNganh_Click);
            // 
            // tabNganh
            // 
            this.tabNganh.AttachedControl = this.superTabControlPanel2;
            this.tabNganh.GlobalItem = false;
            this.tabNganh.Name = "tabNganh";
            this.tabNganh.Text = "NGÀNH";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.labelX5);
            this.superTabControlPanel1.Controls.Add(this.metroToolbar1);
            this.superTabControlPanel1.Controls.Add(this.dgvKhoa);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(537, 385);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabKhoa;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(167, 12);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(194, 32);
            this.labelX5.TabIndex = 21;
            this.labelX5.Text = "DANH SÁCH KHOA";
            // 
            // metroToolbar1
            // 
            this.metroToolbar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroToolbar1.ContainerControlProcessDialogKey = true;
            this.metroToolbar1.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top;
            this.metroToolbar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroToolbar1.ForeColor = System.Drawing.Color.Black;
            this.metroToolbar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonThemKhoa,
            this.buttonXoaKhoa,
            this.buttonLamMoiKhoa});
            this.metroToolbar1.Location = new System.Drawing.Point(119, 331);
            this.metroToolbar1.Name = "metroToolbar1";
            this.metroToolbar1.Size = new System.Drawing.Size(242, 46);
            this.metroToolbar1.TabIndex = 3;
            this.metroToolbar1.Text = "metroToolbar1";
            // 
            // buttonThemKhoa
            // 
            this.buttonThemKhoa.Image = global::QLHPHP.Properties.Resources.NewInvoice1;
            this.buttonThemKhoa.Name = "buttonThemKhoa";
            this.buttonThemKhoa.Text = "buttonItem";
            this.buttonThemKhoa.Tooltip = "Thêm Khoa Mới";
            this.buttonThemKhoa.Click += new System.EventHandler(this.buttonThemKhoa_Click);
            // 
            // buttonXoaKhoa
            // 
            this.buttonXoaKhoa.Image = global::QLHPHP.Properties.Resources.Delete1;
            this.buttonXoaKhoa.Name = "buttonXoaKhoa";
            this.buttonXoaKhoa.Text = "buttonItem3";
            this.buttonXoaKhoa.Tooltip = "Xóa Khoa Đang Chọn";
            this.buttonXoaKhoa.Click += new System.EventHandler(this.buttonXoaKhoa_Click);
            // 
            // buttonLamMoiKhoa
            // 
            this.buttonLamMoiKhoa.Image = global::QLHPHP.Properties.Resources.Refresh_button1;
            this.buttonLamMoiKhoa.Name = "buttonLamMoiKhoa";
            this.buttonLamMoiKhoa.Text = "Cập Nhật Danh Sách";
            this.buttonLamMoiKhoa.Tooltip = "Cập Nhật Danh Sách";
            this.buttonLamMoiKhoa.Click += new System.EventHandler(this.buttonLamMoiKhoa_Click);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKhoa.Location = new System.Drawing.Point(64, 50);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(397, 235);
            this.dgvKhoa.TabIndex = 2;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            // 
            // tabKhoa
            // 
            this.tabKhoa.AttachedControl = this.superTabControlPanel1;
            this.tabKhoa.GlobalItem = false;
            this.tabKhoa.Name = "tabKhoa";
            this.tabKhoa.Text = "KHOA";
            // 
            // DongButton
            // 
            this.DongButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DongButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DongButton.Location = new System.Drawing.Point(464, 419);
            this.DongButton.Name = "DongButton";
            this.DongButton.Size = new System.Drawing.Size(75, 32);
            this.DongButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DongButton.Symbol = "";
            this.DongButton.TabIndex = 5;
            this.DongButton.Tooltip = "Quay về màn hình chính";
            // 
            // KhoaNganhControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DongButton);
            this.Controls.Add(this.superTabControl1);
            this.Name = "KhoaNganhControl";
            this.Size = new System.Drawing.Size(542, 463);
            this.Load += new System.EventHandler(this.KhoaNganhControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNganh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbKhoa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabNganh;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabKhoa;
        private DevComponents.DotNetBar.ButtonX DongButton;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar1;
        private DevComponents.DotNetBar.ButtonItem buttonThemKhoa;
        private DevComponents.DotNetBar.ButtonItem buttonXoaKhoa;
        private DevComponents.DotNetBar.ButtonItem buttonLamMoiKhoa;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar2;
        private DevComponents.DotNetBar.ButtonItem buttonThemNganh;
        private DevComponents.DotNetBar.ButtonItem buttonXoaNganh;
        private DevComponents.DotNetBar.ButtonItem buttonLamMoiNganh;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnChiTietNganh;
    }
}
