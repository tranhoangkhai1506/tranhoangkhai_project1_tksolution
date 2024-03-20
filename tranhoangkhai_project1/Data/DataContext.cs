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

            modelBuilder.Entity<LoaiSanPhamModel>().HasData(
                new LoaiSanPhamModel { Ma_LSP = "lsp_01",Ten_LSP = "Loai 1", Ghi_Chu = "Ghi chu 1" },
                new LoaiSanPhamModel { Ma_LSP = "lsp_02", Ten_LSP = "Loai 2", Ghi_Chu = "Ghi chu 2" },
                new LoaiSanPhamModel { Ma_LSP = "lsp_03", Ten_LSP = "Loai 3", Ghi_Chu = "Ghi chu 3" }
            );

            modelBuilder.Entity<SanPhamModel>().HasData(
                new SanPhamModel { Ma_San_Pham = "sp_01", Ten_San_Pham = "San Pham 1", Loai_San_Pham_ID = "lsp_01",Don_Vi_Tinh_ID = "dvt_01", Ghi_Chu = "Ghi chu 1" },
                new SanPhamModel { Ma_San_Pham = "sp_02", Ten_San_Pham = "San Pham 1 2", Loai_San_Pham_ID = "lsp_02", Don_Vi_Tinh_ID = "dvt_02", Ghi_Chu = "Ghi chu 2" },
                new SanPhamModel { Ma_San_Pham = "sp_03", Ten_San_Pham = "San Pham 1 3", Loai_San_Pham_ID = "lsp_03", Don_Vi_Tinh_ID = "dvt_02", Ghi_Chu = "Ghi chu 3" }
            );
            modelBuilder.Entity<NhaCungCapModel>().HasData(
                new NhaCungCapModel { Ma_NCC = "ncc_01", Ten_NCC = "Nha cung cap 1", Ghi_Chu = "Ghi chu 1" },
                new NhaCungCapModel { Ma_NCC = "ncc_02", Ten_NCC = "Nha cung cap 2", Ghi_Chu = "Ghi chu 2" },
                new NhaCungCapModel { Ma_NCC = "ncc_03", Ten_NCC = "Nha cung cap 3", Ghi_Chu = "Ghi chu 3" }
            );
            modelBuilder.Entity<KhoModel>().HasData(
                new KhoModel { Ten_Kho = "Kho_01", Ghi_Chu = "Ghi chu 1" },
                new KhoModel { Ten_Kho = "Kho_02", Ghi_Chu = "Ghi chu 2" },
                new KhoModel { Ten_Kho = "Kho_03", Ghi_Chu = "Ghi chu 3" }
            );
        }

        public DbSet<DonViTinhModel> tbl_DM_Don_Vi_Tinh { get; set; }
        public DbSet<LoaiSanPhamModel> tbl_DM_Loai_San_Pham { get; set; }
        public DbSet<SanPhamModel> tbl_DM_San_Pham { get; set; }
        public DbSet<NhaCungCapModel> tbl_DM_NCC { get; set; }
        public DbSet<KhoModel> tbl_DM_Kho { get; set; }
    }
}
