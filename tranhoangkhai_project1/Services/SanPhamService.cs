﻿using Microsoft.EntityFrameworkCore;
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
            if (sanPham.Ghi_Chu is null)
            {
                sanPham.Ghi_Chu = "U/N";
            }
            _dataContext.tbl_DM_San_Pham.Add(sanPham);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteSanPhamAsync(int maSanPham)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Id == maSanPham);
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

        public async Task<SanPhamModel> GetByIdAsync(int maSanPham)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Id == maSanPham);
            return sanPham;
        }
        public async Task<SanPhamModel> GetByDVTAsync(int maDVT)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Don_Vi_Tinh_ID == maDVT);
            return sanPham;
        }

        public async Task UpdateSanPhamAsync(SanPhamModel sanPham, int maSanPham)
        {
            var dbSanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Id == maSanPham);
            if (dbSanPham != null)
            {
                dbSanPham.Ma_San_Pham = sanPham.Ma_San_Pham;
                dbSanPham.Ten_San_Pham = sanPham.Ten_San_Pham;
                dbSanPham.Loai_San_Pham_ID = sanPham.Loai_San_Pham_ID;
                dbSanPham.Don_Vi_Tinh_ID = sanPham.Don_Vi_Tinh_ID;
                if (sanPham.Ghi_Chu is null || sanPham.Ghi_Chu == "")
                {
                    dbSanPham.Ghi_Chu = "U/N";
                }
                else
                {
                    dbSanPham.Ghi_Chu = sanPham.Ghi_Chu;
                }
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<SanPhamModel> GetByLoaiSanPhamAsync(int maLoai)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Loai_San_Pham_ID == maLoai);
            return sanPham;
        }

        public async Task<SanPhamModel> GetByNameAsync(string Ten_San_Pham)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Ten_San_Pham.Equals(Ten_San_Pham));
            return sanPham;
        }

        public async Task<SanPhamModel> GetByMaAsync(string Ma_SP)
        {
            var sanPham = await _dataContext.tbl_DM_San_Pham.FirstOrDefaultAsync(p => p.Ma_San_Pham.Equals(Ma_SP));
            return sanPham;
        }
    }
}
