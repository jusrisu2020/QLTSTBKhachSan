namespace QLTSTBKhachSan.Dataset
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonMuaTB")]
    public partial class HoaDonMuaTB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(20)]
        public string MaHDMua { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMuaTB { get; set; }

        [StringLength(20)]
        public string MaNV { get; set; }

        [StringLength(20)]
        public string MaNCC { get; set; }

        public int? TongSLTB { get; set; }
    }
}
