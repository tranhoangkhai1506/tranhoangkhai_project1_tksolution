using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class HieuChinhPhieuXuatKhoService : iHieuChinhPhieuXuatKhoService
    {
        private readonly DataContext _dataContext;
        public HieuChinhPhieuXuatKhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<List<HieuChinhPhieuXuatKhoModel>> GetAllHieuChinhPhieuXuatKhoAsync()
        {
            var result = await _dataContext.tbl_XNK_Xuat_Kho.ToListAsync();
            return result;
        }

        public async Task<HieuChinhPhieuXuatKhoModel> GetByIdAsync(string So_Phieu_Xuat_Kho)
        {
            var dbHieuChinhPhieuXuatKho = await _dataContext.tbl_XNK_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            return dbHieuChinhPhieuXuatKho;
        }

        public async Task<HieuChinhPhieuXuatKhoModel> GetByKhoIDAsync(string Kho_ID)
        {
            var dbHieuChinhPhieuXuatKho = await _dataContext.tbl_XNK_Xuat_Kho.FirstOrDefaultAsync(p => p.Kho_ID.Equals(Kho_ID));
            return dbHieuChinhPhieuXuatKho;
        }

        public async Task UpdateHieuChinhPhieuXuatKhoAsync(HieuChinhPhieuXuatKhoModel phieuXuatKho, string So_Phieu_Xuat_Kho)
        {
            var dbHieuChinhPhieuXuatKho = await _dataContext.tbl_XNK_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            if (dbHieuChinhPhieuXuatKho != null)
            {
                dbHieuChinhPhieuXuatKho.Kho_ID = phieuXuatKho.Kho_ID;
                dbHieuChinhPhieuXuatKho.Ngay_Nhap_Kho = phieuXuatKho.Ngay_Nhap_Kho;
                dbHieuChinhPhieuXuatKho.Ghi_Chu = phieuXuatKho.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
            else
            {
                HieuChinhPhieuXuatKhoModel newHieuChinh = new HieuChinhPhieuXuatKhoModel();
                newHieuChinh.So_Phieu_Xuat_Kho = phieuXuatKho.So_Phieu_Xuat_Kho;
                newHieuChinh.Kho_ID = phieuXuatKho.Kho_ID;
                newHieuChinh.Ngay_Nhap_Kho = phieuXuatKho.Ngay_Nhap_Kho;
                newHieuChinh.Ghi_Chu = phieuXuatKho.Ghi_Chu;

                _dataContext.tbl_XNK_Xuat_Kho.Add(newHieuChinh);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
