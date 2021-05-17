using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class ThietBiDTO
    {
        private int iD;
        private string maTB;
        private string tenTB;
        private string donVi;
        private int soluong;
        private string tenDanhmuc;
        private string maBP;
        private DateTime? thoiGianBH;
        private int tinhTrangTB;
        private string maNCC;
        private string maHDMuaTB;
        private int giaTBMua;

        public int ID { get => iD; set => iD = value; }
        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string TenDanhmuc { get => tenDanhmuc; set => tenDanhmuc = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public DateTime? ThoiGianBH { get => thoiGianBH; set => thoiGianBH = value; }
        public int TinhTrangTB { get => tinhTrangTB; set => tinhTrangTB = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaHDMuaTB { get => maHDMuaTB; set => maHDMuaTB = value; }
        public int GiaTBMua { get => giaTBMua; set => giaTBMua = value; }

        public ThietBiDTO(int id, string matb, string tentb, string donvi,
                        int soluong, string tendanhmuc, string mabp, DateTime? thoigianbaohanh,
                        int tinhtrangthietbi, string mancc, string mahdmuatb, int giatbmua
                            )
        {
            this.ID = id;
            this.MaTB = matb;
            this.TenTB = tentb;
            this.DonVi = donvi;
            this.Soluong = soluong;
            this.TenDanhmuc = tendanhmuc;
            this.MaBP = mabp;
            this.ThoiGianBH = thoigianbaohanh;
            this.TinhTrangTB = tinhtrangthietbi;
            this.MaNCC = mancc;
            this.MaHDMuaTB = mahdmuatb;
            this.GiaTBMua = giatbmua;
        }
        
        public ThietBiDTO(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.MaTB = row["MaTB"].ToString();
            this.TenTB = row["TenTB"].ToString();
            this.DonVi = row["DonVi"].ToString();
            this.Soluong = (int)row["SoLuong"];
            this.TenDanhmuc = row["tendanhmuc"].ToString();
            this.MaBP = row["mabp"].ToString();
            this.ThoiGianBH = (DateTime?)row["ThoiGianBH"];
            this.TinhTrangTB = (int)row["TinhTrangTB"];
            this.MaNCC = row["mancc"].ToString();
            this.MaHDMuaTB = row["MaHDMuaTB"].ToString();
            this.GiaTBMua = (int)row["GiaTBMua"];
        }
    }
}
