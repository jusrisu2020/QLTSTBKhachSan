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
using QLTSTBKhachSan.DTO;
using QLTSTBKhachSan.DAO;
using static QLTSTBKhachSan.UI.FSuaTaiKhoan;

namespace QLTSTBKhachSan.UI
{
    public partial class FTrangChu : Form
    {
        private TaiKhoanDTO loginTaiKhoan;

        public TaiKhoanDTO LoginTaiKhoan 
        { 
            get => loginTaiKhoan;
            set
            {
                loginTaiKhoan = value;
                PhanQuyen(loginTaiKhoan.TenTK);
                LoadInfoUser(loginTaiKhoan.TenHienThi,loginTaiKhoan.HinhAnh);
            }
        }

        public FTrangChu(TaiKhoanDTO tk)
        {
            InitializeComponent();
            AddLoadToolTip();
            LoginTaiKhoan = tk;
            pnDropDownHeThong.Visible = false;
            pnDropDownTSThietBi.Visible = false;
        }
        #region Method
        void AddLoadToolTip()
        {
            ToolTip tt = new ToolTip();
          
        }
       
        void LoadInfoUser(string tenhienthi, byte[] b)
        {
            lbUserName.Text = tenhienthi;
            pbAvartar.Image = TaiKhoanDAO.Instance.ByteArrayToImage(b);
        }
        void PhanQuyen(string tentk)
        {
            if (!tentk.Equals("ad"))
            {
                //btnUserMss.Enabled = false;
            }
        }

        #endregion
        #region Envent_Main
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLyNguoiDung nd = new UCQuanLyNguoiDung();
            pnContainer.Controls.Add(nd);
        }
        
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (pnDropDownHeThong.Visible == false)
            {
                pnDropDownHeThong.Visible = true;
            }
            else
            {
                pnDropDownHeThong.Visible = false;
            }
        }
        //Drop Down Hệ Thống
            private void btnBoPhan_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLiBoPhan bp = new UCQuanLiBoPhan();
                pnContainer.Controls.Add(bp);
            }

            private void btnChucVu_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLiChucVu cv = new UCQuanLiChucVu();
                pnContainer.Controls.Add(cv);
            }
            private void btnNhanVien_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLyNhanVien nv = new UCQuanLyNhanVien();
                pnContainer.Controls.Add(nv);
            }

        private void btnTaiSanThietBi_Click(object sender, EventArgs e)
        {
            if (pnDropDownTSThietBi.Visible == false)
            {
                pnDropDownTSThietBi.Visible = true;
            }
            else
            {
                pnDropDownTSThietBi.Visible = false;
            }
        }

      
            private void gunaButton1_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLyThietBi tb = new UCQuanLyThietBi();
                pnContainer.Controls.Add(tb);
            }
        /*private void btnReportM_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLyBaoCao bc = new UCQuanLyBaoCao();
            pnContainer.Controls.Add(bc);
        }*/
            
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQLNhaCungCap ncc = new UCQLNhaCungCap();
            pnContainer.Controls.Add(ncc);
        }
       
        #endregion
        #region Event_Dif
        private void btnNotification_Click(object sender, EventArgs e)
        {
            FThongBao tb = new FThongBao();
            tb.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FHelp h = new FHelp();
            h.Show();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            FSetting st = new FSetting();
            st.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Hide();
        }



        #endregion

        

        private void btnSuaNguoiDung_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            FSuaTaiKhoan stk = new FSuaTaiKhoan(LoginTaiKhoan);
            stk.UpdateAccount += Stk_UpdateAccount;
            stk.ShowDialog();
        }

        void Stk_UpdateAccount(object sender, AccountEvent e)
        {
            lbUserName.Text = e.Tk.TenHienThi;
        }

        
    }
}
