using QLTSTBKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QLTSTBKhachSan.UI
{
    public partial class SaveImg : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SaveImageDataBase;Integrated Security=True");
        public SaveImg()
        {
            InitializeComponent();
            
        }
        
        private void picInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                picInput.Image = Image.FromFile(ofile.FileName);

                this.Text = ofile.FileName;
            }
        }

        private void SaveImg_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Img", conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            table.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in table.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["Paths"].ToString());
            }
            dataGridView1.DataSource = table;
        }

        /*private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picInput.Image);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LoadHinhAnh(tenhinh,ha)VALUES(@tenhinhanh,@ha)",conn);
            cmd.Parameters.Add("@tenhinhanh", txtPath.Text);
            cmd.Parameters.Add("@ha", b);
            cmd.ExecuteNonQuery();
            conn.Close();
            txtPath.Clear();
            picInput.Controls.Clear();
            LoadData();
        }

        //chuyển Image sang byte

        Byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private void dtgvHinhAnh_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvHinhAnh.SelectedRows[0];
            txtPath.Text = dr.Cells["TenHinh"].Value.ToString();
            byte[] b = (byte[])dr.Cells["ha"].Value;
            picOutPut.Image = ByteArrayToImage(b);
        }

        //Chuyển byte sang Image
        Image ByteArrayToImage(Byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }*/


        /*private void SaveXuatImg_Load(object sender, EventArgs e)
        {
            string Squery = "SELECT * FROM dbo.ThemAnh";
            dtgvHinhAnh.DataSource = DataProvider.Instance.ExecuteQuery(Squery);
            dtgvHinhAnh.Rows[0].Height = 100;
        }*/
    }
}
