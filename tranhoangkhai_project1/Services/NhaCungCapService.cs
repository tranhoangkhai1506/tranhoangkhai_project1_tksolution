﻿using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class NhaCungCapService : iNhaCungCapService
    {
        private readonly DataContext _dataContext;
        public NhaCungCapService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddNhaCungCap(NhaCungCapModel nhaCungCap)
        {
            _dataContext.tbl_DM_NCC.Add(nhaCungCap);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteNhaCungCapAsync(string maNCC)
        {
            var nhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Ma_NCC.Equals(maNCC));
            if (nhaCungCap != null)
            {
                _dataContext.tbl_DM_NCC.Remove(nhaCungCap);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<NhaCungCapModel>> GetAllNhaCungCapAsync()
        {
            var result = await _dataContext.tbl_DM_NCC.ToListAsync();
            return result;
        }

        public async Task<NhaCungCapModel> GetByIdAsync(string maNCC)
        {
            var nhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Ma_NCC.Equals(maNCC));
            return nhaCungCap;
        }

        public async Task UpdateNhaCungCapAsync(NhaCungCapModel nhaCungCap, string maNCC)
        {
            var dbNhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Ma_NCC.Equals(maNCC));
            if (dbNhaCungCap != null)
            {
                dbNhaCungCap.Ten_NCC = nhaCungCap.Ten_NCC;
                dbNhaCungCap.Ghi_Chu = nhaCungCap.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
