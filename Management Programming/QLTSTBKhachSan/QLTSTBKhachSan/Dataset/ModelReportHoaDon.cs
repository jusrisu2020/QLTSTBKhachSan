namespace QLTSTBKhachSan.Dataset
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelReportHoaDon : DbContext
    {
        public ModelReportHoaDon()
            : base("name=ModelReportHoaDon")
        {
        }

        public virtual DbSet<HoaDonMuaTB> HoaDonMuaTBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
