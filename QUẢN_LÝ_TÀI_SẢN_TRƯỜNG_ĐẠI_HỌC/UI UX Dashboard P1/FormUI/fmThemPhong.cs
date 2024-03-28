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
    public partial class fmThemPhong : Form
    {
        public fmThemPhong()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaPhong.Text != "" && txtTenPhong.Text!="")
                {
                    int trangthai = 0;
 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = " INSERT INTO Phong VALUES('" + txtMaPhong.Text + "','"+txtTenPhong.Text+"','"+txtDienTich.Value+"',N'"+txtViTri.Text+"','"+trangthai+"')";
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

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
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clearTextBox()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtDienTich.Value = 0;
            txtViTri.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRamdo_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = MyFunctions.RandomChar("P");
        }
    }
}
