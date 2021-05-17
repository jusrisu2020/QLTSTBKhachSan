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
            dtgvQuanLyND.DataSource = tk;
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
        }
        #endregion

        #region Event
        //Event Button Hover
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (pnAddUser.Visible == false)
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

        //Mở file Dialog
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                picAvatar.ImageLocation = ofile.FileName;
                this.Text = ofile.FileName;
            }
        }

        //Thêm tài khoản từ admin
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string hinhanh = picAvatar.ImageLocation;
            string manv = cbMaNV.Text;
            string macv = cbMaCV.Text;
            string tentk = txtTenTK.Text; 
            string tenhienthi = txtTenHienThi.Text;
            string pass = txtPass.Text;
            if (manv.Equals("") || macv.Equals("") || tentk.Equals("") || tenhienthi.Equals("") || pass.Equals("") || hinhanh == null )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
            else
            {
                if (TaiKhoanDAO.Instance.InsertAccount(hinhanh, manv, tentk, tenhienthi, pass, macv))
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
        //Admin không có quyền sửa thông tin của user
        //XOÁ TÀI KHOẢN TỪ ADMIN
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQuanLyND.SelectedRows[0];
            string matk = dr.Cells["MaTK"].Value.ToString();
            string tentk = dr.Cells["TenTK"].Value.ToString();


            if (MessageBox.Show("Bạn Muốn Xoá Tài Khoản: " + tentk + "", "Tài Khoản", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
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
        }

        //Tìm kiếm
        List<TaiKhoanDTO> TKTenTK(string tentk)
        {
            List<TaiKhoanDTO> TaiKhoanList = TaiKhoanDAO.Instance.TKTenTK(tentk);
            return TaiKhoanList;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tentk = txtTimKiem.Text;
            dtgvQuanLyND.DataSource = TKTenTK(tentk);
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }
        #endregion
    }
}
