using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tl == DialogResult.Yes) Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormLogIn fli = new FormLogIn();
            fli.Show();
            this.Hide();     
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            fQLNV fqlnv = new fQLNV();
            this.Hide();
            fqlnv.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            fQLP fqlP = new fQLP();
            this.Hide();
            fqlP.Show();
        }
    }
}
