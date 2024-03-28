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
    public partial class ucDonViTinh : UserControl
    {
        public ucDonViTinh()
        {
            InitializeComponent();
        }

        private void ucDonViTinh_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDonViTinh.Text != "" && txtDonViTinh.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO DonViTinh VALUES('" + txtMaDonViTinh.Text + "',N'" + txtDonViTinh.Text + "')";
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

            txtDonViTinh.Clear();
            txtMaDonViTinh.Clear();
            btnRamdom.Enabled = true;
            btnThem.Enabled = true;
            txtMaDonViTinh.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDonViTinh.Text != "" && txtDonViTinh.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE DonViTinh SET TenDonViTinh=N'" + txtDonViTinh.Text + "' WHERE MaDonViTinh='" + txtMaDonViTinh.Text + "'";
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
                if (txtMaDonViTinh.Text != "" && txtDonViTinh.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM DonViTinh WHERE MaDonViTinh='" + txtMaDonViTinh.Text + "'";
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
        private void ClearGrid()
        {
            while (gvDonViTinh.RowCount > 0)
            {
                gvDonViTinh.Rows.RemoveAt(0);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void btnRamdom_Click(object sender, EventArgs e)
        {
            string matuchon = "DVT";
            txtMaDonViTinh.Text = MyFunctions.RandomChar(matuchon);
        }
        DataTable dt = new DataTable();
        private void loadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM DonViTinh";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
           
            dt.Load(sdr);

            gvDonViTinh.DataSource = dt;
            gvDonViTinh.Columns[0].HeaderText = "Mã Đơn Vị Tính";
            gvDonViTinh.Columns[1].HeaderText = "Tên Đơn Vị Tính";
            gvDonViTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void gvDonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.gvDonViTinh.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaDonViTinh.Text = row.Cells[0].Value.ToString();
                txtDonViTinh.Text = row.Cells[1].Value.ToString();


                //Không cho phép sửa trường STT
                txtMaDonViTinh.Enabled = false;
                btnRamdom.Enabled = false;
                btnThem.Enabled = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
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
                    dv.RowFilter = string.Format("MaDonViTinh Like '%{0}%'", txtTimKiem.Text);
                    gvDonViTinh.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenDonViTinh Like '%{0}%'", txtTimKiem.Text);
                    gvDonViTinh.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("MaDonViTinh Like '%{0}%'", txtTimKiem.Text);
                    gvDonViTinh.DataSource = dv.ToTable();
                    break;
            }

        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                timKiem();
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvDonViTinh.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_DonViTinh";
                MyFunctions.export2Excel(gvDonViTinh, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvDonViTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
