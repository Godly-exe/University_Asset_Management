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
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
            loadPhongBan();

        }

        private void loadPhongBan()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM PhongBan;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            cbbPhongBan.DataSource = ds.Tables[0];
            cbbPhongBan.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbPhongBan.ValueMember = ds.Tables[0].Columns[0].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                byte chucvu = 0;
                if (rdTruongPhong.Checked)
                    chucvu = 1;
                if (rdNhanVien.Checked)
                    chucvu = 0;


                if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtSoDienThoai.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string phongban = cbbPhongBan.SelectedValue.ToString();
                    cmd.CommandText = "INSERT INTO NhanVien VALUES('" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSoDienThoai.Text + "','" + chucvu + "','" + phongban + "')";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                byte chucvu = 0;
                if (rdTruongPhong.Checked)
                    chucvu = 1;
                if (rdNhanVien.Checked)
                    chucvu = 0;


                if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtSoDienThoai.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "UPDATE NhanVien SET TenNhanVien=N'" + txtTenNhanVien.Text + "',DiaChi=N'" + txtDiaChi.Text + "',SDT='" + txtSoDienThoai.Text + "',ChucVu='" + chucvu + "' WHERE MaNhanVien='" + txtMaNhanVien.Text + "'";
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
                if (txtMaNhanVien.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM NhanVien WHERE MaNhanVien='" + txtMaNhanVien.Text + "'";
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
            while (gvNhanVien.RowCount > 0)
            {
                gvNhanVien.Rows.RemoveAt(0);
            }
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void btnRamdom_Click(object sender, EventArgs e)
        {
            string matuchon = "NV";
            txtMaNhanVien.Text = MyFunctions.RandomChar(matuchon);
        }
        private void clearTextBox()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            rdNhanVien.Checked = false;
            rdTruongPhong.Checked = false;

            txtMaNhanVien.Enabled = true;
            btnRamdom.Enabled = true;
            btnThem.Enabled = true;

        }

        void hieuChinhDatatble(DataTable mydt)
        {
            for (int i = 0; i < mydt.Rows.Count; i++)
                if (mydt.Rows[i][4].ToString() == "1")
                    mydt.Rows[i][4] = "Trưởng phòng";
                else
                    mydt.Rows[i][4] = "Nhân viên";
        }
        DataTable dt = new DataTable();
        private void loadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM NhanVien";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            // hieuChinhDatatble(dt);

            gvNhanVien.DataSource = dt;
            gvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            gvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            gvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
            gvNhanVien.Columns[3].HeaderText = "Số Điện Thoại";
            gvNhanVien.Columns[4].HeaderText = "Chức Vụ";
            gvNhanVien.Columns[5].HeaderText = "Phòng Ban";
            




            gvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.gvNhanVien.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                cbbPhongBan.SelectedItem = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();



                if (row.Cells[4].Value.ToString() == "Trưởng Phòng")
                {
                    rdNhanVien.Checked = false;
                    rdTruongPhong.Checked = true;
                }

                if (row.Cells[4].Value.ToString() == "Nhân Viên")
                {
                    rdNhanVien.Checked = true;
                    rdTruongPhong.Checked = false;
                }
                


                //Không cho phép sửa trường STT
                txtMaNhanVien.Enabled = false;
                btnRamdom.Enabled = false;
                btnThem.Enabled = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_NhanVien";
                MyFunctions.export2Excel(gvNhanVien, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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
                    dv.RowFilter = string.Format("MaNhanVien Like '%{0}%'", txtTimKiem.Text);
                    gvNhanVien.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenNhanVien Like '%{0}%'", txtTimKiem.Text);
                    gvNhanVien.DataSource = dv.ToTable();
                    break;
                case "Tìm theo địa chỉ":
                    dv.RowFilter = string.Format("DiaChi Like '%{0}%'", txtTimKiem.Text);
                    gvNhanVien.DataSource = dv.ToTable();
                    break;
                case "Tìm theo sđt":
                    dv.RowFilter = string.Format("SDT Like '%{0}%'", txtTimKiem.Text);
                    gvNhanVien.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("MaNhanVien Like '%{0}%'", txtTimKiem.Text);
                    gvNhanVien.DataSource = dv.ToTable();
                    break;
            }

        }

        private void gvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
