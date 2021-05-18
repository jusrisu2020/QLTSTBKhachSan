using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance 
        {
            get
            {
                if(instance == null)
                    instance = new TaiKhoanDAO();
                    return TaiKhoanDAO.instance;
            }
            private set
            {
                TaiKhoanDAO.instance = value;
            }
        }
        private TaiKhoanDAO() { }

        //Hiển thị danh sách các tài khoản
        public List<TaiKhoanDTO> LoadListAccount()
        {
            List<TaiKhoanDTO> TaiKhoanList = new List<TaiKhoanDTO>();
            string Query = "EXEC USP_SelectATaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(item);
                TaiKhoanList.Add(tk);
            }
            return TaiKhoanList;
        }

        //Kiểm tra đăng nhập thành công
        public bool Login(string TenTK, string MatKhau)
        {
            string TaiKhoanQuery = "EXEC USP_DangNhap  @TenTK , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(TaiKhoanQuery, new object[] { TenTK, MatKhau });
            return result.Rows.Count > 0;
        }

        //Thêm Tài khoảnmm
        public bool InsertAccount(string hinhanh,string manv, string tentk ,string tenhienthi, string matkhau ,string macv)
        {
            string Query = "EXEC dbo.USP_ThemTaiKhoan @HinhAnh , @MaNV , @TenTK , @TenHienThi , @Pass , @MaCV ";
            int result = DataProvider.Instance.ExecuteNonQuery(Query, new object[] {hinhanh, manv, tentk, tenhienthi, matkhau, macv});
            return result > 0;
        }

        //Sửa tài khoản
        public bool UpdateAccountByUser(string hinhanh, string tentk, string tenhienthi, string matkhau, string matkhaumoi)
        {
            string Query = "EXEC USP_UpdateTaiKhoan @HinhAnh , @TenTK , @TenHienThi , @Pass , @NewPass ";
            int result = DataProvider.Instance.ExecuteNonQuery(Query,new object[]{ hinhanh, tentk, tenhienthi, matkhau, matkhaumoi });
            return result > 0;
        }

        //Xoá tài khoản
        public bool DeleteAccount(string matk)
        {
            string Query = string.Format("DELETE dbo.TaiKhoan WHERE MaTK = '{0}'", matk);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
        
        public List<TaiKhoanDTO> TKTenTK(string tentk)
        {
            List<TaiKhoanDTO> TaiKhoanList = new List<TaiKhoanDTO>();
            string Query = string.Format("EXEC USP_TKTenTK N'{0}'", tentk);
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDTO table = new TaiKhoanDTO(item);
                TaiKhoanList.Add(table);
            }
            return TaiKhoanList;
        }
        //Phân quyền và Hiển thị tên người dùng
        public TaiKhoanDTO GetAccountByUserName(string tentk)
        {
            string Query = string.Format("SELECT * FROM dbo.TaiKhoan WHERE TenTK = '{0}'", tentk);
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach(DataRow item in data.Rows)
            {
                return new TaiKhoanDTO(item);
            }
            return null;
        }
    }
}
