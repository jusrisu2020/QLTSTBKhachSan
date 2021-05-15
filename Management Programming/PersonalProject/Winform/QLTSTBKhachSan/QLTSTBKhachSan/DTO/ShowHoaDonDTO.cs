using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class ShowHoaDonDTO
    {
        private int id;
        private string maHDMua;
        private DateTime? ngayMuaTB;
        private string maNV;
        private string hoTen;
        private string maNCC;
        private string tenNCC;
        private string tenTB;
        private string tenDanhMuc;
        private string maBP;
        private string donVi;
        private int soLuong;
        private int donGia;
        private int thanhTien;

        public int Id { get => id; set => id = value; }
        public string MaHDMua { get => maHDMua; set => maHDMua = value; }
        public DateTime? NgayMuaTB { get => ngayMuaTB; set => ngayMuaTB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public ShowHoaDonDTO(int id, string mahdmua, DateTime? ngaymuatb, string manv, string hoten,
            string mancc, string tenncc, string tentb, string tendanhmuc, string mabp, string donvi, int soluong, int dongia, int thanhtien)
        {
            this.Id = id;
            this.MaHDMua = mahdmua;
            this.NgayMuaTB = ngaymuatb;
            this.MaNV = manv;
            this.HoTen = hoten;
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.TenTB = tentb;
            this.TenDanhMuc = tendanhmuc;
            this.MaBP = mabp;
            this.DonVi = donvi;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }

        public ShowHoaDonDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.MaHDMua = row["mahdmua"].ToString();
            this.NgayMuaTB = (DateTime?)row["ngaymuatb"];
            this.MaNV = row["manv"].ToString();
            this.HoTen = row["hoten"].ToString();
            this.MaNCC = row["mancc"].ToString();
            this.TenNCC = row["tenncc"].ToString();
            this.TenTB = row["tentb"].ToString();
            this.TenDanhMuc = row["tendanhmuc"].ToString();
            this.MaBP = row["mabp"].ToString();
            this.DonVi = row["donvi"].ToString();
            this.SoLuong = (int)row["soluong"];
            this.DonGia = (int)row["dongia"];
            this.ThanhTien = (int)row["thanhtien"];
        }
    }
}
