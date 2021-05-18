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
    public partial class QuanLiHoaDon : Form
    {
        public QuanLiHoaDon()
        {
            InitializeComponent();
        }
//KẾT NỐI SQL SEVER VÀ TRUYỀN DỮ LIỆU
        DataSet ds = new DataSet("dsQLKH");
        SqlDataAdapter daHOADON;
        private void QuanLiHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-83N839M\SQLEXPRESS;Initial Catalog=QuanLiKhachSan;Integrated Security=True";
            conn.Open();

            string SQueryKHACHHANG = "select * from HOADON";
            daHOADON = new SqlDataAdapter(SQueryKHACHHANG, conn);
            daHOADON.Fill(ds, "tblHOADON");
            dgvHD.DataSource = ds.Tables["tblHOADON"];
// XÓA DỮ LIỆU TỪ DATAGRIDVIEW 
            string sXoaHOADON = @"delete from HOADON  where MaHD =@MaHD";
            SqlCommand cmXOAHOADON = new SqlCommand(sXoaHOADON, conn);
            dgvHD.DataSource = ds.Tables["tblHOADON"];
            cmXOAHOADON.Parameters.Add("@MaHD", SqlDbType.NVarChar, 50, "MaHD");
            cmXOAHOADON.Parameters.Add("@NgayLapHD", SqlDbType.NVarChar, 50, "NgayLapHD");
            cmXOAHOADON.Parameters.Add("@TongThanhToan", SqlDbType.NVarChar, 50, "TongThanhToan");
            cmXOAHOADON.Parameters.Add("@MaKH", SqlDbType.NVarChar, 50, "MaKH");
            cmXOAHOADON.Parameters.Add("@MaNV", SqlDbType.NVarChar, 50, "MaNV");
            cmXOAHOADON.Parameters.Add("@NgayDen", SqlDbType.NVarChar, 50, "NgayDen");
            cmXOAHOADON.Parameters.Add("@NgayDi", SqlDbType.NVarChar, 50, "NgayDi");
            cmXOAHOADON.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 50, "MaPhong");
            daHOADON.DeleteCommand = cmXOAHOADON;
        }
// CHỌN MỘT DÒNG TRONG DATAGRIDVIEW
        private void dgvHD_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvHD.SelectedRows[0];
            txtMaHD.Text = dr.Cells["MaHD"].Value.ToString();
            dateNgay.Text = dr.Cells["NgayLapHD"].Value.ToString();
            txtTTT.Text = dr.Cells["TongThanhToan"].Value.ToString();
            txtMaKH.Text = dr.Cells["MaKH"].Value.ToString();
            //txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();    
            
        }
// BUTTON XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHD.SelectedRows.Count > 0)
                dgvHD.Rows.Remove(dgvHD.SelectedRows[0]);
        }
// BUTTON LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daHOADON.Update(ds, "tblHOADON");
                MessageBox.Show("Complete", "Notification");
                dgvHD.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Complete !" + ex.Message, "Notification");
            }
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Aqua;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Azure;
        }

        private void btnLuu_MouseEnter(object sender, EventArgs e)
        {
            btnLuu.BackColor = Color.Aqua;
        }

        private void btnLuu_MouseLeave(object sender, EventArgs e)
        {
            btnLuu.BackColor = Color.Azure;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
