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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            DocFile();
            
        }
        string path = @"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\OutputFileLog\OutputFileLog\bin\Debug\FileLog.txt";
        void DocFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    ThongBao(sr.ReadToEnd());
                }
            }
        }
        void ThongBao(string x)
        {
            StreamReader sr = new StreamReader(path);
            if (!x.Equals(""))
            {
                Label lb = new Label() { Width = 300 };
                lb.Text = x;
                flpThongBao.Controls.Add(lb);
            }
        }
        void GhiFile()
        {
            string path = @"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\OutputFileLog\OutputFileLog\bin\Debug\FileLog.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Đăng xuất lúc:  " + DateTime.Now.ToString("hh:mm:ss"));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*FDangNhap fdn = new FDangNhap();
            fdn.ShowDialog();*/
            GhiFile();
            Application.Exit();
        }
    }
}
