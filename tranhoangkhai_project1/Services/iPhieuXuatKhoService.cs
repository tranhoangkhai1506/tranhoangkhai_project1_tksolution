using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iPhieuXuatKhoService
    {
        Task<List<PhieuXuatKhoModel>> GetAllPhieuXuatKhoAsync();
        Task<PhieuXuatKhoModel> GetByIdAsync(string So_Phieu_Xuat_Kho);
        Task<PhieuXuatKhoModel> GetByKhoIDAsync(int Kho_ID);
        Task<List<PhieuXuatKhoModel>> GetByDateAsync(DateTime DateFrom, DateTime DateTo);
        Task<List<PhieuXuatKhoModel>> GetByAfterDateAsync(DateTime AfterDate);
        Task AddPhieuXuatKhoAsync(PhieuXuatKhoModel phieuXuatKho);
        Task UpdatePhieuXuatKhoAsync(PhieuXuatKhoModel phieuXuatKho, string So_Phieu_Xuat_Kho);
        Task DeletePhieuXuatKhoAsync(string So_Phieu_Xuat_Kho);
    }
}
