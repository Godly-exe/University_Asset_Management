using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.FormUI;
using XanderUI;
using System.Web.UI.Design.WebControls;
using System.Data.SqlClient;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1
{
    public partial class ucTaiSan : UserControl
    {
        public ucTaiSan()
        {
            InitializeComponent();
        }

       
        private void toolStripBTNThem_Click(object sender, EventArgs e)
        {
            fmThemTaiSan fm = new fmThemTaiSan();
            fm.ShowDialog();
        }


        public void ucTaiSan_Load(object sender, EventArgs e)
        {
           
            showData();

        }

        private void showData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TaiSan LEFT JOIN Phong ON TaiSan.MaPhong=Phong.MaPhong  WHERE TaiSan.TrangThai='1'";

           

            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i][0].ToString();

                Panel pn = new Panel()
                {
                    Width = 159,
                    Height = 141,
                    BorderStyle = BorderStyle.FixedSingle,

                };
                PictureBox pct = new PictureBox()
                {
                    Width = 99,
                    Height = 56,
                    Location = new Point(28, 3),
                    BorderStyle = BorderStyle.FixedSingle,
                    ImageLocation = dt.Rows[i][6].ToString()


                };

                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                pct.ImageLocation = path + "" + dt.Rows[i][6].ToString();

                Label lb = new Label()
                {
                    Text = dt.Rows[i][1].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 66),
                };
                Label lb1 = new Label()
                {
                    Text = "Vị Trí: " + dt.Rows[i][18].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 90),
                };
                XUISuperButton btnXemChiTiet = new XUISuperButton()
                {

                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_eye_24px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = dt.Rows[i][0].ToString(),
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(28, 110),
                    Name = "btnXemChiTiet",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center,

                };


                btnXemChiTiet.Click += delegate (object sender, EventArgs e) { btnXemChiTiet_Click(sender, e, ma, MessageType.B1); };


                XUISuperButton btnSua = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_edit_file_48px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(63, 110),
                    Name = "btnSua",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center


                };

                btnSua.Click += delegate (object sender, EventArgs e) { btnSua_click(sender, e, ma, MessageType.B2); };

                XUISuperButton btnXoa = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_delete_bin_48px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(98, 110),
                    Name = "btnXoa",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center,
                };

                btnXoa.Click += delegate (object sender, EventArgs e) { btnXoa_click(sender, e, ma, MessageType.B3); };

                pn.Controls.Add(pct);
                pn.Controls.Add(lb);
                pn.Controls.Add(lb1);
                pn.Controls.Add(btnXemChiTiet);
                pn.Controls.Add(btnSua);
                pn.Controls.Add(btnXoa);


                flowLayoutPanel1.Controls.Add(pn);

            }
        }

        private void btnXoa_click(object sender, EventArgs e, string MaTaiSan, MessageType b2)
        {
            try
            {
                if (MaTaiSan != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConnectDB.str;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM TaiSan WHERE MaTaiSan='" + MaTaiSan + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flowLayoutPanel1.Controls.Clear();
                            showData();

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

        private void btnSua_click(object sender, EventArgs e, string mataisan, MessageType b2)
        {
            fmSuaTaiSan fm = new fmSuaTaiSan(mataisan);
            fm.ShowDialog();
        }

        enum MessageType
        {
            B1,
            B2,
            B3
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e, string v, object b1)
        {
            fmXemChiTietTaiSan fm = new fmXemChiTietTaiSan(v);
            fm.ShowDialog();
        }





        private void toolStripBTNDanhSach_Click(object sender, EventArgs e)
        {
            fmDanhSachTaiSan fm = new fmDanhSachTaiSan();
            fm.Show();
        }

        private void toolStripBTNLoad_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            showData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
            if (txtTimKiem.Text == "")
            {
                flowLayoutPanel1.Controls.Clear();
                showData();
            }
                
        }
        private void timKiem()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TaiSan WHERE TenTaiSan LIKE '%"+txtTimKiem.Text+"%'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i][0].ToString();

                Panel pn = new Panel()
                {
                    Width = 159,
                    Height = 141,
                    BorderStyle = BorderStyle.FixedSingle,

                };
                PictureBox pct = new PictureBox()
                {
                    Width = 99,
                    Height = 56,
                    Location = new Point(28, 3),
                    BorderStyle = BorderStyle.FixedSingle,
                    ImageLocation = dt.Rows[i][6].ToString()


                };

                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                pct.ImageLocation = path + "" + dt.Rows[i][6].ToString();

                Label lb = new Label()
                {
                    Text = dt.Rows[i][1].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 66),
                };
                Label lb1 = new Label()
                {
                    Text = "Số Lượng: " + dt.Rows[i][7].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(10, 90),
                };
                XUISuperButton btnXemChiTiet = new XUISuperButton()
                {

                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_eye_24px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = dt.Rows[i][0].ToString(),
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(28, 110),
                    Name = "btnXemChiTiet",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center,

                };


                btnXemChiTiet.Click += delegate (object sender, EventArgs e) { btnXemChiTiet_Click(sender, e, ma, MessageType.B1); };


                XUISuperButton btnSua = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_edit_file_48px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(63, 110),
                    Name = "btnSua",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center


                };

                btnSua.Click += delegate (object sender, EventArgs e) { btnSua_click(sender, e, ma, MessageType.B2); };

                XUISuperButton btnXoa = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_delete_bin_48px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(98, 110),
                    Name = "btnXoa",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center,
                };

                btnXoa.Click += delegate (object sender, EventArgs e) { btnXoa_click(sender, e, ma, MessageType.B3); };

                pn.Controls.Add(pct);
                pn.Controls.Add(lb);
                pn.Controls.Add(lb1);
                pn.Controls.Add(btnXemChiTiet);
                pn.Controls.Add(btnSua);
                pn.Controls.Add(btnXoa);

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(pn);

            }
        }

        private void toolStripBTNXuatBaoCao_Click(object sender, EventArgs e)
        {
         
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
