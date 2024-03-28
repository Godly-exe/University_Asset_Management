using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Library;
using System.Data.SqlClient;
using System.Globalization;
using UI_UX_Dashboard_P1.FormUI;

namespace UI_UX_Dashboard_P1
{
    public partial class ucSuaChuaBaoHanh : UserControl
    {
        public ucSuaChuaBaoHanh()
        {
            InitializeComponent();
        }

        private void ucSuaChuaBaoHanh_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT SuaChuaTaiSan.MaSuaChua,TaiSan.TenTaiSan,SuaChuaTaiSan.NgaySuaChua,SuaChuaTaiSan.GiaSuaChua,NhanVien.TenNhanVien,SuaChuaTaiSan.HinhThucSuaChua,SuaChuaTaiSan.GhiChu,SuaChuaTaiSan.TrangThai FROM SuaChuaTaiSan, TaiSan, NhanVien WHERE SuaChuaTaiSan.MaTaiSan = TaiSan.MaTaiSan AND SuaChuaTaiSan.NguoiSuaChua = NhanVien.MaNhanVien";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
           
            dt.Load(sdr);


            gvDanhSachSuaChua.DataSource = dt;
            gvDanhSachSuaChua.Columns[0].HeaderText = "Mã Sửa Chữa";
            gvDanhSachSuaChua.Columns[1].HeaderText = "Tên Thiết Bị";
            gvDanhSachSuaChua.Columns[2].HeaderText = "Ngày Sửa";
            gvDanhSachSuaChua.Columns[3].HeaderText = "Giá Sửa";
            gvDanhSachSuaChua.Columns[4].HeaderText = "Người Sửa";
            gvDanhSachSuaChua.Columns[5].HeaderText = "Hình Thức Sửa";
            gvDanhSachSuaChua.Columns[6].HeaderText = "Ghi Chú";
            gvDanhSachSuaChua.Columns[7].HeaderText = "Trạng Thái";

            gvDanhSachSuaChua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void gvDanhSachSuaChua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void toolStripTimKiem_TextChanged(object sender, EventArgs e)
        {
            tiemKiem();
        }

        private void tiemKiem()
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
                    dv.RowFilter = string.Format("MaSuaChua Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachSuaChua.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachSuaChua.DataSource = dv.ToTable();
                    break;
              
                default:
                    dv.RowFilter = string.Format("MaSuaChua Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachSuaChua.DataSource = dv.ToTable();
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma="";
            fmBaoHanh fm = new fmBaoHanh(ma);
            fm.ShowDialog();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {


             ClearGrid();
            
          
        }
        private void ClearGrid()
        {
            do
            {
                foreach (DataGridViewRow row in gvDanhSachSuaChua.Rows)
                {
                    try
                    {
                        gvDanhSachSuaChua.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gvDanhSachSuaChua.Rows.Count > 1);

            loadData();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvDanhSachSuaChua.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_SuaChuaBaoHanh";
                MyFunctions.export2Excel(gvDanhSachSuaChua, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string masuachua;
        private void gvDanhSachSuaChua_SelectionChanged(object sender, EventArgs e)
        {
            string a;
            if (gvDanhSachSuaChua.CurrentRow != null)
            {

                a = gvDanhSachSuaChua.CurrentRow.Cells[0].Value.ToString();

                masuachua = a;

            }
        }

        private void ToolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (masuachua != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM SuaChuaTaiSan WHERE MaSuaChua='" + masuachua + "'";
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

        private void ToolStripMenuItem_Duyet_Click(object sender, EventArgs e)
        {
            try
            {
                if (masuachua != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Duyệt?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE SuaChuaTaiSan SET TrangThai=N'Đã sửa' WHERE MaSuaChua='" + masuachua + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Duyệt Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearGrid();



                        }
                        else
                        {
                            MessageBox.Show("Duyệt Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void ToolStripMenuItem_LamMoi_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void toolStripBTNXuatBaoCao_Click(object sender, EventArgs e)
        {
           
        }
    }
}
