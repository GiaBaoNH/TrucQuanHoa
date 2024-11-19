namespace WindowsFormsApplication1
{
    partial class NhapFile
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
            this.btn_TiepTuc = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_file = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_file)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiepTuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TiepTuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TiepTuc.Location = new System.Drawing.Point(1261, 898);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(140, 63);
            this.btn_TiepTuc.TabIndex = 28;
            this.btn_TiepTuc.Text = "Tiếp Tục";
            this.btn_TiepTuc.UseVisualStyleBackColor = false;
            this.btn_TiepTuc.Click += new System.EventHandler(this.btn_TiepTuc_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Lavender;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xoa.Location = new System.Drawing.Point(971, 199);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 46);
            this.btn_Xoa.TabIndex = 27;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.BackColor = System.Drawing.Color.LightGray;
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Nhap.Location = new System.Drawing.Point(811, 199);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(113, 46);
            this.btn_Nhap.TabIndex = 26;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = false;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(744, 145);
            this.txt_file.Multiline = true;
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(492, 36);
            this.txt_file.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(567, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhập file";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_QuayLai.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.Location = new System.Drawing.Point(421, 888);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(140, 63);
            this.btn_QuayLai.TabIndex = 20;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(748, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 78);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhập file";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.data_file);
            this.panel1.Location = new System.Drawing.Point(447, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 604);
            this.panel1.TabIndex = 29;
            // 
            // data_file
            // 
            this.data_file.BackgroundColor = System.Drawing.Color.Azure;
            this.data_file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_file.GridColor = System.Drawing.Color.Black;
            this.data_file.Location = new System.Drawing.Point(126, 5);
            this.data_file.Name = "data_file";
            this.data_file.RowTemplate.Height = 24;
            this.data_file.Size = new System.Drawing.Size(871, 596);
            this.data_file.TabIndex = 22;
            // 
            // NhapFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 1021);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapFile";
            this.Text = "NhapFile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapFile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TiepTuc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_file;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}