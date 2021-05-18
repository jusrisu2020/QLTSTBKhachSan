using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhanVienDAO() { }
        public List<NhanVienDTO> LoadNhanVien()
        {
            List<NhanVienDTO> NhanVienList = new List<NhanVienDTO>();
            string SNhanVien = "EXEC dbo.USP_SelectNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(SNhanVien);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO table = new NhanVienDTO(item);
                NhanVienList.Add(table);
            }
            return NhanVienList;
        }

        public bool InsertNhanVien(string hoten,string gioitinh,DateTime? ngaysinh,string diachi,
                                    string sdt,string email,string tongiao,string cmnd, string mabp,string macv)
        {
            string Query = string.Format("EXEC dbo.USP_ThemNhanVien N'{0}',N'{1}','{2}', N'{3}', N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}'", 
                hoten,gioitinh,ngaysinh,diachi,sdt,email,tongiao,cmnd,mabp,macv);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        public bool UpdateNhanVien(string hoten, string gioitinh, DateTime? ngaysinh, string diachi,
                                    string sdt, string email, string tongiao, string cmnd, string mabp, string macv, string manv)
        {
            string Query = string.Format("UPDATE dbo.NhanVien SET Hoten = N'{0}', Gioitinh = N'{1}', NgaySinh = '{2}' , DiaChi = N'{3}', SDT = N'{4}' , Email = N'{5}', TonGiao = N'{6}', CMND = N'{7}', MaBP = N'{8}', MaCV = '{9}' WHERE MaNV = N'{10}'", hoten, gioitinh, ngaysinh, diachi, sdt, email, tongiao, cmnd, mabp, macv, manv);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
        
        public bool DeleteNhanVien(string manv)
        {
            string Query = "DELETE dbo.NhanVien WHERE MaNV = N'" + manv + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
        public int TestNhanVien(string sdt, string email, string cmnd)
        {
            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            foreach (NhanVienDTO item in NhanVienList)
            {
                if (sdt.Equals(item.SDT) || email.Equals(item.Email) || cmnd.Equals(item.CMND))
                {
                    return 0;
                }
            }
            return 1;
        }

        public List<NhanVienDTO> SearchTenNV(string tennv)
        {
            List<NhanVienDTO> NhanVienList = new List<NhanVienDTO>();
            string Query = string.Format("EXEC USP_TKTenNhanVien N'{0}'", tennv);
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO table = new NhanVienDTO(item);
                NhanVienList.Add(table);
            }
            return NhanVienList;
        }
    }
}
