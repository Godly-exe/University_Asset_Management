namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmDoiPass
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
            this.btnOK = new XanderUI.XUIButton();
            this.txtPassword_Old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword_New = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword_ReNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.ButtonImage = null;
            this.btnOK.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOK.ButtonText = "Lưu Lại";
            this.btnOK.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnOK.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.CornerRadius = 5;
            this.btnOK.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOK.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOK.Location = new System.Drawing.Point(162, 277);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 42);
            this.btnOK.TabIndex = 8;
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPassword_Old
            // 
            this.txtPassword_Old.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword_Old.Location = new System.Drawing.Point(21, 42);
            this.txtPassword_Old.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword_Old.Name = "txtPassword_Old";
            this.txtPassword_Old.Size = new System.Drawing.Size(404, 34);
            this.txtPassword_Old.TabIndex = 6;
            this.txtPassword_Old.UseSystemPasswordChar = true;
            this.txtPassword_Old.TextChanged += new System.EventHandler(this.txtPassword_Old_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật Khẩu Mới";
            // 
            // txtPassword_New
            // 
            this.txtPassword_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword_New.Location = new System.Drawing.Point(21, 128);
            this.txtPassword_New.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword_New.Name = "txtPassword_New";
            this.txtPassword_New.Size = new System.Drawing.Size(404, 34);
            this.txtPassword_New.TabIndex = 6;
            this.txtPassword_New.UseSystemPasswordChar = true;
            this.txtPassword_New.TextChanged += new System.EventHandler(this.txtPassword_New_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtPassword_ReNew
            // 
            this.txtPassword_ReNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword_ReNew.Location = new System.Drawing.Point(21, 215);
            this.txtPassword_ReNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword_ReNew.Name = "txtPassword_ReNew";
            this.txtPassword_ReNew.Size = new System.Drawing.Size(404, 34);
            this.txtPassword_ReNew.TabIndex = 6;
            this.txtPassword_ReNew.UseSystemPasswordChar = true;
            this.txtPassword_ReNew.TextChanged += new System.EventHandler(this.txtPassword_ReNew_TextChanged);
            // 
            // fmDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(447, 342);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword_ReNew);
            this.Controls.Add(this.txtPassword_New);
            this.Controls.Add(this.txtPassword_Old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDoiPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnOK;
        private System.Windows.Forms.TextBox txtPassword_Old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword_New;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword_ReNew;
    }
}