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
        public List<TaiKhoanDTO> LoadListAccount()
        {
            List<TaiKhoanDTO> TaiKhoanList = new List<TaiKhoanDTO>();
            string SATaiKhoan = "EXEC USP_SelectATaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(SATaiKhoan);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(item);
                TaiKhoanList.Add(tk);
            }
            return TaiKhoanList;
        }

        public bool Login(string TenTK, string Pass)
        {
            string TaiKhoanQuery = "EXEC USP_DangNhap  @TenTK , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(TaiKhoanQuery, new object[] { TenTK, Pass });
            return result.Rows.Count > 0;
        }

        public bool InsertAccount(string hinhanh,string manv, string tentk ,string tenhienthi, string pass ,string macv)
        {
            string TaiKhoanQuery = "EXEC dbo.USP_ThemTaiKhoan @HinhAnh , @MaNV , @TenTK , @TenHienThi , @Pass , @MaCV ";
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery, new object[] {hinhanh, manv, tentk, tenhienthi, pass, macv});
            return result > 0;
        }

        public bool UpdateAccountByUser(string hinhanh, string tentk, string tenhienthi, string pass, string newPass)
        {
            string Query = "EXEC USP_UpdateTaiKhoan @HinhAnh , @TenTK , @TenHienThi , @Pass , @NewPass ";
            int result = DataProvider.Instance.ExecuteNonQuery(Query,new object[]{ hinhanh, tentk, tenhienthi, pass, newPass});
            return result > 0;
        }

        /*public bool UpdateAccountByAdmin(string tentk, string tenhienthi, string pass, string newPass)
        {
            string Query = string.Format("EXEC USP_UpdateTaiKhoan '{0}','{1}',{2},{3}", tentk, tenhienthi, pass, newPass);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }*/

        public bool DeleteAccount(string matk)
        {
            string TaiKhoanQuery = string.Format("DELETE dbo.TaiKhoan WHERE MaTK = '{0}'", matk);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }
        //Phân quyền và Hiển thị tên người dùng
        public TaiKhoanDTO GetAccountByUserName(string tentk)
        {
            string Query = "SELECT * FROM dbo.TaiKhoan WHERE TenTK = '" + tentk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach(DataRow item in data.Rows)
            {
                return new TaiKhoanDTO(item);
            }
            return null;
        }
    }
}
