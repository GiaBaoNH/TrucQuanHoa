namespace WindowsFormsApplication1
{
    partial class Form_TimKiem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.nK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.cob_TinhToan = new System.Windows.Forms.ComboBox();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLyThuyet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nK)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 1041);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lbl_KetQua);
            this.panel2.Controls.Add(this.cob_TinhToan);
            this.panel2.Controls.Add(this.btn_Tinh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 275);
            this.panel2.TabIndex = 11;
            // 
            // nK
            // 
            this.nK.Location = new System.Drawing.Point(344, 151);
            this.nK.Name = "nK";
            this.nK.Size = new System.Drawing.Size(137, 22);
            this.nK.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập số cần tìm :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(917, 37);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(84, 207);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(128, 32);
            this.lbl_KetQua.TabIndex = 6;
            this.lbl_KetQua.Text = "Kết quả :";
            this.lbl_KetQua.Click += new System.EventHandler(this.lbl_KetQua_Click);
            // 
            // cob_TinhToan
            // 
            this.cob_TinhToan.FormattingEnabled = true;
            this.cob_TinhToan.Items.AddRange(new object[] {
            "Tìm kiếm số k trong mảng",
            "Tìm số lớn nhất trong mảng",
            "Tìm số nhỏ nhất trong mảng",
            "Tìm các số nguyên tố trong mảng"});
            this.cob_TinhToan.Location = new System.Drawing.Point(247, 90);
            this.cob_TinhToan.Name = "cob_TinhToan";
            this.cob_TinhToan.Size = new System.Drawing.Size(321, 24);
            this.cob_TinhToan.TabIndex = 1;
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Tinh.Location = new System.Drawing.Point(675, 125);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(151, 65);
            this.btn_Tinh.TabIndex = 3;
            this.btn_Tinh.Text = "Tìm";
            this.btn_Tinh.UseVisualStyleBackColor = false;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm :";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(150, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 532);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 518);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.Controls.Add(this.lblLyThuyet);
            this.panel5.Location = new System.Drawing.Point(3, 819);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(866, 172);
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
            // Form_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TimKiem";
            this.Text = "Form_TimKiem";
            this.Load += new System.EventHandler(this.Form_TimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nK)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.ComboBox cob_TinhToan;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLyThuyet;



    }
}