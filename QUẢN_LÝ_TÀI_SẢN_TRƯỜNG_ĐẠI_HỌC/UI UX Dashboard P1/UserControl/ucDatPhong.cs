using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using System.Data.SqlClient;
using UI_UX_Dashboard_P1.Library;
using UI_UX_Dashboard_P1.FormUI;

namespace UI_UX_Dashboard_P1
{
    public partial class ucDatPhong : UserControl
    {
        public ucDatPhong()
        {
            InitializeComponent();
        }
        private void ucDatPhong_Load(object sender, EventArgs e)
        {
            showData();
        }
        enum MessageType
        {
            B1,
            B2,
            B3
        }
        private void showData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Phong";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i][0].ToString();
              
                string trangthai = dt.Rows[i][4].ToString();



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
                    // ImageLocation = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_eye_24px,


                };

                // string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                // pct.ImageLocation = path + "" + dt.Rows[i][5].ToString();

                if (trangthai == "1")
                {
                    pn.BackColor = System.Drawing.Color.LightSalmon;
                    pct.Image = global::UI_UX_Dashboard_P1.Properties.Resources.phongdung;
                    pct.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else
                {
                    pn.BackColor = System.Drawing.Color.Aqua;
                    pct.Image = global::UI_UX_Dashboard_P1.Properties.Resources.phong_trong;
                    pct.SizeMode = PictureBoxSizeMode.StretchImage;
                }




                Label lb = new Label()
                {
                    Text = "Tên: "+dt.Rows[i][1].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 66),
                };
                Label lbvt = new Label()
                {
                    Text = "Vị Trí: "+dt.Rows[i][3].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 100),
                };
                string status = "";
                if (trangthai == "1")
                    status = "Đang sử dụng";
                else
                    status = "Đang trống";

                Label lb1 = new Label()
                {
                    Text = "Trạng Thái: " + status,
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 80),
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

                XUISuperButton btnDatPhong = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_cloud_backup_restore_64px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(63, 110),
                    Name = "btnDatPhong",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center


                };

                btnDatPhong.Click += delegate (object sender, EventArgs e) { btnSua_click(sender, e, ma, MessageType.B2); };

                XUISuperButton btnTraPhong = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.thanhly,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(98, 110),
                    Name = "btnTraPhong",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center,
                };

                btnTraPhong.Click += delegate (object sender, EventArgs e) { btnTraPhong_click(sender, e, ma, MessageType.B3); };

                pn.Controls.Add(pct);
                pn.Controls.Add(lb);
                pn.Controls.Add(lbvt);
                pn.Controls.Add(lb1);
                pn.Controls.Add(btnXemChiTiet);
                pn.Controls.Add(btnDatPhong);
                pn.Controls.Add(btnTraPhong);



                if (dt.Rows.Count > 0)
                    flowLayoutPanel1.Controls.Add(pn);
                else
                    MessageBox.Show("Không có dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);    

            }
        }

        private void btnTraPhong_click(object sender, EventArgs e, string ma, MessageType b3)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectDB.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Phong WHERE MaPhong='" + ma + "'";
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                string status = dt.Rows[0][4].ToString();
                string tenphong = dt.Rows[0][1].ToString();

                if (status=="1")
                {
                    DialogResult dr = MessageBox.Show("Bạn Chắc Chắn Muốn Trả Phòng Không?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                       
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con;
                        cmd1.CommandText = "UPDATE Phong SET  TrangThai='0' WHERE MaPhong='" + ma + "'";
                        int result = cmd1.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trả Phòng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flowLayoutPanel1.Controls.Clear();
                            showData();

                        }
                        else
                        {
                            MessageBox.Show("Trả Phòng Thất Bại Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("Không làm gì", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    DialogResult dr1 = MessageBox.Show("Phòng này đang trống bạn có muốn đặt phòng này?", "Xắc Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr1 == DialogResult.Yes)
                    {
                        fmDatPhong fm = new fmDatPhong(ma, tenphong);
                        fm.ShowDialog();
                    }
                   
                }


            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_click(object sender, EventArgs e, string ma, object b2)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectDB.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Phong WHERE MaPhong='" + ma + "'";
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                string status = dt.Rows[0][4].ToString();
                string tenphong = dt.Rows[0][1].ToString();
                //xu ly
                if (status == "1")
                    MessageBox.Show("Phòng đã được dùng. Vui lòng đặt phòng khác","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
               else
                {
                    fmDatPhong fm = new fmDatPhong(ma,tenphong);
                    fm.ShowDialog();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void btnXemChiTiet_Click(object sender, EventArgs e, string ma, object b1)
        {
            if (ma != null)
            {
                fmXemPhong fm = new fmXemPhong(ma);
                fm.ShowDialog();
            }
        }

        private void toolStripBTNThem_Click(object sender, EventArgs e)
        {
            fmThemPhong fm = new fmThemPhong();
            fm.ShowDialog();
        }

        private void toolStripBTNDanhSach_Click(object sender, EventArgs e)
        {
            fmDanhSachPhong fm = new fmDanhSachPhong();
            fm.ShowDialog();
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
            cmd.CommandText = "SELECT * FROM Phong WHERE TenPhong LIKE '%" + txtTimKiem.Text + "%'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i][0].ToString();
                string trangthai = dt.Rows[i][4].ToString();



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
                    // ImageLocation = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_eye_24px,


                };

                // string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                // pct.ImageLocation = path + "" + dt.Rows[i][5].ToString();

                if (trangthai == "1")
                {
                    pn.BackColor = System.Drawing.Color.LightSalmon;
                    pct.Image = global::UI_UX_Dashboard_P1.Properties.Resources.phongdung;
                    pct.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else
                {
                    pn.BackColor = System.Drawing.Color.Aqua;
                    pct.Image = global::UI_UX_Dashboard_P1.Properties.Resources.phong_trong;
                    pct.SizeMode = PictureBoxSizeMode.StretchImage;
                }




                Label lb = new Label()
                {
                    Text = dt.Rows[i][1].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 66),
                };
                Label lbvt = new Label()
                {
                    Text = dt.Rows[i][3].ToString(),
                    Width = 159,
                    Height = 13,
                    Location = new Point(4, 100),
                };
                string status = "";
                if (trangthai == "1")
                    status = "Đang sử dụng";
                else
                    status = "Đang trống";

                Label lb1 = new Label()
                {
                    Text = "Trạng Thái: " + status,
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

                XUISuperButton btnDatPhong = new XUISuperButton()
                {
                    BackgroundColor = System.Drawing.Color.Transparent,
                    ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_cloud_backup_restore_64px,
                    ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
                    ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges,
                    ButtonText = "",
                    CornerRadius = 5,
                    Horizontal_Alignment = System.Drawing.StringAlignment.Center,
                    HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174))))),
                    HoverTextColor = System.Drawing.Color.White,
                    ImagePosition = XanderUI.XUISuperButton.imgPosition.Left,
                    Location = new System.Drawing.Point(63, 110),
                    Name = "btnDatPhong",
                    SelectedBackColor = System.Drawing.Color.LimeGreen,
                    SelectedTextColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(29, 28),
                    SuperSelected = false,
                    TabIndex = 0,
                    TextColor = System.Drawing.Color.White,
                    Vertical_Alignment = System.Drawing.StringAlignment.Center


                };

                btnDatPhong.Click += delegate (object sender, EventArgs e) { btnSua_click(sender, e, ma, MessageType.B2); };


                pn.Controls.Add(pct);
                pn.Controls.Add(lb);
                pn.Controls.Add(lb1);
                pn.Controls.Add(btnXemChiTiet);
                pn.Controls.Add(btnDatPhong);



                if (dt.Rows.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(pn);
                }    
                   
                else
                    MessageBox.Show("Không có dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnChiTietDatPhong_Click(object sender, EventArgs e)
        {
            fmDanhSachDatPhong fm = new fmDanhSachDatPhong();
            fm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
