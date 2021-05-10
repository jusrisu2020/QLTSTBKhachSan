using QLTSTBKhachSan.DAO;
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
    public partial class SaveImg : Form
    {
        public SaveImg()
        {
            InitializeComponent();
        }
        string ImgLoc = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg";
                dlg.Title = "Select Img";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    ImgLoc = dlg.FileName.ToString();
                    picOutPut.ImageLocation = ImgLoc; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveXuatImg_Load(object sender, EventArgs e)
        {
            string Squery = "SELECT * FROM dbo.ThemAnh ";
            dtgvHinhAnh.DataSource = DataProvider.Instance.ExecuteQuery(Squery);
            dtgvHinhAnh.Rows[0].Height = 100;
        }
    }
}
