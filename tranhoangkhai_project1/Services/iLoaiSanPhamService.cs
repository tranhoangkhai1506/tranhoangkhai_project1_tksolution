using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iLoaiSanPhamService
    {
        Task<List<LoaiSanPhamModel>> GetAllLoaiSanPhamAsync();
        Task<LoaiSanPhamModel> GetByIdAsync(string Ten_Don_Vi_Tinh);
        Task<LoaiSanPhamModel> GetByNameAsync(string Ten_Loai_San_Pham);

        Task AddLoaiSanPham(LoaiSanPhamModel donViTinh);
        Task UpdateLoaiSanPhamAsync(LoaiSanPhamModel donViTinh, string Ten_Don_Vi_Tinh);
        Task DeleteLoaiSanPhamAsync(string Ten_Don_Vi_Tinh);
    }
}
