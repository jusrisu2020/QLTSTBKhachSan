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
    public partial class FFL2 : Form
    {
        public FFL2()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\OutputFileLog\OutputFileLog\bin\Debug\FileLog.txt";


        void Loop(string x)
        {
            if(!x.Equals(""))
            {
                Label lb = new Label() { Width = 300 };
                lb.Text = x;
                flpThongBao.Controls.Add(lb);
            }
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {

                    txtDoc.Text = sr.ReadToEnd();
                }
            }
           /* StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(lbUserName.Text + " Đã đăng nhập vào lúc:  " + DateTime.Now.ToString("hh:mm:ss"));
            sw.Close();
            StreamReader sr = new StreamReader(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\OutputFileLog\OutputFileLog\bin\Debug\FileLog.txt");
            MessageBox.Show("Đã đăng nhập");
            Loop(sr.ReadToEnd() + "\n");
            sr.Close();*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(txtDoc.Text);
            }
            /*StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(lbUserName.Text + " Đã đăng xuất" + DateTime.Now.ToString("hh:mm:ss"));
            MessageBox.Show("Đã đăng xuất");
            sw.Flush();
            sw.Close();*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoc.Clear();
            txtDoc.Focus();
        }
    }
}
