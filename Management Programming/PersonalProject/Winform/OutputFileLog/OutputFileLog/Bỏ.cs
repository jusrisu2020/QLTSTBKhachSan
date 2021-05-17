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
    public partial class FFL1 : Form
    {
        public FFL1()
        {
            InitializeComponent();
            string Fpath = @"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\OutputFileLog\OutputFileLog\bin\Debug\FileLog.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(Fpath).ToList();

            foreach(String line in lines)
            {
                richTextBox1.Text = line;
            }

            richTextBox1.ReadLine();

        }

    }
}
