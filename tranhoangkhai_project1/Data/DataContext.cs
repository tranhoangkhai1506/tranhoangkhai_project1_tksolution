using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DonViTinhModel>().HasData(
                new DonViTinhModel { Ten_Don_Vi_Tinh = "dvt_01", Ghi_Chu = "Ghi chu 1" },
                new DonViTinhModel { Ten_Don_Vi_Tinh = "dvt_02", Ghi_Chu = "Ghi chu 2" },
                new DonViTinhModel { Ten_Don_Vi_Tinh = "dvt_03", Ghi_Chu = "Ghi chu 3" }
            );
        }

        public DbSet<DonViTinhModel> tbl_DM_Don_Vi_Tinh { get; set; }
    }
}
