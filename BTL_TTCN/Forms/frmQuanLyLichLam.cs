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
    public partial class frmQuanLyLichLam : Form
    {
        public frmQuanLyLichLam()
        {
            InitializeComponent();
        }
        private void reset_value()
        {
            cboCaLam.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            checkBox1.Checked = false;
        }
        DataTable tblLichLam;
        private void Load_Data()
        {
            string sql = @"
                SELECT MaLichLam, MaNV, MaCa, Ngay, TrangThaiDuyet 
                FROM tblLichLam";
            if (checkBox1.Checked==true)
            {
                // Filter only rows where TrangThaiDuyet = 0
                sql += " WHERE TrangThaiDuyet = 0";
            }
            tblLichLam = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblLichLam;
            dataGridView1.Columns[0].HeaderText = "Mã lịch làm";
            dataGridView1.Columns[1].HeaderText = "Mã NV";
            dataGridView1.Columns[2].HeaderText = "Ca làm";
            dataGridView1.Columns[3].HeaderText = "Ngày";
            dataGridView1.Columns[4].HeaderText = "Trạng thái";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";

        }

        private void frmQuanLyLichLam_Load(object sender, EventArgs e)
        {
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            Class.Functions.FillCombo("SELECT MaCa, TenCa FROM tblCaLam", cboCaLam, "MaCa", "TenCa");
            cboCaLam.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaNV, TenNV FROM tblNhanVien", cboMaNV, "MaNV", "TenNV");
            cboMaNV.SelectedIndex = -1;
            Load_Data();
            reset_value();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra trang chủ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
                btnBoQua.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                //btnXoa.Enabled = false;
                btnDuyet.Enabled = false;
                reset_value();
            
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

                if (cboMaNV.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn phải nhập mã NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNV.Focus();
                    return;
                }
                if (cboCaLam.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn phải chọn ca làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCaLam.Focus();
                    return;
                }
                string sqlCheck = $"SELECT Ngay FROM tblLichLam WHERE MaNV = N'{cboMaNV.Text.ToString()}' AND Ngay = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                if (Functions.CheckKey(sqlCheck))
                {
                    MessageBox.Show("Ngày làm việc của nhân viên này đã tồn tại! Chọn ngày làm việc hoặc mã nhân viên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Focus();
                    return;
                }
                string sql = $"INSERT INTO tblLichLam (MaLichLam, MaNV, MaCa, Ngay, TrangThaiDuyet) VALUES (N'" + Class.Functions.CreateKey("LL").ToString() + "', N'" + cboMaNV.SelectedValue.ToString() + "', N'" + cboCaLam.SelectedValue.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "', 0)";
                Functions.RunSql(sql);
                MessageBox.Show($"ĐĂNG KÝ THÀNH CÔNG: \nMã nhân viên: {cboMaNV.Text.Trim()} \nNgày: {dateTimePicker1.Value.ToShortDateString()} \nCa làm: {cboCaLam.Text.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThem.Enabled = true;
                btnBoQua.Enabled = false;
                btnLuu.Enabled = false;
                btnDuyet.Enabled = true;
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
                //btnXoa.Enabled = true;
                btnDuyet.Enabled = true;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNV.Focus();
                return;
            }
            if (tblLichLam.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maNV = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            string maCa = dataGridView1.CurrentRow.Cells["MaCa"].Value.ToString();
            DateTime ngayLam = (DateTime)dataGridView1.CurrentRow.Cells["Ngay"].Value;

            // Đưa dữ liệu lên ComboBox và DateTimePicker
            cboMaNV.SelectedValue = maNV;
            cboCaLam.SelectedValue = maCa;
            dateTimePicker1.Value = ngayLam;
        }
        private void CapNhatDuyetLich(string maLichLam, string maNV)
        {
            DateTime ngayHienTai = DateTime.Now;

            // Format ngày theo định dạng SQL
            string ngayDuyet = ngayHienTai.ToString("yyyy-MM-dd");

            // Tạo mã duyệt lịch mới
            string maDuyetLich = Functions.CreateKey("DL");

            // Tạo câu lệnh SQL để chèn dữ liệu vào bảng tblDuyetLich
            string sqlInsert = $"INSERT INTO tblDuyetLich (MaDuyetLich, MaLichLam, MaNVDuyet, NgayDuyet) " +
                               $"VALUES (N'{maDuyetLich}', N'{maLichLam}', N'{maNV}', '{ngayDuyet}')";

            // Thực thi câu lệnh SQL
            Functions.RunSql(sqlInsert);
        }


        private void btnDuyet_Click(object sender, EventArgs e)
        {
                if (dataGridView1.CurrentRow != null)
                {
                    // Lấy giá trị của Trạng thái duyệt từ dòng hiện tại trong DataGridView
                    int trangThaiDuyet = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TrangThaiDuyet"].Value);


                    if (trangThaiDuyet == 0)
                    {
                        // Nếu Trạng thái duyệt là 0, thực hiện cập nhật lên database
                        string maLichLam = dataGridView1.CurrentRow.Cells["MaLichLam"].Value.ToString();
                        string maNV = Class.UserSession.UserID.ToString();

                        string sqlUpdate = $"UPDATE tblLichLam SET TrangThaiDuyet = 1 WHERE MaLichLam = N'{maLichLam}'";
                        Functions.RunSql(sqlUpdate);
                        CapNhatDuyetLich(maLichLam, maNV);
                        MessageBox.Show("Duyệt lịch làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cập nhật lại dữ liệu trong DataGridView
                        Load_Data();
                        reset_value();
                    }
                    else
                    {
                        // Nếu Trạng thái duyệt đã là 1, hiển thị thông báo
                        MessageBox.Show("Lịch làm này đã được duyệt trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn lịch làm để duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

    }
}
