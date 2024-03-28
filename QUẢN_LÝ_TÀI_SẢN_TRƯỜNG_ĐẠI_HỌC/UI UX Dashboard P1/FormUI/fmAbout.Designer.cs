namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiSuperButton4 = new XanderUI.XUISuperButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(323, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhóm 8 - 20DTHB1";
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.CornflowerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(197, 500);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 3;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
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
            this.xuiSuperButton4.Location = new System.Drawing.Point(945, 0);
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(385, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "IT - HUTECH";
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuiSuperButton4);
            this.Controls.Add(this.xuiSlidingPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUISuperButton xuiSuperButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}