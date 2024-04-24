using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iChiTietPhieuNhapKhoService
    {
        Task<List<ChiTietPhieuNhapKho>> GetAllChiTietPhieuNhapKhoAsync();
        Task<List<ChiTietPhieuNhapKho>> GetAllChiTietByKhoIDAsync(string Nhap_Kho_ID);
        Task<ChiTietPhieuNhapKho> GetByNhapKhoIDSanPhamIdAsync(string Nhap_Kho_ID, int San_Pham_ID);
        Task<ChiTietPhieuNhapKho> GetByIdAsync(int Id);
        Task<ChiTietPhieuNhapKho> GetChiTietByKhoIDAsync(string Nhap_Kho_ID);
        Task<ChiTietPhieuNhapKho> GetBySanPhamIDAsync(int maSanPham);
        Task AddChiTietPhieuNhap(ChiTietPhieuNhapKho chitietPHK);
        Task UpdateChiTietPhieuNhapAsync(ChiTietPhieuNhapKho chitietPHK, int Id);
        Task DeleteChiTietPhieuNhapAsync(int Id);
    }
}
