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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DateTime dt = new DateTime();
        string path = Environment.CurrentDirectory + "/" + "FileLog.txt";
        string Time;


        private void btnTaoFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Đã có FileLog");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lb = new Label();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            using (StreamWriter sw = new StreamWriter(path))
            {
                string time = DateTime.Now.ToString("dd/MM/yyyy , HH:mm:ss");
                sw.WriteLine("Đã đăng xuất 2" + time);
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                textBox1.Text =  sr.ReadLine();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy , HH:mm:ss");
        }
    }
}
