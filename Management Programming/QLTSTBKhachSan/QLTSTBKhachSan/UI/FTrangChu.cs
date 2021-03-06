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
using static QLTSTBKhachSan.UI.FCapNhatThongTin;
using System.Runtime.InteropServices;
using System.IO;

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
                LoadInfoUser(loginTaiKhoan.TenHienThi, loginTaiKhoan.TenTK,loginTaiKhoan.HinhAnh);
            }
        }

        //Kéo thả Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FTrangChu(TaiKhoanDTO tk)
        {
            InitializeComponent();
            ShowSL();
            LoginTaiKhoan = tk;
            pnDropDownHeThong.Visible = false;
            pnDropDownTSThietBi.Visible = false;
        }

        #region Method
        void LoadInfoUser(string tenhienthi, string tentk, string hinhanh)
        {
            lbUserName.Text = tenhienthi;
            lbTenTK.Text = tentk;
            pbAvartar.Image = Image.FromFile(hinhanh);
        }

        void PhanQuyen(string tentk)
        {
            if (!tentk.Equals("Ad"))
            {
                btnAdmin.Enabled = false;
            }
        }
        //Xử lí xự kiện Event Cập nhật xong Load trực tiếp
        void Stk_UpdateAccount(object sender, AccountEvent e)
        {
            lbUserName.Text = e.Tk.TenHienThi;
            pbAvartar.ImageLocation = e.Tk.HinhAnh;
        }
        
        void ShowSL()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadListBoPhan();
            foreach (BoPhanDTO item in BoPhanList)
            {
                lbShowBoPhan.Text = item.ID.ToString();
            }

            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            foreach (NhanVienDTO item in NhanVienList)
            {
                lbShowNhanVien.Text = item.ID.ToString();
            }
        }



        #endregion
        #region Envent_Main
        private void pnTitlte_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLyNguoiDung nd = new UCQuanLyNguoiDung();
            pnContainer.Controls.Add(nd);
            nd.Dock = DockStyle.Fill;
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
                bp.Dock = DockStyle.Fill;
            }

        private void btnChucVu_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLiChucVu cv = new UCQuanLiChucVu();
                pnContainer.Controls.Add(cv);
                cv.Dock = DockStyle.Fill;
            }
        private void btnNhanVien_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLyNhanVien nv = new UCQuanLyNhanVien();
                pnContainer.Controls.Add(nv);
                nv.Dock = DockStyle.Fill;
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

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            
            pnContainer.Controls.Clear();
            UCQuanLyThietBi tb = new UCQuanLyThietBi();
            pnContainer.Controls.Add(tb);
            tb.Dock = DockStyle.Fill;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQLNhaCungCap ncc = new UCQLNhaCungCap();
            pnContainer.Controls.Add(ncc);
            ncc.Dock = DockStyle.Fill;
        }
        private void btnLSThongBao_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCLSThongBao lstb = new UCLSThongBao();
            pnContainer.Controls.Add(lstb);
            lstb.Dock = DockStyle.Fill;
        }

        private void btnHoaDonMuaTB_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLyHoaDon bc = new UCQuanLyHoaDon();
            pnContainer.Controls.Add(bc);
            bc.Dock = DockStyle.Fill;
        }

        private void btnReportHoaDon_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCReportHoaDon rp = new UCReportHoaDon();
            pnContainer.Controls.Add(rp);
            rp.Dock = DockStyle.Fill;
        }
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            FCapNhatThongTin stk = new FCapNhatThongTin(LoginTaiKhoan);
            stk.UpdateAccount += Stk_UpdateAccount;
            stk.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (pnList.Visible == false)
            {
                pnList.Visible = true;
            }
            else
            {
                pnList.Visible = false;
            }
        }
        #endregion
        #region Event_Dif

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
                using (StreamReader re = new StreamReader(paths))
                {
                    while (!re.EndOfStream)
                    {
                        txtFileLog.Text = re.ReadLine();
                    }
                }
                using (StreamWriter sw = new StreamWriter(paths))
                {
                    sw.WriteLine(txtFileLog.Text);
                    sw.WriteLine("\nTài khoản: " + lbTenTK.Text + " đăng Xuất vào lúc " + DateTime.Now.ToString("hh:mm:ss"));
                }
            }
        }

        string paths = @"C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\QLTSTBKhachSan\Filelog.txt";
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Hide();
            using (StreamReader re = new StreamReader(paths))
            {
                while (!re.EndOfStream)
                {
                     txtFileLog.Text = re.ReadLine();
                }
            }
            using (StreamWriter sw = new StreamWriter(paths))
            {
                sw.WriteLine(txtFileLog.Text);
                sw.WriteLine("\nTài khoản: "+lbTenTK.Text+" đăng Xuất vào lúc " + DateTime.Now.ToString("hh:mm:ss"));
            }
        }
        private void TimHienThiThoiGian_Tick(object sender, EventArgs e)
        {
            DateTime Nowdt = DateTime.Now;
            this.lbTime.Text = "Date: " + Nowdt.ToString("dd/MM/yyyy") + "\nTime: " + Nowdt.ToString("HH:mm:ss");
        }
        #endregion
    }
}
