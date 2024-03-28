using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1
{
    public partial class ucNhaCungCap : UserControl
    {
        public ucNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnRamdom_Click(object sender, EventArgs e)
        {
            string matuchon = "NCC";
            txtMaNhaCungCap.Text = MyFunctions.RandomChar(matuchon);
        }
        private void ClearGrid()
        {
            while (gvNhaCungCap.RowCount > 0)
            {
                gvNhaCungCap.Rows.RemoveAt(0);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhaCungCap.Text != "" && txtTenNhaCungCap.Text != "" && txtDiaChi.Text!="")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO NhaCungCap VALUES('" + txtMaNhaCungCap.Text + "',N'" + txtTenNhaCungCap.Text + "',N'"+txtDiaChi.Text+"')";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearGrid();
                        loadData();
                        clearTextBox();

                    }
                    else
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearTextBox();
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTextBox()
        {
            txtDiaChi.Clear();
            txtMaNhaCungCap.Clear();
            txtTenNhaCungCap.Clear();
            txtMaNhaCungCap.Enabled = true;
            btnThem.Enabled = true;
            btnRamdom.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhaCungCap.Text != "" && txtTenNhaCungCap.Text != "" && txtDiaChi.Text!="")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE NhaCungCap SET TenNhaCungCap=N'" + txtTenNhaCungCap.Text + "',DiaChiNhaCungCap='"+txtDiaChi.Text+"' WHERE MaNhaCungCap='" + txtMaNhaCungCap.Text + "'";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearGrid();
                        loadData();
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearTextBox();
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhaCungCap.Text != "" && txtTenNhaCungCap.Text != "" && txtDiaChi.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM NhaCungCap WHERE MaNhaCungCap='" + txtMaNhaCungCap.Text + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearGrid();
                            loadData();
                            clearTextBox();

                        }
                        else
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearTextBox();
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

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM NhaCungCap";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
           
            dt.Load(sdr);

            gvNhaCungCap.DataSource = dt;
            gvNhaCungCap.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            gvNhaCungCap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            gvNhaCungCap.Columns[2].HeaderText = "Địa Chỉ Nhà Cung Cấp";

            gvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            con.Close();
        }

        private void gvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.gvNhaCungCap.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNhaCungCap.Text = row.Cells[0].Value.ToString();
                txtTenNhaCungCap.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();


                //Không cho phép sửa trường STT
                txtMaNhaCungCap.Enabled = false;
                btnRamdom.Enabled = false;
                btnThem.Enabled = false;
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvNhaCungCap.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_NhaCungCap";
                MyFunctions.export2Excel(gvNhaCungCap, path, MyFunctions.RandomChar(tenFile));
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
                    dv.RowFilter = string.Format("MaNhaCungCap Like '%{0}%'", txtTimKiem.Text);
                    gvNhaCungCap.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenNhaCungCap Like '%{0}%'", txtTimKiem.Text);
                    gvNhaCungCap.DataSource = dv.ToTable();
                    break;
                case "Tìm theo địa chỉ":
                    dv.RowFilter = string.Format("DiaChiNhaCungCap Like '%{0}%'", txtTimKiem.Text);
                    gvNhaCungCap.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("MaNhaCungCap Like '%{0}%'", txtTimKiem.Text);
                    gvNhaCungCap.DataSource = dv.ToTable();
                    break;
            }

        }

        private void gvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
