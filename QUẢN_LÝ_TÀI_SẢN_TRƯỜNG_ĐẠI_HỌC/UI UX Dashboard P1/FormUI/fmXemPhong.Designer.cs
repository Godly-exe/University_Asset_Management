namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmXemPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvDanhSachTaiSan = new System.Windows.Forms.DataGridView();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViTriPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatBaoCao = new XanderUI.XUISuperButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongSoTaiSan = new System.Windows.Forms.Label();
            this.btnXoa = new XanderUI.XUISuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachTaiSan
            // 
            this.gvDanhSachTaiSan.BackgroundColor = System.Drawing.Color.Khaki;
            this.gvDanhSachTaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachTaiSan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvDanhSachTaiSan.Location = new System.Drawing.Point(0, 309);
            this.gvDanhSachTaiSan.Margin = new System.Windows.Forms.Padding(4);
            this.gvDanhSachTaiSan.Name = "gvDanhSachTaiSan";
            this.gvDanhSachTaiSan.RowHeadersWidth = 51;
            this.gvDanhSachTaiSan.Size = new System.Drawing.Size(1449, 420);
            this.gvDanhSachTaiSan.TabIndex = 0;
            this.gvDanhSachTaiSan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachTaiSan_CellContentClick);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.ForeColor = System.Drawing.Color.Lime;
            this.txtDienTich.Location = new System.Drawing.Point(113, 114);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(405, 30);
            this.txtDienTich.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(108, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Diện Tích Phòng: (m   )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(563, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÔNG TIN PHÒNG: ";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenPhong.ForeColor = System.Drawing.Color.Crimson;
            this.lbTenPhong.Location = new System.Drawing.Point(795, 11);
            this.lbTenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(40, 41);
            this.lbTenPhong.TabIndex = 15;
            this.lbTenPhong.Text = "lb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(531, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vị Trí Phòng:";
            // 
            // txtViTriPhong
            // 
            this.txtViTriPhong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriPhong.ForeColor = System.Drawing.Color.Lime;
            this.txtViTriPhong.Location = new System.Drawing.Point(536, 114);
            this.txtViTriPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtViTriPhong.Name = "txtViTriPhong";
            this.txtViTriPhong.ReadOnly = true;
            this.txtViTriPhong.Size = new System.Drawing.Size(405, 30);
            this.txtViTriPhong.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(949, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trạng Thái Phòng:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.ForeColor = System.Drawing.Color.Lime;
            this.txtTrangThai.Location = new System.Drawing.Point(955, 114);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(405, 30);
            this.txtTrangThai.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(351, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "2";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Crimson;
            this.txtTimKiem.Location = new System.Drawing.Point(431, 270);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 30);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_search_48px;
            this.btnTimKiem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTimKiem.ButtonText = "";
            this.btnTimKiem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTimKiem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.CornerRadius = 5;
            this.btnTimKiem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTimKiem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTimKiem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTimKiem.Location = new System.Drawing.Point(845, 270);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(37, 32);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(253, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 5);
            this.panel1.TabIndex = 19;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnXuatBaoCao.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_print_80px;
            this.btnXuatBaoCao.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnXuatBaoCao.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnXuatBaoCao.ButtonText = "Xuất Báo Cáo";
            this.btnXuatBaoCao.CornerRadius = 5;
            this.btnXuatBaoCao.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXuatBaoCao.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnXuatBaoCao.HoverTextColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(891, 270);
            this.btnXuatBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnXuatBaoCao.SelectedTextColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Size = new System.Drawing.Size(144, 32);
            this.btnXuatBaoCao.SuperSelected = false;
            this.btnXuatBaoCao.TabIndex = 20;
            this.btnXuatBaoCao.TextColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(531, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phòng Đang Chứa:";
            // 
            // lbTongSoTaiSan
            // 
            this.lbTongSoTaiSan.AutoSize = true;
            this.lbTongSoTaiSan.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongSoTaiSan.ForeColor = System.Drawing.Color.Crimson;
            this.lbTongSoTaiSan.Location = new System.Drawing.Point(772, 176);
            this.lbTongSoTaiSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongSoTaiSan.Name = "lbTongSoTaiSan";
            this.lbTongSoTaiSan.Size = new System.Drawing.Size(34, 36);
            this.lbTongSoTaiSan.TabIndex = 15;
            this.lbTongSoTaiSan.Text = "lb";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnXoa.ButtonImage = null;
            this.btnXoa.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnXoa.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnXoa.ButtonText = "Xóa Phòng";
            this.btnXoa.CornerRadius = 5;
            this.btnXoa.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnXoa.HoverTextColor = System.Drawing.Color.White;
            this.btnXoa.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnXoa.Location = new System.Drawing.Point(1043, 270);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.SelectedTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.SuperSelected = false;
            this.btnXoa.TabIndex = 20;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fmXemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1449, 729);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtViTriPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTongSoTaiSan);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDanhSachTaiSan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmXemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Chi Tiết Phòng";
            this.Load += new System.EventHandler(this.fmXemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTaiSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDanhSachTaiSan;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViTriPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private XanderUI.XUIButton btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISuperButton btnXuatBaoCao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTongSoTaiSan;
        private XanderUI.XUISuperButton btnXoa;
    }
}