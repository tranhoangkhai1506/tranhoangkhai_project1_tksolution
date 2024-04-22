using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iPhieuNhapKhoService
    {
        Task<List<PhieuNhapKhoModel>> GetAlPhieuNhapKhoAsync();
        Task<PhieuNhapKhoModel> GetByIdAsync(string So_Phieu_Nhap_Kho);
        Task<List<PhieuNhapKhoModel>> GetByDateAsync(DateTime DateFrom, DateTime DateTo);
        Task<List<PhieuNhapKhoModel>> GetByAfterDateAsync(DateTime AfterDate);
        Task<PhieuNhapKhoModel> GetByNCCIDAsync(string NCC_ID);
        Task<PhieuNhapKhoModel> GetByKhoIDAsync(int Kho_ID);
        Task AddPhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho);
        Task UpdatePhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho, string So_Phieu_Nhap_Kho);
        Task DeletePhieuNhapKhoAsync(string So_Phieu_Nhap_Kho);

    }
}
