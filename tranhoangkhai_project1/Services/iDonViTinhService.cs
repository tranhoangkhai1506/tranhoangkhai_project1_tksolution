using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iDonViTinhService
    {
        Task<List<DonViTinhModel>> GetAllDonViTinhAsync();
        Task<DonViTinhModel> GetByIdAsync(int donViTinhID);
        Task<DonViTinhModel> GetByNameAsync(string Ten_Don_Vi_Tinh);
        Task AddDonViTinh(DonViTinhModel donViTinh);
        Task UpdateDonViTinhAsync(DonViTinhModel donViTinh, int DonViTinhID);
        Task DeleteDonViTinhAsync(int donViTinhID);
    }
}
