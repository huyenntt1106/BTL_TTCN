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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmResetMK a=new frmResetMK();
            a.Show();
        }
        
        DataTable TK;
        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (txtTenDN.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtMatKhau.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql = "SELECT MatKhau FROM tblTaiKhoan WHERE MaNV = N'" + txtTenDN.Text + "'";
                DataTable table = Functions.GetDataToTable(sql);

                if (table.Rows.Count > 0)
                {
                    string passFromDB = table.Rows[0]["MatKhau"].ToString();

                    // Kiểm tra mật khẩu
                    if (passFromDB.Equals(txtMatKhau.Text))
                    {
                        UserSession.UserID = txtTenDN.Text;
                        txtTenDN.Text = null;
                        txtMatKhau.Text = null;
                        TrangChu a = new TrangChu();
                        a.Show();
                    }
                    else
                    {
                        // Đăng nhập không thành công
                        MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau.Text = null;
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    // Tên đăng nhập không tồn tại
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDN.Text = null;
                    txtTenDN.Focus();
                }
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            txtTenDN.Focus();
        }
        
       
    }
}
