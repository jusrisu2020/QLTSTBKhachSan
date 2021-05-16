using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class ThietBiDAO
    {
        private static ThietBiDAO instance;
        public static ThietBiDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new ThietBiDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThietBiDAO() { }

        public List<ThietBiDTO> LoadThietBi()
        {
            List<ThietBiDTO> ThietBiList = new List<ThietBiDTO>();
            string Query = string.Format("EXEC USP_SelectAThietBi");
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                ThietBiDTO thietbi = new ThietBiDTO(item);
                ThietBiList.Add(thietbi);
            }
            return ThietBiList;
        }

        public List<ThietBiDTO> LoadThietBiTrongBoPhan(string mabp)
        {
            List<ThietBiDTO> ThietBiList = new List<ThietBiDTO>();
            string Query = string.Format("SELECT * FROM dbo.ThietBi WHERE MaBP = '{0}'", mabp);
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                ThietBiDTO thietbi = new ThietBiDTO(item);
                ThietBiList.Add(thietbi);
            }
            return ThietBiList;
        }

        public bool InsertThietBi(string tentb,string donvi, int soluong,string tendanhmuc, string mabp, DateTime? thoigianbh, string tinhtrangtb, string mancc, string mahdmuatb , string ghichu)
        {
            string Query = "EXEC dbo.USP_ThemThietBi @TenTB , @DonVi , @SoLuong , @TenDanhMuc , @MaBP , @ThoiGianBH , @TinhTrangTB , @MaNCC , @MaHDMuaTB , @GhiChu";
            int result = DataProvider.Instance.ExecuteNonQuery(Query, new object[] { tentb, donvi, soluong, tendanhmuc, mabp, thoigianbh, tinhtrangtb, mancc, mahdmuatb, ghichu});
            return result > 0;
        }

    }
}
