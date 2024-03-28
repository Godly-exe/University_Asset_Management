namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmThongTinCaNhan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiSuperButton4 = new XanderUI.XUISuperButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoiPass = new XanderUI.XUIButton();
            this.btnLuuLai = new XanderUI.XUIButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnDoiPass);
            this.panel2.Controls.Add(this.btnLuuLai);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDisplayName);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 471);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.xuiSuperButton4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(367, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 471);
            this.panel1.TabIndex = 2;
            // 
            // xuiSuperButton4
            // 
            this.xuiSuperButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiSuperButton4.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_close_window_48px;
            this.xuiSuperButton4.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton4.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton4.ButtonText = "";
            this.xuiSuperButton4.CornerRadius = 5;
            this.xuiSuperButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton4.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton4.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton4.Location = new System.Drawing.Point(170, 4);
            this.xuiSuperButton4.Margin = new System.Windows.Forms.Padding(4);
            this.xuiSuperButton4.Name = "xuiSuperButton4";
            this.xuiSuperButton4.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton4.SelectedTextColor = System.Drawing.Color.Black;
            this.xuiSuperButton4.Size = new System.Drawing.Size(33, 27);
            this.xuiSuperButton4.SuperSelected = false;
            this.xuiSuperButton4.TabIndex = 6;
            this.xuiSuperButton4.TextColor = System.Drawing.Color.Black;
            this.xuiSuperButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton4.Click += new System.EventHandler(this.xuiSuperButton4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(4, 506);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Copyright @ TrungCNTT";
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.btnDoiPass.ButtonImage = null;
            this.btnDoiPass.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDoiPass.ButtonText = "Đổi Mật Khẩu";
            this.btnDoiPass.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDoiPass.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiPass.CornerRadius = 5;
            this.btnDoiPass.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDoiPass.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDoiPass.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiPass.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDoiPass.Location = new System.Drawing.Point(248, 383);
            this.btnDoiPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(111, 42);
            this.btnDoiPass.TabIndex = 3;
            this.btnDoiPass.TextColor = System.Drawing.Color.White;
            this.btnDoiPass.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnLuuLai.ButtonImage = null;
            this.btnLuuLai.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLuuLai.ButtonText = "Lưu Lại";
            this.btnLuuLai.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLuuLai.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLuuLai.CornerRadius = 5;
            this.btnLuuLai.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuuLai.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLuuLai.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLuuLai.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLuuLai.Location = new System.Drawing.Point(23, 383);
            this.btnLuuLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(111, 42);
            this.btnLuuLai.TabIndex = 3;
            this.btnLuuLai.TextColor = System.Drawing.Color.White;
            this.btnLuuLai.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(23, 316);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 34);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(26, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDisplayName.Location = new System.Drawing.Point(23, 244);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(336, 34);
            this.txtDisplayName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.Location = new System.Drawing.Point(23, 163);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(336, 34);
            this.txtUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(26, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Hiện Thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // fmThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 471);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cá Nhân";
            this.Load += new System.EventHandler(this.fmThongTinCaNhan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnDoiPass;
        private XanderUI.XUIButton btnLuuLai;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISuperButton xuiSuperButton4;
        private System.Windows.Forms.Label label5;
    }
}