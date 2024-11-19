using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public static class DataGridView_Layout
    {
        public static void ConfigureDataGridView(DataGridView dataGridView, int cellSize)
        {
            // Tắt chế độ tự động điều chỉnh hàng và cột
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Đặt chiều rộng cho các cột
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = cellSize; // Đặt chiều rộng của cột
            }

            // Đặt chiều cao cho các hàng
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = cellSize; // Đặt chiều cao của hàng
            } 
            AdjustDataGridViewSize(dataGridView, cellSize);
        }

        private static void AdjustDataGridViewSize(DataGridView dataGridView, int cellSize)
        {
            // Tính toán kích thước của DataGridView dựa trên số hàng và cột hiện tại
            int totalWidth = cellSize * dataGridView.ColumnCount + dataGridView.RowHeadersWidth;
            int totalHeight = cellSize * dataGridView.RowCount + dataGridView.ColumnHeadersHeight;

            // Đặt kích thước chính xác cho DataGridView
            dataGridView.Width = totalWidth;
            dataGridView.Height = totalHeight;          
            // Kích thước của DataGridView sẽ tự động thay đổi theo kích thước nội dung
            //dataGridView.Width = dataGridView.GetPreferredSize(new System.Drawing.Size(0, 0)).Width;
            //dataGridView.Height = dataGridView.GetPreferredSize(new System.Drawing.Size(0, 0)).Height;
        }
    }
}
