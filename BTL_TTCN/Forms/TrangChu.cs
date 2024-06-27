using BTL_TTCN.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_TTCN
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            //Class.Functions.ketnoi();
        }

        private void chấmCôngCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChamCongCaNhan a = new frmChamCongCaNhan();
            a.Show();
        }

        private void quảnLýChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyChamCong a = new frmQuanLyChamCong();
            a.Show();
        }

        private void xemBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemBangLuong a = new frmXemBangLuong();
            a.Show();
        }

        private void quảnLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyLuong a = new frmQuanLyLuong(); a.Show();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKyCaLam a=new frmDangKyCaLam();
            a.Show();
        }

        private void quảnLýLịchLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyLichLam a=new frmQuanLyLichLam();
            a.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận Đăng Xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tạoĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoDon a=new frmTaoDon(); a.Show();
        }

        private void quảnLýĐơnTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDon a=new frmQuanLyDon(); a.Show();
        }
    }
}
