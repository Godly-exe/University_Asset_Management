using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;

namespace UI_UX_Dashboard_P1.Library
{
    public static class MyFunctions
    {
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        // Hàm ramdo ký tự
        public static string RandomChar(string matuchon)
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
            return matuchon+"_"+ str_build.ToString();
        }
        public static void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            try
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < g.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < g.Rows.Count; i++)
                {
                    for (int j = 0; j < g.Columns.Count; j++)
                    {
                        if (g.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
                obj.ActiveWorkbook.Saved = true;

                DialogResult dr = MessageBox.Show("Xuất file thành công! Bạn có muốn mở không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
