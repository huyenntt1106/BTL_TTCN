namespace BTL_TTCN.Forms
{
    partial class frmChamCongCaNhan
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
            this.mskGioketca = new System.Windows.Forms.MaskedTextBox();
            this.mskGiovaoca = new System.Windows.Forms.MaskedTextBox();
            this.txtMachamcong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKetca = new System.Windows.Forms.Button();
            this.btnVaoca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMalichlam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskNgay = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHẤM CÔNG CÁ NHÂN";
            // 
            // mskGioketca
            // 
            this.mskGioketca.Location = new System.Drawing.Point(653, 90);
            this.mskGioketca.Mask = "90:00";
            this.mskGioketca.Name = "mskGioketca";
            this.mskGioketca.Size = new System.Drawing.Size(100, 22);
            this.mskGioketca.TabIndex = 27;
            this.mskGioketca.ValidatingType = typeof(System.DateTime);
            // 
            // mskGiovaoca
            // 
            this.mskGiovaoca.Location = new System.Drawing.Point(443, 86);
            this.mskGiovaoca.Mask = "90:00";
            this.mskGiovaoca.Name = "mskGiovaoca";
            this.mskGiovaoca.Size = new System.Drawing.Size(100, 22);
            this.mskGiovaoca.TabIndex = 26;
            this.mskGiovaoca.ValidatingType = typeof(System.DateTime);
            // 
            // txtMachamcong
            // 
            this.txtMachamcong.Location = new System.Drawing.Point(163, 120);
            this.txtMachamcong.Name = "txtMachamcong";
            this.txtMachamcong.Size = new System.Drawing.Size(100, 22);
            this.txtMachamcong.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giờ kết ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giờ vào ca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã chấm công:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày:";
            // 
            // btnKetca
            // 
            this.btnKetca.BackColor = System.Drawing.Color.IndianRed;
            this.btnKetca.Location = new System.Drawing.Point(621, 123);
            this.btnKetca.Name = "btnKetca";
            this.btnKetca.Size = new System.Drawing.Size(96, 37);
            this.btnKetca.TabIndex = 19;
            this.btnKetca.Text = "Kết ca";
            this.btnKetca.UseVisualStyleBackColor = false;
            this.btnKetca.Click += new System.EventHandler(this.btnKetca_Click);
            // 
            // btnVaoca
            // 
            this.btnVaoca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVaoca.Location = new System.Drawing.Point(388, 123);
            this.btnVaoca.Name = "btnVaoca";
            this.btnVaoca.Size = new System.Drawing.Size(96, 37);
            this.btnVaoca.TabIndex = 18;
            this.btnVaoca.Text = "Vào ca";
            this.btnVaoca.UseVisualStyleBackColor = false;
            this.btnVaoca.Click += new System.EventHandler(this.btnVaoca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 219);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtMalichlam
            // 
            this.txtMalichlam.Location = new System.Drawing.Point(163, 169);
            this.txtMalichlam.Name = "txtMalichlam";
            this.txtMalichlam.Size = new System.Drawing.Size(100, 22);
            this.txtMalichlam.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã lịch làm:";
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(438, 175);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(100, 22);
            this.txtTinhtrang.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tình trạng:";
            // 
            // txtPhep
            // 
            this.txtPhep.Location = new System.Drawing.Point(602, 173);
            this.txtPhep.Name = "txtPhep";
            this.txtPhep.Size = new System.Drawing.Size(56, 22);
            this.txtPhep.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Phép:";
            // 
            // txtPhat
            // 
            this.txtPhat.Location = new System.Drawing.Point(722, 173);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(56, 22);
            this.txtPhat.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(674, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Phạt:";
            // 
            // mskNgay
            // 
            this.mskNgay.Location = new System.Drawing.Point(163, 79);
            this.mskNgay.Mask = "00/00/0000";
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(100, 22);
            this.mskNgay.TabIndex = 25;
            this.mskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // frmChamCongCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPhat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMalichlam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskGioketca);
            this.Controls.Add(this.mskGiovaoca);
            this.Controls.Add(this.mskNgay);
            this.Controls.Add(this.txtMachamcong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKetca);
            this.Controls.Add(this.btnVaoca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmChamCongCaNhan";
            this.Text = "Chấm công cá nhân";
            this.Load += new System.EventHandler(this.frmChamCongCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskGioketca;
        private System.Windows.Forms.MaskedTextBox mskGiovaoca;
        private System.Windows.Forms.TextBox txtMachamcong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKetca;
        private System.Windows.Forms.Button btnVaoca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMalichlam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskNgay;
    }
}