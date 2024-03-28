namespace UI_UX_Dashboard_P1
{
    partial class ucSuaChuaBaoHanh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSuaChuaBaoHanh));
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnRefesh = new System.Windows.Forms.ToolStripButton();
            this.cbbTimKiem = new System.Windows.Forms.ToolStripComboBox();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnXuatFile = new System.Windows.Forms.ToolStripButton();
            this.gvDanhSachSuaChua = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip_SuaChuaBaoHanh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Duyet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_LamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.xuiCustomToolstrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSuaChua)).BeginInit();
            this.ContextMenuStrip_SuaChuaBaoHanh.SuspendLayout();
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
            this.btnThem,
            this.btnRefesh,
            this.cbbTimKiem,
            this.txtTimKiem,
            this.btnTimKiem,
            this.btnXuatFile});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1549, 28);
            this.xuiCustomToolstrip1.TabIndex = 4;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_add_48px;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 25);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.btnRefesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(77, 25);
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên"});
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(160, 28);
            this.cbbTimKiem.Text = "Tìm kiếm theo";
            this.cbbTimKiem.ToolTipText = "Chọn tìm kiếm theo";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(399, 28);
            this.txtTimKiem.ToolTipText = "Tìm Kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.toolStripTimKiem_TextChanged);
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
            // gvDanhSachSuaChua
            // 
            this.gvDanhSachSuaChua.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvDanhSachSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachSuaChua.ContextMenuStrip = this.ContextMenuStrip_SuaChuaBaoHanh;
            this.gvDanhSachSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachSuaChua.Location = new System.Drawing.Point(0, 28);
            this.gvDanhSachSuaChua.Margin = new System.Windows.Forms.Padding(4);
            this.gvDanhSachSuaChua.Name = "gvDanhSachSuaChua";
            this.gvDanhSachSuaChua.RowHeadersWidth = 51;
            this.gvDanhSachSuaChua.Size = new System.Drawing.Size(1549, 758);
            this.gvDanhSachSuaChua.TabIndex = 10;
            this.gvDanhSachSuaChua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachSuaChua_CellContentClick);
            this.gvDanhSachSuaChua.SelectionChanged += new System.EventHandler(this.gvDanhSachSuaChua_SelectionChanged);
            // 
            // ContextMenuStrip_SuaChuaBaoHanh
            // 
            this.ContextMenuStrip_SuaChuaBaoHanh.BackColor = System.Drawing.Color.Lavender;
            this.ContextMenuStrip_SuaChuaBaoHanh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip_SuaChuaBaoHanh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Xoa,
            this.toolStripSeparator8,
            this.ToolStripMenuItem_Duyet,
            this.ToolStripMenuItem_LamMoi});
            this.ContextMenuStrip_SuaChuaBaoHanh.Name = "contextMenuStrip1";
            this.ContextMenuStrip_SuaChuaBaoHanh.Size = new System.Drawing.Size(141, 88);
            // 
            // ToolStripMenuItem_Xoa
            // 
            this.ToolStripMenuItem_Xoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Xoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToolStripMenuItem_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Xoa.Image")));
            this.ToolStripMenuItem_Xoa.Name = "ToolStripMenuItem_Xoa";
            this.ToolStripMenuItem_Xoa.Size = new System.Drawing.Size(140, 26);
            this.ToolStripMenuItem_Xoa.Text = "Xóa ";
            this.ToolStripMenuItem_Xoa.Click += new System.EventHandler(this.ToolStripMenuItem_Xoa_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(137, 6);
            // 
            // ToolStripMenuItem_Duyet
            // 
            this.ToolStripMenuItem_Duyet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Duyet.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToolStripMenuItem_Duyet.Image = global::UI_UX_Dashboard_P1.Properties.Resources.suachua;
            this.ToolStripMenuItem_Duyet.Name = "ToolStripMenuItem_Duyet";
            this.ToolStripMenuItem_Duyet.Size = new System.Drawing.Size(140, 26);
            this.ToolStripMenuItem_Duyet.Text = "Duyệt";
            this.ToolStripMenuItem_Duyet.Click += new System.EventHandler(this.ToolStripMenuItem_Duyet_Click);
            // 
            // ToolStripMenuItem_LamMoi
            // 
            this.ToolStripMenuItem_LamMoi.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.ToolStripMenuItem_LamMoi.Name = "ToolStripMenuItem_LamMoi";
            this.ToolStripMenuItem_LamMoi.Size = new System.Drawing.Size(140, 26);
            this.ToolStripMenuItem_LamMoi.Text = "Lam mới";
            this.ToolStripMenuItem_LamMoi.Click += new System.EventHandler(this.ToolStripMenuItem_LamMoi_Click);
            // 
            // ucSuaChuaBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDanhSachSuaChua);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSuaChuaBaoHanh";
            this.Size = new System.Drawing.Size(1549, 786);
            this.Load += new System.EventHandler(this.ucSuaChuaBaoHanh_Load);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSuaChua)).EndInit();
            this.ContextMenuStrip_SuaChuaBaoHanh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.DataGridView gvDanhSachSuaChua;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnRefesh;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_SuaChuaBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Duyet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_LamMoi;
    }
}
