using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_TTCN.Forms
{
    public partial class frmQuanLyLuong : Form
    {
        SqlConnection con;
        public frmQuanLyLuong()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-FRLG1EC;Initial Catalog=TTCN;Integrated Security=True;Encrypt=False");

        }

        private void frmQuanLyLuong_Load(object sender, EventArgs e)
        {
            // Kết nối CSDL khi form được tải
            Class.Functions.ketnoi();

            // Tải dữ liệu vào DataGridView1
            Load_DataGridView1();
            Load_DataGridView2();
            Load_DataGridView3();
        }

        DataTable tblPhieuLuong;  // DataTable cho dataGridView1

        private void Load_DataGridView1()
        {
            string sql = "SELECT tblPhieuLuong.MaPhieuLuong, tblPhieuLuong.MaNV, " +
                 "tblPhieuLuong.MaKTGT, tblPhieuLuong.Thang, tblPhieuLuong.Nam, " +
                 "tblPhieuLuong.SoNgayCong, tblPhieuLuong.SoGioLam, tblPhieuLuong.SoGioTangCa, " +
                 "tblPhieuLuong.SoLanDiMuon, tblPhieuLuong.SoLanVeSom, tblPhieuLuong.TongLuong " +
                 "FROM dbo.tblPhieuLuong " +
                 "INNER JOIN dbo.tblNhanVien ON tblPhieuLuong.MaNV = tblNhanVien.MaNV";

            // Lấy dữ liệu từ câu truy vấn vào DataTable
            tblPhieuLuong = Class.Functions.GetDataToTable(sql);

            // Đặt DataTable làm nguồn dữ liệu của DataGridView1
            dataGridView1.DataSource = tblPhieuLuong;

            // Đổi tên hiển thị của các cột trong DataGridView1
            dataGridView1.Columns[0].HeaderText = "Mã phiếu lương";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên"; // Thay đổi hiển thị từ "Tên nhân viên" thành "Mã nhân viên"
            dataGridView1.Columns[2].HeaderText = "Mã khen thưởng, giảm trừ";
            dataGridView1.Columns[3].HeaderText = "Tháng";
            dataGridView1.Columns[4].HeaderText = "Năm";
            dataGridView1.Columns[5].HeaderText = "Số ngày công";
            dataGridView1.Columns[6].HeaderText = "Số giờ làm";
            dataGridView1.Columns[7].HeaderText = "Số giờ tăng ca";
            dataGridView1.Columns[8].HeaderText = "Số lần đi muộn";
            dataGridView1.Columns[9].HeaderText = "Số lần về sớm";
            dataGridView1.Columns[10].HeaderText = "Tổng lương";

            // Không cho phép người dùng thêm dòng mới trong DataGridView1
            dataGridView1.AllowUserToAddRows = false;

            // Chỉnh sửa dữ liệu trong DataGridView1 bằng mã nguồn
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        DataTable tblChamCong;  // DataTable cho dataGridView3

        private void Load_DataGridView3()
        {
            try
            {
                // Câu truy vấn SQL để lấy dữ liệu từ bảng tblChamCong và tblLichLam
                string sql = "SELECT tblChamCong.MaChamCong, tblChamCong.MaLichLam, " +
                             "tblChamCong.GioVaoCa, tblChamCong.GioKetCa, " +
                             "tblChamCong.TinhTrang, tblChamCong.Phep, " +
                             "tblChamCong.Phat, tblLichLam.MaNV " +
                             "FROM dbo.tblChamCong " +
                             "INNER JOIN dbo.tblLichLam ON tblChamCong.MaLichLam = tblLichLam.MaLichLam";

                // Lấy dữ liệu từ câu truy vấn vào DataTable
                tblChamCong = Class.Functions.GetDataToTable(sql);

                // Di chuyển cột MaNV lên đầu
                if (tblChamCong.Columns.Contains("MaNV"))
                {
                    tblChamCong.Columns["MaNV"].SetOrdinal(0);
                }

                // Đặt DataTable làm nguồn dữ liệu của DataGridView3
                dataGridView3.DataSource = tblChamCong;

                // Đổi tên hiển thị của các cột trong DataGridView3 nếu cần
                dataGridView3.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataGridView3.Columns["MaChamCong"].HeaderText = "Mã chấm công";
                dataGridView3.Columns["MaLichLam"].HeaderText = "Mã lịch làm";
                dataGridView3.Columns["GioVaoCa"].HeaderText = "Giờ vào ca";
                dataGridView3.Columns["GioKetCa"].HeaderText = "Giờ kết ca";
                dataGridView3.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dataGridView3.Columns["Phep"].HeaderText = "Phép";
                dataGridView3.Columns["Phat"].HeaderText = "Phạt";

                // Không cho phép người dùng thêm dòng mới trong DataGridView3
                dataGridView3.AllowUserToAddRows = false;

                // Chỉnh sửa dữ liệu trong DataGridView3 bằng mã nguồn
                dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        DataTable tblKhenThuongGiamTru;  // DataTable cho dataGridView2

        private void Load_DataGridView2()
        {
            try
            {
                string sql = "SELECT tblPhieuLuong.MaNV, tblKhenThuongGiamTru.MaKTGT, " +
                             "tblKhenThuongGiamTru.KhenThuong, tblKhenThuongGiamTru.GiamTru, " +
                             "tblKhenThuongGiamTru.PhuCap " +
                             "FROM dbo.tblKhenThuongGiamTru " +
                             "INNER JOIN dbo.tblPhieuLuong ON tblKhenThuongGiamTru.MaKTGT = tblPhieuLuong.MaKTGT";

                tblKhenThuongGiamTru = Class.Functions.GetDataToTable(sql);

                if (tblKhenThuongGiamTru.Columns.Contains("MaNV"))
                {
                    tblKhenThuongGiamTru.Columns["MaNV"].SetOrdinal(0);
                }

                dataGridView2.DataSource = tblKhenThuongGiamTru;

                dataGridView2.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataGridView2.Columns["MaKTGT"].HeaderText = "Mã khen thưởng, giảm trừ";
                dataGridView2.Columns["KhenThuong"].HeaderText = "Loại khen thưởng";
                dataGridView2.Columns["GiamTru"].HeaderText = "Loại giảm trừ";
                dataGridView2.Columns["PhuCap"].HeaderText = "Phụ cấp";

                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;

                // Đăng ký sự kiện CellClick và SelectionChanged
                dataGridView2.CellClick += dataGridView2_CellClick;
                dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

                // Ban đầu làm mờ hai nút btnCapnhat và btnLuu khi không có dòng nào được chọn
                UpdateButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void UpdateButtonState()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Nếu có ít nhất một dòng được chọn, cho phép hai nút btnCapnhat và btnLuu
                btnCapnhat.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
            {
                // Ngược lại, làm mờ hai nút btnCapnhat và btnLuu
                btnCapnhat.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng đã chọn một dòng hợp lệ
            {
                // Cập nhật trạng thái của các nút khi có thay đổi trong lựa chọn
                UpdateButtonState();

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string khenthuong = row.Cells["KhenThuong"].Value.ToString();
                string giamtru = row.Cells["GiamTru"].Value.ToString();
                string phucap = row.Cells["PhuCap"].Value.ToString();

                // Hiển thị dữ liệu vào các ô tương ứng
                txtKhenthuong.Text = khenthuong;
                txtGiamtru.Text = giamtru;
                txtPhucap.Text = phucap;
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn không
            {
                // Cập nhật trạng thái của các nút khi có thay đổi trong lựa chọn
                UpdateButtonState();

                DataGridViewRow row = dataGridView2.SelectedRows[0];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string khenthuong = row.Cells["KhenThuong"].Value.ToString();
                string giamtru = row.Cells["GiamTru"].Value.ToString();
                string phucap = row.Cells["PhuCap"].Value.ToString();

                // Hiển thị dữ liệu vào các ô tương ứng
                txtKhenthuong.Text = khenthuong;
                txtGiamtru.Text = giamtru;
                txtPhucap.Text = phucap;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            txtKhenthuong.ReadOnly = false;
            txtGiamtru.ReadOnly = false;
            txtPhucap.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lưu các thay đổi vào các ô
            string khenthuong = txtKhenthuong.Text;
            string giamtru = txtGiamtru.Text;
            string phucap = txtPhucap.Text;

            // Cập nhật dữ liệu vào các ô
            dataGridView2.CurrentRow.Cells["KhenThuong"].Value = khenthuong;
            dataGridView2.CurrentRow.Cells["GiamTru"].Value = giamtru;
            dataGridView2.CurrentRow.Cells["PhuCap"].Value = phucap;

            // Đưa các ô về chế độ chỉ đọc
            txtKhenthuong.ReadOnly = true;
            txtGiamtru.ReadOnly = true;
            txtPhucap.ReadOnly = true;

            // Hiển thị thông báo
            MessageBox.Show("Bạn đã cập nhật giảm trừ, khen thưởng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimkiem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ mskThang và mskNam
                string thang = mskThang.Text;
                string nam = mskNam.Text;

                // Xây dựng câu truy vấn SQL ban đầu
                string sql = "SELECT tblPhieuLuong.MaPhieuLuong, tblPhieuLuong.MaNV, " +
                             "tblPhieuLuong.MaKTGT, tblPhieuLuong.Thang, tblPhieuLuong.Nam, " +
                             "tblPhieuLuong.SoNgayCong, tblPhieuLuong.SoGioLam, tblPhieuLuong.SoGioTangCa, " +
                             "tblPhieuLuong.SoLanDiMuon, tblPhieuLuong.SoLanVeSom, tblPhieuLuong.TongLuong " +
                             "FROM dbo.tblPhieuLuong " +
                             "INNER JOIN dbo.tblNhanVien ON tblPhieuLuong.MaNV = tblNhanVien.MaNV " +
                             "WHERE 1 = 1"; // Bắt đầu câu truy vấn

                // Thêm điều kiện tìm kiếm nếu người dùng đã nhập tháng
                if (!string.IsNullOrEmpty(thang))
                {
                    sql += " AND tblPhieuLuong.Thang = @Thang";
                }

                // Thêm điều kiện tìm kiếm nếu người dùng đã nhập năm
                if (!string.IsNullOrEmpty(nam))
                {
                    sql += " AND tblPhieuLuong.Nam = @Nam";
                }

                // Thực hiện truy vấn SQL với các tham số Thang và Nam nếu có
                DataTable tblPhieuLuong = new DataTable();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (!string.IsNullOrEmpty(thang))
                    {
                        cmd.Parameters.AddWithValue("@Thang", thang);
                    }
                    if (!string.IsNullOrEmpty(nam))
                    {
                        cmd.Parameters.AddWithValue("@Nam", nam);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tblPhieuLuong);
                }

                // Đặt DataTable làm nguồn dữ liệu của DataGridView1
                dataGridView1.DataSource = tblPhieuLuong;

                // Đổi tên hiển thị của các cột trong DataGridView1
                dataGridView1.Columns[0].HeaderText = "Mã phiếu lương";
                dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
                dataGridView1.Columns[2].HeaderText = "Mã khen thưởng, giảm trừ";
                dataGridView1.Columns[3].HeaderText = "Tháng";
                dataGridView1.Columns[4].HeaderText = "Năm";
                dataGridView1.Columns[5].HeaderText = "Số ngày công";
                dataGridView1.Columns[6].HeaderText = "Số giờ làm";
                dataGridView1.Columns[7].HeaderText = "Số giờ tăng ca";
                dataGridView1.Columns[8].HeaderText = "Số lần đi muộn";
                dataGridView1.Columns[9].HeaderText = "Số lần về sớm";
                dataGridView1.Columns[10].HeaderText = "Tổng lương";

                // Không cho phép người dùng thêm dòng mới trong DataGridView1
                dataGridView1.AllowUserToAddRows = false;

                // Chỉnh sửa dữ liệu trong DataGridView1 bằng mã nguồn
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiem3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the employee code from txtMaNV
                string maNV = txtMaNV.Text.Trim();

                // Validate if maNV is not empty
                if (string.IsNullOrEmpty(maNV))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SQL query to retrieve data based on employee code
                string sql = "SELECT tblChamCong.MaChamCong, tblChamCong.MaLichLam, " +
                             "tblChamCong.GioVaoCa, tblChamCong.GioKetCa, " +
                             "tblChamCong.TinhTrang, tblChamCong.Phep, " +
                             "tblChamCong.Phat, tblLichLam.MaNV " +
                             "FROM dbo.tblChamCong " +
                             "INNER JOIN dbo.tblLichLam ON tblChamCong.MaLichLam = tblLichLam.MaLichLam " +
                             "WHERE tblLichLam.MaNV = @MaNV";

                // Create a DataTable to hold the results
                DataTable dt = new DataTable();

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Assuming `con` is your SqlConnection instance
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                // Bind the DataTable to dataGridView3
                dataGridView3.DataSource = dt;

                // Optionally, you can customize column headers or other properties of dataGridView3 here

                // Display a message if no data found
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho mã nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiem2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the MaKTGT from txtMaKTGT
                string maKTGT = txtMaKTGT.Text.Trim();

                // Check if the input is not empty
                if (string.IsNullOrEmpty(maKTGT))
                {
                    MessageBox.Show("Vui lòng nhập mã khen thưởng, giảm trừ để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SQL query to retrieve data based on MaKTGT
                string sql = "SELECT tblPhieuLuong.MaNV, tblKhenThuongGiamTru.MaKTGT, " +
                             "tblKhenThuongGiamTru.KhenThuong, tblKhenThuongGiamTru.GiamTru, " +
                             "tblKhenThuongGiamTru.PhuCap " +
                             "FROM dbo.tblKhenThuongGiamTru " +
                             "INNER JOIN dbo.tblPhieuLuong ON tblKhenThuongGiamTru.MaKTGT = tblPhieuLuong.MaKTGT " +
                             "WHERE tblKhenThuongGiamTru.MaKTGT = @MaKTGT";

                // Parameterized query to prevent SQL injection
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(sql, con)) // Ensure 'con' is your SqlConnection instance
                {
                    cmd.Parameters.AddWithValue("@MaKTGT", maKTGT);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                // Bind the DataTable to dataGridView2
                dataGridView2.DataSource = dt;

                // Optionally, handle the column headers and other display settings here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
