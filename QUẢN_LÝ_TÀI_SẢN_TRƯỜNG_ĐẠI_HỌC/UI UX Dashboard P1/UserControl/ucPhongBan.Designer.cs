namespace UI_UX_Dashboard_P1
{
    partial class ucPhongBan
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
            this.btnLamLai = new XanderUI.XUISuperButton();
            this.btnXoa = new XanderUI.XUISuperButton();
            this.btnSua = new XanderUI.XUISuperButton();
            this.btnThem = new XanderUI.XUISuperButton();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.rdCoSan = new XanderUI.XUIRadio();
            this.rdDangDung = new XanderUI.XUIRadio();
            this.txtDienTichPhong = new System.Windows.Forms.NumericUpDown();
            this.txtSoPhong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtViTriPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnRamdom = new XanderUI.XUISuperButton();
            this.gvPhongBan = new System.Windows.Forms.DataGridView();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTichPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBan)).BeginInit();
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
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1373, 28);
            this.xuiCustomToolstrip1.TabIndex = 2;
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
            "Tìm theo tên",
            "Tìm theo vị trí"});
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
            this.panel1.Controls.Add(this.btnLamLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.xuiCustomGroupbox1);
            this.panel1.Controls.Add(this.txtDienTichPhong);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.txtViTriPhong);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.btnRamdom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 708);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnLamLai.Location = new System.Drawing.Point(363, 625);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLamLai.SelectedTextColor = System.Drawing.Color.White;
            this.btnLamLai.Size = new System.Drawing.Size(99, 42);
            this.btnLamLai.SuperSelected = false;
            this.btnLamLai.TabIndex = 12;
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
            this.btnXoa.Location = new System.Drawing.Point(256, 625);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.SelectedTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(99, 42);
            this.btnXoa.SuperSelected = false;
            this.btnXoa.TabIndex = 13;
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
            this.btnSua.Location = new System.Drawing.Point(149, 625);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.SelectedTextColor = System.Drawing.Color.White;
            this.btnSua.Size = new System.Drawing.Size(99, 42);
            this.btnSua.SuperSelected = false;
            this.btnSua.TabIndex = 14;
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
            this.btnThem.Location = new System.Drawing.Point(43, 625);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.SelectedTextColor = System.Drawing.Color.White;
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.SuperSelected = false;
            this.btnThem.TabIndex = 15;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.rdCoSan);
            this.xuiCustomGroupbox1.Controls.Add(this.rdDangDung);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(11, 462);
            this.xuiCustomGroupbox1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.Padding = new System.Windows.Forms.Padding(4);
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(484, 123);
            this.xuiCustomGroupbox1.TabIndex = 10;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Trạng Thái Phòng";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.Snow;
            // 
            // rdCoSan
            // 
            this.rdCoSan.Checked = false;
            this.rdCoSan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdCoSan.ForeColor = System.Drawing.Color.White;
            this.rdCoSan.Location = new System.Drawing.Point(245, 47);
            this.rdCoSan.Margin = new System.Windows.Forms.Padding(4);
            this.rdCoSan.Name = "rdCoSan";
            this.rdCoSan.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdCoSan.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.rdCoSan.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rdCoSan.Size = new System.Drawing.Size(209, 30);
            this.rdCoSan.TabIndex = 10;
            this.rdCoSan.Text = "Có Sẵn";
            // 
            // rdDangDung
            // 
            this.rdDangDung.Checked = false;
            this.rdDangDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdDangDung.ForeColor = System.Drawing.Color.White;
            this.rdDangDung.Location = new System.Drawing.Point(28, 47);
            this.rdDangDung.Margin = new System.Windows.Forms.Padding(4);
            this.rdDangDung.Name = "rdDangDung";
            this.rdDangDung.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdDangDung.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.rdDangDung.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rdDangDung.Size = new System.Drawing.Size(209, 30);
            this.rdDangDung.TabIndex = 11;
            this.rdDangDung.Text = "Đang Dùng";
            // 
            // txtDienTichPhong
            // 
            this.txtDienTichPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienTichPhong.Location = new System.Drawing.Point(9, 326);
            this.txtDienTichPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienTichPhong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtDienTichPhong.Name = "txtDienTichPhong";
            this.txtDienTichPhong.Size = new System.Drawing.Size(484, 39);
            this.txtDienTichPhong.TabIndex = 8;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoPhong.Location = new System.Drawing.Point(9, 246);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(484, 39);
            this.txtSoPhong.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Mã Phòng Ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Số Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhập Vị Trí Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập Diện Tích Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập Tên Phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(9, 70);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(376, 39);
            this.txtMaPhong.TabIndex = 6;
            // 
            // txtViTriPhong
            // 
            this.txtViTriPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtViTriPhong.Location = new System.Drawing.Point(8, 414);
            this.txtViTriPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtViTriPhong.Name = "txtViTriPhong";
            this.txtViTriPhong.Size = new System.Drawing.Size(484, 39);
            this.txtViTriPhong.TabIndex = 6;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.Location = new System.Drawing.Point(9, 162);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(484, 39);
            this.txtTenPhong.TabIndex = 6;
            // 
            // btnRamdom
            // 
            this.btnRamdom.BackgroundColor = System.Drawing.Color.Purple;
            this.btnRamdom.ButtonImage = null;
            this.btnRamdom.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnRamdom.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRamdom.ButtonText = "Random";
            this.btnRamdom.CornerRadius = 5;
            this.btnRamdom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnRamdom.HoverTextColor = System.Drawing.Color.White;
            this.btnRamdom.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRamdom.Location = new System.Drawing.Point(395, 70);
            this.btnRamdom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRamdom.Name = "btnRamdom";
            this.btnRamdom.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnRamdom.SelectedTextColor = System.Drawing.Color.White;
            this.btnRamdom.Size = new System.Drawing.Size(99, 42);
            this.btnRamdom.SuperSelected = false;
            this.btnRamdom.TabIndex = 5;
            this.btnRamdom.TextColor = System.Drawing.Color.White;
            this.btnRamdom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdom.Click += new System.EventHandler(this.btnRamdom_Click);
            // 
            // gvPhongBan
            // 
            this.gvPhongBan.AllowUserToAddRows = false;
            this.gvPhongBan.AllowUserToDeleteRows = false;
            this.gvPhongBan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPhongBan.Location = new System.Drawing.Point(525, 28);
            this.gvPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.gvPhongBan.Name = "gvPhongBan";
            this.gvPhongBan.ReadOnly = true;
            this.gvPhongBan.RowHeadersWidth = 51;
            this.gvPhongBan.Size = new System.Drawing.Size(848, 708);
            this.gvPhongBan.TabIndex = 8;
            this.gvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPhongBan_CellClick);
            this.gvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPhongBan_CellContentClick);
            // 
            // ucPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvPhongBan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPhongBan";
            this.Size = new System.Drawing.Size(1373, 736);
            this.Load += new System.EventHandler(this.ucPhongBan_Load);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTichPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtDienTichPhong;
        private System.Windows.Forms.NumericUpDown txtSoPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtViTriPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private XanderUI.XUISuperButton btnRamdom;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUIRadio rdCoSan;
        private XanderUI.XUIRadio rdDangDung;
        private XanderUI.XUISuperButton btnLamLai;
        private XanderUI.XUISuperButton btnXoa;
        private XanderUI.XUISuperButton btnSua;
        private XanderUI.XUISuperButton btnThem;
        private System.Windows.Forms.DataGridView gvPhongBan;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
    }
}
