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
    public partial class UCQuanLyThietBi : UserControl
    {
        public UCQuanLyThietBi()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            //LoadBtnBoPhan();
            //LoadDanhMuc();
            LoadCB();
            List<ThietBiDTO> tb = ThietBiDAO.Instance.LoadThietBi();
            dtgvThietBi.DataSource = tb;
        }

        void LoadCB()
        {
            cbMaBP.DataSource = BoPhanDAO.Instance.LoadListBoPhan();
            cbMaBP.DisplayMember = "MaBP";
            cbMaNCC.DataSource = NhaCungCapDAO.Instance.LoadNCC();
            cbMaNCC.DisplayMember = "MaNCC";
            cbMaHD.DataSource = HoaDonMuaTBDAO.Instance.LoadHDM();
            cbMaHD.DisplayMember = "MaHDMua";
        }
        void EditColums()
        {
            dtgvThietBi.Columns["id"].Visible = false;
            dtgvThietBi.Columns["MaTB"].HeaderText = "Mã Thiết Bị";
            dtgvThietBi.Columns["TenTB"].HeaderText = "Tên Thiết Bị";
            dtgvThietBi.Columns["Donvi"].HeaderText = "Đơn vị";
            dtgvThietBi.Columns["SoLuongHienHuu"].HeaderText = "Số Lượng";
            dtgvThietBi.Columns["MaDanhMuc"].HeaderText = "Mã Danh Mục";
            dtgvThietBi.Columns["Mabp"].HeaderText = "Mã Bộ Phận";
            dtgvThietBi.Columns["ThoiGianBH"].HeaderText = "Bảo Hành";
            dtgvThietBi.Columns["TinhTrangTB"].HeaderText = "Tình Trạng Thiết Bị";
            dtgvThietBi.Columns["MaNCC"].HeaderText = "Mã Nhà Cung Cấp";
            dtgvThietBi.Columns["MaHDMuaTB"].HeaderText = "Ma Hóa Đơn Mua Thiết Bị";
            dtgvThietBi.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }
        void ShowThietBiTrongBoPhan(string mabp)
        {
            List<ThietBiDTO> tb = ThietBiDAO.Instance.LoadThietBiTrongBoPhan(mabp);
            dtgvThietBi.DataSource = tb;
        }

        /*void LoadBtnBoPhan()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadListBoPhan();
            foreach (BoPhanDTO item in BoPhanList)
            {
                Button btn = new Button() { Width = 120, Height = 80 };
                flpBtnBoPhan.Controls.Add(btn);
                btn.Click += btnClick;
                btn.Tag = item;
                btn.Text = item.MaBP +"\n"+ item.TenBP;
                btn.Image = Image.FromFile(@"QLTSTBKhachSan\Management Programming\PersonalProject\Winform\QLTSTBKhachSan\QLTSTBKhachSan\Resources\department_50px.png");
                btn.ImageAlign = ContentAlignment.BottomCenter;
                btn.TextAlign = ContentAlignment.TopCenter;
            }
        }*/
        private void btnClick(object sender, EventArgs e)
        {
            string mabp = ((sender as Button).Tag as BoPhanDTO).MaBP;
            ShowThietBiTrongBoPhan(mabp);
            EditColums();
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            FDanhMuc dm = new FDanhMuc();
            dm.Show();
        }

        
        private void btnLoadAllThietBi_Click(object sender, EventArgs e)
        {
            dtgvThietBi.Controls.Clear();
            List<ThietBiDTO> ThietBiList = ThietBiDAO.Instance.LoadThietBi();
            dtgvThietBi.DataSource = ThietBiList;
            EditColums();
        }

        private void btnThietBipn_Click(object sender, EventArgs e)
        {
            if (pnThemThietBi.Visible == false)
            {
                pnThemThietBi.Visible = true;
                btnThietBipn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnThemThietBi.Visible = false;
                btnThietBipn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            string tentb = txtTenTB.Text;
            string donvi = cbDonVi.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            string tendanhmuc = cbTenDM.Text;
            string mabp = cbMaBP.Text;
            DateTime? thoigianbh = (DateTime?)dtpThoiGianBH.Value;
            string tinhtrangtb = cbTTTB.Text;
            string mancc = cbMaNCC.Text;
            string mahdmua = cbMaHD.Text;
            string ghichu = txtGhiChu.Text;


                if (ThietBiDAO.Instance.InsertThietBi(tentb,donvi,soluong,tendanhmuc, mabp, thoigianbh, tinhtrangtb, mancc, mahdmua,ghichu))
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
        }
    }
}
