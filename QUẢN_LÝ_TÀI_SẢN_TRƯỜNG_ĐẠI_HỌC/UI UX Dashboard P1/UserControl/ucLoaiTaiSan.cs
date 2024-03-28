using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using UI_UX_Dashboard_P1.Library;


namespace UI_UX_Dashboard_P1
{
    public partial class ucLoaiTaiSan : UserControl
    {
        public ucLoaiTaiSan()
        {
            
            InitializeComponent();
           
        }

        DataTable dt = new DataTable();
        private void loadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LoaiTaiSan";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            
            dt.Load(sdr);
          
            gvLoaiTaiSan.DataSource=dt;
            gvLoaiTaiSan.Columns[0].HeaderText = "Mã Loại Thiết Bị";
            gvLoaiTaiSan.Columns[1].HeaderText = "Tên Loại Thiết Bị";

            gvLoaiTaiSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaLoaiTaiSan.Text!="" && txtTenLoaiTaiSan.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO LoaiTaiSan VALUES('" + txtMaLoaiTaiSan.Text + "',N'" + txtTenLoaiTaiSan.Text + "')";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        ClearGrid();
                        loadData();
                        clearTextBox();
                       
                    }
                    else
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thất Bại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            txtMaLoaiTaiSan.Clear();
            txtTenLoaiTaiSan.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoaiTaiSan.Text != "" && txtTenLoaiTaiSan.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE LoaiTaiSan SET TenLoaiTaiSan=N'"+txtTenLoaiTaiSan.Text+"' WHERE MaloaiTaiSan='"+txtMaLoaiTaiSan.Text+"'";
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

        private void ClearGrid()
        {
            while (gvLoaiTaiSan.RowCount > 0)
            {
                gvLoaiTaiSan.Rows.RemoveAt(0);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoaiTaiSan.Text != "" && txtTenLoaiTaiSan.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM LoaiTaiSan WHERE MaLoaiTaiSan='" + txtMaLoaiTaiSan.Text + "'";
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
                    else if (dr==DialogResult.No)
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

        private void gvLoaiTaiSan_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gvLoaiTaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.gvLoaiTaiSan.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaLoaiTaiSan.Text = row.Cells[0].Value.ToString();
                txtTenLoaiTaiSan.Text = row.Cells[1].Value.ToString();


                //Không cho phép sửa trường STT
                txtMaLoaiTaiSan.Enabled = false;
                btnRamdo.Enabled = false;
                btnThem.Enabled = false;
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            clearTextBox();
            txtMaLoaiTaiSan.Enabled = true;
            btnRamdo.Enabled = true;
            btnThem.Enabled = true;

        }

        private void btnRamdo_Click(object sender, EventArgs e)
        {
            string matuchon = "LTS";
            txtMaLoaiTaiSan.Text = MyFunctions.RandomChar(matuchon);
        }

        private void ucLoaiTaiSan_Load_1(object sender, EventArgs e)
        {
            loadData();
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
            if (gvLoaiTaiSan.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_LoaiThietBi";
                MyFunctions.export2Excel(gvLoaiTaiSan, path, MyFunctions.RandomChar(tenFile));
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
                    dv.RowFilter = string.Format("MaLoaiTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvLoaiTaiSan.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenLoaiTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvLoaiTaiSan.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("MaLoaiTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvLoaiTaiSan.DataSource = dv.ToTable();
                    break;
            }

        }

        private void gvLoaiTaiSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
