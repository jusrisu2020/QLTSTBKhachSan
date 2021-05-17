using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance 
        { get
            {
                if (instance == null)
                    instance = new ChucVuDAO();
                    return instance;
            }
            private set => instance = value; 
        }

        public ChucVuDAO() { }

        public List<ChucVuDTO> LoadChucVu() 
        {
            List<ChucVuDTO> ChucVuList = new List<ChucVuDTO>();
            string Query = "EXEC USP_SelectChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach(DataRow item in data.Rows)
            {
                ChucVuDTO cv = new ChucVuDTO(item);
                ChucVuList.Add(cv);
            }
            return ChucVuList;
        }

        public bool InsertChucVu(string tencv)
        {
            string Query = string.Format("EXEC dbo.USP_ThemChucVu N'{0}'", tencv);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        public bool UpdateChucVu(string macv, string tencv)
        {
            string Query = string.Format("UPDATE dbo.ChucVu SET TenCV = N'{0}' WHERE MaCV = N'{1}'", tencv,macv);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        public bool DeleteChucVu(string macv)
        {
            string Query = string.Format("DELETE dbo.ChucVu WHERE MaCV = N'{0}'", macv);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        public int TestChucVu(string tencv)
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            foreach (ChucVuDTO item in ChucVuList)
            {
                if (tencv.Equals(item.TenCV))
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
