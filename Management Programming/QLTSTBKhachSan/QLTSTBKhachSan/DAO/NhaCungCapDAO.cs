using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhaCungCapDAO() { }
        public List<NhaCungCapDTO> LoadNCC()
        {
            List<NhaCungCapDTO> NCCList = new List<NhaCungCapDTO>();
            string Query = "EXEC USP_SelectNhaCungCap";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO Table = new NhaCungCapDTO(item);
                NCCList.Add(Table);
            }
            return NCCList;
        }

        public bool InsertNhaCungCap(string tenncc, string sdt, string diachi, string email,string stk, string tencongty)
        {
            string Query = string.Format("EXEC dbo.USP_ThemNhaCungCap N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}'", tenncc, sdt, diachi, email, stk, tencongty);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        public bool UpdateNhaCungCap(string tenncc, string sdt, string diachi, string email, string stk, string tencongty, string mancc)
        {
            string Query = string.Format("EXEC USP_UpdateNCC N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}', N'{6}'", tenncc, sdt, diachi, email, stk, tencongty, mancc);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        //Kiểm tra trùng
        public int Test(string tenncc, string phone, string email, string stk, string tencongty)
        {
            List<NhaCungCapDTO> NhaCungCapList = NhaCungCapDAO.Instance.LoadNCC();
            foreach (NhaCungCapDTO item in NhaCungCapList)
            {
                if (tenncc.Equals(item.TenNCC) || phone.Equals(item.SDT) || email.Equals(item.EMail) || stk.Equals(item.STK) || tencongty.Equals(item.TenCongTy))
                {
                    return 0;
                }
            }
            return 1;
        }
        //Xoá
        public bool DeleteNhaCungCap(string mancc)
        {
            string Query = string.Format("DELETE dbo.NhaCungCap WHERE MaNCC = '{0}'", mancc);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        //Tìm kiếm
        public List<NhaCungCapDTO> SeacrchTenNCC(string tenncc)
        {
            List<NhaCungCapDTO> NhaCungCapList = new List<NhaCungCapDTO>();
            string Query = string.Format("EXEC USP_TKTenNCC @TenNCC");
            DataTable data = DataProvider.Instance.ExecuteQuery(Query, new object[] { tenncc});
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO table = new NhaCungCapDTO(item);
                NhaCungCapList.Add(table);
            }
            return NhaCungCapList;
        }

        
    }
}
