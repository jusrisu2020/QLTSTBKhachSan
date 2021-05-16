using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTSTBKhachSan.UI
{
    public partial class FHelp : Form
    {
        public FHelp()
        {
            InitializeComponent();

            

        }

        public List<TestImgDTO> LoadImg()
        {
            List<TestImgDTO> ImgList = new List<TestImgDTO>();
            string query = "SELECT * FROM dbo.TestImg";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                TestImgDTO table = new TestImgDTO(item);
                ImgList.Add(table);
            }
            return ImgList;
        }

        
       


        private void pbLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {

                pbLoadImg.ImageLocation = ofile.FileName;

                richTextBox1.Text = ofile.FileName;
            }
        }

        bool SaveImg(string paths)
        {
            string query = "INSERT INTO dbo.TestImg (paths) VALUES (N'"+paths+"')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SaveImg(pbLoadImg.ImageLocation))
            {
                MessageBox.Show("Thành cÔNG");
            }
            else
            {
                MessageBox.Show("0 Thành cÔNG");
            }
        }
    }
}
