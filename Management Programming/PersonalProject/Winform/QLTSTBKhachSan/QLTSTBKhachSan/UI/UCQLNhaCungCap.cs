using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;

namespace QLTSTBKhachSan.UI
{
    public partial class UCQLNhaCungCap : UserControl
    {
        Exception ex = new Exception();
        public UCQLNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            LoadNCCUC();
        }
        void LoadNCCUC()
        {
            List<NhaCungCapDTO> NhaCungCapList = NhaCungCapDAO.Instance.LoadNCC();
            dtgvNCC.DataSource = NhaCungCapList;
            dtgvNCC.Columns[0].Visible = false;
            dtgvNCC.Columns["MaNCC"].HeaderText = "Mã Nhà Cung Cấp";
            dtgvNCC.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
        }

        private void dtgvNCC_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvNCC.SelectedRows[0];
            txtMaNCC.Text = dr.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dr.Cells["TenNCC"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            cbDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtSTK.Text = dr.Cells["STK"].Value.ToString();
            txtTenCongTy.Text = dr.Cells["TenCongTy"].Value.ToString();
        }
        public int kiemtra()
        {
            for (int i = 0; i < dtgvNCC.RowCount - 1; i++)
            {
                if (txtTenNCC.Text == dtgvNCC.Rows[i].Cells["Tenncc"].Value.ToString())
                    return 0;
            }
            return 1;
        }
        private void btnInsertNhaCungCap_Click(object sender, EventArgs e)
        {
            string tenncc = txtTenNCC.Text;
            string sdt = txtSDT.Text;
            string diachi = cbDiaChi.Text;
            string email = txtEmail.Text;
            string stk = txtSTK.Text;
            string tencongty = txtTenCongTy.Text;
            if(kiemtra() == 0)
            {
                MessageBox.Show("Trùng");
            }
            else if (NhaCungCapDAO.Instance.InsertNhaCungCap(tenncc, sdt, diachi, email, stk, tencongty))
            {
                MessageBox.Show("Saved");
                LoadNCCUC();
            }
            else
            {
                MessageBox.Show(ex + "Không thành công");
            }
        }

        private void btnUpdateNCC_Click(object sender, EventArgs e)
        {
            string mancc = txtMaNCC.Text;
            string tenncc = txtTenNCC.Text;
            string sdt = txtSDT.Text;
            string diachi = cbDiaChi.Text;
            string email = txtEmail.Text;
            string stk = txtSTK.Text;
            string tencongty = txtTenCongTy.Text;
            if (NhaCungCapDAO.Instance.UpdateNhaCungCap(tenncc, sdt, diachi, email, stk, tencongty, mancc))
            {

                MessageBox.Show("Sửa thành công");
                LoadNCCUC();
            }
            else
            {
                MessageBox.Show(ex + "Không thành công");
            }
        }

        private void btnDeleteNCC_Click(object sender, EventArgs e)
        {
            //Xoá Table NhaCC thì phải Xoá Table HoaDonMuaTB có liên quan đến nhà cung cấp đó 
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtTenNCC.Clear();
            txtSDT.Clear();
            cbDiaChi.SelectedItem = "";
            txtEmail.Clear();
            txtSTK.Clear();
            txtTenCongTy.Clear();
            LoadNCCUC();
        }
    }
}
