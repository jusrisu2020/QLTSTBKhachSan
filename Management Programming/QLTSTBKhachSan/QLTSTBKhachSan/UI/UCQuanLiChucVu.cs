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

namespace QLTSTBKhachSan.UI
{
    public partial class UCQuanLiChucVu : UserControl
    {
        public UCQuanLiChucVu()
        {
            InitializeComponent();
            LoadListChucVu();
        }

        void LoadListChucVu()
        {
            dtgvQLCV.DataSource = ChucVuDAO.Instance.LoadChucVu();
        }
        private void dtgvQLCV_Click(object sender, EventArgs e)
        {

            DataGridViewRow dr = dtgvQLCV.SelectedRows[0];
            txtTenCV.Text = dr.Cells["TenCV"].Value.ToString();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (pnNewCV.Visible == false)
            {
                pnNewCV.Visible = true;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\minus_24px.png");
            }
            else
            {
                pnNewCV.Visible = false;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\add_32px.png");
            }
        }
        string ChucVu = "Chức vụ";
        private void btnNewChucVu_Click(object sender, EventArgs e)
        {
            string tencv = txtTenCV.Text;
            if (tencv == "" || ChucVuDAO.Instance.TestChucVu(tencv).Equals(0))
            {
                MessageBox.Show("Tên chức vụ không được bỏ trống và không được trùng!", ChucVu);
            }
            else
            {
                if (ChucVuDAO.Instance.InsertChucVu(tencv))
                {
                    MessageBox.Show("Đã thêm một chức vụ", ChucVu);
                    LoadListChucVu();
                    txtTenCV.Clear();
                    txtTenCV.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công", ChucVu);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLCV.SelectedRows[0];
            string macv = dr.Cells["MaCV"].Value.ToString();
            string tencv = txtTenCV.Text;
            if (tencv == "" || ChucVuDAO.Instance.TestChucVu(tencv).Equals(0))
            {
                MessageBox.Show("Tên chức vụ không được bỏ trống và không được trùng!", ChucVu);
            }
            else
            {
                if (ChucVuDAO.Instance.UpdateChucVu(macv, tencv))
                {
                    MessageBox.Show("Đã thay đổi thông tin mã chức vụ: " + macv + "", ChucVu);
                    LoadListChucVu();
                    txtTenCV.Clear();
                    txtTenCV.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công", ChucVu);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xoá", ChucVu, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow dr = dtgvQLCV.SelectedRows[0];
                string macv = dr.Cells["MaCV"].Value.ToString();
                if (ChucVuDAO.Instance.DeleteChucVu(macv))
                {
                    LoadListChucVu();
                    txtTenCV.Clear();
                    txtTenCV.Focus();
                    MessageBox.Show("Đã xoá!", ChucVu, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xoá không thành công", ChucVu);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenCV.Clear();
            txtTenCV.Focus();
            LoadListChucVu();
        }

        
    }
}
