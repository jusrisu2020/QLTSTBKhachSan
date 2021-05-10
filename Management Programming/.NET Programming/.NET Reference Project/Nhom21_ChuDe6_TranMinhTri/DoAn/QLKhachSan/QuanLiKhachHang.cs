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
    public partial class txtMa : Form
    {
        public txtMa()
        {
            InitializeComponent();
        }
// KẾT NỐI SQL SEVER 
        DataSet ds = new DataSet("dsQLKH");
        SqlDataAdapter daKHACHHANG;
        private void QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-83N839M\SQLEXPRESS;Initial Catalog=QuanLiKhachSan;Integrated Security=True";
            conn.Open();
            string SQueryKHACHHANG = "select * from KHACHHANG";
            daKHACHHANG = new SqlDataAdapter(SQueryKHACHHANG, conn);
            daKHACHHANG.Fill(ds, "tblKHACHHANG");
            dgQLKH.DataSource = ds.Tables["tblKHACHHANG"];
// THÊM DỮ LIỆU
            string sThemKHACHHANG = @"insert into KHACHHANG values(@MaKH, @TenKH, @GioiTinh, @SDT,@CMND,@DiaChi)";
            SqlCommand cmThemKHACHHANG = new SqlCommand(sThemKHACHHANG, conn);
            dgQLKH.DataSource = ds.Tables["tblKHACHHANG"];
            cmThemKHACHHANG.Parameters.Add("@MaKH", SqlDbType.NVarChar, 50, "MaKH");
            cmThemKHACHHANG.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50, "TenKH");
            cmThemKHACHHANG.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50, "GioiTinh");
            cmThemKHACHHANG.Parameters.Add("@SDT", SqlDbType.NVarChar, 50, "SDT");
            cmThemKHACHHANG.Parameters.Add("@CMND", SqlDbType.NVarChar, 50, "CMND");
            cmThemKHACHHANG.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
            daKHACHHANG.InsertCommand = cmThemKHACHHANG;
// XÓA DỮ LIỆU
            string sXoaKHACHHANG = @"delete from KHACHHANG  where MaKH =@MaKH";
            SqlCommand cmXoaKHACHHANG = new SqlCommand(sXoaKHACHHANG, conn);
            dgQLKH.DataSource = ds.Tables["tblKHACHHANG"];
            cmXoaKHACHHANG.Parameters.Add("@MaKH", SqlDbType.NVarChar, 50, "MaKH");
            cmXoaKHACHHANG.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50, "TenKH");
            cmXoaKHACHHANG.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50, "GioiTinh");
            cmXoaKHACHHANG.Parameters.Add("@SDT", SqlDbType.NVarChar, 50, "SDT");
            cmXoaKHACHHANG.Parameters.Add("@CMND", SqlDbType.NVarChar, 50, "CMND");
            cmXoaKHACHHANG.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
            daKHACHHANG.DeleteCommand = cmXoaKHACHHANG;
// SỬA DỮ LIỆU
            string sSuaKHACHHANG = @"update KHACHHANG set TenKH=@tenkh, GioiTinh=@gioitinh, SDT=@sdt, CMND=@cmnd, DiaChi=@diachi where  MaKH =@makh";
            SqlCommand cmSuaKHACHHANG = new SqlCommand(sSuaKHACHHANG, conn);
            dgQLKH.DataSource = ds.Tables["tblKHACHHANG"];
            cmSuaKHACHHANG.Parameters.Add("@makh", SqlDbType.NVarChar, 50, "MaKH");
            cmSuaKHACHHANG.Parameters.Add("@tenkh", SqlDbType.NVarChar, 50, "TenKH");
            cmSuaKHACHHANG.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50, "GioiTinh");
            cmSuaKHACHHANG.Parameters.Add("@sdt", SqlDbType.NVarChar, 50, "SDT");
            cmSuaKHACHHANG.Parameters.Add("@cmnd", SqlDbType.NVarChar, 50, "CMND");
            cmSuaKHACHHANG.Parameters.Add("@diachi", SqlDbType.NVarChar, 50, "DiaChi");
            daKHACHHANG.UpdateCommand = cmSuaKHACHHANG;
        }
        private void dgQLKH_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgQLKH.SelectedRows[0];
            txtMaKH.Text = dr.Cells["MaKH"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            txtTenKH.Text = dr.Cells["TenKH"].Value.ToString();
            txtCMND.Text = dr.Cells["CMND"].Value.ToString();
            txtGioiTinh.Text = dr.Cells["GioiTinh"].Value.ToString();                    
            txtDC.Text = dr.Cells["DiaChi"].Value.ToString();
        }
// BUTTON THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblKHACHHANG"].NewRow();
            row["MaKH"] = txtMaKH.Text;
            row["TenKH"] = txtTenKH.Text;
            row["GioiTinh"] = txtGioiTinh.Text;
            row["SDT"] = txtSDT.Text;
            row["CMND"] = txtCMND.Text;
            row["DiaChi"] = txtDC.Text;
            ds.Tables["tblKHACHHANG"].Rows.Add(row);
        }
// BUTTON LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daKHACHHANG.Update(ds, "tblKHACHHANG");
                MessageBox.Show("da luu", "thong bao");
                dgQLKH.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DALUU" + ex.Message, "THONGBao");
            }
        }
// BUTTON SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgQLKH.SelectedRows[0];
            dgQLKH.BeginEdit(true);
            dr.Cells["MaKH"].Value = txtMaKH.Text;
            dr.Cells["SDT"].Value = txtSDT.Text;
            dr.Cells["TenKH"].Value = txtTenKH.Text;
            dr.Cells["CMND"].Value = txtCMND.Text;
            dr.Cells["GioiTinh"].Value = txtGioiTinh.Text;
            dr.Cells["DiaChi"].Value = txtDC.Text;
            dgQLKH.EndEdit();
        }
// BUTTON XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgQLKH.SelectedRows.Count > 0)
                dgQLKH.Rows.Remove(dgQLKH.SelectedRows[0]);
        }
    }
}
