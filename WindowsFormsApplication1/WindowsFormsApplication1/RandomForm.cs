using System; 
using System.Drawing; 
using System.Windows.Forms; 

namespace WindowsFormsApplication1
{
    public partial class RandomForm : Form 
    {
        private int[,] array2D; // Khai báo một mảng 2 chiều để lưu trữ các số ngẫu nhiên.
        private int rows; // Biến để lưu số dòng của mảng.
        private int cols; // Biến để lưu số cột của mảng.

        public RandomForm() // Hàm khởi tạo cho lớp RandomForm.
        {
            InitializeComponent(); // Khởi tạo các thành phần giao diện của form.       
            

        }

        private void Random_Load(object sender, EventArgs e) // Sự kiện khi form được tải.
        {
            // Các thao tác khi form được tải, nếu cần.
        }

        private void btn_Nhap_Click(object sender, EventArgs e) // Sự kiện khi nút "Nhập" được bấm.
        {
            // Lấy giá trị từ NumericUpDown
            int cols = (int)nCot.Value;
            int rows = (int)nDong.Value;

            // Kiểm tra giá trị nhập vào của số dòng và số cột
            if (cols <= 0 || cols >= 10 || rows <= 0 || rows >= 10)
            {
                // Hiển thị thông báo lỗi nếu giá trị không hợp lệ
                MessageBox.Show("Vui lòng nhập số dòng và số cột hợp lệ (cột và dòng phải lớn hơn 0 và nhỏ hơn 10)!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Thoát khỏi sự kiện nếu dữ liệu không hợp lệ
            }


            // Tạo mảng 2 chiều với kích thước dòng và cột đã nhập.
            array2D = new int[rows, cols];

            // Lưu mảng vào lớp DuLieuNhap để sử dụng trong các form khác.
            DuLieuNhap.SharedArray = array2D;
            DuLieuNhap.Rows = rows;
            DuLieuNhap.Columns = cols;

            // Thiết lập số dòng và cột cho DataGridView để hiển thị mảng.
            data_MangRandom.RowCount = rows;
            data_MangRandom.ColumnCount = cols;

            //layoutttttttttttttttttt
            data_MangRandom.RowHeadersWidth = 60; // Thiết lập độ rộng cho tiêu đề dòng là 60 pixel
            data_MangRandom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// căn giữa các phần tử
            // Thiết lập tiêu đề cho từng dòng.
            for (int i = 0; i < rows; i++)
            {
                data_MangRandom.Rows[i].HeaderCell.Value = "i = " + (i);
                data_MangRandom.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề dòng
            }

            // Thiết lập tiêu đề cho từng cột.
            for (int j = 0; j < cols; j++)
            {
                data_MangRandom.Columns[j].HeaderText = "j = " + (j);
                data_MangRandom.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề cột
            }

            DataGridView_Layout.ConfigureDataGridView(data_MangRandom, 60);
            //layoutttttttttttttttttt

            Random rand = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2D[i, j] = rand.Next(1, 100); // Sinh số ngẫu nhiên từ 1 đến 100.
                    data_MangRandom.Rows[i].Cells[j].Value = array2D[i, j]; // Gán giá trị cho ô tương ứng trong DataGridView.

                    // Tùy chọn: Thay đổi màu sắc của ô để thể hiện việc thêm giá trị.
                    data_MangRandom.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                }
            }

            //layoutttttttttttttttttt
            data_MangRandom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //layoutttttttttttttttttt
        }

        private void btn_Xoa_Click(object sender, EventArgs e) // Sự kiện khi nút "Xóa" được bấm.
        {
            data_MangRandom.Rows.Clear(); // Xóa tất cả các dòng trong DataGridView.
            data_MangRandom.Columns.Clear(); // Xóa tất cả các cột trong DataGridView.
            DuLieuNhap.SharedArray = null; // Xóa dữ liệu mảng được lưu trong lớp DuLieuNhap.
        }

        private void btn_QuayLai_Click(object sender, EventArgs e) // Sự kiện khi nút "Quay Lại" được bấm.
        {
      
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e) // Sự kiện khi nút "Tiếp Tục" được bấm.
        {
            // Kiểm tra xem mảng dữ liệu đã tồn tại hay chưa.
            if (DuLieuNhap.SharedArray != null)
            {
                GiaoDien gd = new GiaoDien(); // Tạo đối tượng của form GiaoDien.
                gd.Show(); // Hiển thị form GiaoDien.
                this.Close(); // Đóng form hiện tại.
            }
            else
            {
                // Hiển thị thông báo nếu chưa có dữ liệu.
                MessageBox.Show("Vui lòng nhập dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RandomForm_Load(object sender, EventArgs e)
        {
           
            // Điền dữ liệu vào các ô trống
            foreach (DataGridViewRow row in data_MangRandom.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || cell.Value == DBNull.Value || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        cell.Value = "Dữ liệu mặc định"; // Điền dữ liệu mặc định vào ô trống
                    }
                }
            }
        }

        private void data_MangRandom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TiepTuc_Click_1(object sender, EventArgs e)
        {

            // Kiểm tra xem mảng dữ liệu đã tồn tại hay chưa.
            if (DuLieuNhap.SharedArray != null)
            {
                GiaoDien gd = new GiaoDien(); // Tạo đối tượng của form GiaoDien.
                gd.Show(); // Hiển thị form GiaoDien.
                this.Close(); // Đóng form hiện tại.
            }
            else
            {
                // Hiển thị thông báo nếu chưa có dữ liệu.
                MessageBox.Show("Vui lòng nhập dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_QuayLai_Click_1(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu(); // Tạo đối tượng của form TrangChu.
            tc.Show(); // Hiển thị form chính (TrangChu).
            this.Close(); // Đóng form hiện tại.
        }
    }
}
