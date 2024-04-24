using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class ChiTietPhieuXuatService : iChiTietPhieuXuatKhoService
    {
        private readonly DataContext _dataContext;
        public ChiTietPhieuXuatService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddChiTietPhieuXuat(ChiTietPhieuXuatKhoModel chitietPXK)
        {
            _dataContext.tbl_DM_Xuat_Kho_Raw_Data.Add(chitietPXK);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteChiTietPhieuXuatAsync(int Id)
        {
            var chiTietPhieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Id == Id);
            if (chiTietPhieuXuatKho != null)
            {
                _dataContext.tbl_DM_Xuat_Kho_Raw_Data.Remove(chiTietPhieuXuatKho);
                await _dataContext.SaveChangesAsync();
            }
        }
        public async Task<List<ChiTietPhieuXuatKhoModel>> GetAllChiTietByKhoIDAsync(string Xuat_Kho_ID)
        {
            var result = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.Where(p => p.Xuat_Kho_ID.Equals(Xuat_Kho_ID)).ToListAsync();
            return result;
        }

        public async Task<List<ChiTietPhieuXuatKhoModel>> GetAllChiTietPhieuXuatKhoAsync()
        {
            var result = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.ToListAsync();
            return result;
        }

        public async Task<ChiTietPhieuXuatKhoModel> GetByIdAsync(int Id)
        {
            var chiTietPhieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Id == Id);
            return chiTietPhieuXuatKho;
        }

        public async Task<ChiTietPhieuXuatKhoModel> GetByIdXuatKhoIDSanPhamIDAsync(string Xuat_Kho_ID, int San_Pham_ID)
        {
            var chiTietPhieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Xuat_Kho_ID.Equals(Xuat_Kho_ID) && p.San_Pham_ID == San_Pham_ID);
            return chiTietPhieuXuatKho;
        }

        public async Task<ChiTietPhieuXuatKhoModel> GetBySanPhamIDAsync(int maSanPham)
        {
            var chiTietPhieuNhapKho = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.FirstOrDefaultAsync(p => p.San_Pham_ID == maSanPham);
            return chiTietPhieuNhapKho;
        }

        public async Task<ChiTietPhieuXuatKhoModel> GetByXuatKhoIdAsync(string Xuat_Kho_ID)
        {
            var chiTietPhieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Xuat_Kho_ID.Equals(Xuat_Kho_ID));
            return chiTietPhieuXuatKho;
        }

        public async Task UpdateChiTietPhieuXuatAsync(ChiTietPhieuXuatKhoModel chitietPXK, int Id)
        {
            var dbChiTietPhieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Id == Id);
            if (dbChiTietPhieuXuatKho != null)
            {
                dbChiTietPhieuXuatKho.SL_Xuat = chitietPXK.SL_Xuat;
                dbChiTietPhieuXuatKho.Don_Gia_Xuat = chitietPXK.Don_Gia_Xuat;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
