using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace WindowsFormsApplication1
{
    
    public static class DuLieuNhap    
    {
        public static int[,] SharedArray { get; set; } // Mảng chia sẻ
        public static int[,] OriginalArray { get; set; } // Mảng gốc
        public static int Rows { get; set; } // Số dòng
        public static int Columns { get; set; } // Số cột
        // Biến static để lưu trữ dữ liệu từ file dưới dạng DataTable.
        public static DataTable SharedDataTable { get; set; }

        // Phương thức để lấy giá trị tại vị trí nhất định
        public static int GetValue(int row, int col)
        {
            if (SharedArray != null && row < Rows && col < Columns)
            {
                return SharedArray[row, col];
            }
            throw new IndexOutOfRangeException("Vị trí không hợp lệ.");
        }

        // Phương thức kiểm tra xem DataTable có dữ liệu không.
        public static bool IsDataTableAvailable()
        {
            return SharedDataTable != null && SharedDataTable.Rows.Count > 0;
        }

        // Phương thức hiển thị dữ liệu từ DataTable
        public static void DisplayDataTable(DataGridView gridView)
        {
            if (IsDataTableAvailable())
            {
                gridView.DataSource = SharedDataTable;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
