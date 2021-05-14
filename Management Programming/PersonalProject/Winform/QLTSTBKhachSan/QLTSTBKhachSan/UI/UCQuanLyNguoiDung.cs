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
using System.Data.SqlClient;
using System.IO;

namespace QLTSTBKhachSan.UI
{
    public partial class UCQuanLyNguoiDung : UserControl
    {
        public UCQuanLyNguoiDung()
        {
            InitializeComponent();
            LoadData();
        }

        #region Method
        void LoadData()
        {
            LoadListAccount();
            LoadCBMaNV();
            LoadChucVu();
        }

        void LoadListAccount()
        {
            List<TaiKhoanDTO> tk = TaiKhoanDAO.Instance.LoadListAccount();
            dtgvQLND.DataSource = tk;
        }

        void LoadCBMaNV()
        {
            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DataSource = NhanVienList;
            cbMaNV.DisplayMember = "MaNV";
        }

        void LoadChucVu()
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbMaCV.DataSource = ChucVuList;
            cbMaCV.DisplayMember = "MaCV";
            dtgvChucVu.DataSource = ChucVuList;
        }


        private void btnShowChucVu_Click(object sender, EventArgs e)
        {
            if (pnShowChucVu.Visible == true)
            {
                pnShowChucVu.Visible = false;
            }
            else
            {
                pnShowChucVu.Visible = true;
            }
        }




        #endregion

        #region Event

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                picInput.Image = Image.FromFile(ofile.FileName);
                this.Text = ofile.FileName;
            }
        }

        Exception ex = new Exception();
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            byte[] hinhanhb = TaiKhoanDAO.Instance.ImageToByte(picInput.Image); ;
            string manv = cbMaNV.Text;
            string macv = cbMaCV.Text;
            string tentk = txtPass.Text; 
            string tenhienthi = txtTenHienThi.Text;
            string pass = txtPass.Text;
            if (manv.Equals("") || macv.Equals("") || tentk.Equals("") || tenhienthi.Equals("") || pass.Equals("") || picInput.Image.Equals(ex))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
            else
            {
                if (TaiKhoanDAO.Instance.InsertAccount(hinhanhb, manv, tentk, tenhienthi, pass, macv))
                {
                    MessageBox.Show("Saved");
                    LoadListAccount();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }
        private void dtgvQLND_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLND.SelectedRows[0];
            byte[] b = (byte[])dr.Cells["HinhAnh"].Value;
            picInput.Image = TaiKhoanDAO.Instance.ByteArrayToImage(b);
            /*cbMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            cbMaCV.Text = dr.Cells["MaCV"].Value.ToString();
            txtTenTK.Text = dr.Cells["TenTK"].Value.ToString();
            txtTenHienThi.Text = dr.Cells["TenHienThi"].Value.ToString();
            txtPass.Text = dr.Cells["Pass"].Value.ToString();*/
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLND.SelectedRows[0];
            string matk = dr.Cells["MaTK"].Value.ToString();
            
            if (TaiKhoanDAO.Instance.DeleteAccount(matk))
            {
                MessageBox.Show("Đã xóa");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }









        /*private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimKiem.Text;
            if (txtTimKiem.Text == "")
            {
                LoadListAccount();
            }
            else
            {
                string SQuery = "SELECT * FROM TaiKhoan WHERE MaTK like '%" + TimKiem + "%' OR MaNV like '%" + TimKiem + "%' OR TenTK like '%" + TimKiem+"%'";
                dtgvQLND.DataSource = DataProvider.Instance.ExecuteQuery(SQuery);
                txtTimKiem.Clear();
                txtTimKiem.Focus();
            }
        }*/
        #endregion

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(pnAddUser.Visible == false)
            {
                pnAddUser.Visible = true;
                btnAddUser.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnAddUser.Visible = false;
                btnAddUser.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        
    }
}
