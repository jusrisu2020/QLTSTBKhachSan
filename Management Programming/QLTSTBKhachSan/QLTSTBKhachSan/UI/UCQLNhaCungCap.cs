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
        public UCQLNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }
        string NhaCungCap = "Nhà Cung Cấp";
        void LoadData()
        {
            LoadNCCUC();
        }
        void LoadNCCUC()
        {
            List<NhaCungCapDTO> NhaCungCapList = NhaCungCapDAO.Instance.LoadNCC();
            dtgvNCC.DataSource = NhaCungCapList;
        }

        private void dtgvNCC_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvNCC.SelectedRows[0];
            txtTenNCC.Text = dr.Cells["TenNCC"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            cbDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtSTK.Text = dr.Cells["STK"].Value.ToString();
            txtTenCongTy.Text = dr.Cells["TenCongTy"].Value.ToString();
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
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tenncc = txtTenNCC.Text;
            string sdt = txtSDT.Text;
            string diachi = cbDiaChi.Text;
            string email = txtEmail.Text;
            string stk = txtSTK.Text;
            string tencongty = txtTenCongTy.Text;
            if (tenncc.Equals("") || sdt.Equals("") || diachi.Equals("") || email.Equals("") || stk.Equals("") || tencongty.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", NhaCungCap);
            }
            else
            {
                if (NhaCungCapDAO.Instance.Test(tenncc,sdt, email,stk,tencongty) == 0)
                {
                    MessageBox.Show("Có một số thông tin bị trùng, bạn hãy xem lại Tên nhà cung cấp, số điện thoại, email, số tài khoản, tên công ty!", NhaCungCap);
                }
                else
                {
                    if (NhaCungCapDAO.Instance.InsertNhaCungCap(tenncc, sdt, diachi, email, stk, tencongty))
                    {
                        MessageBox.Show("Thêm Thành Công!", NhaCungCap);
                        LoadNCCUC();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", NhaCungCap);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvNCC.SelectedRows[0];
            string mancc = dr.Cells["MaNCC"].Value.ToString();
            string tenncc = txtTenNCC.Text;
            string sdt = txtSDT.Text;
            string diachi = cbDiaChi.Text;
            string email = txtEmail.Text;
            string stk = txtSTK.Text;
            string tencongty = txtTenCongTy.Text;


            if (tenncc.Equals("") || sdt.Equals("") || diachi.Equals("") || email.Equals("") || stk.Equals("") || tencongty.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", NhaCungCap);
            }
            else
            {
                if (NhaCungCapDAO.Instance.UpdateNhaCungCap(tenncc, sdt, diachi, email, stk, tencongty, mancc))
                {
                    MessageBox.Show("Sửa thành công", NhaCungCap);
                    LoadNCCUC();
                }
                else
                {
                    MessageBox.Show("Không thành công", NhaCungCap);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvNCC.SelectedRows[0];
            string mancc = dr.Cells["MaNCC"].Value.ToString();
            if(MessageBox.Show("Bạn Muốn Xoá Nhà Cung Cấp Có Mã Số: "+mancc+"",NhaCungCap,MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (NhaCungCapDAO.Instance.DeleteNhaCungCap(mancc))
                {
                    MessageBox.Show("Xóa thành công", NhaCungCap);
                    LoadNCCUC();
                }
                else
                {
                    MessageBox.Show("Không thành công", NhaCungCap);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNCCUC();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvNCC.DataSource =  NhaCungCapDAO.Instance.SeacrchTenNCC(txtSearch.Text);
        }
    }
}
