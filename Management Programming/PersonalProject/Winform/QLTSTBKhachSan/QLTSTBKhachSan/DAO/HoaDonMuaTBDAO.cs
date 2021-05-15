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

        public List<ShowHoaDonDTO> LoadHDM()
        {
            List<ShowHoaDonDTO> HDList = new List<ShowHoaDonDTO>();
            string Query = 
                "SELECT hdm.Id, hdm.MaHDMua,hdm.NgayMuaTB, nv.MaNV, nv.HoTen, hdm.MaNCC, ncc.TenNCC,cthdm.TenTB, cthdm.TenDanhMuc, cthdm.MaBP, cthdm.DonVi, cthdm.SoLuong, cthdm.DonGia, cthdm.ThanhTien " +
                "FROM dbo.HoaDonMuaTB AS hdm, dbo.ChiTietHoaDonMuaTB AS cthdm, dbo.NhanVien AS nv, dbo.NhaCungCap AS ncc " +
                "WHERE hdm.MaHDMua = cthdm.MaHDMua AND hdm.MaNV = nv.MaNV AND ncc.MaNCC = hdm.MaNCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                ShowHoaDonDTO table = new ShowHoaDonDTO(item);
                HDList.Add(table);
            }
            return HDList;
        }
    }
}
