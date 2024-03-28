using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using app = Microsoft.Office.Interop.Excel.Application;
using UI_UX_Dashboard_P1.Library;
using UI_UX_Dashboard_P1.FormUI;

namespace UI_UX_Dashboard_P1
{
    public partial class ucThanhLy : UserControl
    {
        public ucThanhLy()
        {
            InitializeComponent();
        }

        private void ucThanhLy_Load(object sender, EventArgs e)
        {
            loadData();
        }
        System.Data.DataTable ds = new System.Data.DataTable();
        private void loadData()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);

            string getEmpSQL = "SELECT PhieuThanhLy.MaThanhLy, TaiSan.TenTaiSan,PhieuThanhLy.SoLuongThanhLy,PhieuThanhLy.GiaThanhLy,PhieuThanhLy.NgayThanhLy,NhanVien.TenNhanVien,PhieuThanhLy.NguoiMua FROM PhieuThanhLy,TaiSan,NhanVien WHERE PhieuThanhLy.MaTaiSan=TaiSan.MaTaiSan AND PhieuThanhLy.NguoiThanhLy=NhanVien.MaNhanVien";
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
            //Ten Tai San


            gvDanhSachThanhLy.DataSource = ds;

            gvDanhSachThanhLy.Columns[0].HeaderText = "Mã Thanh Lý";
            gvDanhSachThanhLy.Columns[1].HeaderText = "Tên Thiết Bị";
            gvDanhSachThanhLy.Columns[2].HeaderText = "Số Lượng Thanh Lý";
            gvDanhSachThanhLy.Columns[3].HeaderText = "Giá Thanh Lý";
            gvDanhSachThanhLy.Columns[4].HeaderText = "Ngày Thanh Lý";
            gvDanhSachThanhLy.Columns[5].HeaderText = "Tên Người Thanh Lý";
            gvDanhSachThanhLy.Columns[6].HeaderText = "Tên Người Mua";


            gvDanhSachThanhLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripBTNRefesh_Click(object sender, EventArgs e)
        {


             ClearGrid();
   

        }
        private void ClearGrid()
        {
            do
            {
                foreach (DataGridViewRow row in gvDanhSachThanhLy.Rows)
                {
                    try
                    {
                        gvDanhSachThanhLy.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gvDanhSachThanhLy.Rows.Count > 1);

            loadData();
        }

        private void toolStripTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                timKiem();
            }
        }

        private void timKiem()
        {
            string choice = "";
            if (cbbTimKiem.SelectedIndex > 0)
            {
                choice = cbbTimKiem.SelectedItem.ToString();
            }
            DataView dv = ds.DefaultView;
            switch (choice)
            {
                case "Tìm theo mã":
                    dv.RowFilter = string.Format("MaThanhLy Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachThanhLy.DataSource = dv.ToTable();
                    break;
                case "Tìm theo tên":
                    dv.RowFilter = string.Format("TenTaiSan Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachThanhLy.DataSource = dv.ToTable();
                    break;
                case "Tìm theo ngày":
                    dv.RowFilter = string.Format("NgayThanhLy Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachThanhLy.DataSource = dv.ToTable();
                    break;
                case "Tìm theo người thanh lý":
                    dv.RowFilter = string.Format("TenNhanVien Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachThanhLy.DataSource = dv.ToTable();
                    break;
                default:
                    dv.RowFilter = string.Format("MaThanhLy Like '%{0}%'", txtTimKiem.Text);
                    gvDanhSachThanhLy.DataSource = dv.ToTable();
                    break;
            }

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
            if (gvDanhSachThanhLy.Rows.Count > 0)
            {

                string path = @"E:\";
                string tenFile = "file_ThanhLy";
                MyFunctions.export2Excel(gvDanhSachThanhLy, path, MyFunctions.RandomChar(tenFile));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvDanhSachThanhLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ////Lưu lại dòng dữ liệu vừa kích chọn
                //DataGridViewRow row = this.gvDanhSachThanhLy.Rows[e.RowIndex];
                ////Đưa dữ liệu vào textbox
                //string mathanhly = row.Cells[0].Value.ToString();

                //MessageBox.Show(mathanhly);


            }
        }

        private void gvDanhSachThanhLy_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //// Add this
                //gvDanhSachThanhLy.CurrentCell = gvDanhSachThanhLy.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //// Can leave these here - doesn't hurt
                //gvDanhSachThanhLy.Rows[e.RowIndex].Selected = true;
                //gvDanhSachThanhLy.Focus();

                ////Lưu lại dòng dữ liệu vừa kích chọn
                //DataGridViewRow row = this.gvDanhSachThanhLy.Rows[e.RowIndex];
                ////Đưa dữ liệu vào textbox
                //string mathanhly = row.Cells[0].Value.ToString();

                //MessageBox.Show(mathanhly);

                
            }
        }
        string mathanhly;
        private void gvDanhSachThanhLy_SelectionChanged(object sender, EventArgs e)
        {
            string a;
            if (gvDanhSachThanhLy.CurrentRow != null)
            {
               
                a = gvDanhSachThanhLy.CurrentRow.Cells[0].Value.ToString();

                mathanhly = a;
              
            }
            
        }

        private void ToolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (mathanhly!="")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM PhieuThanhLy WHERE MaThanhLy='" +mathanhly + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearGrid();
                            
                           

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

        private void ToolStripMenuItem_LuuKH_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void toolStripBTNXuatBaoCao_Click(object sender, EventArgs e)
        {
           
        }

        private void gvDanhSachThanhLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
