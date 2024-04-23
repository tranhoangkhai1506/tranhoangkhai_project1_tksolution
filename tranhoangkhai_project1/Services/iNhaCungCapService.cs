using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iNhaCungCapService
    {
        Task<List<NhaCungCapModel>> GetAllNhaCungCapAsync();
        Task<NhaCungCapModel> GetByIdAsync(int Id);
        Task<NhaCungCapModel> GetByNameAsync(string Ten_NhaCC);
        Task<NhaCungCapModel> GetByMaNCCAsync(string Ma_NCC);
        Task AddNhaCungCap(NhaCungCapModel nhaCungCap);
        Task UpdateNhaCungCapAsync(NhaCungCapModel nhaCungCap, int Id);
        Task DeleteNhaCungCapAsync(int Id);
    }
}
