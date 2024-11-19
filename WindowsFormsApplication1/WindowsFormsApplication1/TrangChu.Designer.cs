namespace WindowsFormsApplication1
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btb_NhapMang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Thoat = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thoat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_file);
            this.panel1.Controls.Add(this.btn_Random);
            this.panel1.Controls.Add(this.btb_NhapMang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 838);
            this.panel1.TabIndex = 0;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_file.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Location = new System.Drawing.Point(137, 608);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(324, 111);
            this.btn_file.TabIndex = 3;
            this.btn_file.Text = "Nhập file";
            this.btn_file.UseVisualStyleBackColor = false;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            this.btn_file.MouseEnter += new System.EventHandler(this.btn_file_MouseEnter);
            this.btn_file.MouseLeave += new System.EventHandler(this.btn_file_MouseLeave);
            // 
            // btn_Random
            // 
            this.btn_Random.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Random.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Random.Location = new System.Drawing.Point(137, 438);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(324, 111);
            this.btn_Random.TabIndex = 2;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = false;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            this.btn_Random.MouseEnter += new System.EventHandler(this.btn_Random_MouseEnter);
            this.btn_Random.MouseLeave += new System.EventHandler(this.btn_Random_MouseLeave);
            // 
            // btb_NhapMang
            // 
            this.btb_NhapMang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btb_NhapMang.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_NhapMang.Location = new System.Drawing.Point(137, 268);
            this.btb_NhapMang.Name = "btb_NhapMang";
            this.btb_NhapMang.Size = new System.Drawing.Size(324, 111);
            this.btb_NhapMang.TabIndex = 1;
            this.btb_NhapMang.Text = "Nhập mảng";
            this.btb_NhapMang.UseVisualStyleBackColor = false;
            this.btb_NhapMang.Click += new System.EventHandler(this.btb_BatDau_Click);
            this.btb_NhapMang.MouseEnter += new System.EventHandler(this.btb_NhapMang_MouseEnter);
            this.btb_NhapMang.MouseLeave += new System.EventHandler(this.btb_NhapMang_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 178);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to \r\n   2D array";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(598, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 896);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1550, 814);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.Transparent;
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.Location = new System.Drawing.Point(1922, 3);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(70, 69);
            this.Thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Thoat.TabIndex = 1;
            this.Thoat.TabStop = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Thoat);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1942, 253);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(681, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1305, 69);
            this.label3.TabIndex = 7;
            this.label3.Text = "TRƯỜNG ĐẠI HỌC CÔNG THƯƠNG TP HCM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thoat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btb_NhapMang;
        private System.Windows.Forms.PictureBox Thoat;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

