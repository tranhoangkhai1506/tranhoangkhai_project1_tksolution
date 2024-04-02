using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class SanPhamService : iSanPhamService
    {
        private readonly DataContext _dataContext;
        public SanPhamService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddSanPham(SanPhamModel sanPham)
        {
            _dataContext.tbl_DM_San_Pham.Add(sanPham);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteSanPhamAsync(string maSanPham)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Ma_San_Pham.Equals(maSanPham));
            if (sanPham != null)
            {
                _dataContext.tbl_DM_San_Pham.Remove(sanPham);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<SanPhamModel>> GetAllSanPhamAsync()
        {
            var result = await _dataContext.tbl_DM_San_Pham.ToListAsync();
            return result;
        }

        public async Task<SanPhamModel> GetByIdAsync(string maSanPham)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Ma_San_Pham.Equals(maSanPham));
            return sanPham;
        }
        public async Task<SanPhamModel> GetByDVTAsync(string maDVT)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Don_Vi_Tinh_ID.Equals(maDVT));
            return sanPham;
        }

        public async Task UpdateSanPhamAsync(SanPhamModel sanPham, string maSanPham)
        {
            var dbSanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Ma_San_Pham.Equals(maSanPham));
            if (dbSanPham != null)
            {
                dbSanPham.Ten_San_Pham = sanPham.Ten_San_Pham;
                dbSanPham.Loai_San_Pham_ID = sanPham.Loai_San_Pham_ID;
                dbSanPham.Don_Vi_Tinh_ID = sanPham.Don_Vi_Tinh_ID;
                dbSanPham.Ghi_Chu = sanPham.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
