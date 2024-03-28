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
    public partial class fmDanhSachPhong : Form
    {
        public fmDanhSachPhong()
        {
            InitializeComponent();
        }

        private void fmDanhSachPhong_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM Phong";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            if (dt.Rows.Count>0)
            {
                gvDanhSachPhong.DataSource = dt;
                gvDanhSachPhong.Columns[0].HeaderText = "Mã Phòng";
                gvDanhSachPhong.Columns[1].HeaderText = "Tên Phòng";
                gvDanhSachPhong.Columns[2].HeaderText = "Diện Tích";
                gvDanhSachPhong.Columns[3].HeaderText = "Vị Trí";
                gvDanhSachPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

           

            con.Close();
        }

        private void toolStripBTNRefesh_Click(object sender, EventArgs e)
        {

            ClearGrid();
        }

        private void ClearGrid()
        {
            do
            {
                foreach (DataGridViewRow row in gvDanhSachPhong.Rows)
                {
                    try
                    {
                        gvDanhSachPhong.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gvDanhSachPhong.Rows.Count > 1);

            loadData();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

            if (gvDanhSachPhong.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_Phong";
                MyFunctions.export2Excel(gvDanhSachPhong, path, MyFunctions.RandomChar(tenFile));
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
                    dv.RowFilter = string.Format("MaPhong Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachPhong.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenPhong Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachPhong.DataSource = dv.ToTable();
                    break;
                case "Tìm theo vị trí":
                    dv.RowFilter = string.Format("ViTri Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachPhong.DataSource = dv.ToTable();
                    break;

                default:
                    dv.RowFilter = string.Format("MaPhong Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachPhong.DataSource = dv.ToTable();
                    break;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fmThemPhong fm = new fmThemPhong();
            fm.ShowDialog();
        }

        string maphong;
        private void gvDanhSachPhong_SelectionChanged(object sender, EventArgs e)
        {
            string a;
            if (gvDanhSachPhong.CurrentRow != null)
            {

                a = gvDanhSachPhong.CurrentRow.Cells[0].Value.ToString();

                maphong = a;

            }
        }

        private void ToolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (maphong != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM Phong WHERE MaPhong='" + maphong + "'";


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

        private void ToolStripMenuItem_SuaPhong_Click(object sender, EventArgs e)
        {
            fmSuaPhong fm = new fmSuaPhong(maphong);
            fm.ShowDialog();
        }

        private void ToolStripMenuItem_LamMoi_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void gvDanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
