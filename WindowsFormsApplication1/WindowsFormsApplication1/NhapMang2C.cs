using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class NhapMang2C : Form
    {
        private int[,] array2D; // Khai báo mảng 2 chiều
        private int rows;       // Số dòng của mảng
        private int cols;       // Số cột của mảng

        public NhapMang2C()
        {
            InitializeComponent();
        }

        // Nút để quay lại trang chủ
        private void btn_QuayLai_Click_1(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();  // Hiển thị lại form chính
            this.Close(); // Đóng form hiện tại
        }
        // Nút để nhập dữ liệu vào DataGridView
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            // Lấy giá trị số dòng và số cột từ NumericUpDown
            int cols = (int)nCot.Value;
            int rows = (int)nDong.Value;

            // Kiểm tra nếu giá trị nằm ngoài phạm vi cho phép
            if (cols <= 0 || cols >= 10 || rows <= 0 || rows >= 10)
            {
                MessageBox.Show("Vui lòng nhập số dòng và số cột hợp lệ! (lớn hơn 0 và nhỏ hơn 10)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Khởi tạo mảng 2 chiều và lưu vào lớp DuLieuNhap
            array2D = new int[rows, cols];
            DuLieuNhap.SharedArray = array2D;
            DuLieuNhap.Rows = rows;
            DuLieuNhap.Columns = cols;

            // Cấu hình DataGridView
            data_Mang2C.RowCount = rows;
            data_Mang2C.ColumnCount = cols;


            data_Mang2C.RowHeadersWidth = 60;
            data_Mang2C.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // Thiết lập tiêu đề cho từng dòng và cột
            for (int i = 0; i < rows; i++)
            {
                data_Mang2C.Rows[i].HeaderCell.Value = "i = " + i;
                data_Mang2C.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int j = 0; j < cols; j++)
            {
                data_Mang2C.Columns[j].HeaderText = "j = " + j;
                data_Mang2C.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            DataGridView_Layout.ConfigureDataGridView(data_Mang2C, 60);
            // Nhập dữ liệu từ bàn phím vào từng ô của mảng 2 chiều
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string value = Prompt.ShowDialog("Nhập giá trị tại [" + i + ", " + j + "]", "Nhập giá trị");
                    int result;
                    if (int.TryParse(value, out result))
                    {
                        array2D[i, j] = result;
                        data_Mang2C.Rows[i].Cells[j].Value = result;
                        data_Mang2C.Rows[i].Cells[j].Style.BackColor = Color.White;
                        data_Mang2C.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị không hợp lệ! Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        j--; // Yêu cầu nhập lại giá trị cho ô hiện tại
                    }
                }
            }
            data_Mang2C.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Nút để xóa dữ liệu trong DataGridView
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            data_Mang2C.Rows.Clear();
            data_Mang2C.Columns.Clear();
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            // Chỉ mở form nếu có dữ liệu
            if (DuLieuNhap.SharedArray != null)
            {
                GiaoDien gd = new GiaoDien();
                gd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    Text = caption
                };
                Label lblText = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70 };
                confirmation.DialogResult = DialogResult.OK;
                prompt.Controls.Add(lblText);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
            }
        }
      
        private void NhapMang2C_Load(object sender, EventArgs e)
        {
            
        }
    }
}
