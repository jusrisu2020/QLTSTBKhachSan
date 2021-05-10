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
            LoadCBChucVu();
            AddBinding();
        }

        void LoadListAccount()
        {
            List<TaiKhoanDTO> tk = TaiKhoanDAO.Instance.LoadListAccount();
            dtgvQLND.DataSource = tk;
            dtgvQLND.Columns["id"].Visible = false;
            dtgvQLND.Columns["Pass"].Visible = false;
            dtgvQLND.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            dtgvQLND.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgvQLND.Columns["TenTK"].HeaderText = "Tên Tài Khoản";
            dtgvQLND.Columns["Macv"].HeaderText = "Chức Vụ";
        }

        void LoadCBMaNV()
        {
            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DataSource = NhanVienList;
            cbMaNV.DisplayMember = "MaNV";
        }

        void LoadCBChucVu()
        {
            pnShowChucVu.Visible = false;
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbMaCV.DataSource = ChucVuList;
            cbMaCV.DisplayMember = "MaCV";
            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns[0].Visible = false;
            dtgvChucVu.Columns[1].HeaderText = "Mã chức vụ";
            dtgvChucVu.Columns[2].HeaderText = "Tên chức vụ";
        }

        void AddBinding()
        {
            cbMaNV.DataBindings.Add(new Binding("Text",dtgvQLND.DataSource,"MaNV",true,DataSourceUpdateMode.Never));
            cbMaCV.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaCV", true, DataSourceUpdateMode.Never));
            txtMaTK.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaTK", true, DataSourceUpdateMode.Never));
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
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picInput.Image);

            string manv = cbMaNV.Text;
            string macv = cbMaCV.Text;
            string tentk = txtPass.Text;
            string tenhienthi = txtTenHienThi.Text;
            string pass = txtPass.Text;
            if (TaiKhoanDAO.Instance.InsertAccount(b,manv, tentk, tenhienthi, pass, macv))
            {
                MessageBox.Show("Saved");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matk = txtMaTK.Text;
            
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

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                picInput.Image = Image.FromFile(ofile.FileName);
                this.Text = ofile.FileName;
            }
        }
        Byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(Byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void dtgvQLND_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLND.SelectedRows[0];
            txtMaTK.Text = dr.Cells["MaTK"].Value.ToString();
            byte[] b = (byte[])dr.Cells["HinhAnh"].Value;
            picOutput.Image = ByteArrayToImage(b);
            cbMaNV.Text = dr.Cells["MaTK"].Value.ToString();
            cbMaCV.Text = dr.Cells["MaTK"].Value.ToString();
            txtTenTK.Text = dr.Cells["MaTK"].Value.ToString();
            txtTenHienThi.Text = dr.Cells["MaTK"].Value.ToString();
            txtPass.Text = dr.Cells["MaTK"].Value.ToString();
        }
    }
}
