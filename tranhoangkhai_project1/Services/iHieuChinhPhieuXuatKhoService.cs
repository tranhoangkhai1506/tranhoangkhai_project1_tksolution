using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iHieuChinhPhieuXuatKhoService
    {
        Task<List<HieuChinhPhieuXuatKhoModel>> GetAllHieuChinhPhieuXuatKhoAsync();
        Task<HieuChinhPhieuXuatKhoModel> GetByIdAsync(string So_Phieu_Xuat_Kho);
        Task UpdateHieuChinhPhieuXuatKhoAsync(HieuChinhPhieuXuatKhoModel phieuXuatKho, string So_Phieu_Xuat_Kho);
    }
}
