namespace UI_UX_Dashboard_P1
{
    partial class ucTaiSan
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
            this.toolStripBTNDanhSach = new System.Windows.Forms.ToolStripButton();
            this.toolStripBTNLoad = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.xuiCustomToolstrip1.SuspendLayout();
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
            this.toolStripBTNDanhSach,
            this.toolStripBTNLoad,
            this.txtTimKiem,
            this.btnTimKiem});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1447, 30);
            this.xuiCustomToolstrip1.TabIndex = 1;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripButton1.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_add_48px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 27);
            this.toolStripButton1.Text = "Thêm";
            this.toolStripButton1.ToolTipText = "Thêm Tài Sản";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripBTNThem_Click);
            // 
            // toolStripBTNDanhSach
            // 
            this.toolStripBTNDanhSach.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_list_48px;
            this.toolStripBTNDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBTNDanhSach.Name = "toolStripBTNDanhSach";
            this.toolStripBTNDanhSach.Size = new System.Drawing.Size(101, 27);
            this.toolStripBTNDanhSach.Text = "Danh sách";
            this.toolStripBTNDanhSach.Click += new System.EventHandler(this.toolStripBTNDanhSach_Click);
            // 
            // toolStripBTNLoad
            // 
            this.toolStripBTNLoad.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.toolStripBTNLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBTNLoad.Name = "toolStripBTNLoad";
            this.toolStripBTNLoad.Size = new System.Drawing.Size(82, 27);
            this.toolStripBTNLoad.Text = "Refresh";
            this.toolStripBTNLoad.Click += new System.EventHandler(this.toolStripBTNLoad_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(399, 30);
            this.txtTimKiem.ToolTipText = "Tìm Kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_search_48px;
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 27);
            this.btnTimKiem.Text = "Search";
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 30);
            this.xuiSlidingPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(60, 667);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 2;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 30);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1387, 667);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ucTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.xuiSlidingPanel1);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTaiSan";
            this.Size = new System.Drawing.Size(1447, 697);
            this.Load += new System.EventHandler(this.ucTaiSan_Load);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripButton toolStripBTNLoad;
        private System.Windows.Forms.ToolStripButton toolStripBTNDanhSach;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
