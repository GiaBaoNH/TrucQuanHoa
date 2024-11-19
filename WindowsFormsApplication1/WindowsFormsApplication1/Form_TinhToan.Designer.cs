namespace WindowsFormsApplication1
{
    partial class Form_TinhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLyThuyet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XoaAll = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.nDong = new System.Windows.Forms.NumericUpDown();
            this.nCot = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hthiketqua = new System.Windows.Forms.TextBox();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cob_TinhToan = new System.Windows.Forms.ComboBox();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCot)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1695, 1102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 1047);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(11, 829);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(873, 172);
            this.panel6.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lý thuyết :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(895, 19);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.Controls.Add(this.lblLyThuyet);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(873, 234);
            this.panel5.TabIndex = 14;
            // 
            // lblLyThuyet
            // 
            this.lblLyThuyet.AutoSize = true;
            this.lblLyThuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyThuyet.Location = new System.Drawing.Point(12, 18);
            this.lblLyThuyet.Name = "lblLyThuyet";
            this.lblLyThuyet.Size = new System.Drawing.Size(145, 32);
            this.lblLyThuyet.TabIndex = 0;
            this.lblLyThuyet.Text = "Lý thuyết :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btn_XoaAll);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.nDong);
            this.panel2.Controls.Add(this.nCot);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.hthiketqua);
            this.panel2.Controls.Add(this.lbl_KetQua);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.cob_TinhToan);
            this.panel2.Controls.Add(this.btn_Tinh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 315);
            this.panel2.TabIndex = 7;
            // 
            // btn_XoaAll
            // 
            this.btn_XoaAll.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_XoaAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaAll.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_XoaAll.Location = new System.Drawing.Point(608, 253);
            this.btn_XoaAll.Name = "btn_XoaAll";
            this.btn_XoaAll.Size = new System.Drawing.Size(162, 50);
            this.btn_XoaAll.TabIndex = 14;
            this.btn_XoaAll.Text = "Xóa tất cả";
            this.btn_XoaAll.UseVisualStyleBackColor = false;
            this.btn_XoaAll.Click += new System.EventHandler(this.btn_XoaAll_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Reset.Location = new System.Drawing.Point(608, 128);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(162, 50);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // nDong
            // 
            this.nDong.Location = new System.Drawing.Point(364, 272);
            this.nDong.Name = "nDong";
            this.nDong.Size = new System.Drawing.Size(90, 22);
            this.nDong.TabIndex = 12;
            this.nDong.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nDong.ValueChanged += new System.EventHandler(this.nDong_ValueChanged);
            // 
            // nCot
            // 
            this.nCot.Location = new System.Drawing.Point(363, 216);
            this.nCot.Name = "nCot";
            this.nCot.Size = new System.Drawing.Size(90, 22);
            this.nCot.TabIndex = 11;
            this.nCot.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập dòng cần xóa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập cột cần xóa :";
            // 
            // hthiketqua
            // 
            this.hthiketqua.Location = new System.Drawing.Point(236, 146);
            this.hthiketqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hthiketqua.Multiline = true;
            this.hthiketqua.Name = "hthiketqua";
            this.hthiketqua.Size = new System.Drawing.Size(156, 32);
            this.hthiketqua.TabIndex = 8;
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(84, 146);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(128, 32);
            this.lbl_KetQua.TabIndex = 6;
            this.lbl_KetQua.Text = "Kết quả :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Xoa.Location = new System.Drawing.Point(608, 188);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(162, 50);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // cob_TinhToan
            // 
            this.cob_TinhToan.FormattingEnabled = true;
            this.cob_TinhToan.Items.AddRange(new object[] {
            "Tổng các phần tử trong mảng",
            "Tổng các phần tử chẵn",
            "Tổng các phần tử lẻ",
            "Tổng các phần tử đường chéo chính",
            "Tổng các phần tử đường chéo phụ"});
            this.cob_TinhToan.Location = new System.Drawing.Point(236, 86);
            this.cob_TinhToan.Name = "cob_TinhToan";
            this.cob_TinhToan.Size = new System.Drawing.Size(308, 24);
            this.cob_TinhToan.TabIndex = 1;
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Tinh.Location = new System.Drawing.Point(608, 65);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(162, 50);
            this.btn_Tinh.TabIndex = 3;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = false;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phép toán";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(82, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(781, 489);
            this.panel4.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Form_TinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TinhToan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form_TinhToan";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCot)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox hthiketqua;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cob_TinhToan;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_XoaAll;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.NumericUpDown nDong;
        private System.Windows.Forms.NumericUpDown nCot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLyThuyet;




    }
}