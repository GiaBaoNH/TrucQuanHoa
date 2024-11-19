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
    public partial class Form_SapXep : Form
    {
        private int[,] originalArray;

        private bool isSortingStopped = false;

        public Form_SapXep()
        {

            InitializeComponent();           
            this.Load += new EventHandler(Form_SapXep_Load);
        }

        private void Form_SapXep_Load(object sender, EventArgs e)
        {

            // Kiểm tra nếu mảng có dữ liệu
            if (DuLieuNhap.SharedArray != null)
            {
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;
               
                // Cấu hình DataGridView
                data_SapXep.RowCount = rows;
                data_SapXep.ColumnCount = cols;
                //DataGridView_Layout.ConfigureDataGridView(data_SapXep, 60);            

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
                for (int i = 0; i < rows ; i++)
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


        private void Swap(int[,] array, int index1, int index2)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int r1 = index1 / cols;
            int c1 = index1 % cols;

            int r2 = index2 / cols;
            int c2 = index2 % cols;

            int temp = array[r1, c1];
            array[r1, c1] = array[r2, c2];
            array[r2, c2] = temp;
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
        private void BubbleSort(int[,] array, int rows, int cols)
        {
            int r = DuLieuNhap.Rows;
            int c = DuLieuNhap.Columns;

            //Tính tổng số phần tử trong mảng
            int total = rows * cols;
            txtQuaTrinh.Clear();
            txtQuaTrinh.AppendText("Mảng 2 chiều của ta có " + rows + " dòng, " + cols + " cột " +" và "+ total+" phẩn tử"+ Environment.NewLine +
            "Nên ta sẽ có được 2 vòng lặp như sau: " + Environment.NewLine + "for (int i = 0; i < " + (total - 1) + "; i++){" + Environment.NewLine +
                                                                             "   for (int j = " + (total - 1) + "; j > i; " + " j--)" + Environment.NewLine + "}" + Environment.NewLine);
            
            Application.DoEvents(); // Cập nhật giao diện
            System.Threading.Thread.Sleep(TBTocDo.Value);
            // Vòng lặp chính để sắp xếp
            for (int i = 0; i < total - 1; i++)
            {         
                // Hiển thị thông báo bắt đầu vòng lặp ngoài với chỉ số i
                txtQuaTrinh.AppendText("Bắt đầu vòng lặp ngoài i = " + i + Environment.NewLine);
                Application.DoEvents(); // Cập nhật giao diện
                System.Threading.Thread.Sleep(TBTocDo.Value);

                // Vòng lặp phụ chạy từ cuối về đầu
                for (int j = total - 1; j > i; j--)
                {
                    if (isSortingStopped)  // Kiểm tra nếu quá trình sắp xếp bị dừng
                    {
                        txtQuaTrinh.AppendText("Quá trình sắp xếp đã bị dừng." + Environment.NewLine);
                        return;  // Dừng hàm sắp xếp
                    }
                    Application.DoEvents(); // Cập nhật giao diện
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // Hiển thị thông báo cho vòng lặp trong với chỉ số j
                    txtQuaTrinh.AppendText("Vòng lặp trong (i = " + i + ",j = " + j + ")" + Environment.NewLine);
                    Application.DoEvents(); // Cập nhật giao diện

                    // Tính chỉ số hàng và cột cho phần tử thứ nhất
                    int r1 = j / cols, c1 = j % cols;
                    // Tính chỉ số hàng và cột cho phần tử thứ hai
                    int r2 = (j - 1) / cols, c2 = (j - 1) % cols;
                    
                    // Tô màu tiêu đề dòng
                    data_SapXep.Rows[r1].HeaderCell.Style.BackColor = Color.LightGreen;
                    data_SapXep.Rows[r2].HeaderCell.Style.BackColor = Color.LightGreen;

                    // Tô màu tiêu đề cột
                    data_SapXep.Columns[c1].HeaderCell.Style.BackColor = Color.LightGreen;
                    data_SapXep.Columns[c2].HeaderCell.Style.BackColor = Color.LightGreen; 

                    // Màu các ô hiện tại
                    data_SapXep.Rows[r1].Cells[c1].Style.BackColor = Color.Yellow;
                    data_SapXep.Rows[r2].Cells[c2].Style.BackColor = Color.Yellow;

                    // Đợi một khoảng thời gian để người dùng có thể thấy sự di chuyển
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // So sánh và hoán đổi 
                    if (array[r1, c1] < array[r2, c2]) // Đổi dấu so sánh
                    {
                        // Hoán đổi giá trị của hai phần tử
                        int temp = array[r1, c1];
                        array[r1, c1] = array[r2, c2];
                        array[r2, c2] = temp;

                        // Cập nhật lại DataGridView
                        data_SapXep.Rows[r1].Cells[c1].Value = array[r1, c1];
                        data_SapXep.Rows[r2].Cells[c2].Value = array[r2, c2];
                        // Thông báo đã hoán đổi
                        txtQuaTrinh.AppendText("Hoán đổi phần tử (" + data_SapXep.Rows[r1].Cells[c1].Value + ") tại (i = " + r1 + ", j = " + c1 + ") và phần tử (" + data_SapXep.Rows[r2].Cells[c2].Value + ") (i = " + r2 + ", j = " + c2 + ")" + Environment.NewLine);
                        Application.DoEvents();
                    }
                    else
                    {
                        txtQuaTrinh.AppendText("Không cần hoán đổi phần tử (" + data_SapXep.Rows[r1].Cells[c1].Value + ") tại (i = " + r1 + ", j = " + c1 + ") và phần tử (" + data_SapXep.Rows[r1].Cells[c1].Value + ") (i = " + r2 + ", j = " + c2 + ") vì nó nhỏ hơn" + Environment.NewLine);
                        Application.DoEvents();
                    }                
                    // Đặt lại màu cho ô
                    data_SapXep.Rows[r1].Cells[c1].Style.BackColor = Color.White;
                    data_SapXep.Rows[r2].Cells[c2].Style.BackColor = Color.White;

                    // Đặt lại màu cho dòng
                    data_SapXep.Rows[r1].HeaderCell.Style.BackColor = Color.White;
                    data_SapXep.Rows[r2].HeaderCell.Style.BackColor = Color.White;

                    // Đặt lại màu cho cột
                    data_SapXep.Columns[c1].HeaderCell.Style.BackColor = Color.White;
                    data_SapXep.Columns[c2].HeaderCell.Style.BackColor = Color.White;

                    System.Threading.Thread.Sleep(TBTocDo.Value); // Dừng lại sau mỗi bước để dễ quan sát
                }
                // Thông báo kết thúc vòng lặp ngoài hiện tại
                txtQuaTrinh.AppendText("Kết thúc vòng lặp ngoài thứ: " + i + Environment.NewLine);
                Application.DoEvents();
                System.Threading.Thread.Sleep(TBTocDo.Value);
            }
            txtQuaTrinh.AppendText("Sắp xếp hoàn thành!" + Environment.NewLine);
            Application.DoEvents();
        }

        private void InterchangeSort(int[,] array, int rows, int cols)
        {
            int total = rows * cols;
            txtQuaTrinh.Clear();
            txtQuaTrinh.AppendText("Mảng 2 chiều của ta có " + rows + " dòng, " + cols + " cột " + " và " + total + " phẩn tử" + Environment.NewLine +
            "Nên ta sẽ có được 2 vòng lặp như sau: " + Environment.NewLine + "for (int i = 0; i < " + (total - 1) + "; i++){" + Environment.NewLine +
                                                                             "   for (int j = i + 2; j < "+total+"; j++)" + Environment.NewLine + "}" + Environment.NewLine);

            Application.DoEvents(); // Cập nhật giao diện
            System.Threading.Thread.Sleep(TBTocDo.Value);

            for (int i = 0; i < total - 1; i++)
            {
                txtQuaTrinh.AppendText("Bắt đầu vòng lặp ngoài i = " + i + Environment.NewLine);
                Application.DoEvents(); // Cập nhật giao diện
                System.Threading.Thread.Sleep(TBTocDo.Value);
                // Tính chỉ số hàng và cột cho phần tử đầu tiên
                int r1 = i / cols, c1 = i % cols;

                for (int j = i + 1; j < total; j++)
                {
                    if (isSortingStopped) // Kiểm tra nếu quá trình sắp xếp bị dừng
                    {
                        txtQuaTrinh.AppendText("Quá trình sắp xếp đã bị dừng." + Environment.NewLine);
                        return; // Dừng hàm sắp xếp
                    }
                    // Hiển thị thông báo cho vòng lặp trong với chỉ số j
                    txtQuaTrinh.AppendText("Vòng lặp trong (i = " + i + ",j = " + j + ")" + Environment.NewLine);
                    Application.DoEvents(); // Cập nhật giao diện
                      
                    // Tính chỉ số hàng và cột cho phần tử thứ hai
                    int r2 = j / cols, c2 = j % cols;

                    // Tô màu các ô hiện tại để dễ quan sát
                    data_SapXep.Rows[r1].Cells[c1].Style.BackColor = Color.Yellow;
                    data_SapXep.Rows[r2].Cells[c2].Style.BackColor = Color.Yellow;

                    // Đợi một khoảng thời gian để người dùng thấy sự di chuyển
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // So sánh và hoán đổi nếu cần
                    if (array[r1, c1] > array[r2, c2]) // Thực hiện sắp xếp tăng dần
                    {
                        int temp = array[r1, c1];
                        array[r1, c1] = array[r2, c2];
                        array[r2, c2] = temp;

                        // Cập nhật lại DataGridView
                        data_SapXep.Rows[r1].Cells[c1].Value = array[r1, c1];
                        data_SapXep.Rows[r2].Cells[c2].Value = array[r2, c2];

                        // Thông báo hoán đổi
                        txtQuaTrinh.AppendText("Hoán đổi phần tử (" + data_SapXep.Rows[r1].Cells[c1].Value + ") (i = " + r1 + ", j = " + c1 + ") và (" + data_SapXep.Rows[r2].Cells[c2].Value + ") (i = " + r2 + ", j = " + c2 + ")" + Environment.NewLine);
                        Application.DoEvents();
                    }
                    else
                    {
                        txtQuaTrinh.AppendText("Không cần hoán đổi giữa phần tử (" + data_SapXep.Rows[r1].Cells[c1].Value + ") (i = " + r1 + ", j = " + c1 + ") và (" + data_SapXep.Rows[r2].Cells[c2].Value + ") (i = " + r2 + ", j = " + c2 + ")" + Environment.NewLine);
                        Application.DoEvents();
                    }

                    // Đặt lại màu cho ô sau khi hoàn thành bước hiện tại
                    data_SapXep.Rows[r1].Cells[c1].Style.BackColor = Color.White;
                    data_SapXep.Rows[r2].Cells[c2].Style.BackColor = Color.White;

                    System.Threading.Thread.Sleep(TBTocDo.Value); // Dừng lại để dễ quan sát
                }
            }

            txtQuaTrinh.AppendText("Sắp xếp Interchange Sort hoàn thành!" + Environment.NewLine);
            Application.DoEvents();
        }

            
        private void SelectionSort(int[,] array, int rows, int cols)
        {
            int total = rows * cols;
            txtQuaTrinh.Clear();
            txtQuaTrinh.AppendText("Mảng 2 chiều của ta có " + rows + " dòng, " + cols + " cột " + " và " + total + " phẩn tử" + Environment.NewLine +
            "Nên ta sẽ có được 2 vòng lặp như sau: " + Environment.NewLine + "for (int i = 0; i < " + (total - 1) + "; i++){" + Environment.NewLine +
                                                                             "     for (int j = i + 1; j < " + total + "; j--)" + Environment.NewLine + "}" + Environment.NewLine);
      
            // Đợi để người dùng thấy sự hoán đổi
            Application.DoEvents();
            System.Threading.Thread.Sleep(TBTocDo.Value);
            // Vòng lặp chính của Selection Sort
            for (int i = 0; i < total - 1; i++)
            {              
                // Giả sử phần tử đầu tiên trong dãy chưa được sắp xếp là nhỏ nhất
                int minIndex = i;               

                // Tìm phần tử nhỏ nhất trong dãy từ i đến total - 1
                for (int j = i + 1; j < total; j++)
                {
                    if (isSortingStopped)  // Kiểm tra nếu quá trình sắp xếp bị dừng
                    {
                        txtQuaTrinh.AppendText("Quá trình sắp xếp đã bị dừng." + Environment.NewLine);
                        return;  // Dừng hàm sắp xếp
                    }

                    // Tính chỉ số hàng và cột cho phần tử minIndex và j
                    int rMin = minIndex / cols, cMin = minIndex % cols;
                    int rJ = j / cols, cJ = j % cols;

                    // Hiển thị thông báo bắt đầu vòng lặp ngoài với chỉ số i
                    txtQuaTrinh.AppendText("Bắt đầu vòng lặp ngoài thứ: " + i + Environment.NewLine +
                    "Giả sử phần tử (" + data_SapXep.Rows[rMin].Cells[cMin].Value + ") tại chỉ số (i= " + rMin + ", j = " + cMin + ") là phần tử nhỏ nhất ban đầu" + Environment.NewLine);
                    Application.DoEvents(); // Cập nhật giao diện
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // Hiển thị thông báo cho vòng lặp trong với chỉ số j
                    txtQuaTrinh.AppendText("Vòng lặp trong thứ: (i = " + i + Environment.NewLine +
                    "So sánh phần tử (" + data_SapXep.Rows[rMin].Cells[cMin].Value + ") tại vị trí (i =" + rMin + ", j ="+ cMin +") với phần tử ("+ data_SapXep.Rows[rJ].Cells[cJ].Value + ") tại vị trí (i =" + rJ + ", j ="+ cJ +")" + Environment.NewLine);
                    Application.DoEvents(); // Cập nhật giao diện

                    // Tô màu tiêu đề dòng
                    data_SapXep.Rows[rMin].HeaderCell.Style.BackColor = Color.LightPink;
                    data_SapXep.Rows[rJ].HeaderCell.Style.BackColor = Color.LightPink;

                    // Tô màu tiêu đề cột
                    data_SapXep.Columns[cMin].HeaderCell.Style.BackColor = Color.LightPink;
                    data_SapXep.Columns[cJ].HeaderCell.Style.BackColor = Color.LightPink; 

                    // Tô màu ô đang so sánh
                    data_SapXep.Rows[rMin].Cells[cMin].Style.BackColor = Color.LightBlue;
                    data_SapXep.Rows[rJ].Cells[cJ].Style.BackColor = Color.Yellow;

                    // Đợi một khoảng thời gian để người dùng có thể thấy sự so sánh
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // So sánh giá trị
                    if (array[rJ, cJ] < array[rMin, cMin]) // Nếu phần tử j nhỏ hơn phần tử nhỏ nhất hiện tại
                    {
                        minIndex = j; // Cập nhật chỉ số của phần tử nhỏ nhất
                    }

                    // Đặt lại màu cho ô sau khi so sánh xong
                    data_SapXep.Rows[rMin].Cells[cMin].Style.BackColor = Color.White;
                    data_SapXep.Rows[rJ].Cells[cJ].Style.BackColor = Color.White;

                    // Đặt lại màu cho tiêu đề dòng sau khi so sánh xong
                    data_SapXep.Rows[rMin].HeaderCell.Style.BackColor = Color.White;
                    data_SapXep.Rows[rJ].HeaderCell.Style.BackColor = Color.White;

                    // Đặt lại màu cho tiêu đề cột sau khi so sánh xong
                    data_SapXep.Columns[cMin].HeaderCell.Style.BackColor = Color.White;
                    data_SapXep.Columns[cJ].HeaderCell.Style.BackColor = Color.White;

                    System.Threading.Thread.Sleep(TBTocDo.Value); // Dừng lại sau mỗi bước để dễ quan sát
                }

                // Hoán đổi phần tử tại vị trí i với phần tử nhỏ nhất
                if (minIndex != i)
                {

                    // Tính chỉ số hàng và cột cho phần tử i và minIndex
                    int rI = i / cols, cI = i % cols;
                    int rMin = minIndex / cols, cMin = minIndex % cols;

                    // Hiển thị thông báo về việc hoán đổi
                    txtQuaTrinh.AppendText("Hoán đổi phần tử (" + data_SapXep.Rows[rI].Cells[cI].Value + ") tại vị trí (" + rI + ", " + cI + ") và phần tử (" + data_SapXep.Rows[rMin].Cells[cMin].Value + ") (" + rMin + ", " + cMin + ")" + Environment.NewLine + " ");

                    // Tô màu các ô đang được hoán đổi
                    data_SapXep.Rows[rI].Cells[cI].Style.BackColor = Color.Red;
                    data_SapXep.Rows[rMin].Cells[cMin].Style.BackColor = Color.Red;

                    // Tô màu tiêu đề dòng
                    data_SapXep.Rows[rMin].HeaderCell.Style.BackColor = Color.LightGreen;
                    data_SapXep.Rows[rI].HeaderCell.Style.BackColor = Color.LightGreen;

                    // Tô màu tiêu đề cột
                    data_SapXep.Columns[cMin].HeaderCell.Style.BackColor = Color.LightGreen;
                    data_SapXep.Columns[cI].HeaderCell.Style.BackColor = Color.LightGreen; 

                    // Hoán đổi giá trị trong mảng
                    Swap(array, i, minIndex);

                    // Cập nhật lại DataGridView sau khi hoán đổi
                    data_SapXep.Rows[rI].Cells[cI].Value = array[rI, cI];
                    data_SapXep.Rows[rMin].Cells[cMin].Value = array[rMin, cMin];

                    // Đợi để người dùng thấy sự hoán đổi
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // Đặt lại màu cho các ô sau khi hoán đổi
                    data_SapXep.Rows[rI].Cells[cI].Style.BackColor = Color.White;
                    data_SapXep.Rows[rMin].Cells[cMin].Style.BackColor = Color.White;

                    // Tô màu tiêu đề dòng
                    data_SapXep.Rows[rMin].HeaderCell.Style.BackColor = Color.White;
                    data_SapXep.Rows[rI].HeaderCell.Style.BackColor = Color.White;

                    // Tô màu tiêu đề cột
                    data_SapXep.Columns[cMin].HeaderCell.Style.BackColor = Color.White;
                    data_SapXep.Columns[cI].HeaderCell.Style.BackColor = Color.White;
                }
                else
                {
                    // Nếu không hoán đổi, có thể thêm một dòng thông báo khác
                    txtQuaTrinh.AppendText("Không cần hoán đổi phần tử tại vị trí " + i + " vì nó đã là phần tử nhỏ nhất." + Environment.NewLine+ " "  );
                }
            }
            txtQuaTrinh.AppendText("Sắp xếp hoàn thành!" + Environment.NewLine);
            Application.DoEvents();
        }

        private void InsertionSort(int[,] array, int rows, int cols)
        {
            int total = rows * cols;

            // Bắt đầu từ phần tử thứ 1 (vì phần tử đầu tiên được coi là đã sắp xếp)
            for (int i = 1; i < total; i++)
            {
                if (isSortingStopped)  // Kiểm tra nếu quá trình sắp xếp bị dừng
                {
                    txtQuaTrinh.AppendText("Quá trình sắp xếp đã bị dừng." + Environment.NewLine);
                    return;  // Dừng hàm sắp xếp
                }
                      
                // Tính chỉ số hàng và cột cho phần tử i
                int rI = i / cols, cI = i % cols;
                int currentValue = array[rI, cI];

                // Tô màu ô đang được chọn để chèn
                data_SapXep.Rows[rI].Cells[cI].Style.BackColor = Color.LightBlue;

                txtQuaTrinh.AppendText("Bắt đầu vòng lặp với chỉ số i = " + i + Environment.NewLine);
                txtQuaTrinh.AppendText("Chọn phần tử tại vị trí " + i + " với giá trị " + currentValue + " để chèn." + Environment.NewLine);

                Application.DoEvents();
                System.Threading.Thread.Sleep(TBTocDo.Value);

                // Tìm vị trí thích hợp để chèn phần tử i
                int j = i - 1;
                while (j >= 0)
                {
                    
                    // Tính chỉ số hàng và cột cho phần tử j
                    int rJ = j / cols, cJ = j % cols;

                    // Tô màu ô đang so sánh
                    data_SapXep.Rows[rJ].Cells[cJ].Style.BackColor = Color.Yellow;

                    txtQuaTrinh.AppendText("So sánh giá trị " + currentValue + " với giá trị tại vị trí " + j + " (" + array[rJ, cJ] + ")." + Environment.NewLine);

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    if (array[rJ, cJ] < currentValue) // Nếu phần tử hiện tại lớn hơn phần tử j, dừng lại
                    {
                        txtQuaTrinh.AppendText("Không cần di chuyển thêm vì giá trị hiện tại lớn hơn tại vị trí " + j + Environment.NewLine);
                        break;
                    }

                    for (int k = 0; k < i; k++)
                    {
                        int rK = k / cols, cK = k % cols;
                        data_SapXep.Rows[rK].Cells[cK].Style.BackColor = Color.White;
                    }

                    // Di chuyển phần tử j sang vị trí j + 1
                    int rNext = (j + 1) / cols, cNext = (j + 1) % cols;
                    array[rNext, cNext] = array[rJ, cJ];
                    data_SapXep.Rows[rNext].Cells[cNext].Value = array[rJ, cJ]; // Cập nhật UI với giá trị mới

                    txtQuaTrinh.AppendText("Di chuyển giá trị " + array[rJ, cJ] + " từ vị trí " + j + " đến vị trí " + (j + 1) + Environment.NewLine);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(TBTocDo.Value);

                    // Làm rỗng ô tại vị trí j sau khi di chuyển
                    array[rJ, cJ] = 0; // Hoặc giữ giá trị bạn muốn
                    data_SapXep.Rows[rJ].Cells[cJ].Value = ""; // Hiển thị ô trống trong DataGridView

                    // Đặt lại màu cho ô đã so sánh
                    data_SapXep.Rows[rJ].Cells[cJ].Style.BackColor = Color.White;

                    // Di chuyển tiếp sang phần tử trước đó
                    j--;
                }

                // Chèn phần tử i vào vị trí thích hợp
                int rInsert = (j + 1) / cols, cInsert = (j + 1) % cols;
                array[rInsert, cInsert] = currentValue;
                data_SapXep.Rows[rInsert].Cells[cInsert].Value = currentValue;

                txtQuaTrinh.AppendText("Chèn giá trị " + currentValue + " vào vị trí " + (j + 1) + Environment.NewLine);                

                // Đặt lại màu cho ô đã chèn
                data_SapXep.Rows[rInsert].Cells[cInsert].Style.BackColor = Color.Green;

                // Đợi một chút trước khi tiếp tục
                Application.DoEvents();
                System.Threading.Thread.Sleep(TBTocDo.Value);

                // Đặt lại màu cho ô sau khi hoàn tất quá trình chèn
                data_SapXep.Rows[rI].Cells[cI].Style.BackColor = Color.White;
                data_SapXep.Rows[rInsert].Cells[cInsert].Style.BackColor = Color.White;

                txtQuaTrinh.AppendText("Hoàn thành vòng lặp ngoài thứ " + i + Environment.NewLine);
                // Đợi một chút trước khi tiếp tục
                Application.DoEvents();
                System.Threading.Thread.Sleep(TBTocDo.Value);
            }
            txtQuaTrinh.AppendText("Sắp xếp hoàn thành!" + Environment.NewLine);
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            isSortingStopped = false;
            // Kiểm tra nếu chưa chọn thuật toán
            if (cob_TinhToan.SelectedItem == null || string.IsNullOrEmpty(cob_TinhToan.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn một thuật toán sắp xếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng hàm nếu chưa chọn thuật toán
            }

            string selectedAlgorithm = cob_TinhToan.SelectedItem.ToString();

            if (selectedAlgorithm == "Interchange Sort")
            {
                lblLyThuyet.Text = ("Lý thuyết: Xuất phát từ đầu dãy, tìm phần tử nào tạo nghịch thế với phần tử đang xét thì đổi chỗ" + Environment.NewLine +
                "2 phần tử này với nhau, lần lượt xét phần tử kế tiếp cho đến cuối dãy. Xem như phần tử đầu tiên được sắp xếp " + Environment.NewLine + 
                "và không cần xét đến nó nữa. Tăng vị trí kiểm tra lên 1. ");
                InterchangeSort(DuLieuNhap.SharedArray, DuLieuNhap.Rows, DuLieuNhap.Columns);
            }

            if (selectedAlgorithm == "Bubble Sort")
            {
                lblLyThuyet.Text = "Lý thuyết: Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn" + Environment.NewLine +
                "trong cặp phần tử đó về vị trí đứng đầu dãy hiện hành, sau đó không xét tới nó ở bước tiếp theo," + Environment.NewLine +
                "do vậy ở lần lặp thứ i có vị trí đầu dãy là i.";

                BubbleSort(DuLieuNhap.SharedArray, DuLieuNhap.Rows, DuLieuNhap.Columns);
                
            }

            if (selectedAlgorithm == "Selection Sort")
            {
                lblLyThuyet.Text = "Lý thuyết: Chọn phần tử nhỏ nhất trong n phần tử ban đầu, đổi chổ với phần tử vị trí thứ 1 của dãy hiện hành" + Environment.NewLine +
               "sau đó không quan tâm đến nó nữa. Bắt đầu từ vị trí thứ 2; Chọn phần tử nhỏ nhất trong n-1 phần tử còn lại đổi chổ với phần tử"+ Environment.NewLine +
               "vị trí thứ 2 của dãy hiện hành";

                SelectionSort(DuLieuNhap.SharedArray, DuLieuNhap.Rows, DuLieuNhap.Columns);
            }

            if (selectedAlgorithm == "Insertion Sort")
            {
                lblLyThuyet.Text = "Lý thuyết: Giả sử có 1 dãy a1, a2,…, an trong đó (i – 1) phần tử đầu tiên a1, a2,…, ai-1 đã có thứ tự tăng dần." + Environment.NewLine +
                "Tìm cách chèn phần tử ai vào vị trí thích hợp của đoạn đã sắp xếp để có dãy mới a1, a2,…, ai có thứ tự tăng dần." + Environment.NewLine;
                InsertionSort(DuLieuNhap.SharedArray, DuLieuNhap.Rows, DuLieuNhap.Columns);
            }

            //Hiển thị lại mảng sau khi sắp xếp
            DisplayArray();
            // Đặt lại màu cho tất cả ô sau khi sắp xếp hoàn tất
            ResetCellColors(DuLieuNhap.Rows, DuLieuNhap.Columns);
        }

        private void TBTocDo_Scroll(object sender, EventArgs e)
        {
            lblTocDo.Text = "Tốc độ: " + TBTocDo.Value.ToString() + " mili giây (ms)!";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetArrayToOriginal();
            txtQuaTrinh.Clear();
            lblLyThuyet.Text = "";
            isSortingStopped = false;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            isSortingStopped = true;  // Đánh dấu là dừng quá trình sắp xếp
        }

        private void data_SapXep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            data_SapXep.ClearSelection();
        }

    }
}
