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
    public partial class fmDatPhong : Form
    {
        string maPhong, tenPhong;
        public fmDatPhong(string maphong, string tenphong)
        {
            InitializeComponent();
            maPhong = maphong;
            tenPhong = tenphong;

        }

        private void fmDatPhong_Load(object sender, EventArgs e)
        {
            loadDataCombobox();
            txtTenPhong.Text = tenPhong;

            dtpThoiGianTraPhong.Format = DateTimePickerFormat.Custom;
            dtpThoiGianTraPhong.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpThoiGianTraPhong.Text = DateTime.Now.ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaDatPhong.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd1 = new SqlCommand();

                    cmd.Connection = con;
                    cmd1.Connection = con;

                   

                    string manhanvien = cbbNguoiDatPhong.SelectedValue.ToString();
                    string ngaydatphong = dtpThoiGianTraPhong.Text;

                    cmd.CommandText = "INSERT INTO DatPhong VALUES('" + txtMaDatPhong.Text + "','"+maPhong+"','" + manhanvien + "','" + DateTime.Now.ToString() + "','" + ngaydatphong + "','"+rtbGhiChu.Text+"')";
                    cmd1.CommandText = "UPDATE Phong SET TrangThai='1' WHERE MaPhong='" + maPhong + "'";

                    int result = cmd.ExecuteNonQuery();
                    int result1 = cmd1.ExecuteNonQuery();

                    if (result > 0 && result1 > 0)
                    {
                        MessageBox.Show("Đặt phòng thành công Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đặt Phòng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtMaDatPhong.Text = MyFunctions.RandomChar("MDP");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataCombobox()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM NhanVien;";
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

            cbbNguoiDatPhong.DataSource = ds.Tables[0];
            cbbNguoiDatPhong.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbNguoiDatPhong.ValueMember = ds.Tables[0].Columns[0].ToString();

        }
    }
}
