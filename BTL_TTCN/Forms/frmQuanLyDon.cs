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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BTL_TTCN.Forms
{
    public partial class frmQuanLyDon : Form
    {
        public frmQuanLyDon()
        {
            InitializeComponent();
        }
        private void reset_value()
        {
            cboLoaiDon.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            txtLyDo.Text =string.Empty;
            checkBox1.Checked = false;
        }
        DataTable tblDonTu;
        private void Load_Data()
        {
            string sql = @"
                SELECT MaDon, MaLoaiDon, MaNV, NgayGioBD,NgayGioKT, LyDo, TrangThaiDuyet 
                FROM tblDonTu";
            if (checkBox1.Checked == true)
            {
                // Filter only rows where TrangThaiDuyet = 0
                sql += " WHERE TrangThaiDuyet = 0";
            }
            tblDonTu = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblDonTu;
            dataGridView1.Columns[0].HeaderText = "Mã đơn";
            dataGridView1.Columns[1].HeaderText = "Mã loại đơn";
            dataGridView1.Columns[2].HeaderText = "Mã NV";
            dataGridView1.Columns[3].HeaderText = "Ngày giờ BĐ";
            dataGridView1.Columns[4].HeaderText = "Ngày giờ KT";
            dataGridView1.Columns[5].HeaderText = "Lý do";
            dataGridView1.Columns[6].HeaderText = "Trạng thái";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
        }
        private void frmQuanLyDon_Load(object sender, EventArgs e)
        {
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            Class.Functions.FillCombo("SELECT MaLoaiDon, TenLoaiDon FROM tblLoaiDon", cboLoaiDon, "MaLoaiDon", "TenLoaiDon");
            cboLoaiDon.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaNV, TenNV FROM tblNhanVien", cboMaNV, "MaNV", "TenNV");
            cboMaNV.SelectedIndex = -1;
            Load_Data();
            reset_value();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnDuyet.Enabled = false;
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
                btnDuyet.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }

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
                         $"N'{cboMaNV.SelectedValue.ToString()}', " +
                         $"'{ngayGioBD.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                         $"'{ngayGioKT.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                         $"N'{lyDo}', 0)";

            Functions.RunSql(sql);
            MessageBox.Show("Đã tạo đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            btnDuyet.Enabled = true;
            //btnXoa.Enabled = false;
            reset_value();
            Load_Data();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy chỉ số dòng hiện tại
                int rowIndex = dataGridView1.CurrentRow.Index;

                // Lấy giá trị của cột TrangThaiDuyet từ dòng hiện tại
                int trangThaiDuyet = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TrangThaiDuyet"].Value);

                if (trangThaiDuyet == 1)
                {
                    MessageBox.Show("Đơn đã được duyệt trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lấy giá trị của cột MaDon và MaNV từ dòng hiện tại
                string maDon = dataGridView1.CurrentRow.Cells["MaDon"].Value.ToString();
                string maNV = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString(); // Giả sử bạn có cột này trong DataGridView

                // Cập nhật trạng thái duyệt của đơn
                string sqlUpdate = $"UPDATE tblDonTu SET TrangThaiDuyet = 1 WHERE MaDon = N'{maDon}'";
                Functions.RunSql(sqlUpdate);

                // Thêm bản ghi vào bảng tblDuyetDon
                string maDuyetDon = Class.Functions.CreateKey("DD"); // Giả sử hàm này tạo mã duyệt đơn tự động
                string maNVDuyet = Class.UserSession.UserID.ToString(); // Giả sử bạn lấy được mã NV duyệt từ phiên người dùng
                DateTime ngayDuyet = DateTime.Now;
                string sqlInsert = $"INSERT INTO tblDuyetDon (MaDuyetDon, MaDon, MaNVDuyet, NgayDuyet) " +
                                   $"VALUES (N'{maDuyetDon}', N'{maDon}', N'{maNVDuyet}', '{ngayDuyet.ToString("yyyy-MM-dd HH:mm:ss")}')";
                Functions.RunSql(sqlInsert);

                MessageBox.Show("Đã duyệt đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại dữ liệu
                Load_Data();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn để duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
