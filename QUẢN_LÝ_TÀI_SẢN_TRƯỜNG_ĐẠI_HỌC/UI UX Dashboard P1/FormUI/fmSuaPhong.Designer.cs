namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmSuaPhong
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new XanderUI.XUIButton();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(123, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 53);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sửa Phòng ";
            // 
            // btnSua
            // 
            this.btnSua.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.ButtonImage = null;
            this.btnSua.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnSua.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnSua.CornerRadius = 5;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnSua.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnSua.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSua.Location = new System.Drawing.Point(156, 352);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 42);
            this.btnSua.TabIndex = 16;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSửa_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.Black;
            this.txtTenPhong.Location = new System.Drawing.Point(24, 129);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(435, 34);
            this.txtTenPhong.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(13, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vị Trí";
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtViTri.ForeColor = System.Drawing.Color.Black;
            this.txtViTri.Location = new System.Drawing.Point(21, 309);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(435, 34);
            this.txtViTri.TabIndex = 14;
            // 
            // txtDienTich
            // 
            this.txtDienTich.BackColor = System.Drawing.Color.White;
            this.txtDienTich.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.ForeColor = System.Drawing.Color.Crimson;
            this.txtDienTich.Location = new System.Drawing.Point(24, 223);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(436, 37);
            this.txtDienTich.TabIndex = 19;
            // 
            // fmSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(488, 444);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSuaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Phòng";
            this.Load += new System.EventHandler(this.fmSuaPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton btnSua;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.NumericUpDown txtDienTich;
    }
}