using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iChiTietPhieuXuatKhoService
    {
        Task<List<ChiTietPhieuXuatKhoModel>> GetAllChiTietPhieuXuatKhoAsync();
        Task<ChiTietPhieuXuatKhoModel> GetByIdAsync(string Xuat_Kho_ID, string San_Pham_ID);

        Task AddChiTietPhieuXuat(ChiTietPhieuXuatKhoModel chitietPXK);
        Task UpdateChiTietPhieuXuatAsync(ChiTietPhieuXuatKhoModel chitietPXK, string Xuat_Kho_ID, string San_Pham_ID);
        Task DeleteChiTietPhieuXuatAsync(string Xuat_Kho_ID, string San_Pham_ID);
    }
}
