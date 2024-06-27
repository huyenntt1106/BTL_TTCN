using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_TTCN.Forms
{
    public partial class frmChamCongCaNhan : Form
    {
        private bool btnVaoca_Clicked = false; // Cờ để kiểm tra đã xử lý sự kiện btnVaoca_Click hay chưa
        private int newIndex = -1; // Biến để lưu index của dòng mới nhất

        public frmChamCongCaNhan()
        {
            InitializeComponent();
            btnVaoca.Click += btnVaoca_Click; // Thêm sự kiện Click cho nút btnVaoca
            btnKetca.Enabled = false; // Vô hiệu hóa nút btnKetca ban đầu
        }

        private void frmChamCongCaNhan_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            Load_Data();
            resetvalue();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        DataTable tblKT;

        private void Load_Data()
        {
            string sql = "SELECT tblLichLam.Ngay, tblChamCong.MaChamCong, tblChamCong.MaLichLam, tblLichLam.MaCa, tblChamCong.GioVaoCa, tblChamCong.GioKetCa, tblChamCong.TinhTrang, tblChamCong.Phep, tblChamCong.Phat " +
                         "FROM tblChamCong " +
                         "JOIN tblLichLam ON tblChamCong.MaLichLam = tblLichLam.MaLichLam";
            tblKT = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblKT;

            // Đặt tên các cột hiển thị
            dataGridView1.Columns[0].HeaderText = "Ngày";
            dataGridView1.Columns[1].HeaderText = "Mã chấm công";
            dataGridView1.Columns[2].HeaderText = "Mã lịch làm";
            dataGridView1.Columns[3].HeaderText = "Mã ca"; // Đảm bảo cột MaCa được đặt tên chính xác
            dataGridView1.Columns[4].HeaderText = "Giờ vào ca";
            dataGridView1.Columns[5].HeaderText = "Giờ kết ca";
            dataGridView1.Columns[6].HeaderText = "Tình trạng";
            dataGridView1.Columns[7].HeaderText = "Phép";
            dataGridView1.Columns[8].HeaderText = "Phạt";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void resetvalue()
        {
            mskNgay.Text = "";
            txtMachamcong.Text = "";
            txtMalichlam.Text = "";
            mskGioketca.Text = "";
            mskGiovaoca.Text = "";
            txtTinhtrang.Text = "";
            txtPhep.Text = "";
            txtPhat.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
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

        private void btnVaoca_Click(object sender, EventArgs e)
        {
            if (btnVaoca_Clicked)
            {
                // Nếu sự kiện đã được xử lý rồi thì không làm gì nữa
                return;
            }

            // Đánh dấu rằng sự kiện đã được xử lý
            btnVaoca_Clicked = true;

            // Tạo mã chấm công tự động
            Random rand = new Random();
            int randomNumber = rand.Next(10, 100); // Sinh số ngẫu nhiên từ 10 đến 99
            string maChamCong = "CC" + randomNumber.ToString();
            txtMachamcong.Text = maChamCong;

            // Máy tự chọn mã lịch làm
            string[] maLichLams = { "LL01", "LL02", "LL03" };
            string maLichLam = maLichLams[rand.Next(maLichLams.Length)];
            txtMalichlam.Text = maLichLam;

            // Mã ca cố định là CL03
            string maCa = "CL03";

            // Ghi nhận giờ vào ca hiện tại
            DateTime now = DateTime.Now;
            string gioVaoCa = now.ToString("HH:mm:ss");
            mskGiovaoca.Text = gioVaoCa;

            // Ghi nhận ngày hiện tại
            string ngayHienTai = now.ToString("dd/MM/yyyy");
            mskNgay.Text = ngayHienTai;

            // Kiểm tra giờ vào ca
            DateTime startShiftTime = DateTime.Parse("08:00:00");
            if (now < startShiftTime)
            {
                MessageBox.Show("Bạn đã vào ca sớm", "Thông báo");
                txtTinhtrang.Text = "Vào ca sớm"; // Cập nhật txtTinhtrang
            }
            else if (now > startShiftTime)
            {
                MessageBox.Show("Bạn đã vào ca muộn", "Thông báo");
                txtTinhtrang.Text = "Vào ca muộn"; // Cập nhật txtTinhtrang
            }
            else
            {
                MessageBox.Show("Bạn đã vào ca đúng giờ", "Thông báo");
                txtTinhtrang.Text = "Vào ca đúng giờ"; // Cập nhật txtTinhtrang
            }

            // Thêm dòng mới vào DataTable
            DataRow newRow = tblKT.NewRow();
            newRow["Ngay"] = now.Date; // Lấy ngày hiện tại
            newRow["MaChamCong"] = maChamCong;
            newRow["MaLichLam"] = maLichLam;
            newRow["MaCa"] = maCa; // Thêm mã ca vào dòng mới
            newRow["GioVaoCa"] = gioVaoCa;
            newRow["GioKetCa"] = DBNull.Value; // Đặt giá trị ban đầu là DBNull
            newRow["TinhTrang"] = txtTinhtrang.Text; // Cập nhật tình trạng vào DataTable
            newRow["Phep"] = "";
            newRow["Phat"] = "";

            // Thêm dòng mới vào tblKT
            tblKT.Rows.Add(newRow);

            // Lưu index của dòng mới nhất
            newIndex = tblKT.Rows.Count - 1;

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tblKT;

            // Vô hiệu hóa nút btnVaoca và kích hoạt nút btnKetca sau khi đã nhấn btnVaoca
            btnVaoca.Enabled = false;
            btnKetca.Enabled = true;
        }



        private void btnKetca_Click(object sender, EventArgs e)
        {
            // Chỉnh sửa giờ kết ca vào dòng mới nhất đã được tạo ra từ btnVaoca_Click
            if (newIndex != -1 && newIndex < tblKT.Rows.Count)
            {
                DateTime now = DateTime.Now;
                string gioKetCa = now.ToString("HH:mm:ss");
                tblKT.Rows[newIndex]["GioKetCa"] = gioKetCa;

                // Cập nhật lại trường mskGioketca.Text
                mskGioketca.Text = gioKetCa;

                // Kiểm tra giờ kết ca
                DateTime endShiftTime = DateTime.Parse("17:00:00");
                if (now < endShiftTime)
                {
                    MessageBox.Show("Bạn đã kết ca sớm", "Thông báo");
                }
                else if (now > endShiftTime)
                {
                    MessageBox.Show("Bạn đã kết ca muộn", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn đã kết ca đúng giờ", "Thông báo");
                }

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tblKT;
            }

                // Ẩn nút btnKetca sau khi đã xử lý
                btnKetca.Enabled = false;
        }


    }
}
