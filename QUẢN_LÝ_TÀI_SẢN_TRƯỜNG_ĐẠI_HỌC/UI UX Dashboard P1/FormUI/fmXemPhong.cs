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
    public partial class fmXemPhong : Form
    {
        string maPhong;
        public fmXemPhong(string maphong)
        {
            InitializeComponent();
            maPhong = maphong;
        }

        private void fmXemPhong_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataGV();
        }

        private void loadDataGV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT MaTaiSan, TenTaiSan,Gia FROM TaiSan WHERE MaPhong='" + maPhong + "'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
           
            gvDanhSachTaiSan.DataSource = dt;
            gvDanhSachTaiSan.Columns[0].HeaderText = "Mã Thiết Bị";
            gvDanhSachTaiSan.Columns[1].HeaderText = "Tên Thiết Bị";
            gvDanhSachTaiSan.Columns[2].HeaderText = "Giá";
            gvDanhSachTaiSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataTable dt = new DataTable();
            string getEmpSQL = "SELECT * FROM Phong WHERE MaPhong='"+maPhong+"'";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataTable dt2 = new DataTable();
            string getEmpSQL2 = "SELECT COUNT(*) AS Dem FROM TaiSan WHERE MaPhong='" + maPhong + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(getEmpSQL2, conn);


            try
            {
                conn.Open();
                sda.Fill(dt);
                sda2.Fill(dt2);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            lbTenPhong.Text = dt.Rows[0][1].ToString();
            lbTongSoTaiSan.Text = dt2.Rows[0][0].ToString()+" Thiết Bị";
            txtDienTich.Text = dt.Rows[0][2].ToString();
            txtViTriPhong.Text = dt.Rows[0][3].ToString();

            int trangthai = Convert.ToInt32(dt.Rows[0][4].ToString());
            if (trangthai == 0)
                txtTrangThai.Text = "Phòng Đang Rảnh";
            else
                txtTrangThai.Text = "Phòng Đang Được Sử Dụng";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (maPhong != "" )
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM Phong WHERE MaPhong='" + maPhong + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (gvDanhSachTaiSan.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_ThietBiTrongPhong_"+lbTenPhong.Text;
                MyFunctions.export2Excel(gvDanhSachTaiSan, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timKiem()
        {
            //DataTable dt = new DataTable();
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("TenTaiSan Like '%{0}%'", txtTimKiem.Text);
            //gvDanhSachTaiSan.DataSource = dv.ToTable();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT MaTaiSan, TenTaiSan,Gia FROM TaiSan WHERE TenTaiSan LIKE '%"+txtTimKiem.Text+"%' AND MaPhong='"+maPhong+"'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            gvDanhSachTaiSan.DataSource = dt;
            gvDanhSachTaiSan.Columns[0].HeaderText = "Mã Thiết Bị";
            gvDanhSachTaiSan.Columns[1].HeaderText = "Tên Thiết Bị";
            gvDanhSachTaiSan.Columns[2].HeaderText = "Giá";
            gvDanhSachTaiSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();



        }

        private void gvDanhSachTaiSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
