using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1.FormUI
{
    public partial class fmDanhSachTaiSan : Form
    {
        public fmDanhSachTaiSan()
        {
            InitializeComponent();
        }

        private void fmDanhSachTaiSan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        DataTable dt = new DataTable();
        private void loadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT TaiSan.MaTaiSan,TaiSan.TenTaiSan,TaiSan.Gia,LoaiTaiSan.TenLoaiTaiSan,DonViTinh.TenDonViTinh,NhaCungCap.TenNhaCungCap,TaiSan.HinhMinhHoa,TaiSan.GhiChu,TaiSan.TrangThai,TaiSan.NgayNhap,NhanVien.TenNhanVien,TaiSan.ThongSoKyThuat,TaiSan.ThoiGianTinhKhauHau,TaiSan.ThoiGianBaoHanh,Phong.TenPhong FROM TaiSan, LoaiTaiSan, DonViTinh, NhaCungCap, NhanVien, Phong WHERE TaiSan.MaLoaiTaiSan = LoaiTaiSan.MaLoaiTaiSan AND TaiSan.MaDonViTinh = DonViTinh.MaDonViTinh AND TaiSan.MaNhaCungCap = NhaCungCap.MaNhaCungCap AND TaiSan.MaNguoiNhap = NhanVien.MaNhanVien AND TaiSan.MaPhong = Phong.MaPhong";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            
            dt.Load(sdr);
           

            gvDanhSachTaiSan.DataSource = dt;
            gvDanhSachTaiSan.Columns[0].HeaderText = "Mã Thiết Bị";
            gvDanhSachTaiSan.Columns[1].HeaderText = "Tên Thiết Bị";
            gvDanhSachTaiSan.Columns[2].HeaderText = "Giá";
            gvDanhSachTaiSan.Columns[3].HeaderText = "Loại Thiết Bị";
            gvDanhSachTaiSan.Columns[4].HeaderText = "Đơn Vị Tính";
            gvDanhSachTaiSan.Columns[5].HeaderText = "Nhà Cung Cấp";

            //  gvDanhSachTaiSan.Columns[6].HeaderText = "Hình Ảnh";
            gvDanhSachTaiSan.Columns[6].Visible = false;
          //  gvDanhSachTaiSan.Columns[7].HeaderText = "Số Lượng";
            gvDanhSachTaiSan.Columns[7].HeaderText = "Ghi Chú";
            gvDanhSachTaiSan.Columns[8].HeaderText = "Trạng Thái";

            gvDanhSachTaiSan.Columns[9].HeaderText = "Ngày Nhập";
            gvDanhSachTaiSan.Columns[10].HeaderText = "Người Nhập";
            gvDanhSachTaiSan.Columns[11].HeaderText = "Thông Số Kỹ Thuật";
            gvDanhSachTaiSan.Columns[12].HeaderText = "Thời Gian Tính Khấu Hao";

            gvDanhSachTaiSan.Columns[13].HeaderText = "Thời Gian Bảo Hành";
            gvDanhSachTaiSan.Columns[14].HeaderText = "Vị Trí";



            gvDanhSachTaiSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void hieuChinhDatatble(DataTable dt)

        {
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i][8].ToString() == "1")
                    dt.Rows[i][8] = "Đã Duyệt";
                else
                    dt.Rows[i][8] = "Chưa duyệt";
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            fmThemTaiSan fm = new fmThemTaiSan();
            fm.ShowDialog();
        }
       
        private void toolStripBTNRefesh_Click(object sender, EventArgs e)
        {
            ClearGrid();
          
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvDanhSachTaiSan.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_ThietBi";
                MyFunctions.export2Excel(gvDanhSachTaiSan, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void timKiem()
        {
            string choice = "";
            if (cbbTimKiem.SelectedIndex > 0)
            {
                choice = cbbTimKiem.SelectedItem.ToString();
            }
            DataView dv = dt.DefaultView;
            switch (choice)
            {
                case "Tìm theo mã":
                    dv.RowFilter = string.Format("MaTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachTaiSan.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachTaiSan.DataSource = dv.ToTable();
                    break;
                
                default:
                    dv.RowFilter = string.Format("MaTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachTaiSan.DataSource = dv.ToTable();
                    break;
            }

        }
        private void ClearGrid()
        {
            do
            {
                foreach (DataGridViewRow row in gvDanhSachTaiSan.Rows)
                {
                    try
                    {
                        gvDanhSachTaiSan.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gvDanhSachTaiSan.Rows.Count > 1);

            loadData();
        }
        string mataisan;
        private void gvDanhSachTaiSan_SelectionChanged(object sender, EventArgs e)
        {
            string a;
            if (gvDanhSachTaiSan.CurrentRow != null)
            {

                a = gvDanhSachTaiSan.CurrentRow.Cells[0].Value.ToString();

                mataisan = a;

            }
        }

        private void ToolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (mataisan != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM TaiSan WHERE MaTaiSan='" + mataisan + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearGrid();

                        }
                        else
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("Không làm gì", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItem_Sửa_Click(object sender, EventArgs e)
        {
            fmSuaTaiSan fm = new fmSuaTaiSan(mataisan);
            fm.ShowDialog();
        }

        private void gvDanhSachTaiSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
