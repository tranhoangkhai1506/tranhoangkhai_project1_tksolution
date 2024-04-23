using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iSanPhamService
    {
        Task<List<SanPhamModel>> GetAllSanPhamAsync();
        Task<SanPhamModel> GetByIdAsync(int maSanPham);
        Task<SanPhamModel> GetByDVTAsync(int maDVT);
        Task<SanPhamModel> GetByLoaiSanPhamAsync(string maLoai);
        Task<SanPhamModel> GetByNameAsync(string Ten_San_Pham);
        Task<SanPhamModel> GetByMaAsync(string Ma_SP);
        Task AddSanPham(SanPhamModel sanPham);
        Task UpdateSanPhamAsync(SanPhamModel sanPham, int maSanPham);
        Task DeleteSanPhamAsync(int maSanPham);
    }
}
