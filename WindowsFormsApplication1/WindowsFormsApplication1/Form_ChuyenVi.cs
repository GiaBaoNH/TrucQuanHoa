using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form_ChuyenVi : Form
    {
        private int[,] originalArray;

        public Form_ChuyenVi()
        {
            InitializeComponent();           
            this.Load += new EventHandler(Form_ChuyenVi_Load);
                      
        }

        private void Form_ChuyenVi_Load(object sender, EventArgs e)
        {
            // Kiểm tra nếu mảng có dữ liệu
            if (DuLieuNhap.SharedArray != null)
            {
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;

                // Cấu hình DataGridView
                data_SapXep.RowCount = rows;
                data_SapXep.ColumnCount = cols;

              
                // Lưu bản sao của mảng gốc
                originalArray = (int[,])DuLieuNhap.SharedArray.Clone();
                // Điền dữ liệu từ DataStorage vào DataGridView
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        data_SapXep.Rows[i].Cells[j].Value = DuLieuNhap.SharedArray[i, j];
                    }
                }
                DisplayArray();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);

        }
        private void ResetCellColors(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data_SapXep.Rows[i].Cells[j].Style.BackColor = Color.White; // Hoặc màu khác nếu cần
                }
            }
        }

        private void RemoveRow(int rowToRemove)
        {
            // Tô màu dòng cần xóa trước
            for (int col = 0; col < DuLieuNhap.Columns; col++)
            {
                data_SapXep.Rows[rowToRemove].Cells[col].Style.BackColor = Color.Red; // Màu đỏ
            }

            // Thực hiện xóa trong một luồng nền
            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(500); // Chờ 500ms

                // Xóa dòng
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;

                // Tạo mảng mới với số dòng ít hơn 1
                int[,] newArray = new int[rows - 1, cols];

                int newRow = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (i == rowToRemove)
                        continue; // Bỏ qua dòng cần xóa

                    for (int j = 0; j < cols; j++)
                    {
                        newArray[newRow, j] = DuLieuNhap.SharedArray[i, j];
                    }
                    newRow++; // Chỉ số dòng mới tăng lên
                }

                // Cập nhật mảng gốc
                DuLieuNhap.SharedArray = newArray;

                // Cập nhật lại số dòng trong DuLieuNhap
                DuLieuNhap.Rows--;

                // Quay lại luồng chính để cập nhật giao diện
                this.Invoke((MethodInvoker)delegate
                {
                    // Hiển thị lại mảng đã cập nhật
                    DisplayArray();
                    ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);
                });
            });
        }

        private void RemoveColumn(int colToRemove)
        {
            // Tô màu cột cần xóa trước
            for (int row = 0; row < DuLieuNhap.Rows; row++)
            {
                data_SapXep.Rows[row].Cells[colToRemove].Style.BackColor = Color.Red; // Màu đỏ
            }

            // Thực hiện xóa trong một luồng nền
            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(500); // Chờ 500ms

                // Xóa cột
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;

                // Tạo mảng mới với số cột ít hơn 1
                int[,] newArray = new int[rows, cols - 1];

                for (int i = 0; i < rows; i++)
                {
                    int newCol = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        if (j == colToRemove)
                            continue; // Bỏ qua cột cần xóa

                        newArray[i, newCol] = DuLieuNhap.SharedArray[i, j];
                        newCol++; // Chỉ số cột mới tăng lên
                    }
                }

                // Cập nhật mảng gốc
                DuLieuNhap.SharedArray = newArray;

                // Cập nhật lại số cột trong DuLieuNhap
                DuLieuNhap.Columns--;

                // Quay lại luồng chính để cập nhật giao diện
                this.Invoke((MethodInvoker)delegate
                {
                    // Hiển thị lại mảng đã cập nhật
                    DisplayArray();
                    ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);
                });
            });
        }
 

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            // Lấy giá trị từ NumericUpDown
            int rowToRemove = (int)nDong1.Value;
            int colToRemove = (int)nCot1.Value;

            // Kiểm tra và xóa dòng nếu chỉ số dòng hợp lệ
            if (rowToRemove >= 0 && rowToRemove < DuLieuNhap.Rows)
            {

                RemoveRow(rowToRemove);
            }
            else if (colToRemove >= 0 && colToRemove < DuLieuNhap.Columns) // Kiểm tra và xóa cột nếu chỉ số cột hợp lệ
            {
                RemoveColumn(colToRemove);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập chỉ số dòng hoặc cột hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Đặt lại giá trị sau khi thực hiện xóa
            nDong1.Value = 100;
            nCot1.Value = 100;

            // Đặt lại về trống sau khi thực hiện xóa
            nDong1.Text = string.Empty;
            nCot1.Text = string.Empty;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetArrayToOriginal();
            
        }
        

        private void ResetArrayToOriginal()
        {
            if (originalArray != null)
            {
                // Khôi phục mảng gốc vào DuLieuNhap.SharedArray
                DuLieuNhap.SharedArray = (int[,])originalArray.Clone(); // Khôi phục mảng gốc
                DuLieuNhap.Rows = originalArray.GetLength(0); // Cập nhật số dòng
                DuLieuNhap.Columns = originalArray.GetLength(1); // Cập nhật số cột

                DisplayArray(); // Hiển thị lại mảng đã khôi phục
            }
        }

        private void DisplayArray()
        {
            // Kiểm tra nếu mảng có dữ liệu
            if (DuLieuNhap.SharedArray != null)
            {
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;

                // Cấu hình DataGridView
                data_SapXep.RowCount = rows;
                data_SapXep.ColumnCount = cols;

                // Layout cho DataGridView

                data_SapXep.RowHeadersWidth = 60; // Độ rộng tiêu đề dòng
                data_SapXep.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa các ô

                // Thiết lập tiêu đề cho từng dòng
                for (int i = 0; i < rows; i++)
                {
                    data_SapXep.Rows[i].HeaderCell.Value = "i = " + (i);
                    data_SapXep.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề dòng
                }

                // Thiết lập tiêu đề cho từng cột
                for (int j = 0; j < cols; j++)
                {
                    data_SapXep.Columns[j].HeaderText = "j = " + (j);
                    data_SapXep.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề cột
                }

                DataGridView_Layout.ConfigureDataGridView(data_SapXep, 60);

                // Điền dữ liệu vào DataGridView
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        data_SapXep.Rows[i].Cells[j].Value = DuLieuNhap.SharedArray[i, j];
                    }
                }

                // Thiết lập chế độ tự động điều chỉnh kích thước cột
                data_SapXep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SwapColumns(int col1, int col2)
        {
            // Kiểm tra nếu chỉ số cột hợp lệ
            if (col1 < 0 || col1 >= DuLieuNhap.Columns || col2 < 0 || col2 >= DuLieuNhap.Columns)
            {
                MessageBox.Show("Chỉ số cột không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tô màu hai cột khác nhau trước khi hoán đổi
            for (int row = 0; row < DuLieuNhap.Rows; row++)
            {
                data_SapXep.Rows[row].Cells[col1].Style.BackColor = Color.LightBlue; // Màu xanh cho cột 1
                data_SapXep.Rows[row].Cells[col2].Style.BackColor = Color.LightGreen; // Màu xanh lá cho cột 2
            }

            // Tạm ngưng để thấy màu trước khi đổi chỗ
            Task.Delay(500).Wait();

            // Thực hiện hoán đổi giá trị giữa hai cột
            for (int row = 0; row < DuLieuNhap.Rows; row++)
            {
                int temp = DuLieuNhap.SharedArray[row, col1];
                DuLieuNhap.SharedArray[row, col1] = DuLieuNhap.SharedArray[row, col2];
                DuLieuNhap.SharedArray[row, col2] = temp;
            }

            // Hiển thị lại mảng sau khi hoán đổi
            DisplayArray();
        }

        private void SwapRows(int row1, int row2)
        {
            // Kiểm tra nếu chỉ số dòng hợp lệ
            if (row1 < 0 || row1 >= DuLieuNhap.Rows || row2 < 0 || row2 >= DuLieuNhap.Rows)
            {
                MessageBox.Show("Chỉ số dòng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tô màu hai dòng khác nhau trước khi hoán đổi
            for (int col = 0; col < DuLieuNhap.Columns; col++)
            {
                data_SapXep.Rows[row1].Cells[col].Style.BackColor = Color.LightCoral; // Màu đỏ nhạt cho dòng 1
                data_SapXep.Rows[row2].Cells[col].Style.BackColor = Color.LightYellow; // Màu vàng nhạt cho dòng 2
            }

            // Tạm ngưng để thấy màu trước khi đổi chỗ
            Task.Delay(500).Wait();

            // Thực hiện hoán đổi giá trị giữa hai dòng
            for (int col = 0; col < DuLieuNhap.Columns; col++)
            {
                int temp = DuLieuNhap.SharedArray[row1, col];
                DuLieuNhap.SharedArray[row1, col] = DuLieuNhap.SharedArray[row2, col];
                DuLieuNhap.SharedArray[row2, col] = temp;
            }

            // Hiển thị lại mảng sau khi hoán đổi
            DisplayArray();
            
        }

        private void btn_ChuyenVi_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có giá trị trong txtDong1 và txtDong2 thì thực hiện hoán đổi dòng
            int row1, row2;
            if (int.TryParse(nDong1.Text, out row1) && int.TryParse(nDong2.Text, out row2))
            {
                SwapRows(row1, row2);
            }
            else
            {
                // Nếu không có giá trị dòng, kiểm tra nếu có giá trị trong txtCot1 và txtCot2 thì thực hiện hoán đổi cột
                int col1, col2;
                if (int.TryParse(nCot1.Text, out col1) && int.TryParse(nCot2.Text, out col2))
                {
                    SwapColumns(col1, col2);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập chỉ số hợp lệ cho dòng hoặc cột để hoán đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Xóa nội dung của tất cả các TextBox sau khi thực hiện
            nDong1.Text = string.Empty;
            nDong2.Text = string.Empty;
            nCot1.Text = string.Empty;
            nCot2.Text = string.Empty;

            LockInputs(); // Cập nhật trạng thái khóa
        }

        private void LockInputs()
        {
            // Nếu có dữ liệu trong bất kỳ TextBox dòng nào
            bool hasRowInput = !string.IsNullOrWhiteSpace(nDong1.Text) || !string.IsNullOrWhiteSpace(nDong2.Text);

            // Nếu có dữ liệu trong bất kỳ TextBox cột nào
            bool hasColumnInput = !string.IsNullOrWhiteSpace(nCot1.Text) || !string.IsNullOrWhiteSpace(nCot2.Text);

            // Khóa TextBox cột nếu có dữ liệu dòng và ngược lại
            nCot1.ReadOnly = hasRowInput;
            nCot2.ReadOnly = hasRowInput;

            // Khóa TextBox dòng nếu có dữ liệu cột
            nDong1.ReadOnly = hasColumnInput;
            nDong2.ReadOnly = hasColumnInput;
        }

        private void txt_Dong2_TextChanged(object sender, EventArgs e)
        {
            LockInputs();
        }

        private void txt_Dong_TextChanged(object sender, EventArgs e)
        {
            LockInputs();
        }

        private void txt_Cot_TextChanged(object sender, EventArgs e)
        {
            LockInputs();
        }

        private void txt_Cot2_TextChanged(object sender, EventArgs e)
        {
            LockInputs();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
   
    }
}
