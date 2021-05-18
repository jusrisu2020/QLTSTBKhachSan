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
            TatClickDTGV();
        }

        string ThietBi = "Thiết Bị";
        void LoadData()
        {
            LoadListThietBi();
            LoadBtnBoPhan();
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
            cbMaHD.DataSource = HoaDonMuaTBDAO.Instance.LoadListHoaDon();
            cbMaHD.DisplayMember = "MaHDMua";
        }
       
        
        void ShowThietBiTrongBoPhan(string mabp)
        {
            List<ThietBiDTO> tb = ThietBiDAO.Instance.LoadThietBiTrongBoPhan(mabp);
            dtgvThietBi.DataSource = tb;
        }

        void LoadListThietBi()
        {
            dtgvThietBi.Controls.Clear();
            List<ThietBiDTO> ThietBiList = ThietBiDAO.Instance.LoadThietBi();
            dtgvThietBi.DataSource = ThietBiList;
        }
        void TatClickDTGV()
        {
            if (dtgvThietBi.RowCount == 0)
            {
                dtgvThietBi.Enabled = false;
            }
        }
        void LoadBtnBoPhan()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadListBoPhan();
            foreach (BoPhanDTO item in BoPhanList)
            {
                Button btn = new Button() { Width = 120, Height = 80 };
                flpBtnBoPhan.Controls.Add(btn);
                btn.Click += btnClick;
                btn.Tag = item;
                btn.Text = item.MaBP + "\n" + item.TenBP;
                btn.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\QLTSTBKhachSan\QLTSTBKhachSan\Resources\department_50px.png");
                btn.ImageAlign = ContentAlignment.BottomCenter;
                btn.TextAlign = ContentAlignment.TopCenter;
            }
        }
        private void btnClick(object sender, EventArgs e)
        {
            string mabp = ((sender as Button).Tag as BoPhanDTO).MaBP;
            ShowThietBiTrongBoPhan(mabp);
        }

        private void btnThietBipn_Click(object sender, EventArgs e)
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

        private void dtgvThietBi_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvThietBi.SelectedRows[0];
            txtTenTB.Text = dr.Cells["TenTB"].Value.ToString();
            cbDonVi.Text = dr.Cells["DonVi"].Value.ToString();
            txtSoLuong.Text = dr.Cells["SoLuong"].Value.ToString();
            cbTenDM.Text = dr.Cells["TenDanhMuc"].Value.ToString();
            cbMaBP.Text = dr.Cells["MaBP"].Value.ToString();
            dtpThoiGianBH.Text = dr.Cells["ThoiGianBH"].Value.ToString();
            if (int.Parse(dr.Cells["TinhTrangTB"].Value.ToString()) == 1)
            {
                cbTTTB.SelectedIndex = 0;
            }
            else
            {
                cbTTTB.SelectedIndex = 1;
            }
            cbMaNCC.Text = dr.Cells["MaNCC"].Value.ToString();
            cbMaHD.Text = dr.Cells["MaHDMuaTB"].Value.ToString();
            txtGiaTB.Text = dr.Cells["GiaTBMua"].Value.ToString();
        }


        private void btnThemTB_Click(object sender, EventArgs e)
        {
            string tentb = txtTenTB.Text;
            string donvi = cbDonVi.Text;
            string tendanhmuc = cbTenDM.Text;
            string mabp = cbMaBP.Text;
            DateTime? thoigianbh = (DateTime?)dtpThoiGianBH.Value;
            int tinhtrangtb;
            if (cbTTTB.SelectedIndex == 0)
            {
                tinhtrangtb = 1;
            }
            else
            {
                tinhtrangtb = 0;
            }

            string mancc = cbMaNCC.Text;
            string mahdmua = cbMaHD.Text;
            

            if (txtGiaTB.Text == "" || txtSoLuong.Text == "" || tentb.Equals("") || donvi.Equals("") || tendanhmuc.Equals("") || mabp.Equals("") || thoigianbh.Equals("") || tinhtrangtb.Equals("") || mancc.Equals("") || mahdmua.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", ThietBi);
            }
            else
            {
                if (int.Parse(txtSoLuong.Text).GetType() == typeof(string)|| int.Parse(txtGiaTB.Text).GetType() == typeof(string))
                {
                    MessageBox.Show("Hãy nhập số lượng và giá thiết bị bằng số!", ThietBi);
                }
                else
                {
                    if (ThietBiDAO.Instance.InsertThietBi(tentb, donvi, int.Parse(txtSoLuong.Text), tendanhmuc, mabp, thoigianbh, tinhtrangtb, mancc, mahdmua, int.Parse(txtGiaTB.Text)))
                    {
                        MessageBox.Show("Đã Thêm 1 Thiết Bị Thành Công", ThietBi);
                        LoadListThietBi();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", ThietBi);
                    }
                }
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        
    }
}
