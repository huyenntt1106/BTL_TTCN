using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_TTCN.Forms
{
    public partial class frmXemBangLuong : Form
    {
        public frmXemBangLuong()
        {
            InitializeComponent();
        }

        private void frmXemBangLuong_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            Load_Data();
            Load_DataGridView2(); // Gọi phương thức để tải dữ liệu vào dataGridView2
        }

        DataTable tblKT;   // DataTable cho dataGridView1
        DataTable tblKT2;  // DataTable cho dataGridView2

        // Phương thức tải dữ liệu cho dataGridView1
        private void Load_Data()
        {
            string sql;
            sql = "SELECT MaPhieuLuong, MaKTGT, Thang, Nam, SoNgayCong, SoGioLam, SoGioTangCa, SoLanDiMuon, SoLanVeSom, TongLuong from tblPhieuLuong";
            tblKT = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblKT;
            dataGridView1.Columns[0].HeaderText = "Mã phiếu lương";
            dataGridView1.Columns[1].HeaderText = "Mã khen thưởng, giảm trừ";
            dataGridView1.Columns[2].HeaderText = "Tháng";
            dataGridView1.Columns[3].HeaderText = "Năm";
            dataGridView1.Columns[4].HeaderText = "Số ngày công";
            dataGridView1.Columns[5].HeaderText = "Số giờ làm";
            dataGridView1.Columns[6].HeaderText = "Số giờ tăng ca";
            dataGridView1.Columns[7].HeaderText = "Số lần đi muộn";
            dataGridView1.Columns[8].HeaderText = "Số lần về sớm";
            dataGridView1.Columns[9].HeaderText = "Tổng lương";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // Phương thức tải dữ liệu cho dataGridView2
        private void Load_DataGridView2()
        {
            string sql;
            sql = "SELECT MaKTGT, KhenThuong, GiamTru, PhuCap from tblKhenThuongGiamTru";
            tblKT2 = Class.Functions.GetDataToTable(sql);
            dataGridView2.DataSource = tblKT2;
            dataGridView2.Columns[0].HeaderText = "Mã KTGT";
            dataGridView2.Columns[1].HeaderText = "Khen thưởng";
            dataGridView2.Columns[2].HeaderText = "Giảm trừ";
            dataGridView2.Columns[3].HeaderText = "Phụ cấp";
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void resetvalue()
        {
            // Nội dung hàm reset value còn trống
        }

        private void btnTimkiem1_Click(object sender, EventArgs e)
        {
            string thang = mskThang.Text.Trim();
            string nam = mskNam.Text.Trim();
            string sql = "SELECT MaPhieuLuong, MaKTGT, Thang, Nam, SoNgayCong, SoGioLam, SoGioTangCa, SoLanDiMuon, SoLanVeSom, TongLuong from tblPhieuLuong";
            bool hasCondition = false;

            if (string.IsNullOrEmpty(thang) && string.IsNullOrEmpty(nam))
            {
                MessageBox.Show("Vui lòng nhập tháng hoặc năm để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(thang))
            {
                sql += " WHERE Thang = " + thang;
                hasCondition = true;
            }

            if (!string.IsNullOrEmpty(nam))
            {
                if (hasCondition)
                {
                    sql += " AND Nam = " + nam;
                }
                else
                {
                    sql += " WHERE Nam = " + nam;
                }
            }

            tblKT = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblKT;
        }

        private void btnTimkiem2_Click(object sender, EventArgs e)
        {
            string maKTGT = txtMaKTGT.Text.Trim();
            if (string.IsNullOrEmpty(maKTGT))
            {
                MessageBox.Show("Vui lòng nhập mã KTGT để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "SELECT MaKTGT, KhenThuong, GiamTru, PhuCap from tblKhenThuongGiamTru WHERE MaKTGT = '" + maKTGT + "'";
            tblKT2 = Class.Functions.GetDataToTable(sql);
            dataGridView2.DataSource = tblKT2;
        }
    }
}
