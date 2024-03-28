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
    public partial class fmDanhSachDatPhong : Form
    {
        public fmDanhSachDatPhong()
        {
            InitializeComponent();
        }

        private void fmDanhSachDatPhong_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT DatPhong.MaDatPhong, Phong.TenPhong,NhanVien.TenNhanVien,DatPhong.ThoiGianDatPhong,DatPhong.ThoiGianTraPhong,DatPhong.GhiChu, Phong.MaPhong FROM Phong,NhanVien,DatPhong WHERE DatPhong.MaPhong=Phong.MaPhong AND DatPhong.MaNhanVien=NhanVien.MaNhanVien";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            if (dt.Rows.Count > 0)
            {
                gvDanhSachDatPhong.DataSource = dt;
                gvDanhSachDatPhong.Columns[0].HeaderText = "Mã Đặt Phòng";
                gvDanhSachDatPhong.Columns[1].HeaderText = "Tên Phòng";
                gvDanhSachDatPhong.Columns[2].HeaderText = "Tên Người Đặt Phòng";
                gvDanhSachDatPhong.Columns[3].HeaderText = "Thời Gian Đặt Phòng";
                gvDanhSachDatPhong.Columns[4].HeaderText = "Thời Gian Trả Phòng";
                gvDanhSachDatPhong.Columns[5].HeaderText = "Ghi Chú";
                gvDanhSachDatPhong.Columns[6].HeaderText = "Mã Phòng";
                gvDanhSachDatPhong.Columns[6].Visible = false;
                gvDanhSachDatPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            con.Close();
        }
        private void ClearGrid()
        {
            do
            {
                foreach (DataGridViewRow row in gvDanhSachDatPhong.Rows)
                {
                    try
                    {
                        gvDanhSachDatPhong.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gvDanhSachDatPhong.Rows.Count > 1);

            loadData();
        }

        private void toolStripBTNRefesh_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void txtTimKiem_VisibleChanged(object sender, EventArgs e)
        {
            timKiem();
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
                    gvDanhSachDatPhong.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenPhong Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachDatPhong.DataSource = dv.ToTable();
                    break;

                default:
                    dv.RowFilter = string.Format("MaDatPhong Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachDatPhong.DataSource = dv.ToTable();
                    break;
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvDanhSachDatPhong.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_datphong";
                MyFunctions.export2Excel(gvDanhSachDatPhong, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string madatphong;
        string maphong;
        private void gvDanhSachDatPhong_SelectionChanged(object sender, EventArgs e)
        {
            string a,b;
            if (gvDanhSachDatPhong.CurrentRow != null)
            {

                a = gvDanhSachDatPhong.CurrentRow.Cells[0].Value.ToString();
                b = gvDanhSachDatPhong.CurrentRow.Cells[6].Value.ToString();
                madatphong = a;
                maphong = b;

            }
        }

        private void ToolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (madatphong != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM DatPhong WHERE MaDatPhong='" + madatphong + "'";

                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con;
                        cmd1.CommandText = "UPDATE Phong SET TrangThai='0' WHERE MaPhong='" + maphong + "'";

                        int result = cmd.ExecuteNonQuery();
                        int result1 = cmd1.ExecuteNonQuery();

                        if (result > 0 && result1>0)
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

        private void ToolStripMenuItem_TraPhong_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectDB.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Phong WHERE MaPhong='" + maphong + "'";
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                string status = dt.Rows[0][4].ToString();
                string tenphong = dt.Rows[0][1].ToString();

                if (status == "1")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Trả Phòng Không?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con;
                        cmd1.CommandText = "UPDATE Phong SET  TrangThai='0' WHERE MaPhong='" + maphong + "'";
                        int result = cmd1.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trả Phòng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearGrid();

                        }
                        else
                        {
                            MessageBox.Show("Trả Phòng Thất Bại Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("Không làm gì", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    DialogResult dr1 = MessageBox.Show("Phòng này đang trống bạn có muốn đặt phòng này?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr1 == DialogResult.Yes)
                    {
                        fmDatPhong fm = new fmDatPhong(maphong, tenphong);
                        fm.ShowDialog();
                    }

                }


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

        private void gvDanhSachDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
