using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class PhieuXuatKhoService : iPhieuXuatKhoService
    {
        private readonly DataContext _dataContext;
        public PhieuXuatKhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddPhieuXuatKhoAsync(PhieuXuatKhoModel phieuXuatKho)
        {
            _dataContext.tbl_DM_Xuat_Kho.Add(phieuXuatKho);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<List<PhieuXuatKhoModel>> GetByDateAsync(DateTime DateFrom, DateTime DateTo)
        {
            var phieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.Where(p => p.Ngay_Nhap_Kho >= DateFrom && p.Ngay_Nhap_Kho <= DateTo).ToListAsync();
            return phieuXuatKho;
        }

        public async Task DeletePhieuXuatKhoAsync(string So_Phieu_Xuat_Kho)
        {
            var phieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            if (phieuXuatKho != null)
            {
                _dataContext.tbl_DM_Xuat_Kho.Remove(phieuXuatKho);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<PhieuXuatKhoModel>> GetAllPhieuXuatKhoAsync()
        {
            var result = await _dataContext.tbl_DM_Xuat_Kho.ToListAsync();
            return result;
        }

        public async Task<PhieuXuatKhoModel> GetByIdAsync(string So_Phieu_Xuat_Kho)
        {
            var phieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            return phieuXuatKho;
        }

        public async Task<PhieuXuatKhoModel> GetByKhoIDAsync(int Kho_ID)
        {
            var phieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.FirstOrDefaultAsync(p => p.Kho_ID == Kho_ID);
            return phieuXuatKho;
        }

        public async Task<List<PhieuXuatKhoModel>> GetByAfterDateAsync(DateTime AfterDate)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Xuat_Kho.Where(p => p.Ngay_Nhap_Kho < AfterDate).ToListAsync();
            return phieuNhapKho;
        }

        public async Task UpdatePhieuXuatKhoAsync(PhieuXuatKhoModel phieuXuatKho, string So_Phieu_Xuat_Kho)
        {
            var dbPhieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            if (dbPhieuXuatKho != null)
            {
                dbPhieuXuatKho.Ngay_Nhap_Kho = phieuXuatKho.Ngay_Nhap_Kho;
                dbPhieuXuatKho.Kho_ID = phieuXuatKho.Kho_ID;
                dbPhieuXuatKho.Ghi_Chu = phieuXuatKho.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
