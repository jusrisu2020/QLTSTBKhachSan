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
        
       void LoadData()
        {
            LoadNhanVien();
            LoadChucVu();
            LoadCBBoPhan();
        }
        void LoadNhanVien()
        {
            List<NhanVienDTO> Table = NhanVienDAO.Instance.LoadNhanVien();
            dtgvQLNV.DataSource = Table;
            dtgvQLNV.Columns["id"].Visible = false;
            dtgvQLNV.Columns["Manv"].HeaderText = "Mã Nhân Viên";
            dtgvQLNV.Columns["Hoten"].HeaderText = "Họ tên";
            dtgvQLNV.Columns["Gioitinh"].HeaderText = "Giới tính";
            dtgvQLNV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvQLNV.Columns["Diachi"].HeaderText = "Địa chỉ";
            dtgvQLNV.Columns["sdt"].HeaderText = "SDT";
            dtgvQLNV.Columns["Email"].HeaderText = "Email";
            dtgvQLNV.Columns["TonGiao"].HeaderText = "Tôn giáo";
            dtgvQLNV.Columns["CMND"].HeaderText = "CMND";
            dtgvQLNV.Columns["Mabp"].HeaderText = "Mã bộ phận";
            dtgvQLNV.Columns["Macv"].HeaderText = "Mã chức vụ";
        }

        void LoadChucVu()
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns["id"].Visible = false;
            dtgvChucVu.Columns["MaCV"].HeaderText = "Mã chức vụ";
            dtgvChucVu.Columns["TenCV"].HeaderText = "Tên chức vụ";
            cbChucVu.DataSource = ChucVuList;
            cbChucVu.DisplayMember = "MaCV";
        }

        void LoadCBBoPhan()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadListBoPhan();
            cbBoPhan.DataSource = BoPhanList;
            cbBoPhan.DisplayMember = "MaBP";
        }
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvQLNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLNV.SelectedRows[0];
            txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();

            if(dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpkNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtTonGiao.Text = dr.Cells["TonGiao"].Value.ToString();
            txtCMND.Text = dr.Cells["CMND"].Value.ToString();
            cbBoPhan.Text = dr.Cells["MaBP"].Value.ToString();
            cbChucVu.Text = dr.Cells["MaCV"].Value.ToString();
        }
    }
}
