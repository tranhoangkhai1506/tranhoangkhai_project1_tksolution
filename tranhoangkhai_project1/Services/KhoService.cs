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
            _dataContext.tbl_DM_Kho.Add(kho);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteKhoAsync(string tenKho)
        {
            var kho = await _dataContext.tbl_DM_Kho.FirstOrDefaultAsync(p => p.Ten_Kho.Equals(tenKho));
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

        public async Task<KhoModel> GetByIdAsync(string tenKho)
        {
            var kho = await _dataContext.tbl_DM_Kho.FirstOrDefaultAsync(p => p.Ten_Kho.Equals(tenKho));
            return kho;
        }

        public async Task UpdateKhoAsync(KhoModel kho, string tenKho)
        {
            var dbKho = await _dataContext.tbl_DM_Kho.FirstOrDefaultAsync(p => p.Ten_Kho.Equals(tenKho));
            if(dbKho != null)
            {
                dbKho.Ghi_Chu = kho.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
