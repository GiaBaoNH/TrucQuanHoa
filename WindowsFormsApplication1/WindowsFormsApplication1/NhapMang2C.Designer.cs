namespace WindowsFormsApplication1
{
    partial class NhapMang2C
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.data_Mang2C = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TiepTuc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nCot = new System.Windows.Forms.NumericUpDown();
            this.nDong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.data_Mang2C)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(658, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập mảng 2 chiều";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.LightBlue;
            this.btn_QuayLai.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.Location = new System.Drawing.Point(504, 904);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(140, 58);
            this.btn_QuayLai.TabIndex = 10;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click_1);
            // 
            // data_Mang2C
            // 
            this.data_Mang2C.BackgroundColor = System.Drawing.Color.Azure;
            this.data_Mang2C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Mang2C.GridColor = System.Drawing.Color.Black;
            this.data_Mang2C.Location = new System.Drawing.Point(206, 3);
            this.data_Mang2C.Name = "data_Mang2C";
            this.data_Mang2C.RowTemplate.Height = 24;
            this.data_Mang2C.Size = new System.Drawing.Size(763, 611);
            this.data_Mang2C.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(644, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhập số cột :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(644, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập số dòng :";
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.BackColor = System.Drawing.Color.LightGray;
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Nhap.Location = new System.Drawing.Point(1156, 143);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(128, 46);
            this.btn_Nhap.TabIndex = 16;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = false;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Lavender;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xoa.Location = new System.Drawing.Point(1156, 206);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(128, 46);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.BackColor = System.Drawing.Color.LightBlue;
            this.btn_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiepTuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TiepTuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TiepTuc.Location = new System.Drawing.Point(1346, 904);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(140, 58);
            this.btn_TiepTuc.TabIndex = 18;
            this.btn_TiepTuc.Text = "Tiếp Tục";
            this.btn_TiepTuc.UseVisualStyleBackColor = false;
            this.btn_TiepTuc.Click += new System.EventHandler(this.btn_TiepTuc_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.data_Mang2C);
            this.panel1.Location = new System.Drawing.Point(502, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 617);
            this.panel1.TabIndex = 20;
            // 
            // nCot
            // 
            this.nCot.Location = new System.Drawing.Point(888, 160);
            this.nCot.Name = "nCot";
            this.nCot.Size = new System.Drawing.Size(215, 22);
            this.nCot.TabIndex = 12;
            // 
            // nDong
            // 
            this.nDong.Location = new System.Drawing.Point(888, 206);
            this.nDong.Name = "nDong";
            this.nDong.Size = new System.Drawing.Size(215, 22);
            this.nDong.TabIndex = 21;
            // 
            // NhapMang2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1483, 974);
            this.Controls.Add(this.nDong);
            this.Controls.Add(this.nCot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "NhapMang2C";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapMang2C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Mang2C)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.DataGridView data_Mang2C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TiepTuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nCot;
        private System.Windows.Forms.NumericUpDown nDong;
    }
}