using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True");
            // Dữ liệu combobox Chức vụ             
            string sQueryChucVu = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";

            // Dữ liệu datagrid Danh sách nhân viên                         
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["manv"].Width = 100;
            dgDSNhanVien.Columns["holot"].HeaderText = "Họ lót";
            dgDSNhanVien.Columns["holot"].Width = 100;
            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["tennv"].Width = 100;
            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["phai"].Width = 100;
            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["ngaysinh"].Width = 100;
            dgDSNhanVien.Columns["macv"].Visible = false;
            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["tencv"].Width = 100;

            // Command Thêm nhân viên             
            string sThemNV = @"insert into nhanvien values(@MaNV , @HoLot , @TenNV , @Phai , @NgaySinh , @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            daNhanVien.InsertCommand = cmThemNV;
            //sửa nv
            string sSuaNV = @"update nhanvien set holot=@HoLot , tennv=@TenNV , phai=@Phai , ngaysinh=@NgaySinh , macv=@MaCV where manv=@MaNV";
            SqlCommand cmSuaNV = new SqlCommand(sSuaNV, conn);
            cmSuaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmSuaNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmSuaNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmSuaNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmSuaNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmSuaNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            daNhanVien.UpdateCommand = cmSuaNV;
            //xóa
            string sXoaNV = @"delete from nhanvien where manv = @MaNV";
            SqlCommand cmXoaNV = new SqlCommand(sXoaNV, conn);
            cmXoaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            daNhanVien.DeleteCommand = cmXoaNV;

        }

        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0]; 
            txtMaNV.Text = dr.Cells["manv"].Value.ToString(); 
            txtHoLot.Text = dr.Cells["holot"].Value.ToString(); 
            txtTen.Text = dr.Cells["tennv"].Value.ToString(); 
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            { radNam.Checked = true; 
            }             
            else 
            { 
                radNu.Checked = true; 
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString(); 
            dr.Cells["macv"].Value = cboChucVu.SelectedValue;
            cboChucVu.Text = dr.Cells["tencv"].Value.ToString();

        }
        public int kiemtra()
        {
            for (int i = 0; i < dgDSNhanVien.RowCount - 1; i ++)
            {
                if (txtMaNV.Text == dgDSNhanVien.Rows[i].Cells["manv"].Value.ToString())
                return 0;
            }
            return 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu hợp lệ (SV tự viết):             
            //  - các trường không bỏ trống             
            //  - manv không trùng 
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "" || 
                cboChucVu.Text == "" || (radNam.Checked == false && radNu.Checked == false))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }    
            else
            {
                if (kiemtra() == 0)
                    MessageBox.Show("đã tồn tại mã nhân viên");
                else
                {
                    // Thêm 1 dòng vào bảng tblNhanVien             
                    DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
                    row["manv"] = txtMaNV.Text;
                    row["holot"] = txtHoLot.Text;
                    row["tennv"] = txtTen.Text;
                    if (radNu.Checked == true)
                    {
                        row["phai"] = "Nữ";
                    }
                    else
                    {
                        row["phai"] = "Nam";
                    }
                    row["ngaysinh"] = dtpNgaySinh.Text;
                    // row["macv"] = cboChucVu.SelectedValue.ToString();
                    row["macv"] = cboChucVu.SelectedValue;
                    row["tencv"] = cboChucVu.Text;
                    ds.Tables["tblDSNhanVien"].Rows.Add(row);
                }    
            }    
            

            // Hiển thị tên chức vụ tương ứng (SV tự viết) 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0)
                dgDSNhanVien.Rows.Remove(dgDSNhanVien.SelectedRows[0]);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            dgDSNhanVien.BeginEdit(true);
            dr.Cells["manv"].Value = txtMaNV.Text ;
            dr.Cells["holot"].Value = txtHoLot.Text;
            dr.Cells["tennv"].Value = txtTen.Text;
            if (radNam.Checked == true)
            {
                dr.Cells["phai"].Value = "Nam";
            }
            else
            {
                dr.Cells["phai"].Value = "Nữ";
            }
            dr.Cells["ngaysinh"].Value = dtpNgaySinh.Text;
            dr.Cells["macv"].Value = cboChucVu.SelectedValue;
            dr.Cells["tencv"].Value = cboChucVu.Text;
            dgDSNhanVien.EndEdit();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Đã Lưu", "Thông báo");
                dgDSNhanVien.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tb "+ex.Message, "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
                Application.Exit();
        }
    }
}
