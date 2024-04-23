using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iKhoService
    {
        Task<List<KhoModel>> GetAllKhoAsync();
        Task<KhoModel> GetByIdAsync(int khoId);
        Task<KhoModel> GetByNameAsync(string Ten_Kho);

        Task AddKho(KhoModel kho);
        Task UpdateKhoAsync(KhoModel kho, int khoId);
        Task DeleteKhoAsync(int khoId);
    }
}
