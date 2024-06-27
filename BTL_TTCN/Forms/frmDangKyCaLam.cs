using BTL_TTCN.Class;
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
    public partial class frmDangKyCaLam : Form
    {
        public frmDangKyCaLam()
        {
            InitializeComponent();
        }
        private void reset_value()
        {
            cboCaLam.SelectedIndex = -1;
        }
        DataTable tblLichLam;
        private void Load_Data()
        {
            string sql = @"
                SELECT MaLichLam, MaCa, Ngay, TrangThaiDuyet 
                FROM tblLichLam
                WHERE MaNV = N'" + txtMaNV.Text + "'";
            tblLichLam = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblLichLam;
            dataGridView1.Columns[0].HeaderText = "Mã lịch làm";
            dataGridView1.Columns[1].HeaderText = "Mã ca";
            dataGridView1.Columns[2].HeaderText = "Ngày làm";
            dataGridView1.Columns[3].HeaderText = "Trạng thái duyệt";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            
        }
        private void frmDangKyCaLam_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled= false;
           // btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled= false;
            txtMaNV.Text = Class.UserSession.UserID.ToString();
            Class.Functions.FillCombo("SELECT MaCa, TenCa FROM tblCaLam", cboCaLam, "MaCa", "TenCa");
            cboCaLam.SelectedIndex = -1;
            Load_Data();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra trang chủ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnBoQua.Enabled = true;
            btnLuu.Enabled=true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            reset_value();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboCaLam.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn ca làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCaLam.Focus();
                return;
            }
            string sqlCheck = $"SELECT Ngay FROM tblLichLam WHERE MaNV = N'{txtMaNV.Text}' AND Ngay = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
            if (Functions.CheckKey(sqlCheck))
            {
                MessageBox.Show("Ngày làm việc này đã tồn tại! Chọn ngày làm việc khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return;
            }
            string sql = $"INSERT INTO tblLichLam (MaLichLam, MaNV, MaCa, Ngay, TrangThaiDuyet) VALUES (N'" + Class.Functions.CreateKey("LL").ToString() + "', N'" + txtMaNV.Text.Trim() + "', N'" + cboCaLam.SelectedValue.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "', 0)";
            Functions.RunSql(sql);
            MessageBox.Show($"ĐĂNG KÝ THÀNH CÔNG: \nMã nhân viên: {txtMaNV.Text.Trim()} \nNgày: {dateTimePicker1.Value.ToShortDateString()} \nCa làm: {cboCaLam.Text.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            reset_value();
            Load_Data();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chế độ thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reset_value();
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblLichLam.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(btnThem.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            btnXoa.Enabled = false;

            if (dataGridView1.CurrentRow != null)
            {
                // Lấy ra chỉ số của dòng hiện tại
                int rowIndex = dataGridView1.CurrentRow.Index;

                // Lấy giá trị của cột TrangThaiDuyet từ dòng hiện tại
                int trangThaiDuyet = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TrangThaiDuyet"].Value);

                if (trangThaiDuyet == 1)
                {
                    MessageBox.Show("Lịch đã duyệt không thể xóa đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị của cột MaLichLam (hoặc MaDon tùy vào cấu trúc của dữ liệu)
                string maLichLam = dataGridView1.CurrentRow.Cells["MaLichLam"].Value.ToString(); // Thay "MaLichLam" bằng tên cột chứa mã lịch làm trong DataGridView của bạn

                // Xóa dòng hiện tại trong DataTable
                tblLichLam.Rows.RemoveAt(rowIndex);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tblLichLam;

                // Cập nhật lại giao diện
                dataGridView1.Refresh();

                // Thực hiện xóa dữ liệu trong cơ sở dữ liệu
                string sqlDelete = $"DELETE FROM tblLichLam WHERE MaLichLam = N'{maLichLam}'";
                Functions.RunSql(sqlDelete);

                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn lịch làm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                btnXoa.Enabled = true;
            }
        }
    }
}
