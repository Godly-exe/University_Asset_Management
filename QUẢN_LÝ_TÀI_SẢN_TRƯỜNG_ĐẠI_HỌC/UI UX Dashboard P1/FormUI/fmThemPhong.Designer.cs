namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmThemPhong
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
            this.btnThoat = new XanderUI.XUIButton();
            this.btnLuu = new XanderUI.XUIButton();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.NumericUpDown();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRamdo = new XanderUI.XUISuperButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.ButtonImage = null;
            this.btnThoat.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(293, 405);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 32);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.ButtonImage = null;
            this.btnLuu.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.CornerRadius = 5;
            this.btnLuu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLuu.Location = new System.Drawing.Point(175, 405);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 32);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(80, 175);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(405, 30);
            this.txtTenPhong.TabIndex = 16;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(80, 95);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(405, 30);
            this.txtMaPhong.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(75, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(75, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(196, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 53);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÊM PHÒNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(75, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "Diện Tích (m   )";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(80, 270);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienTich.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(407, 32);
            this.txtDienTich.TabIndex = 27;
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.Location = new System.Drawing.Point(80, 350);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(405, 30);
            this.txtViTri.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(75, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Vị Trí";
            // 
            // btnRamdo
            // 
            this.btnRamdo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRamdo.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_process_48px;
            this.btnRamdo.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.btnRamdo.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRamdo.ButtonText = "";
            this.btnRamdo.CornerRadius = 5;
            this.btnRamdo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnRamdo.HoverTextColor = System.Drawing.Color.White;
            this.btnRamdo.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRamdo.Location = new System.Drawing.Point(495, 95);
            this.btnRamdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRamdo.Name = "btnRamdo";
            this.btnRamdo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnRamdo.SelectedTextColor = System.Drawing.Color.White;
            this.btnRamdo.Size = new System.Drawing.Size(36, 33);
            this.btnRamdo.SuperSelected = false;
            this.btnRamdo.TabIndex = 17;
            this.btnRamdo.TextColor = System.Drawing.Color.White;
            this.btnRamdo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdo.Click += new System.EventHandler(this.btnRamdo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(225, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "2";
            // 
            // fmThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(563, 459);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnRamdo);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnThoat;
        private XanderUI.XUIButton btnLuu;
        private XanderUI.XUISuperButton btnRamdo;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtDienTich;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}