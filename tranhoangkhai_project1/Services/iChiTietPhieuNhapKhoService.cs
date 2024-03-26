using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iChiTietPhieuNhapKhoService
    {
        Task<List<ChiTietPhieuNhapKho>> GetAllChiTietPhieuNhapKhoAsync();
        Task<ChiTietPhieuNhapKho> GetByIdAsync(string Nhap_Kho_ID, string San_Pham_ID);

        Task AddChiTietPhieuNhap(ChiTietPhieuNhapKho chitietPHK);
        Task UpdateChiTietPhieuNhapAsync(ChiTietPhieuNhapKho chitietPHK, string Nhap_Kho_ID, string San_Pham_ID);
        Task DeleteChiTietPhieuNhapAsync(string Nhap_Kho_ID, string San_Pham_ID);
    }
}
