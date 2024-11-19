namespace WindowsFormsApplication1
{
    partial class Form_ChuyenVi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nCot2 = new System.Windows.Forms.NumericUpDown();
            this.nDong2 = new System.Windows.Forms.NumericUpDown();
            this.nCot1 = new System.Windows.Forms.NumericUpDown();
            this.nDong1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ChuyenVi = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_SapXep = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLyThuyet = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDong1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_SapXep)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(838, 801);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nCot2);
            this.panel2.Controls.Add(this.nDong2);
            this.panel2.Controls.Add(this.nCot1);
            this.panel2.Controls.Add(this.nDong1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_ChuyenVi);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_KetQua);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 276);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nCot2
            // 
            this.nCot2.Location = new System.Drawing.Point(370, 168);
            this.nCot2.Name = "nCot2";
            this.nCot2.Size = new System.Drawing.Size(204, 22);
            this.nCot2.TabIndex = 17;
            // 
            // nDong2
            // 
            this.nDong2.Location = new System.Drawing.Point(370, 217);
            this.nDong2.Name = "nDong2";
            this.nDong2.Size = new System.Drawing.Size(204, 22);
            this.nDong2.TabIndex = 16;
            // 
            // nCot1
            // 
            this.nCot1.Location = new System.Drawing.Point(370, 80);
            this.nCot1.Name = "nCot1";
            this.nCot1.Size = new System.Drawing.Size(204, 22);
            this.nCot1.TabIndex = 15;
            this.nCot1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nCot1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nDong1
            // 
            this.nDong1.Location = new System.Drawing.Point(370, 121);
            this.nDong1.Name = "nDong1";
            this.nDong1.Size = new System.Drawing.Size(204, 22);
            this.nDong1.TabIndex = 14;
            this.nDong1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập cột cần chuyển vị: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhập dòng cần chuyển vị:";
            // 
            // btn_ChuyenVi
            // 
            this.btn_ChuyenVi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_ChuyenVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChuyenVi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ChuyenVi.Location = new System.Drawing.Point(636, 67);
            this.btn_ChuyenVi.Name = "btn_ChuyenVi";
            this.btn_ChuyenVi.Size = new System.Drawing.Size(148, 54);
            this.btn_ChuyenVi.TabIndex = 11;
            this.btn_ChuyenVi.Text = "Chuyển vị";
            this.btn_ChuyenVi.UseVisualStyleBackColor = false;
            this.btn_ChuyenVi.Click += new System.EventHandler(this.btn_ChuyenVi_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Reset.Location = new System.Drawing.Point(636, 187);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(148, 54);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 35);
            this.panel3.TabIndex = 7;
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(13, 75);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(136, 32);
            this.lbl_KetQua.TabIndex = 6;
            this.lbl_KetQua.Text = "Nhập cột:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Xoa.Location = new System.Drawing.Point(636, 127);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(148, 54);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập dòng: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.data_SapXep);
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 496);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // data_SapXep
            // 
            this.data_SapXep.BackgroundColor = System.Drawing.Color.Azure;
            this.data_SapXep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_SapXep.Location = new System.Drawing.Point(43, 3);
            this.data_SapXep.Name = "data_SapXep";
            this.data_SapXep.RowTemplate.Height = 24;
            this.data_SapXep.Size = new System.Drawing.Size(744, 464);
            this.data_SapXep.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.Controls.Add(this.lblLyThuyet);
            this.panel5.Location = new System.Drawing.Point(12, 810);
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
            // Form_ChuyenVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 1055);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form_ChuyenVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ChuyenVi";
            this.Load += new System.EventHandler(this.Form_ChuyenVi_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDong1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_SapXep)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_SapXep;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_ChuyenVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nCot2;
        private System.Windows.Forms.NumericUpDown nDong2;
        private System.Windows.Forms.NumericUpDown nCot1;
        private System.Windows.Forms.NumericUpDown nDong1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLyThuyet;



    }
}