using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
            //modelBuilder.Entity<DonViTinhModel>().HasData(
            //    new DonViTinhModel { Ten_Don_Vi_Tinh = "dvt_01", Ghi_Chu = "Ghi chu 1" },
            //    new DonViTinhModel { Ten_Don_Vi_Tinh = "dvt_02", Ghi_Chu = "Ghi chu 2" },
            //    new DonViTinhModel { Ten_Don_Vi_Tinh = "dvt_03", Ghi_Chu = "Ghi chu 3" }
            //);

            //modelBuilder.Entity<LoaiSanPhamModel>().HasData(
            //    new LoaiSanPhamModel { Ma_LSP = "lsp_01",Ten_LSP = "Loai 1", Ghi_Chu = "Ghi chu 1" },
            //    new LoaiSanPhamModel { Ma_LSP = "lsp_02", Ten_LSP = "Loai 2", Ghi_Chu = "Ghi chu 2" },
            //    new LoaiSanPhamModel { Ma_LSP = "lsp_03", Ten_LSP = "Loai 3", Ghi_Chu = "Ghi chu 3" }
            //);

            //modelBuilder.Entity<NhaCungCapModel>().HasData(
            //    new NhaCungCapModel { Ma_NCC = "ncc_01", Ten_NCC = "Nha cung cap 1", Ghi_Chu = "Ghi chu 1" },
            //    new NhaCungCapModel { Ma_NCC = "ncc_02", Ten_NCC = "Nha cung cap 2", Ghi_Chu = "Ghi chu 2" },
            //    new NhaCungCapModel { Ma_NCC = "ncc_03", Ten_NCC = "Nha cung cap 3", Ghi_Chu = "Ghi chu 3" }
            //);
            //modelBuilder.Entity<KhoModel>().HasData(
            //    new KhoModel { Ten_Kho = "Kho_01", Ghi_Chu = "Ghi chu 1" },
            //    new KhoModel { Ten_Kho = "Kho_02", Ghi_Chu = "Ghi chu 2" },
            //    new KhoModel { Ten_Kho = "Kho_03", Ghi_Chu = "Ghi chu 3" }
            //);
            //modelBuilder.Entity<KhoUserModel>().HasData(
            //    new KhoUserModel { Ma_Dang_Nhap = "qlkho1", Kho_ID = "Kho_01" },
            //    new KhoUserModel { Ma_Dang_Nhap = "qlkho2", Kho_ID = "Kho_02" },
            //    new KhoUserModel { Ma_Dang_Nhap = "qlkho3", Kho_ID = "Kho_03" }
            //);
            //modelBuilder.Entity<PhieuNhapKhoModel>().HasData(
            //    new PhieuNhapKhoModel { So_Phieu_Nhap_Kho = "pn_01", Kho_ID = "Kho_01",NCC_ID = "ncc_01",Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu 1" },
            //    new PhieuNhapKhoModel { So_Phieu_Nhap_Kho = "pn_02", Kho_ID = "Kho_02", NCC_ID = "ncc_02", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu 2" },
            //    new PhieuNhapKhoModel { So_Phieu_Nhap_Kho = "pn_03", Kho_ID = "Kho_03", NCC_ID = "ncc_03", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu 3" }
            //);
            modelBuilder.Entity<ChiTietPhieuNhapKho>().HasKey(table => new {
                table.Nhap_Kho_ID,
                table.San_Pham_ID
            });
            modelBuilder.Entity<ChiTietPhieuNhapKho>().HasData(
                new ChiTietPhieuNhapKho { Nhap_Kho_ID = "pn_01", San_Pham_ID = "sp_01", SL_Nhap = 100, Don_Gia_Nhap = 2000000},
                new ChiTietPhieuNhapKho { Nhap_Kho_ID = "pn_02", San_Pham_ID = "sp_01", SL_Nhap = 200, Don_Gia_Nhap = 4000000 },
                new ChiTietPhieuNhapKho { Nhap_Kho_ID = "pn_03", San_Pham_ID = "sp_01", SL_Nhap = 300, Don_Gia_Nhap = 5000000 }
            );
            //modelBuilder.Entity<PhieuXuatKhoModel>().HasData(
            //    new PhieuXuatKhoModel { So_Phieu_Xuat_Kho = "px_01", Kho_ID = "Kho_01", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu 1" },
            //    new PhieuXuatKhoModel { So_Phieu_Xuat_Kho = "px_02", Kho_ID = "Kho_02", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu 2" },
            //    new PhieuXuatKhoModel { So_Phieu_Xuat_Kho = "px_03", Kho_ID = "Kho_03", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu 3" }
            //);
            //modelBuilder.Entity<HieuChinhPhieuXuatKhoModel>().HasData(
            //    new PhieuXuatKhoModel { So_Phieu_Xuat_Kho = "px_01", Kho_ID = "Kho_01", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu da sua 1" },
            //    new PhieuXuatKhoModel { So_Phieu_Xuat_Kho = "px_02", Kho_ID = "Kho_02", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu da chu 2" },
            //    new PhieuXuatKhoModel { So_Phieu_Xuat_Kho = "px_03", Kho_ID = "Kho_03", Ngay_Nhap_Kho= DateTime.Now, Ghi_Chu = "Ghi chu da chu 3" }
            //);
            modelBuilder.Entity<ChiTietPhieuXuatKhoModel>().HasKey(table => new
            {
                table.Xuat_Kho_ID,
                table.San_Pham_ID
            });
            modelBuilder.Entity<ChiTietPhieuXuatKhoModel>().HasData(
                new ChiTietPhieuXuatKhoModel { Xuat_Kho_ID = "px_01", San_Pham_ID = "sp_01", SL_Xuat = 100, Don_Gia_Xuat = 2000000 },
                new ChiTietPhieuXuatKhoModel { Xuat_Kho_ID = "px_02", San_Pham_ID = "sp_02", SL_Xuat = 200, Don_Gia_Xuat = 4000000 },
                new ChiTietPhieuXuatKhoModel { Xuat_Kho_ID = "px_03", San_Pham_ID = "sp_03", SL_Xuat = 300, Don_Gia_Xuat = 5000000 }
               );
        }
        public DbSet<DonViTinhModel> tbl_DM_Don_Vi_Tinh { get; set; }
        public DbSet<LoaiSanPhamModel> tbl_DM_Loai_San_Pham { get; set; }
        public DbSet<SanPhamModel> tbl_DM_San_Pham { get; set; }
        public DbSet<NhaCungCapModel> tbl_DM_NCC { get; set; }
        public DbSet<KhoModel> tbl_DM_Kho { get; set; }
        public DbSet<KhoUserModel> tbl_DM_Kho_User { get; set; }
        public DbSet<PhieuNhapKhoModel> tbl_DM_Nhap_Kho { get; set; }
        public DbSet<ChiTietPhieuNhapKho> tbl_DM_Nhap_Kho_Raw_Data { get; set; }
        public DbSet<PhieuXuatKhoModel> tbl_DM_Xuat_Kho { get; set; }
        public DbSet<ChiTietPhieuXuatKhoModel>tbl_DM_Xuat_Kho_Raw_Data  { get; set; }
    }
}
