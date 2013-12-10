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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNganh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btnChiTietNganh = new DevComponents.DotNetBar.ButtonX();
            this.buttonLamMoiNganh = new DevComponents.DotNetBar.ButtonX();
            this.buttonXoaNganh = new DevComponents.DotNetBar.ButtonX();
            this.buttonThemNganh = new DevComponents.DotNetBar.ButtonX();
            this.tabNganh = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.buttonLamMoiKhoa = new DevComponents.DotNetBar.ButtonX();
            this.buttonXoaKhoa = new DevComponents.DotNetBar.ButtonX();
            this.buttonThemKhoa = new DevComponents.DotNetBar.ButtonX();
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
            this.dgvNganh.BackgroundColor = System.Drawing.Color.White;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNganh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNganh.EnableHeadersVisualStyles = false;
            this.dgvNganh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNganh.Location = new System.Drawing.Point(19, 47);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNganh.Size = new System.Drawing.Size(469, 253);
            this.dgvNganh.TabIndex = 4;
            this.dgvNganh.Click += new System.EventHandler(this.dgvNganh_Click);
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
            this.cbKhoa.Location = new System.Drawing.Point(100, 15);
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
            this.labelX2.Location = new System.Drawing.Point(19, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Chọn Khoa:";
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
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
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
            this.superTabControlPanel2.Controls.Add(this.btnChiTietNganh);
            this.superTabControlPanel2.Controls.Add(this.buttonLamMoiNganh);
            this.superTabControlPanel2.Controls.Add(this.buttonXoaNganh);
            this.superTabControlPanel2.Controls.Add(this.buttonThemNganh);
            this.superTabControlPanel2.Controls.Add(this.cbKhoa);
            this.superTabControlPanel2.Controls.Add(this.dgvNganh);
            this.superTabControlPanel2.Controls.Add(this.labelX2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(537, 385);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabNganh;
            // 
            // btnChiTietNganh
            // 
            this.btnChiTietNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChiTietNganh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChiTietNganh.Location = new System.Drawing.Point(494, 164);
            this.btnChiTietNganh.Name = "btnChiTietNganh";
            this.btnChiTietNganh.Size = new System.Drawing.Size(33, 136);
            this.btnChiTietNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChiTietNganh.Symbol = "";
            this.btnChiTietNganh.TabIndex = 24;
            this.btnChiTietNganh.Click += new System.EventHandler(this.btnChiTietNganh_Click_1);
            // 
            // buttonLamMoiNganh
            // 
            this.buttonLamMoiNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonLamMoiNganh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonLamMoiNganh.Location = new System.Drawing.Point(494, 125);
            this.buttonLamMoiNganh.Name = "buttonLamMoiNganh";
            this.buttonLamMoiNganh.Size = new System.Drawing.Size(33, 33);
            this.buttonLamMoiNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonLamMoiNganh.Symbol = "";
            this.buttonLamMoiNganh.TabIndex = 23;
            this.buttonLamMoiNganh.Click += new System.EventHandler(this.buttonLamMoiNganh_Click_1);
            // 
            // buttonXoaNganh
            // 
            this.buttonXoaNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXoaNganh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXoaNganh.Location = new System.Drawing.Point(494, 86);
            this.buttonXoaNganh.Name = "buttonXoaNganh";
            this.buttonXoaNganh.Size = new System.Drawing.Size(33, 33);
            this.buttonXoaNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXoaNganh.Symbol = "";
            this.buttonXoaNganh.TabIndex = 23;
            this.buttonXoaNganh.Click += new System.EventHandler(this.buttonXoaNganh_Click_1);
            // 
            // buttonThemNganh
            // 
            this.buttonThemNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonThemNganh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonThemNganh.Location = new System.Drawing.Point(494, 47);
            this.buttonThemNganh.Name = "buttonThemNganh";
            this.buttonThemNganh.Size = new System.Drawing.Size(33, 33);
            this.buttonThemNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonThemNganh.Symbol = "";
            this.buttonThemNganh.TabIndex = 23;
            this.buttonThemNganh.Click += new System.EventHandler(this.buttonThemNganh_Click_1);
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
            this.superTabControlPanel1.Controls.Add(this.buttonLamMoiKhoa);
            this.superTabControlPanel1.Controls.Add(this.buttonXoaKhoa);
            this.superTabControlPanel1.Controls.Add(this.buttonThemKhoa);
            this.superTabControlPanel1.Controls.Add(this.dgvKhoa);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(537, 385);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabKhoa;
            // 
            // buttonLamMoiKhoa
            // 
            this.buttonLamMoiKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonLamMoiKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonLamMoiKhoa.Location = new System.Drawing.Point(464, 19);
            this.buttonLamMoiKhoa.Name = "buttonLamMoiKhoa";
            this.buttonLamMoiKhoa.Size = new System.Drawing.Size(50, 27);
            this.buttonLamMoiKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonLamMoiKhoa.Symbol = "";
            this.buttonLamMoiKhoa.TabIndex = 22;
            this.buttonLamMoiKhoa.Tooltip = "Cập Nhật Lại Danh Sách";
            this.buttonLamMoiKhoa.Click += new System.EventHandler(this.buttonLamMoiKhoa_Click_1);
            // 
            // buttonXoaKhoa
            // 
            this.buttonXoaKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXoaKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXoaKhoa.Location = new System.Drawing.Point(408, 19);
            this.buttonXoaKhoa.Name = "buttonXoaKhoa";
            this.buttonXoaKhoa.Size = new System.Drawing.Size(50, 27);
            this.buttonXoaKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXoaKhoa.Symbol = "";
            this.buttonXoaKhoa.TabIndex = 22;
            this.buttonXoaKhoa.Tooltip = "Xóa Khoa Đang Chọn";
            this.buttonXoaKhoa.Click += new System.EventHandler(this.buttonXoaKhoa_Click_1);
            // 
            // buttonThemKhoa
            // 
            this.buttonThemKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonThemKhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonThemKhoa.Location = new System.Drawing.Point(352, 19);
            this.buttonThemKhoa.Name = "buttonThemKhoa";
            this.buttonThemKhoa.Size = new System.Drawing.Size(50, 27);
            this.buttonThemKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonThemKhoa.Symbol = "";
            this.buttonThemKhoa.TabIndex = 22;
            this.buttonThemKhoa.Tooltip = "Thêm Khoa Mới";
            this.buttonThemKhoa.Click += new System.EventHandler(this.buttonThemKhoa_Click_1);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhoa.EnableHeadersVisualStyles = false;
            this.dgvKhoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKhoa.Location = new System.Drawing.Point(21, 52);
            this.dgvKhoa.Name = "dgvKhoa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhoa.Size = new System.Drawing.Size(494, 313);
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
        private DevComponents.DotNetBar.ButtonX buttonLamMoiKhoa;
        private DevComponents.DotNetBar.ButtonX buttonXoaKhoa;
        private DevComponents.DotNetBar.ButtonX buttonThemKhoa;
        private DevComponents.DotNetBar.ButtonX btnChiTietNganh;
        private DevComponents.DotNetBar.ButtonX buttonLamMoiNganh;
        private DevComponents.DotNetBar.ButtonX buttonXoaNganh;
        private DevComponents.DotNetBar.ButtonX buttonThemNganh;
    }
}
