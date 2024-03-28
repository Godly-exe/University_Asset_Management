namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmChuyenPhong
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
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChuyen = new XanderUI.XUISuperButton();
            this.SuspendLayout();
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(7, 63);
            this.cbbPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(403, 40);
            this.cbbPhongBan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(53, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Vị Trí Cần Chuyển";
            // 
            // btnChuyen
            // 
            this.btnChuyen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChuyen.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.btnChuyen.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnChuyen.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnChuyen.ButtonText = "Chuyển";
            this.btnChuyen.CornerRadius = 5;
            this.btnChuyen.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChuyen.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnChuyen.HoverTextColor = System.Drawing.Color.White;
            this.btnChuyen.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnChuyen.Location = new System.Drawing.Point(144, 111);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnChuyen.SelectedTextColor = System.Drawing.Color.White;
            this.btnChuyen.Size = new System.Drawing.Size(159, 39);
            this.btnChuyen.SuperSelected = false;
            this.btnChuyen.TabIndex = 1;
            this.btnChuyen.TextColor = System.Drawing.Color.White;
            this.btnChuyen.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // fmChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(444, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.cbbPhongBan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmChuyenPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Phòng";
            this.Load += new System.EventHandler(this.fmChuyenPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUISuperButton btnChuyen;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.Label label1;
    }
}