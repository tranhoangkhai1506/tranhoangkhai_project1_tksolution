using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iSanPhamService
    {
        Task<List<SanPhamModel>> GetAllSanPhamAsync();
        Task<SanPhamModel> GetByIdAsync(string maSanPham);
        Task<SanPhamModel> GetByDVTAsync(int maDVT);
        Task<SanPhamModel> GetByLoaiSanPhamAsync(string maLoai);
        Task<SanPhamModel> GetByNameAsync(string Ten_San_Pham);
        Task AddSanPham(SanPhamModel sanPham);
        Task UpdateSanPhamAsync(SanPhamModel sanPham, string maSanPham);
        Task DeleteSanPhamAsync(string maSanPham);
    }
}
