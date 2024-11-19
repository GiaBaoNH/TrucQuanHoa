using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class NhapFile : Form
    {
         private int[,] array2D;
         private int rows; // Biến để lưu số dòng của mảng.
         private int cols; // Biến để lưu số cột của mảng.

        public NhapFile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Hiển thị đường dẫn file vào TextBox
                txt_file.Text = filePath;

                // Tiến hành tải dữ liệu từ file
                LoadDataFromFile(filePath);
            }
          
        }
        private void LoadDataFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                string[] dimensions = firstLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int rows;
                int cols;

                if (dimensions.Length != 2 ||
                    !int.TryParse(dimensions[0], out rows) ||
                    !int.TryParse(dimensions[1], out cols) ||
                    rows <= 0 || cols <= 0)
                {
                    MessageBox.Show("Dữ liệu đầu vào không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                DuLieuNhap.SharedArray = new int[rows, cols];
                DuLieuNhap.Rows = rows;
                DuLieuNhap.Columns = cols;
                DuLieuNhap.SharedDataTable = new DataTable();

                for (int j = 0; j < cols; j++)
                {
                    DuLieuNhap.SharedDataTable.Columns.Add("j = " + j);
                }

                for (int i = 0; i < rows; i++)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        string[] values = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (values.Length != cols)
                        {
                            MessageBox.Show("Dữ liệu không đầy đủ cho số cột đã chỉ định.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DataRow dataRow = DuLieuNhap.SharedDataTable.NewRow();

                        for (int j = 0; j < cols; j++)
                        {
                            int value;
                            if (int.TryParse(values[j], out value))
                            {
                                DuLieuNhap.SharedArray[i, j] = value;
                                dataRow[j] = value;
                            }
                            else
                            {
                                MessageBox.Show("Giá trị không hợp lệ trong dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        DuLieuNhap.SharedDataTable.Rows.Add(dataRow);
                    }
                }

                data_file.DataSource = DuLieuNhap.SharedDataTable;
                DataGridView_Layout.ConfigureDataGridView(data_file, 60);
                data_file.RowHeadersWidth = 60; // Thiết lập độ rộng cho tiêu đề dòng là 60 pixel
                // Căn giữa nội dung, tiêu đề cột, và tiêu đề dòng
                data_file.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                data_file.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                data_file.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (int i = 0; i < rows; i++)
                {
                    data_file.Rows[i].HeaderCell.Value = "i = " + i;
                    data_file.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            data_file.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }





        private void NhapFile_Load(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            data_file.Rows.Clear();
            data_file.Columns.Clear();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();  // Hiển thị lại form chính
            this.Close(); // Đóng form hiện tại
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem dữ liệu từ file đã được nhập hay chưa
            if (DuLieuNhap.SharedDataTable != null && DuLieuNhap.SharedDataTable.Rows.Count > 0)
            {
                GiaoDien gd = new GiaoDien(); // Tạo form GiaoDien
                gd.Show(); // Hiển thị form GiaoDien
                this.Close(); // Đóng form hiện tại
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu từ file trước khi tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
