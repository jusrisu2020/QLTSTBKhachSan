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
    public partial class UCQuanLyHoaDon : UserControl
    {
        public UCQuanLyHoaDon()
        {
            InitializeComponent();
            LoadData();
        }
        string HoaDon = "Hoá Đơn";
        void LoadData()
        {
            LoadHD();
            LoadCB();
        }

        void LoadHD()
        {
            dtgvHoaDon.DataSource = HoaDonMuaTBDAO.Instance.LoadListHoaDon();
        }


        void LoadCB()
        {
            cbMaNV.DataSource = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DisplayMember = "MaNV";

            cbMaNCC.DataSource = NhaCungCapDAO.Instance.LoadNCC();
            cbMaNCC.DisplayMember = "MaNCC";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (pnNew.Visible == false)
            {
                pnNew.Visible = true;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\minus_24px.png");
            }
            else
            {
                pnNew.Visible = false;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\add_32px.png");
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            DateTime? ngaymua = (DateTime?)dtpNgayMua.Value;
            string manv = cbMaNV.Text;
            string mancc =  cbMaNCC.Text;
            int sltb;
            if(int.TryParse(txtSLTB.Text, out sltb) == false)
            {
                MessageBox.Show("Hãy nhập vào kiểu số!", HoaDon);
            }
            else
            {
                if (HoaDonMuaTBDAO.Instance.InsertHoaDonMua(ngaymua, manv, mancc, int.Parse(txtSLTB.Text)))
                {
                    MessageBox.Show("Thêm Hoá đơn thành công", HoaDon);
                    LoadHD();
                }
                else
                {
                    MessageBox.Show("Thêm Hoá đơn không thành công", HoaDon);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvHoaDon.SelectedRows[0];
            string mahdmua = dr.Cells["MaHDMua"].Value.ToString();
            if(MessageBox.Show("Bạn có muốn xoá mã hoá đơn: "+mahdmua+"",HoaDon, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (HoaDonMuaTBDAO.Instance.DeleteHoaDonMua(mahdmua))
                {
                    MessageBox.Show("Đã xoá hoá đơn có mã số là: " + mahdmua + "", HoaDon);
                    LoadHD();
                }
                else
                {
                    MessageBox.Show("Thêm Hoá đơn không thành công", HoaDon);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cbSearch.SelectedIndex == 0)
            {
                dtgvHoaDon.DataSource = HoaDonMuaTBDAO.Instance.SearchMaHD(txtSearch.Text);
            }
            else if(cbSearch.SelectedIndex == 1)
            {
                dtgvHoaDon.DataSource = HoaDonMuaTBDAO.Instance.SearchTongSL(int.Parse(txtSearch.Text));
            }
            else
            {
                dtgvHoaDon.DataSource = HoaDonMuaTBDAO.Instance.SearchMaNCC(txtSearch.Text);
            }
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            if (pnTimeSearch.Visible == false)
            {
                pnTimeSearch.Visible = true;
                btnTimeSearch.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\minus_24px.png");
            }
            else
            {
                pnTimeSearch.Visible = false;
                btnTimeSearch.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\add_32px.png");
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = HoaDonMuaTBDAO.Instance.TimeSearch(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHD();
        }
    }
}
