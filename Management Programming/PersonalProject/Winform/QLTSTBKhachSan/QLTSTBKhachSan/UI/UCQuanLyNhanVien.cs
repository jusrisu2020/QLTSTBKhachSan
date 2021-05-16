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
    public partial class UCQuanLyNhanVien : UserControl
    {
        public UCQuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        string NhanVien = "Nhân Viên";

        void LoadData()
        {
            LoadNhanVien();
            LoadCB();
        }
        void LoadNhanVien()
        {
            List<NhanVienDTO> Table = NhanVienDAO.Instance.LoadNhanVien();
            dtgvQLNV.DataSource = Table;
        }


        void LoadCB()
        {
            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DataSource = NhanVienList;
            cbMaNV.DisplayMember = "MaNV";

            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbMaCV.DataSource = ChucVuList;
            cbMaCV.DisplayMember = "MaCV";

            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadListBoPhan();
            cbMaBP.DataSource = BoPhanList;
            cbMaBP.DisplayMember = "MaBP";
        }


        private void dtgvQLNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLNV.SelectedRows[0];
            cbMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            cbMaCV.Text = dr.Cells["MaCV"].Value.ToString();
            cbMaBP.Text = dr.Cells["MaBP"].Value.ToString();
            txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtTonGiao.Text = dr.Cells["TonGiao"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtCMND.Text = dr.Cells["CMND"].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (pnNewNV.Visible == false)
            {
                pnNewNV.Visible = true;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnNewNV.Visible = false;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string gioitinh;
            if (radNam.Checked == true)
            {
                gioitinh = radNam.Text;
            }
            else
            {
                gioitinh = radNu.Text;
            }
            DateTime? ngaysinh = (DateTime?)dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string tongiao = txtTonGiao.Text;
            string cmnd = txtCMND.Text;
            string mabp = cbMaBP.Text;
            string macv = cbMaCV.Text;


            if (hoten.Equals("") || gioitinh.Equals("") || ngaysinh.Equals("") || diachi.Equals("") || sdt.Equals("") || cmnd.Equals("") || mabp.Equals("") || macv.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin, không được bỏ trống!", NhanVien);
            }
            else
            {
                if(NhanVienDAO.Instance.TestNhanVien(sdt, email, cmnd).Equals(0))
                {
                    MessageBox.Show("Bạn hãy kiểm tra lại Phone, Email, CMND!", NhanVien);
                }
                else
                {
                    if (NhanVienDAO.Instance.InsertNhanVien(hoten, gioitinh, ngaysinh, diachi, sdt, email, tongiao, cmnd, mabp, macv))
                    {
                        MessageBox.Show("Thêm Nhân Viên Thành Công!", NhanVien);
                        LoadNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Nhân Viên Không Thành Công!", NhanVien);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLNV.SelectedRows[0];
            string manv = dr.Cells["MaNV"].Value.ToString();
            string hoten = txtHoTen.Text;
            string gioitinh;
            if (radNam.Checked == true)
            {
                gioitinh = radNam.Text;
            }
            else
            {
                gioitinh = radNu.Text;
            }
            DateTime? ngaysinh = (DateTime?)dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string tongiao = txtTonGiao.Text;
            string cmnd = txtCMND.Text;
            string mabp = cbMaBP.Text;
            string macv = cbMaCV.Text;


            if (hoten.Equals("") || gioitinh.Equals("") || ngaysinh.Equals("") || diachi.Equals("") || sdt.Equals("") || cmnd.Equals("") || mabp.Equals("") || macv.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin, không được bỏ trống!", NhanVien);
            }
            else
            {
                if (NhanVienDAO.Instance.TestNhanVien(sdt, email, cmnd).Equals(0))
                {
                    MessageBox.Show("Bạn hãy kiểm tra lại Phone, Email, CMND!", NhanVien);
                }
                else
                {
                    if (NhanVienDAO.Instance.UpdateNhanVien(hoten, gioitinh, ngaysinh, diachi, sdt, email, tongiao, cmnd, mabp, macv, manv))
                    {
                        MessageBox.Show("Cập Nhật Nhân Viên Thành Công!", NhanVien);
                        LoadNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Nhân Viên Không Thành Công!", NhanVien);
                    }
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLNV.SelectedRows[0];
            string manv = dr.Cells["MaNV"].Value.ToString();
            if(MessageBox.Show("Bạn muốn xoá nhân viên có mã nhân viên: " + manv + "", NhanVien, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (NhanVienDAO.Instance.DeleteNhanVien(manv))
                {
                    MessageBox.Show("Xoá Nhân Viên có mã số: "+manv+" Thành Công!", NhanVien);
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xoá Nhân Viên Không Thành Công!", NhanVien);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        
    }
}
