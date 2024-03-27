using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iPhieuXuatKhoService
    {
        Task<List<PhieuXuatKhoModel>> GetAllPhieuXuatKhoAsync();
        Task<PhieuXuatKhoModel> GetByIdAsync(string So_Phieu_Xuat_Kho);

        Task AddPhieuXuatKhoAsync(PhieuXuatKhoModel phieuXuatKho);
        //Task UpdatePhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho, string So_Phieu_Nhap_Kho);
        Task DeletePhieuXuatKhoAsync(string So_Phieu_Xuat_Kho);
    }
}
