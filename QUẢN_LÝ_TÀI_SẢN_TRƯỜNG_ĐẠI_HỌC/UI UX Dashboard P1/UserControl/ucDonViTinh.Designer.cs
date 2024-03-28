namespace UI_UX_Dashboard_P1
{
    partial class ucDonViTinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.btnRamdom = new XanderUI.XUISuperButton();
            this.gvDonViTinh = new System.Windows.Forms.DataGridView();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).BeginInit();
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
            this.xuiCustomToolstrip1.TabIndex = 3;
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
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaDonViTinh);
            this.panel1.Controls.Add(this.txtDonViTinh);
            this.panel1.Controls.Add(this.btnRamdom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 708);
            this.panel1.TabIndex = 7;
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
            this.btnLamLai.Location = new System.Drawing.Point(357, 450);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLamLai.SelectedTextColor = System.Drawing.Color.White;
            this.btnLamLai.Size = new System.Drawing.Size(99, 42);
            this.btnLamLai.SuperSelected = false;
            this.btnLamLai.TabIndex = 8;
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
            this.btnXoa.Location = new System.Drawing.Point(251, 450);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.SelectedTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(99, 42);
            this.btnXoa.SuperSelected = false;
            this.btnXoa.TabIndex = 9;
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
            this.btnSua.Location = new System.Drawing.Point(144, 450);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.SelectedTextColor = System.Drawing.Color.White;
            this.btnSua.Size = new System.Drawing.Size(99, 42);
            this.btnSua.SuperSelected = false;
            this.btnSua.TabIndex = 10;
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
            this.btnThem.Location = new System.Drawing.Point(37, 450);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.SelectedTextColor = System.Drawing.Color.White;
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.SuperSelected = false;
            this.btnThem.TabIndex = 11;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Mã Đơn Vị Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập Đơn Vị Tính";
            // 
            // txtMaDonViTinh
            // 
            this.txtMaDonViTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDonViTinh.Location = new System.Drawing.Point(9, 250);
            this.txtMaDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDonViTinh.Name = "txtMaDonViTinh";
            this.txtMaDonViTinh.Size = new System.Drawing.Size(376, 39);
            this.txtMaDonViTinh.TabIndex = 6;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonViTinh.Location = new System.Drawing.Point(9, 342);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(484, 39);
            this.txtDonViTinh.TabIndex = 6;
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
            this.btnRamdom.Location = new System.Drawing.Point(395, 250);
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
            // gvDonViTinh
            // 
            this.gvDonViTinh.AllowUserToAddRows = false;
            this.gvDonViTinh.AllowUserToDeleteRows = false;
            this.gvDonViTinh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDonViTinh.Location = new System.Drawing.Point(525, 28);
            this.gvDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.gvDonViTinh.Name = "gvDonViTinh";
            this.gvDonViTinh.ReadOnly = true;
            this.gvDonViTinh.RowHeadersWidth = 51;
            this.gvDonViTinh.Size = new System.Drawing.Size(848, 708);
            this.gvDonViTinh.TabIndex = 8;
            this.gvDonViTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDonViTinh_CellClick);
            this.gvDonViTinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDonViTinh_CellContentClick);
            // 
            // ucDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDonViTinh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDonViTinh";
            this.Size = new System.Drawing.Size(1373, 736);
            this.Load += new System.EventHandler(this.ucDonViTinh_Load);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDonViTinh;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private XanderUI.XUISuperButton btnRamdom;
        private XanderUI.XUISuperButton btnLamLai;
        private XanderUI.XUISuperButton btnXoa;
        private XanderUI.XUISuperButton btnSua;
        private XanderUI.XUISuperButton btnThem;
        private System.Windows.Forms.DataGridView gvDonViTinh;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
