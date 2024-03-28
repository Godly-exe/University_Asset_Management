using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1.FormUI
{
    public partial class fmThemTaiSan : Form
    {
        public fmThemTaiSan()
        {
            InitializeComponent();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmThemTaiSan_Load(object sender, EventArgs e)
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
            loadDataComboboxPB();
        }



        private void btnRamdom_Click(object sender, EventArgs e)
        {
            int length = 7;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            txtMaTaiSan.Text = "TS_" + str_build.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
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
                    string phong = cbbPhong.SelectedValue.ToString();


                    //Upload file

                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    if (filename == null)
                    {
                        MessageBox.Show("Please select a valid image.");
                    }
                    else
                    {
                        //we already define our connection globaly. We are just calling the object of connection.




                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                        if (openFileDialog1.CheckFileExists == true && openFileDialog1.CheckPathExists == true)
                        {
                            if (File.Exists(path + "\\Image\\" + filename))
                            {
                                File.Delete(path + "\\Image\\" + filename);
                            }
                            System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
                            cmd.CommandText = " INSERT INTO TaiSan VALUES('" + txtMaTaiSan.Text + "',N'" + txtTenTaiSan.Text + "','" + txtGiaTaiSan.Value + "',N'" + loaitaisan + "',N'" + donvitinh + "',N'" + nhacungcap + "','\\Image\\" + filename + "',N'" + rtbGhiChu.Text + "','" + trangthai + "','" + dtpNgayNhap.Text + "','" + nguoinhap + "','" + rtbThongSoKyThuat.Text + "','" + dtpThoiGianKhauHau.Text + "','" + dtpThoiGianBaoHanh.Text + "','" + phong + "')";
                        }
                        else
                        {
                            System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
                            cmd.CommandText = " INSERT INTO TaiSan VALUES('" + txtMaTaiSan.Text + "',N'" + txtTenTaiSan.Text + "','" + txtGiaTaiSan.Value + "',N'" + loaitaisan + "',N'" + donvitinh + "',N'" + nhacungcap + "','\\Image\\" + filename + "',N'" + rtbGhiChu.Text + "','" + trangthai + "','" + dtpNgayNhap.Text + "','" + nguoinhap + "','" + rtbThongSoKyThuat.Text + "','" + dtpThoiGianKhauHau.Text + "','" + dtpThoiGianBaoHanh.Text + "','" + phong + "')";
                        }
                           

                    }
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void clearTextBox()
        {
            txtMaTaiSan.Clear();
            txtTenTaiSan.Clear();
            rtbThongSoKyThuat.Clear();
            rtbGhiChu.Clear();
            rdDuyet.Checked = false;
            rdKhongDuyet.Checked = false;
            txtGiaTaiSan.Value = 0;
            dtpNgayNhap.Text = DateTime.Now.ToString();
            dtpThoiGianKhauHau.Text = DateTime.Now.ToString();

        }

        private void loadDataComboboxPB()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM Phong;";
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

            cbbPhong.DataSource = ds.Tables[0];
            cbbPhong.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbPhong.ValueMember = ds.Tables[0].Columns[0].ToString();
        }
        private void loadDataComboboxLTS()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM LoaiTaiSan;";
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

            ccbLoaiTaiSan.DataSource = ds.Tables[0];
            ccbLoaiTaiSan.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ccbLoaiTaiSan.ValueMember = ds.Tables[0].Columns[0].ToString();

        }
        private void loadDataComboboxDVT()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM DonViTinh;";
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

            ccbDonViTinh.DataSource = ds.Tables[0];
            ccbDonViTinh.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ccbDonViTinh.ValueMember = ds.Tables[0].Columns[0].ToString();

        }
        private void loadDataComboboxNCC()
        {

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM NhaCungCap;";
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

            cbbNhaCungCap.DataSource = ds.Tables[0];
            cbbNhaCungCap.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbNhaCungCap.ValueMember = ds.Tables[0].Columns[0].ToString();

        }
        private void loadDataComboboxNhanVien()
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

            cbbNguoiNhap.DataSource = ds.Tables[0];
            cbbNguoiNhap.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbNguoiNhap.ValueMember = ds.Tables[0].Columns[0].ToString();

        }

        private void btnUpFlie_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);

                        ptbHinhMinhHoa.Image = new Bitmap(openFileDialog1.FileName);
                        ptbHinhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
