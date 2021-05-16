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
    public partial class UCQuanLiBoPhan : UserControl
    {
        public UCQuanLiBoPhan()
        {
            InitializeComponent();
            LoadData();
        }
        string BoPhan = "Bộ Phận";
        #region Method
        void LoadData()
        {
            LoadListBoPhan();
        }
        void LoadListBoPhan()
        {
            dtgvQLBP.DataSource = BoPhanDAO.Instance.LoadListBoPhan();
        }

       
        #endregion

        #region Event
        private void dtgvQLBP_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLBP.SelectedRows[0];
            txtTenBP.Text = dr.Cells["TenBP"].Value.ToString();
        }

        private void btnNewBoPhan_Click(object sender, EventArgs e)
        {
            string tenbp = txtTenBP.Text;
            if (tenbp == "" || BoPhanDAO.Instance.TestBoPhan(tenbp).Equals(0))
            {
                MessageBox.Show("Tên phòng không được bỏ trống và không được trùng!", BoPhan);
            }
            else
            {
                if (BoPhanDAO.Instance.InsertBoPhan(tenbp))
                {
                    MessageBox.Show("Đã thêm một bộ phận", BoPhan);
                    LoadListBoPhan();
                    txtTenBP.Clear();
                    txtTenBP.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công", BoPhan);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLBP.SelectedRows[0];
            string mabp = dr.Cells["MaBP"].Value.ToString();
            string tenbp = txtTenBP.Text;
            if (tenbp == "" || BoPhanDAO.Instance.TestBoPhan(tenbp).Equals(0))
            {
                MessageBox.Show("Tên phòng không được bỏ trống và không được trùng!", BoPhan);
            }
            else
            {
                if (BoPhanDAO.Instance.UpdateBoPhan(mabp, tenbp))
                {
                    MessageBox.Show("Đã thay đổi thông tin mã bộ phận: "+mabp+"", BoPhan);
                    LoadListBoPhan();
                    txtTenBP.Clear();
                    txtTenBP.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công", BoPhan);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xoá", BoPhan, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow dr = dtgvQLBP.SelectedRows[0];
                string mabp = dr.Cells["MaBP"].Value.ToString();
                if (BoPhanDAO.Instance.DeleteBoPhan(mabp))
                {
                    LoadListBoPhan();
                    txtTenBP.Clear();
                    txtTenBP.Focus();
                    MessageBox.Show("Đã xoá!", BoPhan, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xoá không thành công", BoPhan);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenBP.Clear();
            txtTenBP.Focus();
            LoadListBoPhan();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.SearchBoPhan(txtTKBoPhan.Text);
            dtgvQLBP.DataSource = BoPhanList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (pnNewBP.Visible == false)
            {
                pnNewBP.Visible = true;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\minus_24px.png");
            }
            else
            {
                pnNewBP.Visible = false;
                btnNew.Image = Image.FromFile(@"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\add_32px.png");
            }
        }
        #endregion
    }
}
