using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class HieuChinhPhieuNhapKhoService : iHieuChinhPhieuNhapKhoService
    {
        private readonly DataContext _dataContext;
        public HieuChinhPhieuNhapKhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<List<HieuChinhPhieuNhapKhoModel>> GetAllHieuChinhPhieuNhapKhoAsync()
        {
            var result = await _dataContext.tbl_XNK_Nhap_Kho.ToListAsync();
            return result;
        }

        public async Task<HieuChinhPhieuNhapKhoModel> GetByIdAsync(string So_Phieu_Nhap_Kho)
        {
            var dbHieuChinhPhieuNhapKho = await _dataContext.tbl_XNK_Nhap_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Nhap_Kho.Equals(So_Phieu_Nhap_Kho));
            return dbHieuChinhPhieuNhapKho;        
        }

        public async Task UpdateHieuChinhPhieuNhapKhoAsync(HieuChinhPhieuNhapKhoModel phieuNhapKho, string So_Phieu_Nhap_Kho)
        {

            var dbHieuChinhPhieuNhapKho = await _dataContext.tbl_XNK_Nhap_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Nhap_Kho.Equals(So_Phieu_Nhap_Kho));
            if (dbHieuChinhPhieuNhapKho != null)
            {
                dbHieuChinhPhieuNhapKho.Kho_ID = phieuNhapKho.Kho_ID;
                dbHieuChinhPhieuNhapKho.NCC_ID = phieuNhapKho.NCC_ID;
                dbHieuChinhPhieuNhapKho.Ngay_Nhap_Kho = phieuNhapKho.Ngay_Nhap_Kho;
                dbHieuChinhPhieuNhapKho.Ghi_Chu = phieuNhapKho.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
            else
            {
                HieuChinhPhieuNhapKhoModel newHieuChinh = new HieuChinhPhieuNhapKhoModel();
                newHieuChinh.So_Phieu_Nhap_Kho = phieuNhapKho.So_Phieu_Nhap_Kho;
                newHieuChinh.Kho_ID = phieuNhapKho.Kho_ID;
                newHieuChinh.NCC_ID = phieuNhapKho.NCC_ID;
                newHieuChinh.Ngay_Nhap_Kho = phieuNhapKho.Ngay_Nhap_Kho;
                newHieuChinh.Ghi_Chu = phieuNhapKho.Ghi_Chu;

                _dataContext.tbl_XNK_Nhap_Kho.Add(newHieuChinh);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
