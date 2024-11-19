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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn muốn đóng giao diện?", "Đóng", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn Yes
                this.Close();
            }
        }

        private void btb_BatDau_Click(object sender, EventArgs e)
        {
            NhapMang2C nm = new NhapMang2C();
            nm.Show();
            this.Visible = false;
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
           
            RandomForm gd = new RandomForm();
            gd.Show();
            this.Visible = false;
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            NhapFile nf = new NhapFile();
            nf.Show();
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btb_NhapMang_MouseEnter(object sender, EventArgs e)
        {
            btb_NhapMang.BackColor = Color.LightBlue;
           
        }

        private void btb_NhapMang_MouseLeave(object sender, EventArgs e)
        {
            btb_NhapMang.BackColor = Color.DarkSeaGreen;
        }

        private void btn_Random_MouseEnter(object sender, EventArgs e)
        {
            btn_Random.BackColor = Color.LightBlue;
        }

        private void btn_Random_MouseLeave(object sender, EventArgs e)
        {
            btn_Random.BackColor = Color.DarkSeaGreen;
        }

        private void btn_file_MouseEnter(object sender, EventArgs e)
        {
            btn_file.BackColor = Color.LightBlue;
        }

        private void btn_file_MouseLeave(object sender, EventArgs e)
        {
            btn_file.BackColor = Color.DarkSeaGreen;
        }
    }
}
