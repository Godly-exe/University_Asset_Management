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
    public partial class fmXemChiTietTaiSan : Form
    {
        public string ma;
        public fmXemChiTietTaiSan(string mataisan)
        {
            InitializeComponent();
            ma = mataisan;
        }

        private void fmXemChiTietTaiSan_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            //LoaiTaiSan
            DataSet dsLTS = new DataSet();
            string getEmpSQL_LTS = "SELECT * FROM LoaiTaiSan ";
            SqlDataAdapter sda_LTS = new SqlDataAdapter(getEmpSQL_LTS, conn);

            //Nha Cung Cap
            DataSet dsNCC = new DataSet();
            string getEmpSQL_NCC = "SELECT * FROM NhaCungCap";
            SqlDataAdapter sda_NCC = new SqlDataAdapter(getEmpSQL_NCC, conn);

            //NguoiNhap
            DataSet dsNN = new DataSet();
            string getEmpSQL_NN = "SELECT * FROM NhanVien";
            SqlDataAdapter sda_NN = new SqlDataAdapter(getEmpSQL_NN, conn);

            //PhongBan
            DataSet dsPB = new DataSet();
            string getEmpSQL_PB = "SELECT * FROM Phong";
            SqlDataAdapter sda_PB = new SqlDataAdapter(getEmpSQL_PB, conn);

            //Don Vi Tinh
            DataSet dsDVT = new DataSet();
            string getEmpSQL_DVT = "SELECT * FROM PhongBan";
            SqlDataAdapter sda_DVT = new SqlDataAdapter(getEmpSQL_DVT, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda_LTS.Fill(dsLTS);
                sda_NCC.Fill(dsNCC);
                sda_PB.Fill(dsPB);
                sda_NN.Fill(dsNN);
                sda_DVT.Fill(dsDVT);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            lbTenTaiSan.Text = ds.Tables[0].Rows[0][1].ToString();
            lbGia.Text = ds.Tables[0].Rows[0][2].ToString();


            for (int i = 0; i < dsLTS.Tables[0].Rows.Count; i++)
                if (dsLTS.Tables[0].Rows[i][0].ToString() == ds.Tables[0].Rows[0][3].ToString())
                    lbLoaiTaiSan.Text = dsLTS.Tables[0].Rows[i][1].ToString();

            for (int i = 0; i < dsNCC.Tables[0].Rows.Count; i++)
                if (dsNCC.Tables[0].Rows[i][0].ToString() == ds.Tables[0].Rows[0][5].ToString())
                    lbNhaCungCap.Text = dsNCC.Tables[0].Rows[i][1].ToString();
            //Hinh Anh
            string filename = ds.Tables[0].Rows[0][6].ToString(); ;
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            ptbHinhAnh.ImageLocation = path + "" + filename;
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

         
            rtbGhiChu.Text = ds.Tables[0].Rows[0][7].ToString();



            string trangthai = ds.Tables[0].Rows[0][8].ToString() == "0" ? "Chưa Duyệt" : "Đã Duyệt";
            lbTrangThai.Text = trangthai;

            lbNgayNhap.Text = ds.Tables[0].Rows[0][9].ToString();

            for (int i = 0; i < dsNN.Tables[0].Rows.Count; i++)
                if (dsNN.Tables[0].Rows[i][0].ToString() == ds.Tables[0].Rows[0][10].ToString())
                    lbNguoiNhap.Text = dsNN.Tables[0].Rows[i][1].ToString();

            rtbThongSoKyThuat.Text = ds.Tables[0].Rows[0][11].ToString();
            lbThoiGianTinhKhauHao.Text = ds.Tables[0].Rows[0][12].ToString();
            lbThoiGianBaoHanh.Text = ds.Tables[0].Rows[0][13].ToString();


            for (int i = 0; i < dsPB.Tables[0].Rows.Count; i++)
                if (dsPB.Tables[0].Rows[i][0].ToString() == ds.Tables[0].Rows[0][14].ToString())
                    lbPhong.Text = dsPB.Tables[0].Rows[i][1].ToString();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fmSuaTaiSan fm = new fmSuaTaiSan(ma);
            fm.ShowDialog();
        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ma != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM TaiSan WHERE MaTaiSan='" + ma + "'";
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

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            fmChuyenPhong fm = new fmChuyenPhong(ma);
            fm.ShowDialog();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            fmThanhLy fm = new fmThanhLy(ma);
            fm.ShowDialog();
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            fmBaoHanh fm = new fmBaoHanh(ma);
            fm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
