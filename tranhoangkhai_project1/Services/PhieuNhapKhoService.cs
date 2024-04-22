using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tranhoangkhai_project1.Services
{
    public class PhieuNhapKhoService : iPhieuNhapKhoService
    {
        private readonly DataContext _dataContext;
        public PhieuNhapKhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddPhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho)
        {
            if (phieuNhapKho.Ghi_Chu is null)
            {
                phieuNhapKho.Ghi_Chu = "U/N";
            }
            _dataContext.tbl_DM_Nhap_Kho.Add(phieuNhapKho);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeletePhieuNhapKhoAsync(string So_Phieu_Nhap_Kho)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Nhap_Kho.Equals(So_Phieu_Nhap_Kho));
            if (phieuNhapKho != null)
            {
                _dataContext.tbl_DM_Nhap_Kho.Remove(phieuNhapKho);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<PhieuNhapKhoModel>> GetAlPhieuNhapKhoAsync()
        {
            var result = await _dataContext.tbl_DM_Nhap_Kho.ToListAsync();
            return result;
        }

        public async Task<List<PhieuNhapKhoModel>> GetByAfterDateAsync(DateTime AfterDate)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.Where(p => p.Ngay_Nhap_Kho < AfterDate).ToListAsync();
            return phieuNhapKho;
        }

        public async Task<List<PhieuNhapKhoModel>> GetByDateAsync(DateTime DateFrom, DateTime DateTo)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.Where(p => p.Ngay_Nhap_Kho >= DateFrom && p.Ngay_Nhap_Kho <= DateTo).ToListAsync();
            return phieuNhapKho;
        }

        public async Task<PhieuNhapKhoModel> GetByIdAsync(string So_Phieu_Nhap_Kho)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Nhap_Kho.Equals(So_Phieu_Nhap_Kho));
            return phieuNhapKho;
        }

        public async Task<PhieuNhapKhoModel> GetByKhoIDAsync(string Kho_ID)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.FirstOrDefaultAsync(p => p.Kho_ID.Equals(Kho_ID));
            return phieuNhapKho;
        }

        public async Task<PhieuNhapKhoModel> GetByNCCIDAsync(string NCC_ID)
        {
            var phieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.FirstOrDefaultAsync(p => p.NCC_ID.Equals(NCC_ID));
            return phieuNhapKho;
        }

        //public async Task UpdatePhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho, string So_Phieu_Nhap_Kho)
        //{
        //    var dbPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Nhap_Kho.Equals(So_Phieu_Nhap_Kho));
        //    if(dbPhieuNhapKho != null){

        //    }
        //}
    }
}
