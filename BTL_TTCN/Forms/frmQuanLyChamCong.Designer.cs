namespace BTL_TTCN.Forms
{
    partial class frmQuanLyChamCong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskNgayden = new System.Windows.Forms.MaskedTextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.rdoTheokhoang = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.mskNgaytu = new System.Windows.Forms.MaskedTextBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.mskTheongay = new System.Windows.Forms.MaskedTextBox();
            this.rdoTheongay = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalichlam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskGioketca = new System.Windows.Forms.MaskedTextBox();
            this.mskGiovaoca = new System.Windows.Forms.MaskedTextBox();
            this.txtMachamcong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskNgay = new System.Windows.Forms.MaskedTextBox();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskNgayden);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.rdoTheokhoang);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.mskNgaytu);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.mskTheongay);
            this.groupBox1.Controls.Add(this.rdoTheongay);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboPhongban);
            this.groupBox1.Location = new System.Drawing.Point(608, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 200);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // mskNgayden
            // 
            this.mskNgayden.Location = new System.Drawing.Point(322, 38);
            this.mskNgayden.Mask = "00/00/0000";
            this.mskNgayden.Name = "mskNgayden";
            this.mskNgayden.Size = new System.Drawing.Size(83, 22);
            this.mskNgayden.TabIndex = 81;
            this.mskNgayden.ValidatingType = typeof(System.DateTime);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoc.Location = new System.Drawing.Point(323, 139);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(77, 28);
            this.btnLoc.TabIndex = 85;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // rdoTheokhoang
            // 
            this.rdoTheokhoang.AutoSize = true;
            this.rdoTheokhoang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheokhoang.Location = new System.Drawing.Point(21, 36);
            this.rdoTheokhoang.Name = "rdoTheokhoang";
            this.rdoTheokhoang.Size = new System.Drawing.Size(123, 23);
            this.rdoTheokhoang.TabIndex = 77;
            this.rdoTheokhoang.TabStop = true;
            this.rdoTheokhoang.Text = "Theo khoảng";
            this.rdoTheokhoang.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 75;
            this.label11.Text = "Tìm theo tên:";
            // 
            // mskNgaytu
            // 
            this.mskNgaytu.Location = new System.Drawing.Point(190, 38);
            this.mskNgaytu.Mask = "00/00/0000";
            this.mskNgaytu.Name = "mskNgaytu";
            this.mskNgaytu.Size = new System.Drawing.Size(83, 22);
            this.mskNgaytu.TabIndex = 79;
            this.mskNgaytu.ValidatingType = typeof(System.DateTime);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(122, 111);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(183, 22);
            this.txtTimkiem.TabIndex = 74;
            // 
            // mskTheongay
            // 
            this.mskTheongay.Location = new System.Drawing.Point(162, 71);
            this.mskTheongay.Mask = "00/00/0000";
            this.mskTheongay.Name = "mskTheongay";
            this.mskTheongay.Size = new System.Drawing.Size(100, 22);
            this.mskTheongay.TabIndex = 83;
            this.mskTheongay.ValidatingType = typeof(System.DateTime);
            // 
            // rdoTheongay
            // 
            this.rdoTheongay.AutoSize = true;
            this.rdoTheongay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheongay.Location = new System.Drawing.Point(20, 71);
            this.rdoTheongay.Name = "rdoTheongay";
            this.rdoTheongay.Size = new System.Drawing.Size(104, 23);
            this.rdoTheongay.TabIndex = 78;
            this.rdoTheongay.TabStop = true;
            this.rdoTheongay.Text = "Theo ngày";
            this.rdoTheongay.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 16);
            this.label12.TabIndex = 80;
            this.label12.Text = "Từ:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem.Location = new System.Drawing.Point(322, 72);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(77, 28);
            this.btnTimkiem.TabIndex = 76;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 82;
            this.label13.Text = "Đến:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Phòng ban:";
            // 
            // cboPhongban
            // 
            this.cboPhongban.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboPhongban.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhongban.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Items.AddRange(new object[] {
            "Kinh Doanh",
            "CSKH"});
            this.cboPhongban.Location = new System.Drawing.Point(122, 160);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(183, 23);
            this.cboPhongban.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "QUẢN LÝ CHẤM CÔNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(999, 207);
            this.dataGridView1.TabIndex = 99;
            // 
            // txtPhat
            // 
            this.txtPhat.Location = new System.Drawing.Point(473, 155);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(56, 22);
            this.txtPhat.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 116;
            this.label9.Text = "Phạt:";
            // 
            // txtPhep
            // 
            this.txtPhep.Location = new System.Drawing.Point(353, 155);
            this.txtPhep.Name = "txtPhep";
            this.txtPhep.Size = new System.Drawing.Size(56, 22);
            this.txtPhep.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 114;
            this.label8.Text = "Phép:";
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(392, 116);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(100, 22);
            this.txtTinhtrang.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = "Tình trạng:";
            // 
            // txtMalichlam
            // 
            this.txtMalichlam.Location = new System.Drawing.Point(144, 154);
            this.txtMalichlam.Name = "txtMalichlam";
            this.txtMalichlam.Size = new System.Drawing.Size(100, 22);
            this.txtMalichlam.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Mã lịch làm:";
            // 
            // mskGioketca
            // 
            this.mskGioketca.Location = new System.Drawing.Point(397, 74);
            this.mskGioketca.Mask = "90:00";
            this.mskGioketca.Name = "mskGioketca";
            this.mskGioketca.Size = new System.Drawing.Size(100, 22);
            this.mskGioketca.TabIndex = 109;
            this.mskGioketca.ValidatingType = typeof(System.DateTime);
            // 
            // mskGiovaoca
            // 
            this.mskGiovaoca.Location = new System.Drawing.Point(397, 36);
            this.mskGiovaoca.Mask = "90:00";
            this.mskGiovaoca.Name = "mskGiovaoca";
            this.mskGiovaoca.Size = new System.Drawing.Size(100, 22);
            this.mskGiovaoca.TabIndex = 108;
            this.mskGiovaoca.ValidatingType = typeof(System.DateTime);
            // 
            // txtMachamcong
            // 
            this.txtMachamcong.Location = new System.Drawing.Point(144, 115);
            this.txtMachamcong.Name = "txtMachamcong";
            this.txtMachamcong.Size = new System.Drawing.Size(100, 22);
            this.txtMachamcong.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Giờ kết ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 104;
            this.label5.Text = "Giờ vào ca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "Mã chấm công:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTennhanvien);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.mskNgay);
            this.groupBox2.Controls.Add(this.txtPhat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPhep);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTinhtrang);
            this.groupBox2.Controls.Add(this.txtMachamcong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMalichlam);
            this.groupBox2.Controls.Add(this.mskGiovaoca);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mskGioketca);
            this.groupBox2.Location = new System.Drawing.Point(30, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 188);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chấm công";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(144, 32);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(100, 22);
            this.txtTennhanvien.TabIndex = 120;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 119;
            this.label14.Text = "Tên nhân viên:";
            // 
            // mskNgay
            // 
            this.mskNgay.Location = new System.Drawing.Point(144, 73);
            this.mskNgay.Mask = "00/00/0000";
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(100, 22);
            this.mskNgay.TabIndex = 118;
            this.mskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBoqua.Location = new System.Drawing.Point(641, 508);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(77, 28);
            this.btnBoqua.TabIndex = 124;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDong.Location = new System.Drawing.Point(743, 508);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(77, 28);
            this.btnDong.TabIndex = 123;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(540, 508);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 28);
            this.btnLuu.TabIndex = 122;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(433, 508);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 28);
            this.btnSua.TabIndex = 121;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(333, 508);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 28);
            this.btnXoa.TabIndex = 120;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(230, 508);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 28);
            this.btnThem.TabIndex = 119;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 559);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyChamCong";
            this.Text = "Quản lý chấm công";
            this.Load += new System.EventHandler(this.frmQuanLyChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskNgayden;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.RadioButton rdoTheokhoang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskNgaytu;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.MaskedTextBox mskTheongay;
        private System.Windows.Forms.RadioButton rdoTheongay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPhongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalichlam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskGioketca;
        private System.Windows.Forms.MaskedTextBox mskGiovaoca;
        private System.Windows.Forms.TextBox txtMachamcong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.MaskedTextBox mskNgay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTennhanvien;
    }
}