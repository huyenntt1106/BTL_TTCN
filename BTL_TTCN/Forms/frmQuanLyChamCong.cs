using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BTL_TTCN.Forms
{
    public partial class frmQuanLyChamCong : Form
    {
        DataTable tblKT;

        public frmQuanLyChamCong()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick; // Gắn sự kiện CellClick cho dataGridView1
        }

        private void frmQuanLyChamCong_Load(object sender, EventArgs e)
        {
            // Kết nối cơ sở dữ liệu và tải dữ liệu lên DataGridView
            Class.Functions.ketnoi(); // Đảm bảo rằng phương thức kết nối đã được định nghĩa trong Class.Functions
            Load_Data();
            ResetValue(); // Thay vì resetvalue()
        }

        private void ResetValue()
        {
            // Đặt các điều khiển nhập liệu về giá trị mặc định
            txtTennhanvien.Text = "";
            mskNgay.Text = "";
            txtMachamcong.Text = "";
            txtMalichlam.Text = "";
            mskGiovaoca.Text = "";
            mskGioketca.Text = "";
            txtTinhtrang.Text = "";
            txtPhep.Text = "";
            txtPhat.Text = "";

            // Đặt trạng thái các nút và DataGridView
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void Load_Data()
        {
            try
            {
                string sql = "SELECT tblNhanVien.TenNV, tblLichLam.Ngay, tblChamCong.MaChamCong, tblChamCong.MaLichLam, tblChamCong.GioVaoCa, tblChamCong.GioKetCa, tblChamCong.TinhTrang, tblChamCong.Phep, tblChamCong.Phat " +
                             "FROM tblChamCong " +
                             "JOIN tblLichLam ON tblChamCong.MaLichLam = tblLichLam.MaLichLam " +
                             "JOIN tblNhanVien ON tblLichLam.MaNV = tblNhanVien.MaNV";

                tblKT = Class.Functions.GetDataToTable(sql); // Đảm bảo phương thức GetDataToTable đã được định nghĩa trong Class.Functions
                dataGridView1.DataSource = tblKT;

                // Đặt thứ tự và tên các cột hiển thị
                dataGridView1.Columns["TenNV"].DisplayIndex = 0;
                dataGridView1.Columns["TenNV"].HeaderText = "Tên nhân viên";
                dataGridView1.Columns["Ngay"].DisplayIndex = 1;
                dataGridView1.Columns["Ngay"].HeaderText = "Ngày";
                dataGridView1.Columns["MaChamCong"].HeaderText = "Mã chấm công";
                dataGridView1.Columns["MaLichLam"].HeaderText = "Mã lịch làm";
                dataGridView1.Columns["GioVaoCa"].HeaderText = "Giờ vào ca";
                dataGridView1.Columns["GioKetCa"].HeaderText = "Giờ kết ca";
                dataGridView1.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dataGridView1.Columns["Phep"].HeaderText = "Phép";
                dataGridView1.Columns["Phat"].HeaderText = "Phạt";

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi người dùng click vào một ô trong DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Hiển thị dữ liệu từ DataGridView lên các điều khiển nhập liệu
                txtTennhanvien.Text = row.Cells["TenNV"].Value.ToString();
                mskNgay.Text = row.Cells["Ngay"].Value.ToString();
                txtMachamcong.Text = row.Cells["MaChamCong"].Value.ToString();
                txtMalichlam.Text = row.Cells["MaLichLam"].Value.ToString();
                mskGiovaoca.Text = row.Cells["GioVaoCa"].Value.ToString();
                mskGioketca.Text = row.Cells["GioKetCa"].Value.ToString();
                txtTinhtrang.Text = row.Cells["TinhTrang"].Value.ToString();
                txtPhep.Text = row.Cells["Phep"].Value.ToString();
                txtPhat.Text = row.Cells["Phat"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMachamcong.Text))
            {
                // Thêm mới dữ liệu
                DataRow newRow = tblKT.NewRow();
                newRow["TenNV"] = txtTennhanvien.Text; // Tạm thời để trống, vì không biết bạn muốn nhập nhân viên nào

                // Kiểm tra và chuyển đổi ngày tháng từ mskNgay.Text
                DateTime ngay;
                if (DateTime.TryParse(mskNgay.Text, out ngay))
                {
                    newRow["Ngay"] = ngay;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi thành công
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập lại ngày theo định dạng đúng.");
                    return; // Ngừng việc lưu nếu ngày không hợp lệ
                }

                newRow["MaChamCong"] = txtMachamcong.Text;
                newRow["MaLichLam"] = txtMalichlam.Text;
                newRow["GioVaoCa"] = mskGiovaoca.Text;
                newRow["GioKetCa"] = mskGioketca.Text;
                newRow["TinhTrang"] = txtTinhtrang.Text;
                newRow["Phep"] = txtPhep.Text;
                newRow["Phat"] = txtPhat.Text;

                tblKT.Rows.Add(newRow);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tblKT;

                // Reset các ô nhập liệu sau khi lưu
                ResetValue();

                MessageBox.Show("Đã thêm mới dữ liệu thành công!");
            }
            else
            {
                // Sửa đổi dữ liệu
                DataRow[] rowsToUpdate = tblKT.Select($"MaChamCong = '{txtMachamcong.Text}'");
                if (rowsToUpdate.Length > 0)
                {
                    DataRow rowToUpdate = rowsToUpdate[0];

                    // Cập nhật dữ liệu từ các điều khiển nhập liệu
                    rowToUpdate["TenNV"] = txtTennhanvien.Text;
                    // Cập nhật các trường dữ liệu khác tương tự
                    DateTime ngay;
                    if (DateTime.TryParse(mskNgay.Text, out ngay))
                    {
                        rowToUpdate["Ngay"] = ngay;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi thành công
                        MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập lại ngày theo định dạng đúng.");
                        return; // Ngừng việc lưu nếu ngày không hợp lệ
                    }

                    rowToUpdate["GioVaoCa"] = mskGiovaoca.Text;
                    rowToUpdate["GioKetCa"] = mskGioketca.Text;
                    rowToUpdate["TinhTrang"] = txtTinhtrang.Text;
                    rowToUpdate["Phep"] = txtPhep.Text;
                    rowToUpdate["Phat"] = txtPhat.Text;

                    // Cập nhật lại DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tblKT;

                    // Reset các ô nhập liệu sau khi lưu
                    ResetValue();

                    MessageBox.Show("Đã cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dòng cần cập nhật trong DataTable.");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị khóa chính của dòng đang chọn (vd: MaChamCong)
                string maChamCong = selectedRow.Cells["MaChamCong"].Value.ToString();

                // Tìm dòng cần xóa trong DataTable tblKT
                for (int i = tblKT.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = tblKT.Rows[i];
                    if (row["MaChamCong"].ToString() == maChamCong)
                    {
                        tblKT.Rows.Remove(row);
                        break; // Sau khi xóa, thoát khỏi vòng lặp
                    }
                }

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tblKT;

                // Thông báo xóa thành công (nếu cần)
                MessageBox.Show("Đã xóa dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Load_Data();    // Tải lại dữ liệu vào DataGridView
            ResetValue();   // Đặt các điều khiển nhập liệu về giá trị mặc định
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Xây dựng câu truy vấn SQL cơ bản
            string sql = "SELECT tblNhanVien.TenNV, tblLichLam.Ngay, tblChamCong.MaChamCong, tblChamCong.MaLichLam, " +
                         "tblChamCong.GioVaoCa, tblChamCong.GioKetCa, tblChamCong.TinhTrang, tblChamCong.Phep, tblChamCong.Phat " +
                         "FROM tblChamCong " +
                         "JOIN tblLichLam ON tblChamCong.MaLichLam = tblLichLam.MaLichLam " +
                         "JOIN tblNhanVien ON tblLichLam.MaNV = tblNhanVien.MaNV";

            // Biến để lưu các điều kiện WHERE của câu truy vấn
            List<string> conditions = new List<string>();

            // Kiểm tra và thêm điều kiện tên nhân viên
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                conditions.Add($"tblNhanVien.TenNV LIKE '%{txtTimkiem.Text}%'");
            }

            // Kiểm tra và thêm điều kiện phòng ban (nếu có)
            if (cboPhongban.SelectedIndex != -1)
            {
                string selectedPhongBan = cboPhongban.SelectedItem.ToString();
                conditions.Add($"tblNhanVien.PhongBan = '{selectedPhongBan}'");
            }

            // Nếu có điều kiện, thêm vào câu truy vấn SQL
            if (conditions.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", conditions);
            }

            try
            {
                // Lấy dữ liệu từ SQL đã xây dựng
                tblKT = Class.Functions.GetDataToTable(sql);

                // Gán lại DataSource cho DataGridView
                dataGridView1.DataSource = tblKT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tblNhanVien.TenNV, tblLichLam.Ngay, tblChamCong.MaChamCong, tblChamCong.MaLichLam, " +
                 "tblChamCong.GioVaoCa, tblChamCong.GioKetCa, tblChamCong.TinhTrang, tblChamCong.Phep, tblChamCong.Phat " +
                 "FROM tblChamCong " +
                 "JOIN tblLichLam ON tblChamCong.MaLichLam = tblLichLam.MaLichLam " +
                 "JOIN tblNhanVien ON tblLichLam.MaNV = tblNhanVien.MaNV";

            List<string> conditions = new List<string>();

            if (rdoTheongay.Checked)
            {
                if (!string.IsNullOrEmpty(mskTheongay.Text))
                {
                    DateTime ngay;
                    if (DateTime.TryParse(mskTheongay.Text, out ngay))
                    {
                        conditions.Add($"tblLichLam.Ngay = '{ngay.ToString("yyyy-MM-dd")}'");
                    }
                    else
                    {
                        MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập lại ngày theo định dạng đúng.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ngày cần tìm kiếm.");
                    return;
                }
            }
            else if (rdoTheokhoang.Checked)
            {
                if (!string.IsNullOrEmpty(mskNgaytu.Text) && !string.IsNullOrEmpty(mskNgayden.Text))
                {
                    DateTime tuNgay, denNgay;
                    if (DateTime.TryParse(mskNgaytu.Text, out tuNgay) && DateTime.TryParse(mskNgayden.Text, out denNgay))
                    {
                        conditions.Add($"tblLichLam.Ngay BETWEEN '{tuNgay.ToString("yyyy-MM-dd")}' AND '{denNgay.ToString("yyyy-MM-dd")}'");
                    }
                    else
                    {
                        MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập lại ngày theo định dạng đúng.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ ngày bắt đầu và ngày kết thúc.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm là 'Theo ngày' hoặc 'Theo khoảng ngày'.");
                return;
            }

            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                conditions.Add($"tblNhanVien.TenNV LIKE '%{txtTimkiem.Text}%'");
            }

            if (cboPhongban.SelectedIndex != -1)
            {
                string selectedPhongBan = cboPhongban.SelectedItem.ToString();
                conditions.Add($"tblNhanVien.PhongBan = '{selectedPhongBan}'");
            }

            if (conditions.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", conditions);
            }

            try
            {
                tblKT = Class.Functions.GetDataToTable(sql);
                dataGridView1.DataSource = tblKT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm dữ liệu: " + ex.Message);
            }
        }
    }
}
