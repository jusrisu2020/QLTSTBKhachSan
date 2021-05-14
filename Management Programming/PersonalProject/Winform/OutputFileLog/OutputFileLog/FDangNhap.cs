using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputFileLog
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        void GhiFile()
        {
            string path = @"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\OutputFileLog\OutputFileLog\bin\Debug\FileLog.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Đăng nhập lúc:  " + DateTime.Now.ToString("hh:mm:ss"));
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FMain fm = new FMain();
            this.Hide();
            fm.ShowDialog();
            GhiFile();
        }
    }
}
