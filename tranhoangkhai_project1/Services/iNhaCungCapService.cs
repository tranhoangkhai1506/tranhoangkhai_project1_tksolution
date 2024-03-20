using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iNhaCungCapService
    {
        Task<List<NhaCungCapModel>> GetAllNhaCungCapAsync();
        Task<NhaCungCapModel> GetByIdAsync(string maNCC);

        Task AddNhaCungCap(NhaCungCapModel nhaCungCap);
        Task UpdateNhaCungCapAsync(NhaCungCapModel nhaCungCap, string maNCC);
        Task DeleteNhaCungCapAsync(string maNCC);
    }
}
