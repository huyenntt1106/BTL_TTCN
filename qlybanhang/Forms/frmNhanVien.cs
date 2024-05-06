using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlybanhang.Class;
using System.Data.SqlClient;

namespace qlybanhang.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_Data();
        }
        DataTable tblNV;
        private void Load_Data()
        {
            string sql;
            sql = "SELECT Manhanvien, Tennhanvien, Gioitinh, Diachi, Dienthoai, Ngaysinh FROM tblNhanvien";
            tblNV=Class.Function.GetDataToTable(sql);
            dataGridView1.DataSource = tblNV;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Điện thoại";
            dataGridView1.Columns[5].HeaderText = "Ngày sinh";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(tblNV.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTenNV.Text = dataGridView1.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDT.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
            mskNgaysinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();


         
            if (dataGridView1.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
           
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void resetvalue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiachi.Text = "";
            chkGioitinh.Checked = false;
            mskNgaysinh.Text = "";
            mskDT.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetvalue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text =="")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if(txtTenNV.Text=="")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if(txtDiachi.Text=="")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDT.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDT.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            

            if (!Function.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            string gt;
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            string sql = "select MaNhanVien from tblNhanVien where MaNhanVien=N'" + txtMaNV.Text + "'";
           
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNhanVien,TenNhanVien,GioiTinh, DiaChi, DienThoai, NgaySinh) VALUES(N'" + txtMaNV.Text + "', N'" + txtTenNV.Text+ "', N'" + gt + "', N'" + txtDiachi.Text + "', '" + mskDT.Text + "', '" + Function.ConvertDateTime(mskNgaysinh.Text) + "')";

            Class.Function.RunSql(sql);
            Load_Data();
            resetvalue();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if(tblNV.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDT.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Function.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanVien SET  TenNhanVien=N'" +
            txtTenNV.Text.Trim().ToString() +
                                "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
                                "',Dienthoai='" + mskDT.Text.ToString() + "',Gioitinh=N'" + gt +
                                "',Ngaysinh='" + Function.ConvertDateTime(mskNgaysinh.Text) +
                                "' WHERE Manhanvien=N'" + txtMaNV.Text + "'";
            Class.Function.RunSql(sql);
            Load_Data();
            resetvalue();
            btnBoqua.Enabled = false;

        }
    }
}
