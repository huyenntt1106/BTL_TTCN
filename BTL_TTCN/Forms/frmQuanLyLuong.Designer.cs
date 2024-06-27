namespace BTL_TTCN.Forms
{
    partial class frmQuanLyLuong
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
            this.btnTimkiem2 = new System.Windows.Forms.Button();
            this.txtMaKTGT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mskNam = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimkiem1 = new System.Windows.Forms.Button();
            this.mskThang = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimkiem3 = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKhenthuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhucap = new System.Windows.Forms.TextBox();
            this.txtGiamtru = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(393, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ LƯƠNG NHÂN VIÊN";
            // 
            // btnTimkiem2
            // 
            this.btnTimkiem2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem2.Location = new System.Drawing.Point(603, 481);
            this.btnTimkiem2.Name = "btnTimkiem2";
            this.btnTimkiem2.Size = new System.Drawing.Size(79, 28);
            this.btnTimkiem2.TabIndex = 106;
            this.btnTimkiem2.Text = "Tìm kiếm";
            this.btnTimkiem2.UseVisualStyleBackColor = false;
            this.btnTimkiem2.Click += new System.EventHandler(this.btnTimkiem2_Click);
            // 
            // txtMaKTGT
            // 
            this.txtMaKTGT.Location = new System.Drawing.Point(473, 481);
            this.txtMaKTGT.Name = "txtMaKTGT";
            this.txtMaKTGT.Size = new System.Drawing.Size(100, 22);
            this.txtMaKTGT.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Nhập mã KTGT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 32);
            this.label3.TabIndex = 103;
            this.label3.Text = "Bảng khen thưởng, giảm trừ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(166, 520);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(721, 231);
            this.dataGridView2.TabIndex = 102;
            // 
            // mskNam
            // 
            this.mskNam.Location = new System.Drawing.Point(450, 170);
            this.mskNam.Mask = "0000";
            this.mskNam.Name = "mskNam";
            this.mskNam.Size = new System.Drawing.Size(83, 22);
            this.mskNam.TabIndex = 100;
            this.mskNam.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Nhập năm:";
            // 
            // btnTimkiem1
            // 
            this.btnTimkiem1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem1.Location = new System.Drawing.Point(570, 167);
            this.btnTimkiem1.Name = "btnTimkiem1";
            this.btnTimkiem1.Size = new System.Drawing.Size(129, 28);
            this.btnTimkiem1.TabIndex = 99;
            this.btnTimkiem1.Text = "Tìm kiếm";
            this.btnTimkiem1.UseVisualStyleBackColor = false;
            this.btnTimkiem1.Click += new System.EventHandler(this.btnTimkiem1_Click);
            // 
            // mskThang
            // 
            this.mskThang.Location = new System.Drawing.Point(261, 170);
            this.mskThang.Mask = "00";
            this.mskThang.Name = "mskThang";
            this.mskThang.Size = new System.Drawing.Size(83, 22);
            this.mskThang.TabIndex = 97;
            this.mskThang.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 98;
            this.label13.Text = "Nhập tháng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 175);
            this.dataGridView1.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1066, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 107;
            this.label5.Text = "Bảng chấm công";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(914, 212);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(489, 176);
            this.dataGridView3.TabIndex = 108;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(1125, 170);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(979, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "Nhập mã nhân viên:";
            // 
            // btnTimkiem3
            // 
            this.btnTimkiem3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem3.Location = new System.Drawing.Point(1254, 167);
            this.btnTimkiem3.Name = "btnTimkiem3";
            this.btnTimkiem3.Size = new System.Drawing.Size(79, 28);
            this.btnTimkiem3.TabIndex = 111;
            this.btnTimkiem3.Text = "Tìm kiếm";
            this.btnTimkiem3.UseVisualStyleBackColor = false;
            this.btnTimkiem3.Click += new System.EventHandler(this.btnTimkiem3_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCapnhat.Location = new System.Drawing.Point(1020, 658);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(85, 28);
            this.btnCapnhat.TabIndex = 112;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtKhenthuong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPhucap);
            this.groupBox1.Controls.Add(this.txtGiamtru);
            this.groupBox1.Location = new System.Drawing.Point(939, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 108);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 121;
            this.label7.Text = "Phụ cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 117;
            this.label8.Text = "Khen thưởng:";
            // 
            // txtKhenthuong
            // 
            this.txtKhenthuong.Location = new System.Drawing.Point(103, 28);
            this.txtKhenthuong.Name = "txtKhenthuong";
            this.txtKhenthuong.Size = new System.Drawing.Size(100, 22);
            this.txtKhenthuong.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 119;
            this.label9.Text = "Giảm trừ:";
            // 
            // txtPhucap
            // 
            this.txtPhucap.Location = new System.Drawing.Point(177, 73);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(100, 22);
            this.txtPhucap.TabIndex = 122;
            // 
            // txtGiamtru
            // 
            this.txtGiamtru.Location = new System.Drawing.Point(294, 28);
            this.txtGiamtru.Name = "txtGiamtru";
            this.txtGiamtru.Size = new System.Drawing.Size(100, 22);
            this.txtGiamtru.TabIndex = 120;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(1146, 658);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 28);
            this.btnLuu.TabIndex = 128;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(315, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 32);
            this.label10.TabIndex = 129;
            this.label10.Text = "Danh sách lương";
            // 
            // frmQuanLyLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 778);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnTimkiem3);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimkiem2);
            this.Controls.Add(this.txtMaKTGT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.mskNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimkiem1);
            this.Controls.Add(this.mskThang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyLuong";
            this.Text = "Quản Lý Lương";
            this.Load += new System.EventHandler(this.frmQuanLyLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimkiem2;
        private System.Windows.Forms.TextBox txtMaKTGT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MaskedTextBox mskNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimkiem1;
        private System.Windows.Forms.MaskedTextBox mskThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimkiem3;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKhenthuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhucap;
        private System.Windows.Forms.TextBox txtGiamtru;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label10;
    }
}