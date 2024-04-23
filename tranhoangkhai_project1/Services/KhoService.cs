using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class KhoService : iKhoService
    {
        private readonly DataContext _dataContext;
        public KhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddKho(KhoModel kho)
        {
            if (kho.Ghi_Chu is null)
            {
                kho.Ghi_Chu = "U/N";
            }
            _dataContext.tbl_DM_Kho.Add(kho);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteKhoAsync(int khoId)
        {
            var kho = await _dataContext.tbl_DM_Kho.FirstOrDefaultAsync(p => p.KhoId == khoId);
            if (kho != null)
            {
                _dataContext.tbl_DM_Kho.Remove(kho);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<KhoModel>> GetAllKhoAsync()
        {
            var result = await _dataContext.tbl_DM_Kho.ToListAsync();
            return result;
        }

        public async Task<KhoModel> GetByIdAsync(int khoId)
        {
            return await _dataContext.tbl_DM_Kho.FindAsync(khoId);
        }

        public async Task<KhoModel> GetByNameAsync(string Ten_Kho)
        {
            var result = await _dataContext.tbl_DM_Kho.FirstOrDefaultAsync(p => p.Ten_Kho.Equals(Ten_Kho));
            return result;
        }

        public async Task UpdateKhoAsync(KhoModel kho, int khoId)
        {
            var existingKho = await _dataContext.tbl_DM_Kho.FindAsync(khoId);

            if (existingKho != null)
            {
                existingKho.Ten_Kho = kho.Ten_Kho;
                if(kho.Ghi_Chu is null)
                {
                    existingKho.Ghi_Chu = "U/N";
                }
                else
                {
                    existingKho.Ghi_Chu = kho.Ghi_Chu;
                }
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
