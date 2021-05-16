using QLTSTBKhachSan.DAO;
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
    public partial class UCQuanLyBaoCao : UserControl
    {
        public UCQuanLyBaoCao()
        {
            InitializeComponent();
            LoadHD();
            LoadCB();
        }


        void LoadHD()
        {
            dtgvBaoCao.DataSource = HoaDonMuaTBDAO.Instance.LoadHDM();
            dtgvBaoCao.Columns[0].Visible = false;
        }


        void LoadCB()
        {
            cbMaNV.DataSource = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DisplayMember = "MaNV";

            cbMaNCC.DataSource = NhaCungCapDAO.Instance.LoadNCC();
            cbMaNCC.DisplayMember = "MaNCC";

            cbMaHD.DataSource = HoaDonMuaTBDAO.Instance.LoadHDM();
            cbMaHD.DisplayMember = "MaHDMua";

            cbMaBP.DataSource = BoPhanDAO.Instance.LoadListBoPhan();
            cbMaBP.DisplayMember = "MaBP";
        }
        private void dtgvBaoCao_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow r = dtgvBaoCao.SelectedRows[0];
            lbTotal.Text = "Total: " + r.Cells["ThanhTien"].Value.ToString();
            lbMaHD.Text = "Mã Hoá Đơn: " + r.Cells["MaHDMua"].Value.ToString();*/
        }



        private void btnThemHoaDonpn_Click(object sender, EventArgs e)
        {
                if (pnAddUser.Visible == false)
                {
                    pnAddUser.Visible = true;
                    btnThemHoaDonpn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
                }
                else
                {
                    pnAddUser.Visible = false;
                    btnThemHoaDonpn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
                }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            DateTime? ngaymua = (DateTime?)dtpNgayMua.Value;
            string manv = cbMaNV.Text;
            string mancc =  cbMaNCC.Text;
            if (HoaDonMuaTBDAO.Instance.InsertHoaDonMua(ngaymua, manv, mancc))
            {
                MessageBox.Show("Thêm Hoá đơn thành công");
                LoadHD();
            }
            else
            {
                MessageBox.Show("Thêm Hoá đơn không thành công");
            }
        }

        private void btnThemTBHD_Click(object sender, EventArgs e)
        {
            if (pnThemThietBi.Visible == false)
            {
                pnThemThietBi.Visible = true;
                btnThemTBHD.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnThemThietBi.Visible = false;
                btnThemTBHD.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {

        }

        private void btnThietBipn_Click(object sender, EventArgs e)
        {
            if (pnThemThietBis.Visible == false)
            {
                pnThemThietBis.Visible = true;
                btnThietBipn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnThemThietBis.Visible = false;
                btnThietBipn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
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


            if (ThietBiDAO.Instance.InsertThietBi(tentb, donvi, soluong, tendanhmuc, mabp, thoigianbh, tinhtrangtb, mancc, mahdmua, ghichu))
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
