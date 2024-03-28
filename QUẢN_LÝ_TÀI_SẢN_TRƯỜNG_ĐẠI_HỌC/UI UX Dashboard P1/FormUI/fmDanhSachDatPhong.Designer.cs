namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmDanhSachDatPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDanhSachDatPhong));
            this.gvDanhSachDatPhong = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip_ListUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_TraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_LamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.toolStripBTNRefesh = new System.Windows.Forms.ToolStripButton();
            this.cbbTimKiem = new System.Windows.Forms.ToolStripComboBox();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnXuatFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachDatPhong)).BeginInit();
            this.ContextMenuStrip_ListUser.SuspendLayout();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDanhSachDatPhong
            // 
            this.gvDanhSachDatPhong.BackgroundColor = System.Drawing.Color.Khaki;
            this.gvDanhSachDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachDatPhong.ContextMenuStrip = this.ContextMenuStrip_ListUser;
            this.gvDanhSachDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachDatPhong.Location = new System.Drawing.Point(0, 28);
            this.gvDanhSachDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.gvDanhSachDatPhong.Name = "gvDanhSachDatPhong";
            this.gvDanhSachDatPhong.RowHeadersWidth = 51;
            this.gvDanhSachDatPhong.Size = new System.Drawing.Size(1264, 623);
            this.gvDanhSachDatPhong.TabIndex = 7;
            this.gvDanhSachDatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachDatPhong_CellContentClick);
            this.gvDanhSachDatPhong.SelectionChanged += new System.EventHandler(this.gvDanhSachDatPhong_SelectionChanged);
            // 
            // ContextMenuStrip_ListUser
            // 
            this.ContextMenuStrip_ListUser.BackColor = System.Drawing.Color.Lavender;
            this.ContextMenuStrip_ListUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip_ListUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Xoa,
            this.toolStripSeparator8,
            this.ToolStripMenuItem_TraPhong,
            this.ToolStripMenuItem_LamMoi});
            this.ContextMenuStrip_ListUser.Name = "contextMenuStrip1";
            this.ContextMenuStrip_ListUser.Size = new System.Drawing.Size(159, 88);
            // 
            // ToolStripMenuItem_Xoa
            // 
            this.ToolStripMenuItem_Xoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Xoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToolStripMenuItem_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Xoa.Image")));
            this.ToolStripMenuItem_Xoa.Name = "ToolStripMenuItem_Xoa";
            this.ToolStripMenuItem_Xoa.Size = new System.Drawing.Size(158, 26);
            this.ToolStripMenuItem_Xoa.Text = "Xóa ";
            this.ToolStripMenuItem_Xoa.Click += new System.EventHandler(this.ToolStripMenuItem_Xoa_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(155, 6);
            // 
            // ToolStripMenuItem_TraPhong
            // 
            this.ToolStripMenuItem_TraPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_TraPhong.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToolStripMenuItem_TraPhong.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_cloud_backup_restore_64px;
            this.ToolStripMenuItem_TraPhong.Name = "ToolStripMenuItem_TraPhong";
            this.ToolStripMenuItem_TraPhong.Size = new System.Drawing.Size(158, 26);
            this.ToolStripMenuItem_TraPhong.Text = "Trả phòng";
            this.ToolStripMenuItem_TraPhong.Click += new System.EventHandler(this.ToolStripMenuItem_TraPhong_Click);
            // 
            // ToolStripMenuItem_LamMoi
            // 
            this.ToolStripMenuItem_LamMoi.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.ToolStripMenuItem_LamMoi.Name = "ToolStripMenuItem_LamMoi";
            this.ToolStripMenuItem_LamMoi.Size = new System.Drawing.Size(158, 26);
            this.ToolStripMenuItem_LamMoi.Text = "Lam mới";
            this.ToolStripMenuItem_LamMoi.Click += new System.EventHandler(this.ToolStripMenuItem_LamMoi_Click);
            // 
            // xuiCustomToolstrip1
            // 
            this.xuiCustomToolstrip1.BackColor = System.Drawing.Color.White;
            this.xuiCustomToolstrip1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.xuiCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBTNRefesh,
            this.cbbTimKiem,
            this.txtTimKiem,
            this.btnTimKiem,
            this.btnXuatFile,
            this.toolStripButton1});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1264, 28);
            this.xuiCustomToolstrip1.TabIndex = 8;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // toolStripBTNRefesh
            // 
            this.toolStripBTNRefesh.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px1;
            this.toolStripBTNRefesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBTNRefesh.Name = "toolStripBTNRefesh";
            this.toolStripBTNRefesh.Size = new System.Drawing.Size(91, 25);
            this.toolStripBTNRefesh.Text = "Làm Mới";
            this.toolStripBTNRefesh.ToolTipText = "Load Data";
            this.toolStripBTNRefesh.Click += new System.EventHandler(this.toolStripBTNRefesh_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên phòng"});
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(160, 28);
            this.cbbTimKiem.Text = "Tìm kiếm theo...";
            this.cbbTimKiem.ToolTipText = "Chọn tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(399, 28);
            this.txtTimKiem.ToolTipText = "Tìm Kiếm";
            this.txtTimKiem.VisibleChanged += new System.EventHandler(this.txtTimKiem_VisibleChanged);
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
            this.btnXuatFile.Image = global::UI_UX_Dashboard_P1.Properties.Resources.thoat1;
            this.btnXuatFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(128, 25);
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // fmDanhSachDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.gvDanhSachDatPhong);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmDanhSachDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đặt Phòng";
            this.Load += new System.EventHandler(this.fmDanhSachDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachDatPhong)).EndInit();
            this.ContextMenuStrip_ListUser.ResumeLayout(false);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDanhSachDatPhong;
        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.ToolStripButton toolStripBTNRefesh;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_ListUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TraPhong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_LamMoi;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}