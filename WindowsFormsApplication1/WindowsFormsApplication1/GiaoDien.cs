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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }
        private void GiaoDien_Load(object sender, System.EventArgs e)
        {
            // Thêm mã xử lý sự kiện khi Form tải, nếu cần.
        }


      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    
        private Form currFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currFormChild!=null)
            {
                currFormChild.Close();
            }
            currFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.BringToFront();
            childForm.Show();
        }

        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TinhToan());
            lbl_TieuDe.Text = "Tính toán trong mảng 2 chiều";
            
        }

        private void btn_SapXep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_SapXep());
            lbl_TieuDe.Text = "Sắp xếp trong mảng 2 chiều";

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TimKiem());
            lbl_TieuDe.Text = "Tìm kiếm trong mảng 2 chiều";

        }

        private void btnChuyenVi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ChuyenVi());
            lbl_TieuDe.Text = "Chuyển vị trong mảng 2 chiều";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();  // Hiển thị lại form chính
            this.Close();// Đóng form hiện tại (OtherForm)
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn muốn đóng giao diện?", "Đóng", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn Yes
                this.Close();
            }
        }

     


        private void GiaoDien_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Tinh_Toan_MouseEnter(object sender, EventArgs e)
        {
            btn_Tinh_Toan.BackColor = Color.Orange; // Màu nền khi rê chuột vào
            btn_Tinh_Toan.ForeColor = Color.Black; 
        }

        private void btn_Tinh_Toan_MouseLeave(object sender, EventArgs e)
        {
            btn_Tinh_Toan.BackColor = Color.White;     // Màu nền khi rời chuột
            btn_Tinh_Toan.ForeColor = Color.Black;  
        }

        private void btn_Sap_Xep_MouseEnter(object sender, EventArgs e)
        {
            btn_Sap_Xep.BackColor = Color.Orange; // Màu nền khi rê chuột vào
            btn_Sap_Xep.ForeColor = Color.Black;
        }

        private void btn_Sap_Xep_MouseLeave(object sender, EventArgs e)
        {
            btn_Sap_Xep.BackColor = Color.White;     // Màu nền khi rời chuột
            btn_Sap_Xep.ForeColor = Color.Black; 
        }

        private void btn_Tim_Kiem_MouseEnter(object sender, EventArgs e)
        {
            btn_Tim_Kiem.BackColor = Color.Orange; // Màu nền khi rê chuột vào
            btn_Tim_Kiem.ForeColor = Color.Black;
        }

        private void btn_Tim_Kiem_MouseLeave(object sender, EventArgs e)
        {
            btn_Tim_Kiem.BackColor = Color.White; // Màu nền khi rê chuột vào
            btn_Tim_Kiem.ForeColor = Color.Black;
        }

        private void btn_Chuyen_Vi_MouseEnter(object sender, EventArgs e)
        {
            btn_Chuyen_Vi.BackColor = Color.Orange; // Màu nền khi rê chuột vào
            btn_Chuyen_Vi.ForeColor = Color.Black;
        }

        private void btn_Chuyen_Vi_MouseLeave(object sender, EventArgs e)
        {
            btn_Chuyen_Vi.BackColor = Color.White; // Màu nền khi rê chuột vào
            btn_Chuyen_Vi.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

      

      

      

      

     
    }
}
