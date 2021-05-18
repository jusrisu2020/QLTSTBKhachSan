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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        
// BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit?", "Notifition",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (tl == DialogResult.OK) Application.Exit();
        }
// HIỂN THỊ MÀU CHO BUTTON 
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Aqua;
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.White;
        }
        private void btnExitt_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Aqua;
        }
        private void btnExitt_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
        }       
    }
}
