using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_TimKiem : Form
    {
        public Form_TimKiem()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_TimKiem_Load);
        }

        private void Form_TimKiem_Load(object sender, EventArgs e)
        {
            // Display data in DataGridView from DuLieuNhap
            DisplayDataInDataGridView();
        }

        private void DisplayDataInDataGridView()
        {
            if (DuLieuNhap.SharedArray != null)
            {
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;

                // Configure DataGridView
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
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

      

       
        private async void FindNumberk()
        {
            // Reset cell colors to default
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.LightGray; // Đặt màu nền mặc định
                }
            }

            // Reset the result Label
            lbl_KetQua.Text = string.Empty;

            // Lấy giá trị số cần tìm từ TextBox
            nK.Minimum = 1;   // hoặc giá trị nhỏ nhất mà bạn cần
            nK.Maximum = 100; // hoặc giá trị lớn nhất mà bạn cần

            int searchNumber = (int)nK.Value;

            // Tiến hành tìm kiếm với searchNumber (không cần kiểm tra tính hợp lệ vì `NumericUpDown` luôn cung cấp giá trị số nguyên)


            // Biến để theo dõi tình trạng tìm kiếm
            bool found = false;

            // Duyệt qua tất cả các ô trong DataGridView
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    // Lấy giá trị trong ô
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue))
                    {
                        // Đặt màu nền ô hiện tại để dễ nhận diện
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        // Thông báo số hiện tại đang kiểm tra
                        lbl_KetQua.Text = string.Format("Đang kiểm tra số: {0}", cellValue);

                        // Đợi một chút để người dùng có thể thấy thông báo
                        await Task.Delay(500); // Thay đổi thời gian nếu cần

                        // So sánh giá trị trong ô với số cần tìm
                        if (cellValue == searchNumber)
                        {
                            // Nếu tìm thấy, làm nổi bật ô đó
                            //HighlightCell(i, j);
                            found = true;
                            lbl_KetQua.Text = string.Format("Số {0} đã được tìm thấy tại vị trí [{1}, {2}].", searchNumber, i + 1, j + 1);
                            break; // Ngắt vòng lặp nếu tìm thấy
                        }
                        else
                        {
                            // Đặt lại màu nền nếu không khớp
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                        }
                    }
                }

                if (found) break; // Ngắt vòng lặp hàng nếu đã tìm thấy số
            }

            // Nếu không tìm thấy số
            if (!found)
            {
                lbl_KetQua.Text = string.Format("Số {0} không có trong mảng.", searchNumber);
            }
        }
        private async void FindMaxNumber()
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.ColumnCount == 0)
            {
                MessageBox.Show("Không có dữ liệu trong mảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maxNumber = int.MinValue;

            // Duyệt qua toàn bộ các ô trong DataGridView để tìm số lớn nhất
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue))
                    {
                        // Đặt lại màu nền trước khi tô màu vàng để tránh bị đè lên
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;

                        // Tô màu vàng cho ô hiện tại để cho người dùng thấy quá trình kiểm tra
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        // Cập nhật giá trị kiểm tra hiện tại trong Label
                        lbl_KetQua.Text = string.Format("Đang kiểm tra số: {0} tại vị trí [{1}, {2}]", cellValue, i + 1, j + 1);

                        // Đợi một chút để người dùng có thể thấy quá trình kiểm tra
                        await Task.Delay(500); // Thời gian chờ giữa mỗi bước kiểm tra (có thể điều chỉnh)

                        // Kiểm tra nếu số hiện tại là lớn hơn số lớn nhất đã tìm thấy
                        if (cellValue > maxNumber)
                        {
                            maxNumber = cellValue;
                        }

                        // Sau khi kiểm tra xong, đặt lại màu ô thành màu mặc định (ở đây là LightGray)
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }

            // Sau khi tìm thấy số lớn nhất, tô màu vàng cho tất cả các ô chứa số đó
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue) && cellValue == maxNumber)
                    {
                        // Tô màu vàng cho ô chứa số lớn nhất
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        lbl_KetQua.Text = string.Format("Số lớn nhất là {0} tại vị trí [{1}, {2}]", maxNumber, i + 1, j + 1);
                    }
                }
            }
        }

        private async void FindMinNumber()
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.ColumnCount == 0)
            {
                MessageBox.Show("Không có dữ liệu trong mảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int minNumber = int.MaxValue;

            // Duyệt qua toàn bộ các ô trong DataGridView để tìm số lớn nhất
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue))
                    {
                        // Đặt lại màu nền trước khi tô màu vàng để tránh bị đè lên
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;

                        // Tô màu vàng cho ô hiện tại để cho người dùng thấy quá trình kiểm tra
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        // Cập nhật giá trị kiểm tra hiện tại trong Label
                        lbl_KetQua.Text = string.Format("Đang kiểm tra số: {0} tại vị trí [{1}, {2}]", cellValue, i + 1, j + 1);

                        // Đợi một chút để người dùng có thể thấy quá trình kiểm tra
                        await Task.Delay(500); // Thời gian chờ giữa mỗi bước kiểm tra (có thể điều chỉnh)

                        // Kiểm tra nếu số hiện tại là lớn hơn số lớn nhất đã tìm thấy
                        if (cellValue < minNumber)
                        {
                            minNumber = cellValue;
                        }

                        // Sau khi kiểm tra xong, đặt lại màu ô thành màu mặc định (ở đây là LightGray)
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }

            // Sau khi tìm thấy số lớn nhất, tô màu vàng cho tất cả các ô chứa số đó
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue) && cellValue == minNumber)
                    {
                        // Tô màu vàng cho ô chứa số lớn nhất
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        lbl_KetQua.Text = string.Format("Số lớn nhất là {0} tại vị trí [{1}, {2}]", minNumber, i + 1, j + 1);
                    }
                }
            }
        }

        bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private async void FindPrimeNumber()
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.ColumnCount == 0)
            {
                MessageBox.Show("Không có dữ liệu trong mảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
            // Duyệt qua toàn bộ các ô trong DataGridView để tìm số lớn nhất
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue))
                    {
                        // Đặt lại màu nền trước khi tô màu vàng để tránh bị đè lên
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;

                        // Tô màu vàng cho ô hiện tại để cho người dùng thấy quá trình kiểm tra
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        // Cập nhật giá trị kiểm tra hiện tại trong Label
                        lbl_KetQua.Text = string.Format("Đang kiểm tra số: {0} tại vị trí [{1}, {2}]", cellValue, i + 1, j + 1);

                        // Đợi một chút để người dùng có thể thấy quá trình kiểm tra
                        await Task.Delay(500); // Thời gian chờ giữa mỗi bước kiểm tra (có thể điều chỉnh)

                        // Kiểm tra nếu số hiện tại là lớn hơn số lớn nhất đã tìm thấy
                        if (IsPrime(cellValue))
                        {
                            // Nếu là số nguyên tố, tô màu vàng cho ô chứa số đó
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            lbl_KetQua.Text = string.Format("Số nguyên tố là {0} tại vị trí [{1}, {2}]", cellValue, i + 1, j + 1);
                        }

                        // Sau khi kiểm tra xong, đặt lại màu ô thành màu mặc định (ở đây là LightGray)
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int cellValue;
                    if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out cellValue) && IsPrime(cellValue))
                    {
                        // Tô màu vàng cho ô chứa số nguyên tố
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        lbl_KetQua.Text = string.Format("Số nguyên tố là {0} tại vị trí [{1}, {2}]", cellValue, i + 1, j + 1);
                    }
                }
            }
        }



        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            if (cob_TinhToan.SelectedItem != null && cob_TinhToan.SelectedItem.ToString() == "Tìm kiếm số k trong mảng")
            {
                lblLyThuyet.Text = ("Lý thuyết:  ");
                FindNumberk();

            }

            else if (cob_TinhToan.SelectedItem.ToString() == "Tìm số lớn nhất trong mảng")
            {
                lblLyThuyet.Text = ("Lý thuyết:  ");
                FindMaxNumber();
            }
            else if (cob_TinhToan.SelectedItem.ToString() == "Tìm số nhỏ nhất trong mảng")
            {
                lblLyThuyet.Text = ("Lý thuyết:  ");
                FindMinNumber();
            }
            else if(cob_TinhToan.SelectedItem.ToString()=="Tìm các số nguyên tố trong mảng")
            {
                lblLyThuyet.Text = ("Lý thuyết:  ");
                FindPrimeNumber();
            }
            dataGridView1.CurrentCell = null;


        }

        private void lbl_KetQua_Click(object sender, EventArgs e)
        {

        }

    }
}
