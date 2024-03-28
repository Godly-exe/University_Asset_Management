namespace UI_UX_Dashboard_P1
{
    partial class ucLoaiTaiSan
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
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cbbTimKiem = new System.Windows.Forms.ToolStripComboBox();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnXuatFile = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiTaiSan = new System.Windows.Forms.TextBox();
            this.txtTenLoaiTaiSan = new System.Windows.Forms.TextBox();
            this.btnRamdo = new XanderUI.XUISuperButton();
            this.btnLamLai = new XanderUI.XUISuperButton();
            this.btnXoa = new XanderUI.XUISuperButton();
            this.btnSua = new XanderUI.XUISuperButton();
            this.btnThem = new XanderUI.XUISuperButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvLoaiTaiSan = new System.Windows.Forms.DataGridView();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiTaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiCustomToolstrip1
            // 
            this.xuiCustomToolstrip1.BackColor = System.Drawing.Color.White;
            this.xuiCustomToolstrip1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.xuiCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cbbTimKiem,
            this.txtTimKiem,
            this.btnTimKiem,
            this.btnXuatFile});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1509, 28);
            this.xuiCustomToolstrip1.TabIndex = 0;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 25);
            this.toolStripButton1.Text = "Refesh";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên"});
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(160, 28);
            this.cbbTimKiem.Text = "Tìm kiếm theo...";
            this.cbbTimKiem.ToolTipText = "Chọn tìm kiếm theo...";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(399, 28);
            this.txtTimKiem.ToolTipText = "Tìm Kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_search_48px;
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 25);
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_export_csv_40px;
            this.btnXuatFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(128, 25);
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaLoaiTaiSan);
            this.panel1.Controls.Add(this.txtTenLoaiTaiSan);
            this.panel1.Controls.Add(this.btnRamdo);
            this.panel1.Controls.Add(this.btnLamLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 778);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Mã Loại Thiết Bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập Tên Loại Thiết Bị:";
            // 
            // txtMaLoaiTaiSan
            // 
            this.txtMaLoaiTaiSan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLoaiTaiSan.Location = new System.Drawing.Point(19, 250);
            this.txtMaLoaiTaiSan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoaiTaiSan.Name = "txtMaLoaiTaiSan";
            this.txtMaLoaiTaiSan.Size = new System.Drawing.Size(384, 39);
            this.txtMaLoaiTaiSan.TabIndex = 6;
            // 
            // txtTenLoaiTaiSan
            // 
            this.txtTenLoaiTaiSan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoaiTaiSan.Location = new System.Drawing.Point(19, 342);
            this.txtTenLoaiTaiSan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiTaiSan.Name = "txtTenLoaiTaiSan";
            this.txtTenLoaiTaiSan.Size = new System.Drawing.Size(484, 39);
            this.txtTenLoaiTaiSan.TabIndex = 6;
            // 
            // btnRamdo
            // 
            this.btnRamdo.BackgroundColor = System.Drawing.Color.Purple;
            this.btnRamdo.ButtonImage = null;
            this.btnRamdo.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnRamdo.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRamdo.ButtonText = "Random";
            this.btnRamdo.CornerRadius = 5;
            this.btnRamdo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnRamdo.HoverTextColor = System.Drawing.Color.White;
            this.btnRamdo.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRamdo.Location = new System.Drawing.Point(405, 250);
            this.btnRamdo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRamdo.Name = "btnRamdo";
            this.btnRamdo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnRamdo.SelectedTextColor = System.Drawing.Color.White;
            this.btnRamdo.Size = new System.Drawing.Size(99, 42);
            this.btnRamdo.SuperSelected = false;
            this.btnRamdo.TabIndex = 4;
            this.btnRamdo.TextColor = System.Drawing.Color.White;
            this.btnRamdo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdo.Click += new System.EventHandler(this.btnRamdo_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackgroundColor = System.Drawing.Color.Orange;
            this.btnLamLai.ButtonImage = null;
            this.btnLamLai.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLamLai.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLamLai.ButtonText = "Làm Lại";
            this.btnLamLai.CornerRadius = 5;
            this.btnLamLai.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLamLai.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnLamLai.HoverTextColor = System.Drawing.Color.White;
            this.btnLamLai.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLamLai.Location = new System.Drawing.Point(371, 411);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLamLai.SelectedTextColor = System.Drawing.Color.White;
            this.btnLamLai.Size = new System.Drawing.Size(99, 42);
            this.btnLamLai.SuperSelected = false;
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.TextColor = System.Drawing.Color.White;
            this.btnLamLai.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ButtonImage = null;
            this.btnXoa.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnXoa.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.CornerRadius = 5;
            this.btnXoa.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnXoa.HoverTextColor = System.Drawing.Color.White;
            this.btnXoa.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnXoa.Location = new System.Drawing.Point(264, 411);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.SelectedTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(99, 42);
            this.btnXoa.SuperSelected = false;
            this.btnXoa.TabIndex = 4;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnSua.ButtonImage = null;
            this.btnSua.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnSua.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.CornerRadius = 5;
            this.btnSua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnSua.HoverTextColor = System.Drawing.Color.White;
            this.btnSua.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnSua.Location = new System.Drawing.Point(157, 411);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.SelectedTextColor = System.Drawing.Color.White;
            this.btnSua.Size = new System.Drawing.Size(99, 42);
            this.btnSua.SuperSelected = false;
            this.btnSua.TabIndex = 5;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThem.ButtonImage = null;
            this.btnThem.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThem.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.CornerRadius = 5;
            this.btnThem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThem.HoverTextColor = System.Drawing.Color.White;
            this.btnThem.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThem.Location = new System.Drawing.Point(51, 411);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.SelectedTextColor = System.Drawing.Color.White;
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.SuperSelected = false;
            this.btnThem.TabIndex = 5;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvLoaiTaiSan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(525, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 778);
            this.panel3.TabIndex = 6;
            // 
            // gvLoaiTaiSan
            // 
            this.gvLoaiTaiSan.AllowUserToAddRows = false;
            this.gvLoaiTaiSan.AllowUserToDeleteRows = false;
            this.gvLoaiTaiSan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvLoaiTaiSan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvLoaiTaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLoaiTaiSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLoaiTaiSan.Location = new System.Drawing.Point(0, 0);
            this.gvLoaiTaiSan.Margin = new System.Windows.Forms.Padding(4);
            this.gvLoaiTaiSan.Name = "gvLoaiTaiSan";
            this.gvLoaiTaiSan.ReadOnly = true;
            this.gvLoaiTaiSan.RowHeadersWidth = 51;
            this.gvLoaiTaiSan.Size = new System.Drawing.Size(984, 778);
            this.gvLoaiTaiSan.TabIndex = 0;
            this.gvLoaiTaiSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLoaiTaiSan_CellClick);
            this.gvLoaiTaiSan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLoaiTaiSan_CellContentClick);
            this.gvLoaiTaiSan.DoubleClick += new System.EventHandler(this.gvLoaiTaiSan_DoubleClick);
            // 
            // ucLoaiTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucLoaiTaiSan";
            this.Size = new System.Drawing.Size(1509, 806);
            this.Load += new System.EventHandler(this.ucLoaiTaiSan_Load_1);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiTaiSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISuperButton btnXoa;
        private XanderUI.XUISuperButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiTaiSan;
        private System.Windows.Forms.TextBox txtTenLoaiTaiSan;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUISuperButton btnSua;
        private System.Windows.Forms.DataGridView gvLoaiTaiSan;
        private XanderUI.XUISuperButton btnLamLai;
        private XanderUI.XUISuperButton btnRamdo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
    }
}
