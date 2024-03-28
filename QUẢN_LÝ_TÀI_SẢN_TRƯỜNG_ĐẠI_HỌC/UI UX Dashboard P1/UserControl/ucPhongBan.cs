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

namespace UI_UX_Dashboard_P1
{
    public partial class ucPhongBan : UserControl
    {
        public ucPhongBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                byte trangthai = 0;
                if (rdCoSan.Checked)
                    trangthai = 1;
                if (rdDangDung.Checked)
                    trangthai = 0;


                if (txtMaPhong.Text != "" && txtTenPhong.Text != "" && txtViTriPhong.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO PhongBan VALUES('" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "','" + txtSoPhong.Value + "','"+txtDienTichPhong.Value+"',N'"+txtViTriPhong.Text+"','"+trangthai+"')";
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
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtViTriPhong.Clear();
            txtSoPhong.Value = 0;
            txtDienTichPhong.Value = 0;
            txtMaPhong.Enabled = true;
            btnRamdom.Enabled = true;
            btnThem.Enabled = true;

        }
        DataTable dt = new DataTable();
        private void loadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM PhongBan";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
           
            dt.Load(sdr);
            //customStatus(dt);

            gvPhongBan.DataSource = dt;
            gvPhongBan.Columns[0].HeaderText = "Mã Phòng Ban";
            gvPhongBan.Columns[1].HeaderText = "Tên Phòng";
            gvPhongBan.Columns[2].HeaderText = "Số Phòng";
            gvPhongBan.Columns[3].HeaderText = "Diện Tích";
            gvPhongBan.Columns[4].HeaderText = "Vị Trí";
            gvPhongBan.Columns[5].HeaderText = "Trạng Thái";

            

            gvPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            con.Close();
        }

        private void customStatus(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string trangthai = dt.Rows[i][5].ToString() == "1" ? "Đang dùng" : "Có sẵn";
                dt.Rows[i][5]=trangthai;
            }
                
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                byte trangthai = 0;
                if (rdCoSan.Checked)
                    trangthai = 1;
                if (rdDangDung.Checked)
                    trangthai = 0;

                if (txtMaPhong.Text != "" && txtTenPhong.Text != "" && txtViTriPhong.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE PhongBan SET TenPhong=N'" + txtTenPhong.Text + "',SoPhong='" + txtSoPhong.Value + "',DienTich='"+txtDienTichPhong.Value+"',ViTri=N'"+txtViTriPhong.Text+"',TrangThaiPhong='"+trangthai+"' WHERE MaPhong='" + txtMaPhong.Text + "'";
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
                if (txtMaPhong.Text != "" && txtTenPhong.Text != "" && txtViTriPhong.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM PhongBan WHERE MaPhong='" + txtMaPhong.Text + "'";
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
            while (gvPhongBan.RowCount > 0)
            {
                gvPhongBan.Rows.RemoveAt(0);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void gvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.gvPhongBan.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtTenPhong.Text = row.Cells[1].Value.ToString();
                txtSoPhong.Text = row.Cells[2].Value.ToString();
                txtDienTichPhong.Text = row.Cells[3].Value.ToString();
                txtViTriPhong.Text = row.Cells[4].Value.ToString();

                if(row.Cells[5].Value.ToString() == "0")
                {
                    rdDangDung.Checked = true;
                    rdCoSan.Checked = false;
                }
                    
                if (row.Cells[5].Value.ToString() == "1")
                {
                    rdDangDung.Checked = false;
                    rdCoSan.Checked = true;
                }
                   


                //Không cho phép sửa trường STT
                txtMaPhong.Enabled = false;
                btnRamdom.Enabled = false;
                btnThem.Enabled = false;
            }
        }

        private void btnRamdom_Click(object sender, EventArgs e)
        {
            string matuchon = "PB";
            txtMaPhong.Text = MyFunctions.RandomChar(matuchon);
        }

        private void ucPhongBan_Load(object sender, EventArgs e)
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
            if (gvPhongBan.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_PhongBan";
                MyFunctions.export2Excel(gvPhongBan, path, MyFunctions.RandomChar(tenFile));
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
                    gvPhongBan.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenPhong Like '%{0}%'", txtTimKiem.Text);
                    gvPhongBan.DataSource = dv.ToTable();
                    break;
                case "Tìm theo vị trí":
                    dv.RowFilter = string.Format("ViTri Like '%{0}%'", txtTimKiem.Text);
                    gvPhongBan.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("MaPhong Like '%{0}%'", txtTimKiem.Text);
                    gvPhongBan.DataSource = dv.ToTable();
                    break;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
