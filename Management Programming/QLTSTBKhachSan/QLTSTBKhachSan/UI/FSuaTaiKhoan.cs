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
    public partial class FCapNhatThongTin : Form
    {
        private TaiKhoanDTO loginTaiKhoan;
        public TaiKhoanDTO LoginTaiKhoan
        {
            get => loginTaiKhoan;
            set
            {
                loginTaiKhoan = value;
                LoadFSua(loginTaiKhoan.HinhAnh,loginTaiKhoan.TenTK, loginTaiKhoan.TenHienThi);
            }
        }

        public FCapNhatThongTin(TaiKhoanDTO tk) 
        {
            InitializeComponent();
            LoginTaiKhoan = tk;
        }

        void LoadFSua(string hinhanh, string tentk, string tenhienthi)
        {
            lbTenTK.Text = tentk;
            txtTenHienThi.Text = tenhienthi;
            picAvatar.Image = Image.FromFile(hinhanh);
        }

        void UpdateUser()
        {
            string HinhAnh = picAvatar.ImageLocation;
            string TenTK = lbTenTK.Text;
            string TenHienThi = txtTenHienThi.Text;
            string Pass = txtPassword.Text;
            string NewPass = txtNewPass.Text;
            string PassNhapLai = txtNhapLaiPass.Text;
            if (!NewPass.Equals(PassNhapLai))
            {
                MessageBox.Show("Vui lòng xem lại Pass mới và Pass Nhập lại");
            }
            else
            {
                if (TaiKhoanDAO.Instance.UpdateAccountByUser(HinhAnh,TenTK, TenHienThi, Pass, NewPass))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    if(updateAccount != null)
                        updateAccount(this, new AccountEvent(TaiKhoanDAO.Instance.GetAccountByUserName(TenTK)));
                    txtPassword.Clear();
                    txtNewPass.Clear();
                    txtNhapLaiPass.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại Pass");
                }
            }
        }
        
        private void btnUpdateTaiKhoan_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        //Event Cập nhật vào Form Trang Chủ
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        
        public class AccountEvent : EventArgs
        {
            private TaiKhoanDTO tk;
            public TaiKhoanDTO Tk 
            {
                get{return tk;}
                set{tk = value;}
            }
            public AccountEvent(TaiKhoanDTO tk)
            {
                this.Tk = tk;
            }
        }
       
        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofile = new OpenFileDialog();
            if(Ofile.ShowDialog() == DialogResult.OK)
            {
                picAvatar.ImageLocation = Ofile.FileName;
                this.Text = Ofile.FileName;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
