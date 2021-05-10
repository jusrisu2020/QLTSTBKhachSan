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

        #region Method
            void LoadData()
            {
                LoadListBoPhan();
                txtMaBP.Enabled = false;
            }
            void LoadListBoPhan()
            {
                dtgvQLBP.DataSource = BoPhanDAO.Instance.LoadListBoPhan();
                dtgvQLBP.Columns[0].Visible = false;
                dtgvQLBP.Columns[1].HeaderText = "Mã Bộ Phận";
                dtgvQLBP.Columns[2].HeaderText = "Tên Bộ Phận";
            }

            List<BoPhanDTO> SearchTenBoPhan(string name)
            {
                List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.SearchBoPhan(name);
                return BoPhanList;
            }
        #endregion

        #region Event
        private void dtgvQLBP_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvQLBP.SelectedRows[0];
            txtMaBP.Text = dr.Cells["MaBP"].Value.ToString();
            txtTenBP.Text = dr.Cells["TenBP"].Value.ToString();
        }

        private void btnInsertBP_Click(object sender, EventArgs e)
        {
            string tenbp = txtTenBP.Text;
            if (tenbp == "")
            {
                MessageBox.Show("Tên phòng không được bỏ trống!");
            }
            else
            {
                if (BoPhanDAO.Instance.InsertBoPhan(tenbp))
                {
                    MessageBox.Show("Saved!");
                    LoadListBoPhan();
                    txtTenBP.Clear();
                    txtTenBP.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void btnUpdateBoPhan_Click(object sender, EventArgs e)
        {
            string tenbp = txtTenBP.Text;
            string mabp = txtMaBP.Text;
            if (tenbp == "")
            {
                MessageBox.Show("Tên phòng không được bỏ trống!");
            }
            else
            {
                if (BoPhanDAO.Instance.UpdateBoPhan(mabp, tenbp))
                {
                    MessageBox.Show("Đã thay đổi!");
                    LoadListBoPhan();
                    txtTenBP.Clear();
                    txtTenBP.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void btnDeleteBoPhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xoá", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mabp = txtMaBP.Text;
                if (BoPhanDAO.Instance.DeleteBoPhan(mabp))
                {
                    LoadListBoPhan();
                    txtTenBP.Clear();
                    txtTenBP.Focus();
                    MessageBox.Show("Đã xoá!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void btnRefeshBoPhan_Click(object sender, EventArgs e)
        {
            txtTenBP.Clear();
            txtTenBP.Focus();
            LoadListBoPhan();
        }

        private void btnSearchBoPhan_Click(object sender, EventArgs e)
        {
            dtgvQLBP.DataSource = SearchTenBoPhan(txtTKBoPhan.Text);
        }
        #endregion

        
    }
}
