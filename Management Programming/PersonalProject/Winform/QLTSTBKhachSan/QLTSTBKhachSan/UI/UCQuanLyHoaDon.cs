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
    public partial class UCQuanLyHoaDon : UserControl
    {
        public UCQuanLyHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            LoadHD();
            LoadCB();
        }
        void LoadHD()
        {
            dtgvHoaDon.DataSource = HoaDonMuaTBDAO.Instance.LoadListHoaDon();
        }

        string HoaDon = "Hoá Đơn";

        void LoadCB()
        {
            cbMaNV.DataSource = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DisplayMember = "MaNV";

            cbMaNCC.DataSource = NhaCungCapDAO.Instance.LoadNCC();
            cbMaNCC.DisplayMember = "MaNCC";
        }
   
        private void btnThemHoaDonpn_Click(object sender, EventArgs e)
        {
            if (pnNew.Visible == false)
            {
                pnNew.Visible = true;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnNew.Visible = false;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            DateTime? ngaymua = (DateTime?)dtpNgayMua.Value;
            string manv = cbMaNV.Text;
            string mancc =  cbMaNCC.Text;
            int sltb = int.Parse(txtSLTB.Text);
            
            if (HoaDonMuaTBDAO.Instance.InsertHoaDonMua(ngaymua, manv, mancc, sltb))
            {
                MessageBox.Show("Thêm Hoá đơn thành công",HoaDon);
                LoadHD();
            }
            else
            {
                MessageBox.Show("Thêm Hoá đơn không thành công", HoaDon);
            }
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (pnNew.Visible == false)
            {
                pnNew.Visible = true;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnNew.Visible = false;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvHoaDon.SelectedRows[0];
            string mahdmua = dr.Cells["MaHDMua"].Value.ToString();
            if (HoaDonMuaTBDAO.Instance.DeleteHoaDonMua(mahdmua))
            {
                MessageBox.Show("Đã xoá hoá đơn có mã số là: "+mahdmua+"", HoaDon);
                LoadHD();
            }
            else
            {
                MessageBox.Show("Thêm Hoá đơn không thành công", HoaDon);
            }
        }

      
    }
}
