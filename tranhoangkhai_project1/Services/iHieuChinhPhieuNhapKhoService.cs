using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iHieuChinhPhieuNhapKhoService
    {
        Task<List<HieuChinhPhieuNhapKhoModel>> GetAllHieuChinhPhieuNhapKhoAsync();
        Task<HieuChinhPhieuNhapKhoModel> GetByIdAsync(string So_Phieu_Nhap_Kho);
        Task<HieuChinhPhieuNhapKhoModel> GetByNCCIDAsync(string NCC_ID);
        Task<HieuChinhPhieuNhapKhoModel> GetByKhoIDAsync(string Kho_ID);
        Task UpdateHieuChinhPhieuNhapKhoAsync(HieuChinhPhieuNhapKhoModel phieuNhapKho, string So_Phieu_Nhap_Kho);
    }
}
