using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class HoaDonMuaTBDAO
    {
        private static HoaDonMuaTBDAO instance;

        public static HoaDonMuaTBDAO Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new HoaDonMuaTBDAO();
                    return instance;
            }
            private set => instance = value; 
        }

        public HoaDonMuaTBDAO() { }
        //Hiển thị danh sách Hoá Đơn
        public List<HoaDonMuaTBDTO> LoadListHoaDon()
        {
            List<HoaDonMuaTBDTO> HoaDonList = new List<HoaDonMuaTBDTO>();
            string Query = "EXEC dbo.USP_ShowHoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                HoaDonMuaTBDTO table = new HoaDonMuaTBDTO(item);
                HoaDonList.Add(table);
            }
            return HoaDonList;
        }

        public bool InsertHoaDonMua(DateTime? ngaymuatb, string manv, string mancc, int tongsltb)
        {
            string Query = "EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB , @Manv , @MaNCC , @TongSLTB";
            int result = DataProvider.Instance.ExecuteNonQuery(Query, new object[] { ngaymuatb, manv, mancc, tongsltb });
            return result > 0;
        }

        public bool DeleteHoaDonMua(string mahdmua)
        {
            string Query = "EXEC USP_HoaDonMuaTB @MaHDMua ";
            int result = DataProvider.Instance.ExecuteNonQuery(Query, new object[] { mahdmua });
            return result > 0;
        }
    }
}
