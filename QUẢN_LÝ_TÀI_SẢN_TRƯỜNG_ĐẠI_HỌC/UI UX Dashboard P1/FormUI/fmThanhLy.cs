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
    public partial class fmThanhLy : Form
    {
        string ma;
        public fmThanhLy(string mataisan)
        {
            InitializeComponent();
            ma = mataisan;
        }

        private void fmThanhLy_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM NhanVien;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataTable ds1 = new DataTable();
            string getEmpSQL1 = "SELECT * FROM TaiSan WHERE MaTaiSan='"+ma+"';";
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

            //Load Combobox
            ccbNguoiThanhLy.DataSource = ds.Tables[0];
            ccbNguoiThanhLy.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ccbNguoiThanhLy.ValueMember = ds.Tables[0].Columns[0].ToString();

            //LoadTextBox
            lbTenTaiSan.Text = ds1.Rows[0][0].ToString() + " - " + ds1.Rows[0][1].ToString();
            lbDonGia.Text = ds1.Rows[0][2].ToString();

           // txtSoLuong.Value = Convert.ToInt32(ds1.Rows[0][7].ToString());
            txtThanhTien.Text = (Convert.ToInt32(lbDonGia.Text) * 1).ToString()+" VNĐ";

        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            try
            {
               
                conn.Open();
                if (lbTenTaiSan.Text!="")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Thanh Lý?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                       
                        SqlCommand cmd = new SqlCommand();
                        SqlCommand cmd1 = new SqlCommand();

                        string matuchon = "TL";
                        string mathanhly = MyFunctions.RandomChar(matuchon);
                        string nguoithanhly = ccbNguoiThanhLy.SelectedValue.ToString();
                        int dongia = Convert.ToInt32(lbDonGia.Text);
                        decimal tien = dongia * 1;

                        cmd1.Connection = conn;
                        cmd1.CommandText= "INSERT INTO PhieuThanhLy VALUES('" + mathanhly + "','" + ma + "','1','"+tien+"','"+DateTime.Now.ToString()+"','"+nguoithanhly+"',N'"+txtNguoiMua.Text+"')";


                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE TaiSan SET TrangThai='0' WHERE MaTaiSan='"+ma+"'";
                        int result = cmd.ExecuteNonQuery();
                        int result1 = cmd1.ExecuteNonQuery();
                        if (result > 0 && result1>0)
                        {
                            MessageBox.Show("Đã bán tài sản với giá: "+txtThanhTien.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Bán Tài Sản Thất Bại Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("Không làm gì", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                    MessageBox.Show("Số lượng hết thống không đủ! Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (Convert.ToInt32(lbDonGia.Text) * 1).ToString() + " VNĐ";
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {

        }
    }
}
