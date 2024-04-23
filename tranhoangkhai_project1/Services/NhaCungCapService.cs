using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.Text.RegularExpressions;
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
            if (nhaCungCap.Ghi_Chu is null || nhaCungCap.Ghi_Chu == "")
            {
                nhaCungCap.Ghi_Chu = "U/N";
            }
            _dataContext.tbl_DM_NCC.Add(nhaCungCap);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteNhaCungCapAsync(int Id)
        {
            var nhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Id == Id);
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

        public async Task<NhaCungCapModel> GetByIdAsync(int Id)
        {
            var nhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Id == Id);
            return nhaCungCap;
        }

        public async Task<NhaCungCapModel> GetByMaNCCAsync(string Ma_NCC)
        {
            var nhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Ma_NCC.Equals(Ma_NCC));
            return nhaCungCap;
        }

        public async Task<NhaCungCapModel> GetByNameAsync(string Ten_NhaCC)
        {
            var nhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Ten_NCC.Equals(Ten_NhaCC));
            return nhaCungCap;
        }

        public async Task UpdateNhaCungCapAsync(NhaCungCapModel nhaCungCap, int Id)
        {
            var dbNhaCungCap = await _dataContext.tbl_DM_NCC.FirstOrDefaultAsync(p => p.Id == Id);
            if (dbNhaCungCap != null)
            {
                dbNhaCungCap.Ten_NCC = nhaCungCap.Ten_NCC;
                if (nhaCungCap.Ghi_Chu is null || nhaCungCap.Ghi_Chu == "")
                {
                    dbNhaCungCap.Ghi_Chu = "U/N";
                }
                else
                {
                    dbNhaCungCap.Ghi_Chu = nhaCungCap.Ghi_Chu;
                }
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
