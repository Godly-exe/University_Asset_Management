using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1.FormUI
{
    public partial class fmSuaTaiSan : Form
    {
        public string ma;
        public fmSuaTaiSan(string mataisan)
        {
            InitializeComponent();
            ma = mataisan;
        }


        private void fmSuaTaiSan_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "yyyy-MM-dd";
            dtpNgayNhap.Text = DateTime.Now.ToString();

            dtpThoiGianKhauHau.Format = DateTimePickerFormat.Custom;
            dtpThoiGianKhauHau.CustomFormat = "yyyy-MM-dd";
            dtpThoiGianKhauHau.Text = DateTime.Now.ToString();

            dtpThoiGianBaoHanh.Format = DateTimePickerFormat.Custom;
            dtpThoiGianBaoHanh.CustomFormat = "yyyy-MM-dd";
            dtpThoiGianBaoHanh.Text = DateTime.Now.ToString();

            loadDataComboboxDVT();
            loadDataComboboxLTS();
            loadDataComboboxNCC();
            loadDataComboboxNhanVien();
            loadTextBox();
            loadDataComboboxPB();


        }



        private void loadTextBox()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT * FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda1.Fill(ds1);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            txtGiaTaiSan.Value = Convert.ToInt32(ds1.Tables[0].Rows[0][2].ToString());
            txtMaTaiSan.Text = ds1.Tables[0].Rows[0][0].ToString();


            txtTenFile.Text = ds1.Tables[0].Rows[0][6].ToString();

            txtTenTaiSan.Text = ds1.Tables[0].Rows[0][1].ToString();

            rtbGhiChu.Text = ds1.Tables[0].Rows[0][7].ToString();

            if (ds1.Tables[0].Rows[0][8].ToString() == "1")
                rdDuyet.Checked = true;
            else
                rdKhongDuyet.Checked = true;

            dtpNgayNhap.Text = ds1.Tables[0].Rows[0][9].ToString();

            rtbThongSoKyThuat.Text = ds1.Tables[0].Rows[0][11].ToString();
            dtpThoiGianBaoHanh.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0][13].ToString());
            dtpThoiGianKhauHau.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0][12].ToString());



            txtMaTaiSan.Enabled = false;
            txtTenFile.Enabled = false;

            string filename = ds1.Tables[0].Rows[0][6].ToString(); ;
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            ptbHinhAnh.ImageLocation = path + "" + filename;
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataComboboxPB()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM Phong;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT MaPhong FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda1.Fill(ds1);
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

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[0][0].ToString())
                    cbbPhongBan.SelectedValue = ds.Tables[0].Rows[i][0].ToString();


        }
        private void loadDataComboboxLTS()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM LoaiTaiSan;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT MaLoaiTaiSan FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda1.Fill(ds1);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            ccbLoaiTaiSan.DataSource = ds.Tables[0];
            ccbLoaiTaiSan.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ccbLoaiTaiSan.ValueMember = ds.Tables[0].Columns[0].ToString();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[0][0].ToString())
                {
                    ccbLoaiTaiSan.SelectedValue = ds.Tables[0].Rows[i][0].ToString();
                    // ccbLoaiTaiSan.SelectedText = ds.Tables[0].Rows[i][1].ToString();
                }


        }
        private void loadDataComboboxDVT()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM DonViTinh;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT MaDonViTinh FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda1.Fill(ds1);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            ccbDonViTinh.DataSource = ds.Tables[0];
            ccbDonViTinh.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ccbDonViTinh.ValueMember = ds.Tables[0].Columns[0].ToString();



            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[0][0].ToString())
                {
                    ccbDonViTinh.SelectedValue = ds.Tables[0].Rows[i][0].ToString();
                    // ccbDonViTinh.SelectedText = ds.Tables[0].Rows[i][1].ToString();
                }


        }
        private void loadDataComboboxNCC()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM NhaCungCap;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT MaNhaCungCap FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda1.Fill(ds1);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            cbbNhaCungCap.DataSource = ds.Tables[0];
            cbbNhaCungCap.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbNhaCungCap.ValueMember = ds.Tables[0].Columns[0].ToString();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[0][0].ToString())
                {
                    cbbNhaCungCap.SelectedValue = ds.Tables[0].Rows[i][0].ToString();
                    // cbbNhaCungCap.SelectedText = ds.Tables[0].Rows[i][1].ToString();
                }


        }
        private void loadDataComboboxNhanVien()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM NhanVien;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT MaNguoiNhap FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda1.Fill(ds1);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            cbbNguoiNhap.DataSource = ds.Tables[0];
            cbbNguoiNhap.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbNguoiNhap.ValueMember = ds.Tables[0].Columns[0].ToString();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[0][0].ToString())
                {
                    cbbNguoiNhap.SelectedValue = ds.Tables[0].Rows[i][0].ToString();
                    // cbbNguoiNhap.SelectedText = ds.Tables[0].Rows[i][1].ToString();
                }


        }



        private void btnUpFlie_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Vui lòng chọn tệp(*.png; *.jpg)|*.png; *.jpg";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        ptbHinhAnh.ImageLocation = path;
                        ptbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

                        txtTenFile.Text = openFileDialog1.FileName;
                    }
                    else
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        File.Delete(path);

                        ptbHinhAnh.ImageLocation = path;
                        ptbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                        txtTenFile.Text = openFileDialog1.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload Images.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaTaiSan.Text != "" && txtTenTaiSan.Text != "" && txtGiaTaiSan.Text != "")
            {
                byte trangthai = 0;
                if (rdDuyet.Checked)
                    trangthai = 1;
                if (rdKhongDuyet.Checked)
                    trangthai = 0;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectDB.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                string loaitaisan = ccbLoaiTaiSan.SelectedValue.ToString();
                string donvitinh = ccbDonViTinh.SelectedValue.ToString();
                string nhacungcap = cbbNhaCungCap.SelectedValue.ToString();
                string nguoinhap = cbbNguoiNhap.SelectedValue.ToString();
                string phongban = cbbPhongBan.SelectedValue.ToString();


                // MessageBox.Show(loaitaisan+" - "+donvitinh+" - "+nhacungcap+" - "+nguoinhap);


                //Upload file

                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
              
                if (openFileDialog1.CheckFileExists == true && openFileDialog1.CheckPathExists == true )
                {
                    
                    if (File.Exists(path + "\\Image\\" + filename))
                    {
                        File.Delete(path + "\\Image\\" + filename);
                    }
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
                    cmd.CommandText = " UPDATE TaiSan SET TenTaiSan =N'" + txtTenTaiSan.Text + "',Gia='" + txtGiaTaiSan.Value + "',MaLoaiTaiSan=N'" + loaitaisan + "',MaDonViTinh=N'" + donvitinh + "',MaNhaCungCap=N'" + nhacungcap + "',HinhMinhHoa='\\Image\\" + filename + "', GhiChu=N'" + rtbGhiChu.Text + "',TrangThai='" + trangthai + "',NgayNhap='" + dtpNgayNhap.Text + "',MaNguoiNhap='" + nguoinhap + "',ThongSoKyThuat='" + rtbThongSoKyThuat.Text + "',ThoiGianTinhKhauHau='" + dtpThoiGianKhauHau.Text + "',ThoiGianBaoHanh='" + dtpThoiGianBaoHanh.Text + "',MaPhong='" + phongban + "' WHERE MaTaiSan='" + ma + "'";
                }
                else
                {
                    cmd.CommandText = "UPDATE TaiSan SET TenTaiSan =N'" + txtTenTaiSan.Text + "',Gia='" + txtGiaTaiSan.Value + "',MaLoaiTaiSan=N'" + loaitaisan + "',MaDonViTinh=N'" + donvitinh + "',MaNhaCungCap=N'" + nhacungcap + "', GhiChu=N'" + rtbGhiChu.Text + "',TrangThai='" + trangthai + "',NgayNhap='" + dtpNgayNhap.Text + "',MaNguoiNhap='" + nguoinhap + "',ThongSoKyThuat='" + rtbThongSoKyThuat.Text + "',ThoiGianTinhKhauHau='" + dtpThoiGianKhauHau.Text + "',ThoiGianBaoHanh='" + dtpThoiGianBaoHanh.Text + "',MaPhong='" + phongban + "' WHERE MaTaiSan='" + ma + "'";
                }
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtpNgayNhap.Format = DateTimePickerFormat.Custom;
                    dtpNgayNhap.CustomFormat = "yyyy-MM-dd";
                    dtpNgayNhap.Text = DateTime.Now.ToString();

                    dtpThoiGianKhauHau.Format = DateTimePickerFormat.Custom;
                    dtpThoiGianKhauHau.CustomFormat = "yyyy-MM-dd";
                    dtpThoiGianKhauHau.Text = DateTime.Now.ToString();

                    dtpThoiGianBaoHanh.Format = DateTimePickerFormat.Custom;
                    dtpThoiGianBaoHanh.CustomFormat = "yyyy-MM-dd";
                    dtpThoiGianBaoHanh.Text = DateTime.Now.ToString();

                    loadDataComboboxDVT();
                    loadDataComboboxLTS();
                    loadDataComboboxNCC();
                    loadDataComboboxNhanVien();
                    loadTextBox();

                }
                else
                {
                    MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            else
                MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
