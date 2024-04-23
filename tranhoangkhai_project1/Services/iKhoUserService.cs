using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iKhoUserService
    {
        Task<List<KhoUserModel>> GetAllKhoUserAsync();
        Task<KhoUserModel> GetByIdAsync(int khoId, string madangnhap);
        Task<List<KhoUserModel>> GetUsersByKhoIdAsync(int khoId);
        Task AddKhoUser(KhoUserModel kho);
        Task UpdateKhoUserAsync(KhoUserModel kho, int khoId, string madangnhap);
        Task DeleteKhoUserAsync(int khoId, string madangnhap);
    }
}
