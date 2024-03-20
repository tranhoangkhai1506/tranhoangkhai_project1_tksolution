using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iKhoService
    {
        Task<List<KhoModel>> GetAllKhoAsync();
        Task<KhoModel> GetByIdAsync(string tenKho);

        Task AddKho(KhoModel kho);
        Task UpdateKhoAsync(KhoModel kho, string tenKho);
        Task DeleteKhoAsync(string tenKho);
    }
}
