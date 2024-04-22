using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class LoaiSanPhamService : iLoaiSanPhamService
    {
        private readonly DataContext _dataContext;
        public LoaiSanPhamService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task AddLoaiSanPham(LoaiSanPhamModel loaiSanPham)
        {
            if (loaiSanPham.Ghi_Chu is null)
            {
                loaiSanPham.Ghi_Chu = "U/N";
            }
            _dataContext.tbl_DM_Loai_San_Pham.Add(loaiSanPham);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteLoaiSanPhamAsync(string Ma_LSP)
        {
            var loaiSP = await _dataContext.tbl_DM_Loai_San_Pham.FirstOrDefaultAsync(p => p.Ma_LSP.Equals(Ma_LSP));
            if (loaiSP != null)
            {
                _dataContext.tbl_DM_Loai_San_Pham.Remove(loaiSP);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<LoaiSanPhamModel>> GetAllLoaiSanPhamAsync()
        {
            var result = await _dataContext.tbl_DM_Loai_San_Pham.ToListAsync();
            return result;
        }

        public async Task<LoaiSanPhamModel> GetByIdAsync(string Ma_LSP)
        {
            var loaiSP = await _dataContext.tbl_DM_Loai_San_Pham.FirstOrDefaultAsync(p => p.Ma_LSP.Equals(Ma_LSP));
            return loaiSP;
        }

        public async Task<LoaiSanPhamModel> GetByNameAsync(string Ten_Loai_San_Pham)
        {
            var loaiSP = await _dataContext.tbl_DM_Loai_San_Pham.FirstOrDefaultAsync(p => p.Ten_LSP.Equals(Ten_Loai_San_Pham));
            return loaiSP;
        }

        public async Task UpdateLoaiSanPhamAsync(LoaiSanPhamModel loaiSP, string Ma_LSP)
        {
            var dbLoaiSP = await _dataContext.tbl_DM_Loai_San_Pham.FirstOrDefaultAsync(p => p.Ma_LSP.Equals(Ma_LSP));
            if (dbLoaiSP != null)
            {
                dbLoaiSP.Ten_LSP = loaiSP.Ten_LSP;
                if (loaiSP.Ghi_Chu is null || loaiSP.Ghi_Chu == "")
                {
                    dbLoaiSP.Ghi_Chu = "U/N";
                }
                else
                {
                    dbLoaiSP.Ghi_Chu = loaiSP.Ghi_Chu;
                }
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
