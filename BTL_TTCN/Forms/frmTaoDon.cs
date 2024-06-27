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
    public partial class frmTaoDon : Form
    {
        public frmTaoDon()
        {
            InitializeComponent();
        }

        private void reset_value()
        {
            cboLoaiDon.SelectedIndex = -1;
            txtLyDo.Text = string.Empty;
        }
        private void frmTaoDon_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            // btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Text = Class.UserSession.UserID.ToString();
            Class.Functions.FillCombo("SELECT MaLoaiDon, TenLoaiDon FROM tblLoaiDon", cboLoaiDon, "MaLoaiDon", "TenLoaiDon");
            cboLoaiDon.SelectedIndex = -1;
            Load_Data();
        }

        DataTable tblDonTu;
        private void Load_Data()
        {
            string sql = @"
                SELECT MaDon, MaLoaiDon, NgayGioBD,NgayGioKT, LyDo, TrangThaiDuyet 
                FROM tblDonTu
                WHERE MaNV = N'" + txtMaNV.Text + "'";
            tblDonTu = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblDonTu;
            dataGridView1.Columns[0].HeaderText = "Mã đơn";
            dataGridView1.Columns[1].HeaderText = "Mã loại đơn";
            dataGridView1.Columns[2].HeaderText = "Ngày giờ BĐ";
            dataGridView1.Columns[3].HeaderText = "Ngày giờ KT";
            dataGridView1.Columns[4].HeaderText = "Lý do";
            dataGridView1.Columns[5].HeaderText = "Trạng thái";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled=true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            reset_value();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra trang chủ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

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
            if (tblDonTu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btnThem.Enabled == false)
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
                    MessageBox.Show("Đơn đã duyệt không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị của cột MaDon (hoặc MaLichLam tùy vào cấu trúc của dữ liệu)
                string maDon = dataGridView1.CurrentRow.Cells["MaDon"].Value.ToString(); // Thay "MaDon" bằng tên cột chứa mã đơn trong DataGridView của bạn

                // Xóa dòng hiện tại trong DataTable
                tblDonTu.Rows.RemoveAt(rowIndex);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tblDonTu;

                // Cập nhật lại giao diện
                dataGridView1.Refresh();

                // Thực hiện xóa dữ liệu trong cơ sở dữ liệu
                string sqlDelete = $"DELETE FROM tblDonTu WHERE MaDon = N'{maDon}'";
                Functions.RunSql(sqlDelete);

                MessageBox.Show("Đã xóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled==true)
            {
                btnXoa.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboLoaiDon.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn loại đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiDon.Focus();
                return;
            }
            DateTime ngayGioBD = dateTimePicker1.Value;
            DateTime ngayGioKT = dateTimePicker2.Value;

            if (ngayGioKT <= ngayGioBD)
            {
                MessageBox.Show("Ngày giờ kết thúc phải lớn hơn ngày giờ bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker2.Focus();
                return;
            }
            string lyDo = txtLyDo.Text.Trim();

            string sql = $"INSERT INTO tblDonTu (MaDon, MaLoaiDon, MaNV, NgayGioBD, NgayGioKT, LyDo, TrangThaiDuyet) " +
                         $"VALUES (N'" + Class.Functions.CreateKey("MD").ToString() + "', " +
                         $"N'{cboLoaiDon.SelectedValue.ToString()}', " +
                         $"N'{txtMaNV.Text}', " +
                         $"'{ngayGioBD.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                         $"'{ngayGioKT.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                         $"N'{lyDo}', 0)";

            Functions.RunSql(sql);
            MessageBox.Show("Đã tạo đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            reset_value();
            Load_Data();
        }
    }
    
}
