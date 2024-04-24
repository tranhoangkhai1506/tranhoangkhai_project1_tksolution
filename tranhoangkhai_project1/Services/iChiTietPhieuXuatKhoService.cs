using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iChiTietPhieuXuatKhoService
    {
        Task<List<ChiTietPhieuXuatKhoModel>> GetAllChiTietPhieuXuatKhoAsync();
        Task<ChiTietPhieuXuatKhoModel> GetByIdXuatKhoIDSanPhamIDAsync(string Xuat_Kho_ID, int San_Pham_ID);
        Task<ChiTietPhieuXuatKhoModel> GetByIdAsync(int Id);
        Task<List<ChiTietPhieuXuatKhoModel>> GetAllChiTietByKhoIDAsync(string Xuat_Kho_ID);
        Task<ChiTietPhieuXuatKhoModel> GetBySanPhamIDAsync(int maSanPham);
        Task AddChiTietPhieuXuat(ChiTietPhieuXuatKhoModel chitietPXK);
        Task UpdateChiTietPhieuXuatAsync(ChiTietPhieuXuatKhoModel chitietPXK, int Id);
        Task DeleteChiTietPhieuXuatAsync(int Id);
    }
}
