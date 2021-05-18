using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class HoaDonMuaTBDTO
    {
        private int id;
        private string maHDMua;
        private DateTime? ngayMuaTB;
        private string maNV;
        private string maNCC;
        private int tongSLTB;

        public int Id { get => id; set => id = value; }
        public string MaHDMua { get => maHDMua; set => maHDMua = value; }
        public DateTime? NgayMuaTB { get => ngayMuaTB; set => ngayMuaTB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public int TongSLTB { get => tongSLTB; set => tongSLTB = value; }

        public HoaDonMuaTBDTO(int id, string mahdmua, DateTime? ngaymuatb, string manv, string mancc,int tongsltb)
        {
            this.Id = id;
            this.maHDMua = mahdmua;
            this.ngayMuaTB = ngaymuatb;
            this.MaNV = manv;
            this.maNCC = mancc;
            this.TongSLTB = tongsltb;
        }

        public HoaDonMuaTBDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.maHDMua = row["mahdmua"].ToString();
            this.ngayMuaTB = (DateTime?)row["ngaymuatb"];
            this.MaNV = row["manv"].ToString();
            this.maNCC = row["mancc"].ToString();
            this.TongSLTB = (int)row["tongsltb"];
        }
    }
}
