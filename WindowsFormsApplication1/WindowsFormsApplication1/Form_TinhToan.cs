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
    public partial class Form_TinhToan : Form 
    {
        private int[,] originalArray;
        public Form_TinhToan() 
        {
            InitializeComponent(); // Khởi tạo các thành phần giao diện của form.
            this.Load += new EventHandler(Form_TinhToan_Load); // Đăng ký sự kiện khi form được tải.
     
        }

        private void Form_TinhToan_Load(object sender, EventArgs e) // Sự kiện khi form được tải.
        {
            // Gọi hàm hiển thị dữ liệu vào DataGridView khi form được tải.
            DisplayDataInDataGridView();
            // Điền dữ liệu từ DataStorage vào DataGridView
            originalArray = (int[,])DuLieuNhap.SharedArray.Clone();
        }

        private void DisplayDataInDataGridView() // Hàm để hiển thị dữ liệu vào DataGridView.
        {
            // Kiểm tra nếu mảng có dữ liệu trong lớp DuLieuNhap
            if (DuLieuNhap.SharedArray != null)
            {
                int rows = DuLieuNhap.Rows; // Lấy số dòng từ DuLieuNhap.
                int cols = DuLieuNhap.Columns; // Lấy số cột từ DuLieuNhap.

          
                // Cấu hình số dòng và số cột cho DataGridView
                dataGridView1.RowCount = rows;
                dataGridView1.ColumnCount = cols;
                // Layout cho DataGridView
                dataGridView1.RowHeadersWidth = 60; // Độ rộng tiêu đề dòng
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa các ô

                // Thiết lập tiêu đề cho từng dòng
                for (int i = 0; i < rows; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = "i = " + (i);
                    dataGridView1.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề dòng
                }

                // Thiết lập tiêu đề cho từng cột
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Columns[j].HeaderText = "j = " + (j);
                    dataGridView1.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề cột
                }

                DataGridView_Layout.ConfigureDataGridView(dataGridView1, 60);

                // Điền dữ liệu vào DataGridView
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = DuLieuNhap.SharedArray[i, j];
                    }
                }

                // Thiết lập chế độ tự động điều chỉnh kích thước cột
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                // Thông báo nếu không có dữ liệu để hiển thị
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Tinh_Click_1(object sender, EventArgs e)
        {
            // Đặt lại màu sắc các ô về mặc định
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Đặt lại màu ban đầu của ô.
                }
            }

            // Lấy phép tính được chọn trong ComboBox
            string selectedCalculation = cob_TinhToan.SelectedItem.ToString(); // Lấy giá trị từ ComboBox.
            int result = 0; // Khởi tạo biến lưu kết quả tính toán.

            // Thực hiện tính toán dựa trên phép tính được chọn
            if (selectedCalculation == "Tổng các phần tử trong mảng")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        int value = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value); // Lấy giá trị của ô.
                        result += value; // Cộng giá trị vào kết quả.

                        // Tô màu ô
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                }
            }
            else if (selectedCalculation == "Tổng các phần tử chẵn")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        int value = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                        if (value % 2 == 0) // Kiểm tra nếu là số chẵn
                        {
                            result += value; // Cộng giá trị chẵn vào kết quả.

                            // Tô màu ô
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                }
            }
            else if (selectedCalculation == "Tổng các phần tử lẻ")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        int value = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                        if (value % 2 != 0) // Kiểm tra nếu là số lẻ
                        {
                            result += value; // Cộng giá trị lẻ vào kết quả.

                            // Tô màu ô
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                }
            }
            else if (selectedCalculation == "Tổng các phần tử đường chéo chính")
            {
                for (int i = 0; i < Math.Min(dataGridView1.RowCount, dataGridView1.ColumnCount); i++)
                {
                    int value = Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value ?? 0);
                    result += value;
                    dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.Yellow;
                }
            }
            else if (selectedCalculation == "Tổng các phần tử đường chéo phụ")
            {
                int cols = dataGridView1.ColumnCount;
                for (int i = 0; i < Math.Min(dataGridView1.RowCount, cols); i++)
                {
                    int value = Convert.ToInt32(dataGridView1.Rows[i].Cells[cols - i - 1].Value ?? 0);
                    result += value;
                    dataGridView1.Rows[i].Cells[cols - i - 1].Style.BackColor = Color.Yellow;
                }
            }
            // Hiển thị kết quả trong ô "Kết quả"
            hthiketqua.Text = result.ToString(); // Cập nhật kết quả tính toán.
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetCellColors(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White; // Hoặc màu khác nếu cần
                }
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            // Lấy giá trị từ NumericUpDown
            int rowToRemove = (int)nDong.Value;
            int colToRemove = (int)nCot.Value;

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
            nDong.Value = 100;
            nCot.Value = 100;

            // Đặt lại về trống sau khi thực hiện xóa
            nDong.Text = string.Empty;
            nCot.Text = string.Empty;
        }
        
        private void RemoveColumn(int colToRemove)
        {
            // Tô màu cột cần xóa trước
            for (int row = 0; row < DuLieuNhap.Rows; row++)
            {
                dataGridView1.Rows[row].Cells[colToRemove].Style.BackColor = Color.Red; // Màu đỏ
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
                    DisplayDataInDataGridView();
                    ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);
                });
            });
        }

        private void RemoveRow(int rowToRemove)
        {
            // Tô màu dòng cần xóa trước
            for (int col = 0; col < DuLieuNhap.Columns; col++)
            {
                dataGridView1.Rows[rowToRemove].Cells[col].Style.BackColor = Color.Red; // Màu đỏ
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
                    DisplayDataInDataGridView();
                    ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);
                });
            });

        }


        private void ResetArrayToOriginal()
        {
            if (originalArray != null)
            {
                // Khôi phục mảng gốc vào DuLieuNhap.SharedArray
                DuLieuNhap.SharedArray = (int[,])originalArray.Clone(); // Khôi phục mảng gốc
                DuLieuNhap.Rows = originalArray.GetLength(0); // Cập nhật số dòng
                DuLieuNhap.Columns = originalArray.GetLength(1); // Cập nhật số cột

                DisplayDataInDataGridView(); // Hiển thị lại mảng đã khôi phục
            }
        }

        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Đặt lại mảng SharedArray thành mảng rỗng
            DuLieuNhap.SharedArray = new int[0, 0];
            DuLieuNhap.Rows = 0;
            DuLieuNhap.Columns = 0;

            // Xóa kết quả hiển thị nếu có
            hthiketqua.Clear();

            // Hiển thị thông báo xác nhận đã xóa toàn bộ dữ liệu
            MessageBox.Show("Toàn bộ dữ liệu đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            ResetArrayToOriginal();
            ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nDong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
