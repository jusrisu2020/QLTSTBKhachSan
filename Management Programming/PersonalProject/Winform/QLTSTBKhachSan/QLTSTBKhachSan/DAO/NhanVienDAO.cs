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

        public bool InsertNhanVien(string hoten,string gioitinh,string ngaysinh,string diachi,
                                    string sdt,string email,string tongiao,string cmnd, string mabp,string macv)
        {
            string Query = string.Format("EXEC dbo.USP_ThemNhanVien N'{0}',N'{1}','{2}', N'{3}', N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}'", 
                hoten,gioitinh,ngaysinh,diachi,sdt,email,tongiao,cmnd,mabp,macv);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
        public void DeleteNhanVienByBoPhan(string mabp)
        {
            string Query = "DELETE dbo.NhanVien WHERE MaBP = N'" + mabp + "'";
            DataProvider.Instance.ExecuteQuery(Query);
        }

    }
}
