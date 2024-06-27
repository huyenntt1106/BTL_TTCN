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
    public partial class frmResetMK : Form
    {
        public frmResetMK()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maNV = txtTenDN.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xnMatKhau = txtXNMatKhau.Text;

            // Kiểm tra mã nhân viên có tồn tại trong cơ sở dữ liệu không
            string sqlCheckNV = $"SELECT * FROM tblTaiKhoan WHERE MaNV = '{maNV}'";
            if (!Functions.CheckKey(sqlCheckNV))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Text = string.Empty;
                txtMatKhau.Text = string.Empty;
                txtXNMatKhau.Text = string.Empty;
                txtTenDN.Focus();
                return;
            }

            // Kiểm tra mật khẩu và xác nhận mật khẩu có trùng khớp
            if (matKhau != xnMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXNMatKhau .Text = string.Empty;
                txtXNMatKhau.Focus();
                return;
            }

            // Cập nhật mật khẩu vào cơ sở dữ liệu
            string sqlUpdate = $"UPDATE tblTaiKhoan SET MatKhau = '{matKhau}' WHERE MaNV = '{maNV}'";
            Functions.RunSql(sqlUpdate);
            MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmResetMK_Load(object sender, EventArgs e)
        {

        }
    }
}
