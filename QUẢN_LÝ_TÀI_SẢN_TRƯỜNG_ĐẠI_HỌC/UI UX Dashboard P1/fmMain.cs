using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.FormUI;

namespace UI_UX_Dashboard_P1
{
    public partial class fmMain : Form
    {
        string tendangnhap;
        string user;
        public fmMain(string displayname, string username)
        {
           // Thread t = new Thread(new ThreadStart(StartFrom));
          // t.Start();
          //  Thread.Sleep(5000);
            InitializeComponent();
            tendangnhap = displayname;
            user = username;
          //  t.Abort();
        }

        private void StartFrom()
        {
            Application.Run(new fmLoadding());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thu gon menu và mở rộng menu
            if (pnMenuLeft.Width <= 50)
            {
                pnMenuLeft.Visible = true;
                pnMenuLeft.Width = 223;
                this.pnMenuLeft.Location = new System.Drawing.Point(174, 7);
            }
            else
            {

                pnMenuLeft.Visible = true;
                pnMenuLeft.Width = 50;
                this.pnMenuLeft.Location = new System.Drawing.Point(1, 7);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
            lbBreadCrumb.Text = "Home";

            lbNguoiDangNhap.Text = tendangnhap;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
            lbBreadCrumb.Text = "Home";
        }

        private void btnQuanLyLTS_Click(object sender, EventArgs e)
        {
            ucLoaiTaiSan1.BringToFront();
            lbBreadCrumb.Text = "Quản Lý Loại Thiết Bị";
        }

        private void btnTaiSan_Click(object sender, EventArgs e)
        {
            ucTaiSan1.BringToFront();
            lbBreadCrumb.Text = "Quản Lý Thiết Bị";
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ucNhaCungCap1.BringToFront();
            lbBreadCrumb.Text = "Nhà Cung Cấp";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ucNhanVien1.BringToFront();
            lbBreadCrumb.Text = "Nhân Viên";
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            ucPhongBan1.BringToFront();
            lbBreadCrumb.Text = "Phòng Ban";
        }

        private void btnDonViTinh_Click(object sender, EventArgs e)
        {
            ucDonViTinh1.BringToFront();
            lbBreadCrumb.Text = "Đơn Vị Tính";
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            ucThanhLy1.BringToFront();
            lbBreadCrumb.Text = "Thanh Lý";
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            ucSuaChuaBaoHanh1.BringToFront();
            lbBreadCrumb.Text = "Bảo Hành - Sửa Chữa";
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            //ucKiemKe1.BringToFront();
            //lbBreadCrumb.Text = "Kiểm Kê";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Bạn đăng cố gắng đang xuất!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                fmLogin fm = new fmLogin();
                fm.ShowDialog();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update for new version...!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở phiên bản mới nhất", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            fmAbout fm = new fmAbout();
            fm.ShowDialog();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            ucDatPhong1.BringToFront();
            lbBreadCrumb.Text = "Đặt Phòng";
        }

        //button setting
        private void button19_Click(object sender, EventArgs e)
        {
            fmThongTinCaNhan fm = new fmThongTinCaNhan(user);
            fm.ShowDialog();
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            fmListUser fm = new fmListUser();
            fm.ShowDialog();
        }

        private void ucDatPhong1_Load(object sender, EventArgs e)
        {

        }
    }
}
