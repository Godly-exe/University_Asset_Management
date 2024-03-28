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
    public partial class fmListUser : Form
    {
        public fmListUser()
        {
            InitializeComponent();
        }

        private void fmListUser_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM Accounts";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
           
            dt.Load(sdr);
            

            gvDanhSachTaiKhoan.DataSource = dt;
            gvDanhSachTaiKhoan.Columns[0].HeaderText = "Tên Tài Khoản";
            gvDanhSachTaiKhoan.Columns[1].HeaderText = "Mật Khẩu";
            gvDanhSachTaiKhoan.Columns[2].HeaderText = "Tên Hiện Thị";
            gvDanhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fmDangKyTaiKhoan fm = new fmDangKyTaiKhoan();
            fm.ShowDialog();
        }
        string username;
        private void gvDanhSachTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            string a;
            if (gvDanhSachTaiKhoan.CurrentRow != null)
            {

                a = gvDanhSachTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                username = a;

            }
        }
        private void ClearGrid()
        {
            do
            {
                foreach (DataGridViewRow row in gvDanhSachTaiKhoan.Rows)
                {
                    try
                    {
                        gvDanhSachTaiKhoan.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gvDanhSachTaiKhoan.Rows.Count > 1);

            loadData();
        }
        private void ToolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (username != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM Accounts WHERE UserName='" + username + "'";
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

        private void ToolStripMenuItem_LamMoi_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }
        

        private void ToolStripMenuItem_Sửa_Click(object sender, EventArgs e)
        {
            fmSuaThongTinUser fm = new fmSuaThongTinUser(username);
            fm.ShowDialog();
        }

        private void toolStripBTNRefesh_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void gvDanhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                case "Tìm theo tên tài khoản":
                    dv.RowFilter = string.Format("UserName Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachTaiKhoan.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên hiên thị":
                    dv.RowFilter = string.Format("Displayname Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachTaiKhoan.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("UserName Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachTaiKhoan.DataSource = dv.ToTable();
                    break;
            }

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvDanhSachTaiKhoan.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_user";
                MyFunctions.export2Excel(gvDanhSachTaiKhoan, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
