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
    public partial class ThuePhong : Form
    {
        public ThuePhong()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsPHIEUTHUE");
        SqlDataAdapter daPhieuThue;

       
        private void ThuePhong_Load(object sender, EventArgs e)
        {
            //ketnoi
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-83N839M\SQLEXPRESS;Initial Catalog=QuanLiKhachSan;Integrated Security=True";
            conn.Open();
            //DulieuDataGridView


            string sQueryPhieuThue = @" select *from PHIEUTHUE "; 
            daPhieuThue = new SqlDataAdapter(sQueryPhieuThue, conn);
            daPhieuThue.Fill(ds, "tblPHIEUTHUE");
            QLKH.DataSource = ds.Tables["tblPHIEUTHUE"];

            QLKH.Columns["MaPhieu"].HeaderText = "Mã phiếu thuê";
            QLKH.Columns["MaPhieu"].Width = 60;
            QLKH.Columns["MaPhong"].HeaderText = "Mã phòng";
            QLKH.Columns["MaPhong"].Width = 60;
            QLKH.Columns["MaKH"].HeaderText = "Mã khách hàng";
            QLKH.Columns["MaKH"].Width = 60;
            QLKH.Columns["NgayDen"].HeaderText = "Ngày đến ";
            QLKH.Columns["NgayDen"].Width = 80;
            QLKH.Columns["NgayDi"].HeaderText = "Ngày đi ";
            QLKH.Columns["NgayDi"].Width = 80;



            //them
            string sThemPHIEUTHUE = @"insert into PHIEUTHUE values(@MaPhieu, @MaPhong, @MaKH, @NgayDen,@NgayDi)";
            SqlCommand cmThemPHIEUTHUE = new SqlCommand(sThemPHIEUTHUE, conn);
            QLKH.DataSource = ds.Tables["tblPHIEUTHUE"];
            cmThemPHIEUTHUE.Parameters.Add("@MaPhieu", SqlDbType.NVarChar, 50, "MaPhieu");
            cmThemPHIEUTHUE.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 50, "MaPhong");
            cmThemPHIEUTHUE.Parameters.Add("@MaKH", SqlDbType.NVarChar, 50, "MaKH");
            cmThemPHIEUTHUE.Parameters.Add("@NgayDen", SqlDbType.Date,10, "NgayDen");
            cmThemPHIEUTHUE.Parameters.Add("@NgayDi", SqlDbType.Date, 10, "NgayDi");
            daPhieuThue.InsertCommand = cmThemPHIEUTHUE;

            //sua
            string s1ThemPHIEUTHUE = @"update  set(@MaPhieu, @MaPhong, @MaKH, @NgayDen,@NgayDi)";
            SqlCommand cm1ThemPHIEUTHUE = new SqlCommand(s1ThemPHIEUTHUE, conn);
            QLKH.DataSource = ds.Tables["tblPHIEUTHUE"];
            cm1ThemPHIEUTHUE.Parameters.Add("@MaPhieu", SqlDbType.NVarChar, 50, "MaPhieu");
            cm1ThemPHIEUTHUE.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 50, "MaPhong");
            cm1ThemPHIEUTHUE.Parameters.Add("@MaKH", SqlDbType.NVarChar, 50, "MaKH");
            cm1ThemPHIEUTHUE.Parameters.Add("@NgayDen", SqlDbType.Date, 10, "NgayDen");
            cm1ThemPHIEUTHUE.Parameters.Add("@NgayDi", SqlDbType.Date, 10, "NgayDi");
            daPhieuThue.UpdateCommand = cm1ThemPHIEUTHUE;

            //xóa
            string s1XoaPHIEUTHUE = @"delete  from PHIEUTHUE MaPhieu = @MaPhieu";
            SqlCommand cm1XoaPHIEUTHUE = new SqlCommand(s1XoaPHIEUTHUE, conn);
            QLKH.DataSource = ds.Tables["tblPHIEUTHUE"];
            cm1XoaPHIEUTHUE.Parameters.Add("@MaPhieu", SqlDbType.NVarChar, 50, "MaPhieu");
            cm1XoaPHIEUTHUE.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 50, "MaPhong");
            cm1XoaPHIEUTHUE.Parameters.Add("@MaKH", SqlDbType.NVarChar, 50, "MaKH");
            cm1XoaPHIEUTHUE.Parameters.Add("@NgayDen", SqlDbType.Date, 10, "NgayDen");
            cm1XoaPHIEUTHUE.Parameters.Add("@NgayDi", SqlDbType.Date, 10, "NgayDi");
            daPhieuThue.DeleteCommand = cm1ThemPHIEUTHUE;
        }
        private void QLKH_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = QLKH.SelectedRows[0];
            txtMaPhieu.Text = dr.Cells["MaPhieu"].Value.ToString();
            txtMaPhong.Text = dr.Cells["MaPhong"].Value.ToString();
            txtMaKhachHang.Text = dr.Cells["MaKH"].Value.ToString();
            Ngayden.Text = dr.Cells["NgayDen"].Value.ToString();
            Ngaydi.Text = dr.Cells["NgayDi"].Value.ToString();
        }

        private void btnThemThue_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblPHIEUTHUE"].NewRow();
            row["MaPhieu"] = txtMaPhieu.Text;
            row["MaPhong"] = txtMaPhong.Text;
            row["MaKH"] = txtMaKhachHang.Text;
            row["NgayDen"] = Ngayden.Text;
            row["NgayDi"] = Ngaydi.Text;

            ds.Tables["tblPHIEUTHUE"].Rows.Add(row);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                daPhieuThue.Update(ds, "tblPHIEUTHUE");
                MessageBox.Show("da luu", "thong bao");
                QLKH.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DALUU" + ex.Message, "THONGBao");
            }
        }

        private void QLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (QLKH.SelectedRows.Count > 0)
                QLKH.Rows.Remove(QLKH.SelectedRows[0]);
        }
    }
}
