namespace BTL_TTCN.Forms
{
    partial class frmXemBangLuong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskThang = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimkiem1 = new System.Windows.Forms.Button();
            this.mskNam = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKTGT = new System.Windows.Forms.TextBox();
            this.btnTimkiem2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG LƯƠNG CÁ NHÂN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 231);
            this.dataGridView1.TabIndex = 18;
            // 
            // mskThang
            // 
            this.mskThang.Location = new System.Drawing.Point(155, 95);
            this.mskThang.Mask = "00";
            this.mskThang.Name = "mskThang";
            this.mskThang.Size = new System.Drawing.Size(83, 22);
            this.mskThang.TabIndex = 86;
            this.mskThang.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 87;
            this.label13.Text = "Nhập tháng:";
            // 
            // btnTimkiem1
            // 
            this.btnTimkiem1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem1.Location = new System.Drawing.Point(178, 140);
            this.btnTimkiem1.Name = "btnTimkiem1";
            this.btnTimkiem1.Size = new System.Drawing.Size(129, 28);
            this.btnTimkiem1.TabIndex = 88;
            this.btnTimkiem1.Text = "Tìm kiếm";
            this.btnTimkiem1.UseVisualStyleBackColor = false;
            this.btnTimkiem1.Click += new System.EventHandler(this.btnTimkiem1_Click);
            // 
            // mskNam
            // 
            this.mskNam.Location = new System.Drawing.Point(344, 95);
            this.mskNam.Mask = "0000";
            this.mskNam.Name = "mskNam";
            this.mskNam.Size = new System.Drawing.Size(83, 22);
            this.mskNam.TabIndex = 89;
            this.mskNam.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Nhập năm:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(532, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(407, 231);
            this.dataGridView2.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 32);
            this.label3.TabIndex = 92;
            this.label3.Text = "Bảng khen thưởng, giảm trừ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "Nhập mã KTGT:";
            // 
            // txtMaKTGT
            // 
            this.txtMaKTGT.Location = new System.Drawing.Point(709, 145);
            this.txtMaKTGT.Name = "txtMaKTGT";
            this.txtMaKTGT.Size = new System.Drawing.Size(100, 22);
            this.txtMaKTGT.TabIndex = 94;
            // 
            // btnTimkiem2
            // 
            this.btnTimkiem2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem2.Location = new System.Drawing.Point(839, 145);
            this.btnTimkiem2.Name = "btnTimkiem2";
            this.btnTimkiem2.Size = new System.Drawing.Size(79, 28);
            this.btnTimkiem2.TabIndex = 95;
            this.btnTimkiem2.Text = "Tìm kiếm";
            this.btnTimkiem2.UseVisualStyleBackColor = false;
            this.btnTimkiem2.Click += new System.EventHandler(this.btnTimkiem2_Click);
            // 
            // frmXemBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
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
            this.Name = "frmXemBangLuong";
            this.Text = "Xem Bảng Lương";
            this.Load += new System.EventHandler(this.frmXemBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTimkiem1;
        private System.Windows.Forms.MaskedTextBox mskNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKTGT;
        private System.Windows.Forms.Button btnTimkiem2;
    }
}